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
    public IEnumerable<string> Orte { get => Model.Orte; }



  }
}
