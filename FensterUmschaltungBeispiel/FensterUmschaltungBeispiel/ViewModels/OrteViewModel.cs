using FensterUmschaltungBeispiel.Models;
using FensterUmschaltungBeispiel.Services;
using FensterUmschaltungBeispiel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FensterUmschaltungBeispiel.ViewModels
{
  public class OrteViewModel : ViewModelBase
  {
    public OrteViewModel(Model model, DataService dataService)
    {
      this.Model = model;
      this.dataService = dataService;
      Liste = model.Orte.Select(ort => new ListItem { Data = ort }).ToList();
    }

    //public IEnumerable<string> Orte { get => Model.Orte; }

    public List<ListItem> Liste { get; set; }


    private string selection;
    private readonly DataService dataService;

    public string Selection
    {
      get { return selection; }
      set
      {
        selection = value;
        //DataService.DieInstanz.SelectedOrt = value;
        //DataService.DieInstanz.SelectedOrtSubject.OnNext(value);
        dataService.SelectedOrtSubject.OnNext(value);
      }
    }


  }
}
