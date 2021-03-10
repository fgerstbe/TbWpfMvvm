using Autofac;
using FensterUmschaltungBeispiel.Models;
using FensterUmschaltungBeispiel.Services;
using FensterUmschaltungBeispiel.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FensterUmschaltungBeispiel
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    public static IContainer Container;

    static App()
    {
      Container = ConfigureServices();
    }

    private static IContainer ConfigureServices()
    {
      ContainerBuilder builder = new ContainerBuilder();

      builder.RegisterType<Model>().SingleInstance();
      builder.RegisterType<DataService>().SingleInstance();
      builder.RegisterType<MainViewModel>().SingleInstance();
      builder.RegisterType<OrteViewModel>().SingleInstance();
      builder.RegisterType<MitarbeiterViewModel>().SingleInstance();
      builder.RegisterType<BrowserViewModel>().SingleInstance();

      return builder.Build();
    }
  }
}
