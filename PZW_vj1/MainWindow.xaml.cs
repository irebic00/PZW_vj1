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

namespace PZW_vj1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.addLeft.Click += new RoutedEventHandler(addLeft_Click);
            this.addRight.Click += new RoutedEventHandler(addRight_Click);
        }

        private void addLeft_Click(object sender, RoutedEventArgs e)
        {
            var tmp = new Rectangle();

            tmp.Fill = temporaryRectangle.Fill;
            tmp.Width = 40;
            tmp.Height = 40;
            tmp.Margin = new Thickness(5);
            leftPanel.Children.Add(tmp);
        }

        private void addRight_Click(object sender, RoutedEventArgs e)
        {
            var tmp = new Rectangle();
            var blackBrush = new SolidColorBrush();
            blackBrush.Color = Colors.Black;

            tmp.Fill = temporaryRectangle.Fill;
            tmp.Width = 350;
            tmp.Height = 30;
            tmp.Stroke = blackBrush;
            tmp.Margin = new Thickness(5);
            rightPanel.Children.Add(tmp);
        }
    }
}
