using SpFinal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpFinal.ViewModel
{
    public class DListViewModel
    {
        public ObservableCollection<DListModel> DList { get; set; }

        public void DListPageViewModel()
        {
            DList = new ObservableCollection<DListModel>();

            DList.Add(new DListModel { DName = "Diabetes", DDescription = "Diabetes is a chronic (long-lasting) health condition that affects how your body turns food into energy. Most of the food you eat is broken down into sugar (also called glucose) and released into your bloodstream. When your blood sugar goes up, it signals your pancreas to release insulin.", DAge = 18, DSymptoms = "polyuria" });
        }

    }
}
