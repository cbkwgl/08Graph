using System;
using System.Collections.Generic;
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

namespace _08Graph
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static double x = 0, y = 0;
        public static double origin_x = 0, origin_y = 0;

        public static Boolean initialized = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawLine(double x1, double y1, double x2, double y2)
        {
            Line ln = new Line();
            ln.X1 = x;
            ln.Y1 = y;
            ln.X2 = x2;
            ln.Y2 = y2;
            ln.StrokeThickness = 3;
            ln.Stroke = Brushes.DarkOrchid;
            cnv.Children.Add(ln);
        }


        private void cnv_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(initialized)
            {
                double temp_x = e.GetPosition(cnv).X;
                double temp_y = e.GetPosition(cnv).Y;
                DrawLine(x, y, temp_x, temp_y);
                //DrawLine(origin_x, y, origin_x, temp_y);
                //DrawLine(x, origin_y, temp_x, origin_y);
                x = temp_x;
                y = temp_y;
            }
            else
            {
                initialized = true;
                x = e.GetPosition(cnv).X;
                y = e.GetPosition(cnv).Y;
                origin_x = x;
                origin_y = y;
            }
        }
    }
}
