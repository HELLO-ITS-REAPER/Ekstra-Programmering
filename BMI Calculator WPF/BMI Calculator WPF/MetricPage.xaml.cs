using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BMI_Calculator_WPF
{
    /// <summary>
    /// Interaction logic for MetricPage.xaml
    /// </summary>
    public partial class MetricPage : Window
    {
        public MetricPage()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double Weight = Convert.ToDouble(WeightKG.Text);
                double Height = Convert.ToDouble(HeightCM.Text);

                double BMI = (Weight / Height / Height) * 10000;

                if (BMI > 18.5 && BMI < 25)
                {
                    Calculate.Foreground = new SolidColorBrush(Colors.Green);
                    HeightCM.Foreground = new SolidColorBrush(Colors.Green);
                    WeightKG.Foreground = new SolidColorBrush(Colors.Green);
                    MessageBox.Show($"Your BMI is {BMI:f2}.\nYou are within the ideal weight range.");
                }
                else if (BMI <= 18.5)
                {
                    Calculate.Foreground = new SolidColorBrush(Colors.Red);
                    HeightCM.Foreground = new SolidColorBrush(Colors.Red);
                    WeightKG.Foreground = new SolidColorBrush(Colors.Red);
                    MessageBox.Show($"Your BMI is {BMI:f2}.\nYou are underweight.");
                }
                else
                {
                    Calculate.Foreground = new SolidColorBrush(Colors.Red);
                    HeightCM.Foreground = new SolidColorBrush(Colors.Red);
                    WeightKG.Foreground = new SolidColorBrush(Colors.Red);
                    MessageBox.Show($"Your BMI is {BMI:f2}.\nYou are overweight. You should contact a doctor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CentimeterMetricPage_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightCM.Text = CentimeterMetricPage.Value.ToString();
        }

        private void KgMetricPage_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            WeightKG.Text = KgMetricPage.Value.ToString();
        }
    }
}
