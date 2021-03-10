using FensterUmschaltungBeispiel.Services;
using FensterUmschaltungBeispiel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FensterUmschaltungBeispiel.ViewModels
{
  public class BrowserViewModel : ViewModelBase
  {
    private readonly DataService dataService;

    public BrowserViewModel(DataService dataService)
    {
      this.dataService = dataService;

      Adresse = new Uri("https://de.wikipedia.org/wiki/Ulm");

      dataService.SelectedOrtSubject.Subscribe(
        ort =>
        Adresse = new Uri($"https://de.wikipedia.org/wiki/{ort}"));
    }

    private Uri adresse;

    public Uri Adresse
    {
      get { return adresse; }
      set { adresse = value; OnPropertyChanged(); }
    }


  }
}
