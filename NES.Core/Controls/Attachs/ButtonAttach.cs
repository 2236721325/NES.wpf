
using System.Windows;

namespace NES.Core.Controls.Attachs
{
    public class ButtonAttach
    {


        public static double GetEnterShadow(DependencyObject obj)
        {
            return (double)obj.GetValue(EnterShadowProperty);
        }

        public static void SetEnterShadow(DependencyObject obj, double value)
        {
            obj.SetValue(EnterShadowProperty, value);
        }

        // Using a DependencyProperty as the backing store for EnterShadow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EnterShadowProperty =
            DependencyProperty.RegisterAttached("EnterShadow", typeof(double), typeof(ButtonAttach), new PropertyMetadata(6.0));






    }
}
