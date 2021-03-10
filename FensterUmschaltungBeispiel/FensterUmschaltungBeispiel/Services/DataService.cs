using FensterUmschaltungBeispiel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace FensterUmschaltungBeispiel.Services
{
  public class DataService : NotificationObject
  {
   // public static readonly DataService DieInstanz = new DataService();

    //private string selectedOrt;

    //public string SelectedOrt
    //{
    //  get { return selectedOrt; }
    //  set
    //  {
    //    selectedOrt = value;
    //    //OnPropertyChanged();
    //  }
    //}


    public ReplaySubject<string> SelectedOrtSubject { get; set; } = new ReplaySubject<string>(10);


  }
}
