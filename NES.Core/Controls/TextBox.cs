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
    public class TextBox : System.Windows.Controls.TextBox
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

            //            int[,] iconCoin = new int[,]
            //{
            //    {0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0},
            //    {0,0,0,1,1,1,2,2,2,1,1,1,1,0,0,0},
            //    {0,0,1,1,2,2,3,3,3,3,3,1,1,0,0,0},
            //    {0,0,1,2,3,3,2,2,2,1,3,3,1,1,0,0},
            //    {0,1,1,2,3,3,2,3,3,1,3,3,1,1,0,0},
            //    {0,1,2,3,3,3,2,3,3,1,3,3,3,1,1,0},
            //    {0,1,2,3,3,3,2,3,3,1,3,3,3,1,1,0},
            //    {0,1,2,3,3,3,2,3,3,1,3,3,3,1,1,0},
            //    {0,1,2,3,3,3,2,3,3,1,3,3,3,1,1,0},
            //    {0,1,2,3,3,3,2,3,3,1,3,3,3,1,1,0},
            //    {0,1,2,3,3,3,2,3,3,1,3,3,3,1,1,0},
            //    {0,1,1,2,3,3,2,3,3,1,3,3,1,1,0,0},
            //    {0,0,1,2,3,3,2,1,1,1,3,3,1,1,0,0},
            //    {0,0,1,1,2,3,3,3,3,3,3,1,1,0,0,0},
            //    {0,0,0,1,1,1,3,3,3,1,1,1,1,0,0,0},
            //    {0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0}
            //};
            //            SolidColorBrush blackBrush = new SolidColorBrush(Colors.Black);
            //            SolidColorBrush whiteBrush = new SolidColorBrush(Colors.White);
            //            SolidColorBrush yellowBrush = new SolidColorBrush(Color.FromRgb(255, 193, 7)); // #ffc107

            //            int size = 16;
            //            int pixelSize = 10;

            //            for (int i = 0; i < size; i++)
            //            {
            //                for (int j = 0; j < size; j++)
            //                {
            //                    Rect pixelRect = new Rect(j * pixelSize, i * pixelSize, pixelSize, pixelSize);

            //                    switch (iconCoin[i, j])
            //                    {
            //                        case 1:
            //                            drawingContext.DrawRectangle(blackBrush, null, pixelRect);
            //                            break;
            //                        case 2:
            //                            drawingContext.DrawRectangle(whiteBrush, null, pixelRect);
            //                            break;
            //                        case 3:
            //                            drawingContext.DrawRectangle(yellowBrush, null, pixelRect);
            //                            break;
            //                    }
            //                }
            //            }


            var pen = new Pen(OutBorderBrush, (OutBorderThickness.Top + OutBorderThickness.Left + OutBorderThickness.Right + OutBorderThickness.Bottom) / 4);
            DrawHelper.DrawPixRectangle(drawingContext, pen, ActualWidth, ActualHeight);
        }
    }
}
