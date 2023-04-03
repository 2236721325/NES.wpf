using NES.Core.Utilities.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NES.Core.Utilities.Draws
{
    public enum DrawDirection
    {
        Up,
        Down,
        Left,
        Right,
    }
    public class DrawHelper
    {
        
        public static void DrawPixRectangle(DrawingContext drawingContext,Pen pen, double width,double height)
        {
            
            Point start, end;
            start = new Point(0, 0);
            end=new Point(width, 0);
            DrawPixStraightLine(drawingContext, pen, start, end, DrawDirection.Right);
            start = new Point(width, 0);
            end = new Point(width, height);
            DrawPixStraightLine(drawingContext, pen, start, end, DrawDirection.Down);
            start = new Point(width, height);
            end = new Point(0, height);
            DrawPixStraightLine(drawingContext, pen, start, end, DrawDirection.Left);
            start = new Point(0, height);
            end = new Point(0, 0);
            DrawPixStraightLine(drawingContext, pen, start, end, DrawDirection.Up);

        }

        public static void DrawPixStraightLine(DrawingContext drawingContext,Pen pen, Point start, Point end, DrawDirection direction)
        {
            var thickness = pen.Thickness/2;
            switch (direction)
            {
                case DrawDirection.Up:
                    start.Y -= thickness;
                    end.Y+=thickness;
                    break;
                case DrawDirection.Down:
                    start.Y += thickness;
                    end.Y -= thickness;
                    break;
                case DrawDirection.Left:
                    start.X -= thickness;
                    end.X += thickness;
                    break;
                case DrawDirection.Right:
                    start.X += thickness;
                    end.X -= thickness;
                    break;
                default:
                    break;
            }

            drawingContext.DrawLine(pen, start, end);
        }

        
    }
}
