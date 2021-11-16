using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;
using SpFinal.Models;
using SpFinal.Services;

namespace SpFinal.ViewModels
{
    public class StrudentsViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Symptoms { get; set; }

        private DBFirebase services;

        public Command AddStudentCommand { get; }

        private ObservableCollection<Student> _strudents = new ObservableCollection<Student>();
        public ObservableCollection<Student> Students
        {
            get { return _strudents; }
            set
            {
                _strudents = value;
                OnPropertyChanged();
            }
        }

        public StrudentsViewModel()
        {
            services = new DBFirebase();
            Students = services.getStudent();
            AddStudentCommand = new Command(async () => await addStudentAsync(FirstName, LastName, Sex, Age, Symptoms));
        }

        public async Task addStudentAsync(string FirstName, string LastName, string Sex, int Age, string Symptoms)
        {
            await services.AddStudent(FirstName, LastName, Sex, Age, Symptoms);
        }



    }
}
