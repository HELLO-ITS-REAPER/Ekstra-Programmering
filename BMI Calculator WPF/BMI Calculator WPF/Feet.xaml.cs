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
    /// Interaction logic for Feet.xaml
    /// </summary>
    public partial class Feet : Window
    {
        public Feet()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double Weight = Convert.ToDouble(WeightPounds.Text);
                double Height = Convert.ToDouble(HeightFeet.Text);
                double ConvertToInches = Height * 12;

                double BMI = (Weight / (ConvertToInches * ConvertToInches) * 703);

                if (BMI > 18.5 && BMI < 25)
                {
                    Calculate.Foreground = new SolidColorBrush(Colors.Green);
                    HeightFeet.Foreground = new SolidColorBrush(Colors.Green);
                    WeightPounds.Foreground = new SolidColorBrush(Colors.Green);
                    MessageBox.Show($"Your BMI is {BMI:f2}.\nYou are within the ideal weight range.");
                }
                else if (BMI <= 18.5)
                {
                    Calculate.Foreground = new SolidColorBrush(Colors.Red);
                    HeightFeet.Foreground = new SolidColorBrush(Colors.Red);
                    WeightPounds.Foreground = new SolidColorBrush(Colors.Red);
                    MessageBox.Show($"Your BMI is {BMI:f2}.\nYou are underweight.");
                }
                else
                {
                    Calculate.Foreground = new SolidColorBrush(Colors.Red);
                    HeightFeet.Foreground = new SolidColorBrush(Colors.Red);
                    WeightPounds.Foreground = new SolidColorBrush(Colors.Red);
                    MessageBox.Show($"Your BMI is {BMI:f2}.\nYou are overweight. You should contact a doctor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FeetsFeetPage_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightFeet.Text = FeetsFeetPage.Value.ToString();
        }

        private void PoundsFeetPage_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            WeightPounds.Text = PoundsFeetPage.Value.ToString();
        }
    }
}
