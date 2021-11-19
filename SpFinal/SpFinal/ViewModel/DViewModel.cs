using SpFinal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpFinal.ViewModel
{
    public class DViewModel
    {
        public ObservableCollection<DListModel> DiseaseDetails { get; set; }


        public DViewModel()
        {
            DiseaseDetails = new ObservableCollection<DListModel>()
            {
                new DListModel (){ DName="Test", DAge = 0, Gender = "Male" ,DDescription = "Test" }
            };
        }
    }
}
