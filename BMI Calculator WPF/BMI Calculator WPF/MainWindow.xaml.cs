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

namespace BMI_Calculator_WPF
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

        private void Metric_Click(object sender, RoutedEventArgs e)
        {
            MetricPage metricPage = new MetricPage();
            metricPage.Show();
            this.Close();
        }

        private void InchesOrFeet_Click(object sender, RoutedEventArgs e)
        {
            InchesOrFeet inchesOrfeet = new InchesOrFeet();
            inchesOrfeet.Show();
            this.Close();
        }
    }
}
