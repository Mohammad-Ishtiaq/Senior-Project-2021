using SP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SP.ManyMenus
{
    class MyListPageViewModel
    {
        public ObservableCollection<MyListModel> CounterList { get; set; }

        public MyListPageViewModel()
        {
            //We are initializing a new object with name CounterList.
            //CounterList is abbreviation for: Over The Counter Medicine List
            //We can simply populate our DB with always accessable OTC medicine.
            CounterList = new ObservableCollection<MyListModel>();

            //By following this model, we can copy and paste it as many times as we need.
            //It will automatically add them to our list view and display them under the "Over The Counter" tab
            CounterList.Add(new MyListModel { Name = "Tylenol / Acetaminophen",
                //In future we wood have the images of the medicine downloaded along with the application.
                //Currently I am sending a https request which requires wifi to pull up the image.
                Image = "https://bit.ly/3aNcFRO",
                //Here we can explain the purpose of the drug.
                //This information is a simply compy and paste from the actual drug website.
                Detail = "Purpose: Tylenol / Acetaminophen is used to relieve mild to moderate pain from headaches, muscle aches, menstrual periods, " +
                "colds and sore throats, toothaches, backaches, and reactions to vaccinations (shots), and to reduce fever.",
                //Here we can explain what is in the drug.
                //This information is a simply compy and paste from the actual drug website.
                Ingredients = "Ingredients: Powdered Cellulose, Pregelatinized Starch, Sodium Starch Glycolate, Magnesium Stearate, " +
                "Purified Water, FD&C Red no. 40 Aluminum Lake, Polyethylene Glycol, Titanium Dioxide, FD&C Yellow no. " +
                "6 Aluminum Lake, Polysorbate 80, Sucralose, Carnauba Wax, Iron Oxide, Hypromellose"
            });
            
            CounterList.Add(new MyListModel
            {
                Name = "Advil / Ibuprofen",
                //In future we wood have the images of the medicine downloaded along with the application.
                //Currently I am sending a https request which requires wifi to pull up the image.
                Image = "https://bit.ly/3n110EC",
                //Here we can explain the purpose of the drug.
                //This information is a simply compy and paste from the actual drug website.
                Detail = "Purpose: Advil / Ibuprofen is used to relieve pain from various conditions such as headache, " +
                "dental pain, menstrual cramps, muscle aches, or arthritis. " +
                "It is also used to reduce fever and to relieve minor aches and pain due to the common cold or flu.",
                //Here we can explain what is in the drug.
                //This information is a simply compy and paste from the actual drug website.
                Ingredients = "Ingredients: acetylated monoglycerides, colloidal silicon dioxide, corn starch, croscarmellose sodium, methylparaben, " +
                "microcrystalline cellulose, pharmaceutical glaze, pharmaceutical ink, povidone, pregelatinized starch, " +
                "propylparaben, sodium benzoate, sodium lauryl sulfate, stearic acid, sucrose, synthetic iron oxide, titanium dioxide, white wax"
            });
            
        }

    }
}
