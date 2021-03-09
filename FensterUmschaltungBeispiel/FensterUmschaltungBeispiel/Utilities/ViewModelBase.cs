using FensterUmschaltungBeispiel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FensterUmschaltungBeispiel.Utilities
{
  public class ViewModelBase : NotificationObject
  {
    public Model Model { get; set; }

  }
}
