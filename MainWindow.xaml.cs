/* Culminating project
 * Elliott McArthur and Aidan Hobman
 * converts cites to either mla or apa format
 */
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

namespace _313502Culminating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {   
            InitializeComponent();
            Background = Brushes.Aqua;
        }

        private void MLA_Click(object sender, RoutedEventArgs e)
        {
            MLA mla = new MLA();
            mla.ShowDialog();
        }

        private void APA_Click(object sender, RoutedEventArgs e)
        {
            APA apa = new APA();
            apa.ShowDialog();
        }

        private void Mlabook_Click(object sender, RoutedEventArgs e)
        {
            MLABook mlabook = new MLABook();
            mlabook.ShowDialog();
        }

        private void APAbook_Click(object sender, RoutedEventArgs e)
        {
            APABook apabook = new APABook();
            apabook.ShowDialog();
        }
    }
}
