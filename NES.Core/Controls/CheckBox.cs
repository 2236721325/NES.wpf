using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace NES.Core.Controls
{
    public class CheckBox:System.Windows.Controls.CheckBox
    {


        public double MarkHeight
        {
            get { return (double)GetValue(MarkHeightProperty); }
            set { SetValue(MarkHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MarkHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MarkHeightProperty =
            DependencyProperty.Register("MarkHeight", typeof(double), typeof(CheckBox));


    }
}
