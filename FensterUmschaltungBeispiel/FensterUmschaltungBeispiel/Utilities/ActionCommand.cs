using System;
using System.Windows.Input;

namespace FensterUmschaltungBeispiel.Utilities
{
  public class ActionCommand : ICommand
  {
    public string DisplayText { get; set; }
    public string ToolTipText { get; set; }

    public ActionCommand(Action action)
    {
      this.action = action;
    }

    public ActionCommand(Action<object> action2)
    {
      this.action2 = action2;
    }

    private bool isEnabled = true;
    private readonly Action action;
    private readonly Action<object> action2;

    public bool IsEnabled
    {
      get { return isEnabled; }
      set
      {
        isEnabled = value;
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
      }
    }

    #region ICommand
    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
      return isEnabled;
    }

    public void Execute(object parameter)
    {
      action?.Invoke();
      action2?.Invoke(parameter);
    }
    #endregion
  }
}
