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
    /// Interaction logic for Inches.xaml
    /// </summary>
    public partial class Inches : Window
    {
        public Inches()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double Weight = Convert.ToDouble(WeightPounds.Text);
                double Height = Convert.ToDouble(HeightInches.Text);
                double BMI = (Weight / (Height * Height) * 703);
                if (BMI > 18.5 && BMI < 25)
                {
                    Calculate.Foreground = new SolidColorBrush(Colors.Green);
                    HeightInches.Foreground = new SolidColorBrush(Colors.Green);
                    WeightPounds.Foreground = new SolidColorBrush(Colors.Green);
                    MessageBox.Show($"Your BMI is {BMI:f2}.\nYou are within the ideal weight range.");
                }
                else if (BMI <= 18.5)
                {
                    Calculate.Foreground = new SolidColorBrush(Colors.Red);
                    HeightInches.Foreground = new SolidColorBrush(Colors.Red);
                    WeightPounds.Foreground = new SolidColorBrush(Colors.Red);
                    MessageBox.Show($"Your BMI is {BMI:f2}.\nYou are underweight.");
                }
                else
                {
                    Calculate.Foreground = new SolidColorBrush(Colors.Red);
                    HeightInches.Foreground = new SolidColorBrush(Colors.Red);
                    WeightPounds.Foreground = new SolidColorBrush(Colors.Red);
                    MessageBox.Show($"Your BMI is {BMI:f2}.\nYou are overweight. You should contact a doctor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PoundsSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            WeightPounds.Text = PoundsSlider.Value.ToString();
        }

        private void InchesSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightInches.Text = InchesSlider.Value.ToString();
        }
    }
}
