using NES.Core.Utilities.Draws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NES.Core.Controls
{
    public class TextBox: System.Windows.Controls.TextBox
    {

        public Thickness OutBorderThickness
        {
            get { return (Thickness)GetValue(OutBorderThicknessProperty); }
            set { SetValue(OutBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OutBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OutBorderThicknessProperty =
            DependencyProperty.Register("OutBorderThickness", typeof(Thickness), typeof(TextBox), new PropertyMetadata(new Thickness(4, 4, 4, 4)));




        public SolidColorBrush OutBorderBrush
        {
            get { return (SolidColorBrush)GetValue(OutBorderBrushProperty); }
            set { SetValue(OutBorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OutBorderBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OutBorderBrushProperty =
            DependencyProperty.Register("OutBorderBrush", typeof(SolidColorBrush), typeof(TextBox), new PropertyMetadata(new SolidColorBrush(Colors.Black)));





        public Thickness InnerMargin
        {
            get { return (Thickness)GetValue(InnerMarginProperty); }
            set { SetValue(InnerMarginProperty, value); }
        }


        // Using a DependencyProperty as the backing store for InnerMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InnerMarginProperty =
            DependencyProperty.Register("InnerMargin", typeof(Thickness), typeof(TextBox), new PropertyMetadata(new Thickness(2.5, 2.5, 2.5, 2.5)));


        protected override void OnRender(DrawingContext drawingContext)
        {
            
            base.OnRender(drawingContext);
            var pen = new Pen(OutBorderBrush, (OutBorderThickness.Left+OutBorderThickness.Right+OutBorderThickness.Bottom+OutBorderThickness.Top)/4);
            DrawHelper.DrawPixRectangle(drawingContext, pen, ActualWidth, ActualHeight);
        }
    }
}
