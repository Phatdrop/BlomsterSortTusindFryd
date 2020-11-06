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

namespace BlomsterSortTusindFryd
{
    /// <summary>
    /// Interaction logic for Vindowtest.xaml
    /// </summary>
    public partial class Vindowtest : Window
    {
        public Vindowtest()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = blomsterNavntextbox.Text;
            string billedesti = billedestitextbox.Text;
            int produktionstid = int.Parse (Produktionstidtextbox.Text);
            int halverinstid = int.Parse(halveringstidtextbox.Text);
            int størrelse = int.Parse(Størrelsetextbox.Text);
            Controller.Instance.UpdateFlowerInformation(name, billedesti, produktionstid, halverinstid, størrelse);
            confirmationtextbox.Text = $"Blomst {name} er blevet opdateret med {størrelse}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }
    }

}
