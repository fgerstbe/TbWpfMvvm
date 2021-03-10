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
  public class MitarbeiterViewModel : ViewModelBase
  {
    public MitarbeiterViewModel(Model model, DataService dataService)
    {
      this.Model = model;
      this.dataService = dataService;
    }

    private Person selectedMitarbeiter;
    private readonly DataService dataService;

    public Person SelectedMitarbeiter
    {
      get { return selectedMitarbeiter; }
      set
      {
        selectedMitarbeiter = value;
        //DataService.DieInstanz.SelectedOrtSubject.OnNext(value.Wohnort);
        dataService.SelectedOrtSubject.OnNext(value.Wohnort);
      }
    }

  }
}
