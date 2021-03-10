using Autofac;
using FensterUmschaltungBeispiel.Models;
using FensterUmschaltungBeispiel.Services;
using FensterUmschaltungBeispiel.Utilities;
using FensterUmschaltungBeispiel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
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

    public List<ActionCommand> NavigationCommands { get; set; }

    private string ausgewählterOrt="nirgends";

    public string AusgewählterOrt
    {
      get { return ausgewählterOrt; }
      set { ausgewählterOrt = value; OnPropertyChanged(); }
    }


    public MainViewModel(Model model, DataService dataService, MitarbeiterViewModel vm1)
    {
      this.model = model;

      NavigationCommands = new List<ActionCommand>
      {
        new ActionCommand(()=>ShowViewModel(typeof(OrteViewModel))){DisplayText="Orte"},
        new ActionCommand(()=>ShowViewModel(typeof(MitarbeiterViewModel))){DisplayText="Mitarbeiter"}
      };

      //model = new Model();
      //SelectedViewModel = new MitarbeiterViewModel();
      //SelectedViewModel.Model = model;

      SelectedViewModel = vm1;

      //DataService.DieInstanz.PropertyChanged += DieInstanz_PropertyChanged;

      //DataService.DieInstanz.SelectedOrtSubject
      //  .ObserveOn(SynchronizationContext.Current)
      //  .Subscribe(ort => AusgewählterOrt = ort);

      dataService.SelectedOrtSubject
        .ObserveOn(SynchronizationContext.Current)
        .Subscribe(ort => AusgewählterOrt = ort);

    }

    //private void DieInstanz_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    //{
    //  switch (e.PropertyName)
    //  {
    //    case "SelectedOrt": AusgewählterOrt = DataService.DieInstanz.SelectedOrt;
    //      break;

    //    default:
    //      break;
    //  }
    //}

    private void ShowViewModel(Type vmType)
    {
      //vmType.GetConstructor(new Type[] { }).Invoke(new object[] { });
      //var vm= Activator.CreateInstance(vmType) as ViewModelBase;
      var vm = App.Container.Resolve(vmType) as ViewModelBase;
      vm.Model = model;
      SelectedViewModel = vm;

      
    }
  }
}
