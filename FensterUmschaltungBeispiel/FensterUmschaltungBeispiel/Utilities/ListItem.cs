using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FensterUmschaltungBeispiel.Utilities
{
  public class ListItem : NotificationObject
  {
    private object data;

    public object Data
    {
      get { return data; }
      set { data = value; OnPropertyChanged(); }
    }

    private bool isSelected;

    public bool IsSelected
    {
      get { return isSelected; }
      set { isSelected = value; OnPropertyChanged(); }
    }


    private bool isEnabled = true;

    public bool IsEnabled
    {
      get { return isEnabled; }
      set { isEnabled = value; }
    }

  }
}
