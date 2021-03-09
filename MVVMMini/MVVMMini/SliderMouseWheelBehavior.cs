using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVVMMini
{
  public class SliderMouseWheelBehavior : Behavior<Slider>
  {
    protected override void OnAttached()
    {
      base.OnAttached();
      AssociatedObject.MouseWheel += AssociatedObject_MouseWheel;
    }

    private void AssociatedObject_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
    {
      AssociatedObject.Value += e.Delta * AssociatedObject.SmallChange;
    }

    protected override void OnDetaching()
    {
      AssociatedObject.MouseWheel -= AssociatedObject_MouseWheel;
      base.OnDetaching();
    }
  }
}
