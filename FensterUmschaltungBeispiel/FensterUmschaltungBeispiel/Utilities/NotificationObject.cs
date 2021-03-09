using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FensterUmschaltungBeispiel.Utilities
{
  public class NotificationObject : INotifyPropertyChanged
  {
    protected void OnPropertyChanged([CallerMemberName]string propetyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }
}
