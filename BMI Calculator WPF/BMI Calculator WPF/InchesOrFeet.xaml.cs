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
    /// Interaction logic for InchesOrFeet.xaml
    /// </summary>
    public partial class InchesOrFeet : Window
    {
        public InchesOrFeet()
        {
            InitializeComponent();
        }

        private void Inches_Click(object sender, RoutedEventArgs e)
        {
            Inches inches = new Inches();
            inches.Show();
            this.Close();
        }

        private void Feet_Click(object sender, RoutedEventArgs e)
        {
            Feet feet = new Feet();
            feet.Show();
            this.Close();
        }
    }
}
