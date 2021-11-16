using Firebase.Database;
using Firebase.Database.Query;
using SpFinal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace SpFinal.Services
{
    public class DBFirebase
    {
        FirebaseClient client;

        public DBFirebase()
        {
            client = new FirebaseClient("https://senior-project-fall-2021-default-rtdb.firebaseio.com/");
        }

        public ObservableCollection<Student> getStudent()
        {
            var studentData = client
                .Child("Students")
                .AsObservable<Student>()
                .AsObservableCollection();

            return studentData;
        }

        public async Task AddStudent(string firstName, string lastName, string sex, int age, string symptoms)
        {
            Student s = new Student(){ FirstName = firstName, LastName = lastName, Sex = sex, Age = age, Symptoms = symptoms};
            await client
                .Child("Students")
                .PostAsync(s);
        }

    }
}
