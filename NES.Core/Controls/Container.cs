using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NES.Core.Controls
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:NES.Core.Controls"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:NES.Core.Controls;assembly=NES.Core.Controls"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误:
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:Container/>
    ///
    /// </summary>
    public class Container : ContentControl
    {

        
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Container));




        public double TitleFontSize
        {
            get { return (double)GetValue(TitleFontSizeProperty); }
            set { SetValue(TitleFontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleFontSizeProperty =
            DependencyProperty.Register("TitleFontSize", typeof(double), typeof(Container), new PropertyMetadata(16.0));

        

        public int Thickness
        {
            get { return (int)GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Thickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register("Thickness", typeof(int), typeof(Container), new PropertyMetadata(4));






        public HorizontalAlignment TitleHorizontalAlignment
        {
            get { return (HorizontalAlignment)GetValue(TitleHorizontalAlignmentProperty); }
            set { SetValue(TitleHorizontalAlignmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleHorizontalAlignment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleHorizontalAlignmentProperty =
            DependencyProperty.Register("TitleHorizontalAlignment", typeof(HorizontalAlignment), typeof(Container), new PropertyMetadata(HorizontalAlignment.Left));





        public Thickness TitleMargin
        {
            get { return (Thickness)GetValue(TitleMarginProperty); }
            set { SetValue(TitleMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TitleMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleMarginProperty =
            DependencyProperty.Register("TitleMargin", typeof(Thickness), typeof(Container), new PropertyMetadata(new Thickness(30, 0, 30, 0)));




        private Label? _title;
        public override void OnApplyTemplate()
        {
            
            base.OnApplyTemplate();

             _title= GetTemplateChild("title") as Label;
        }

        //看到这里 你是否绷不住了 给我绷住啊啊啊啊啊啊啊啊啊啊啊
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);


            
            var pen = new Pen(new SolidColorBrush(Colors.Black),Thickness);

            Point start, end;

            switch (TitleHorizontalAlignment)
            {
                case HorizontalAlignment.Left:
                    start = new Point(Thickness, _title.ActualHeight / 2);
                    end = new Point(TitleMargin.Left, _title.ActualHeight / 2);
                    drawingContext.DrawLine(pen, start, end);


                    start = new Point(TitleMargin.Left + _title.ActualWidth, _title.ActualHeight / 2);
                    end = new Point(this.ActualWidth - Thickness, _title.ActualHeight / 2);
                    drawingContext.DrawLine(pen, start, end);
                    break;
                case HorizontalAlignment.Center:
                    start = new Point(Thickness, _title.ActualHeight / 2);
                    end = new Point((this.ActualWidth - _title.ActualWidth) / 2, _title.ActualHeight / 2);
                    drawingContext.DrawLine(pen, start, end);


                    start = new Point((this.ActualWidth - _title.ActualWidth) / 2 + _title.ActualWidth, _title.ActualHeight / 2);
                    end = new Point(this.ActualWidth - Thickness, _title.ActualHeight / 2);
                    drawingContext.DrawLine(pen, start, end);
                    break;
                case HorizontalAlignment.Right:
                    start = new Point(Thickness, _title.ActualHeight / 2);
                    end = new Point( this.ActualWidth-TitleMargin.Right-_title.ActualWidth, _title.ActualHeight / 2);
                    drawingContext.DrawLine(pen, start, end);


                    start = new Point(this.ActualWidth - TitleMargin.Right, _title.ActualHeight / 2);
                    end = new Point(this.ActualWidth - Thickness, _title.ActualHeight / 2);
                    drawingContext.DrawLine(pen, start, end);
                    break;
                default:
                    start = new Point(Thickness, _title.ActualHeight / 2);
                    end = new Point(TitleMargin.Left, _title.ActualHeight / 2);
                    drawingContext.DrawLine(pen, start, end);


                    start = new Point(TitleMargin.Left + _title.ActualWidth, _title.ActualHeight / 2);
                    end = new Point(this.ActualWidth - Thickness, _title.ActualHeight / 2);
                    drawingContext.DrawLine(pen, start, end);
                    break;
            }
          
         

            //


            start = new Point(this.ActualWidth, _title.ActualHeight / 2+Thickness);
            end = new Point(this.ActualWidth, this.ActualHeight-Thickness);
            drawingContext.DrawLine(pen, start, end);


            start = new Point(this.ActualWidth-Thickness, this.ActualHeight);
            end = new Point(Thickness, this.ActualHeight);
            drawingContext.DrawLine(pen, start, end);


            start =new Point(0, this.ActualHeight-Thickness);

            end = new Point(0, _title.ActualHeight / 2+Thickness);
            drawingContext.DrawLine(pen, start, end);
        }


    }
}
