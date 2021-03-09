using FensterUmschaltungBeispiel.Models;
using FensterUmschaltungBeispiel.Utilities;
using FensterUmschaltungBeispiel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FensterUmschaltungBeispiel
{
  public class MainViewModel : NotificationObject
  {
    private ViewModelBase selectedViewModel;
    private Model model;

    public ViewModelBase SelectedViewModel
    {
      get { return selectedViewModel; }
      set { selectedViewModel = value; OnPropertyChanged(); }
    }

    public MainViewModel()
    {
      model = new Model();
      SelectedViewModel = new OrteViewModel();
      SelectedViewModel.Model = model;
    }
  }
}
