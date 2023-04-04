using NES.Core.Utilities.Draws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NES.Core.Controls
{
    public class ProgressBar:System.Windows.Controls.ProgressBar
    {
        
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            var pen = new Pen(BorderBrush, (BorderThickness.Top + BorderThickness.Left + BorderThickness.Right + BorderThickness.Bottom) / 4);
            DrawHelper.DrawPixRectangle(drawingContext, pen, ActualWidth, ActualHeight);
        }
    }
}
