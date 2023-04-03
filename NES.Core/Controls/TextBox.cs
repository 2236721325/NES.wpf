using NES.Core.Utilities.Draws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NES.Core.Controls
{
    public class TextBox: System.Windows.Controls.TextBox
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            var pen = new Pen(Brushes.Black, 4);
            DrawHelper.DrawPixRectangle(drawingContext, pen, ActualWidth, ActualHeight);
        }
    }
}
