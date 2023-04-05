using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NES.Core.Controls
{
    public class Button:System.Windows.Controls.Button
    {



      

        public double MouseEnterInnerShadow
        {
            get { return (double)GetValue(MouseEnterInnerShadowProperty); }
            set { SetValue(MouseEnterInnerShadowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseEnterInnerShadow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseEnterInnerShadowProperty =
            DependencyProperty.Register("MouseEnterInnerShadow", typeof(double), typeof(Button));




        public GridLength InnerShadow
        {
            get { return (GridLength)GetValue(InnerShadowProperty); }
            set { SetValue(InnerShadowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InnerShadow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InnerShadowProperty =
            DependencyProperty.Register("InnerShadow", typeof(GridLength), typeof(Button));






        public Brush MouseEnterBrush
        {
            get { return (Brush)GetValue(MouseEnterBrushProperty); }
            set { SetValue(MouseEnterBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseEnterBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseEnterBrushProperty =
            DependencyProperty.Register("MouseEnterBrush", typeof(Brush), typeof(Button));




        public Brush InnerShadowBrush
        {
            get { return (Brush)GetValue(InnerShadowBrushProperty); }
            set { SetValue(InnerShadowBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InnerShadowBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InnerShadowBrushProperty =
            DependencyProperty.Register("InnerShadowBrush", typeof(Brush), typeof(Button));








    }
}
