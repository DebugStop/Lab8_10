using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Lab8_10
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

                            private void button_Click(object sender, RoutedEventArgs e)
         {
            string pattern_city_street = @"^[A-Z][a-z]*$";
            string pattern_house = @"^\d*$";
            string text_c = textBox.Text;
            string text_s = textBox1.Text;
            string text_h = textBox2.Text;

            if ((Regex.IsMatch(text_c, pattern_city_street) == true) && (Regex.IsMatch(text_s, pattern_city_street)) && (Regex.IsMatch(text_h, pattern_house)))
            {
                 MessageBox.Show("ДА");
             }
             else
             {
                 MessageBox.Show("НЕТ");
             }
         }
 
        
     }
 }