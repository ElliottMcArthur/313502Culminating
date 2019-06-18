/* Elliott McArthur
 * 313502
 * Mla citation generator for a book
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
using System.Windows.Shapes;

namespace _313502Culminating
{
    /// <summary>
    /// Interaction logic for MLABook.xaml
    /// </summary>
    public partial class MLABook : Window
    { //Everything MLA Coded by Elliott
        public MLABook()
        {   
            InitializeComponent();
        }

        private void btnCalculate2_Click(object sender, RoutedEventArgs e)
        {
            //Coded By Elliott
            TextBlock buildTheMlaCitation = new TextBlock();
            string outputForClipboard = ""; //When the text is copied to notepad, it is not pasted with the correct format with the so that it is entered down two lines

            Paragraph paragraph = new Paragraph();
            buildTheMlaCitation.Inlines.Add(new Run(MlaAuthorlast.Text + ", " + MlaAuthorfirst.Text + ", " + MlaAuthorMiddle.Text + ". "));
            outputForClipboard += MlaAuthorlast.Text + ", " + MlaAuthorfirst.Text + ", " + MlaAuthorMiddle.Text + ". ";

            if (MlaAuthorLast2.Text != "")
            {
                buildTheMlaCitation.Inlines.Add(new Run(MlaAuthorLast2.Text + ", "));
                outputForClipboard += MlaAuthorLast2.Text + ", ";
            }
            

            if (MlaAuthorfirst2.Text != "")
            {
                buildTheMlaCitation.Inlines.Add(new Run(MlaAuthorfirst2.Text + ", "));
                outputForClipboard += MlaAuthorfirst2.Text + ", ";
            }


            if (MlaAuthorMiddle2.Text != "")
            {
                buildTheMlaCitation.Inlines.Add(new Run(MlaAuthorMiddle2.Text + ". "));
                outputForClipboard += MlaAuthorMiddle2.Text + ", ";
            }

            if(MlaAuthorLast3.Text != "")
            {
                buildTheMlaCitation.Inlines.Add(new Run(MlaAuthorLast3.Text + ", "));
                outputForClipboard += MlaAuthorLast3.Text + ", ";
            }

            if(MlaAuthorfirst3.Text != "")
            {
                buildTheMlaCitation.Inlines.Add(new Run(MlaAuthorfirst3.Text + ", "));
                outputForClipboard += MlaAuthorfirst3.Text + ", ";
            }

            if(MlaAuthorMiddle3.Text != "")
            {
                buildTheMlaCitation.Inlines.Add(new Run(MlaAuthorMiddle3.Text + ". "));
                outputForClipboard += MlaAuthorMiddle3.Text + ", ";
            }

            buildTheMlaCitation.Inlines.Add(new Italic(new Run(BookTitle.Text + ". ")));
            outputForClipboard += BookTitle.Text + ", ";

            buildTheMlaCitation.Inlines.Add(new Run(Location.Text + ": " + "\n\n\t" +
                 Publisher.Text + ", " + Date.Text + "/" + Month.Text + "/" + Year.Text + ". " + Print.Text + " "));
            outputForClipboard += Location.Text + ": " + "\n\n\t" +
                 Publisher.Text + ", " + Date.Text + "/" + Month.Text + "/" + Year.Text + ". " + Print.Text + " ";

            lblOutput.Content = buildTheMlaCitation;

            foreach (object o in buildTheMlaCitation.Inlines)
            {
                //MessageBox.Show(o.GetType().ToString());
            }


            Clipboard.SetText(outputForClipboard);


            //Clipboard.SetData(DataFormats.Rtf, buildTheMlaCitation.Inlines);
            
//            MessageBox.Show(buildTheMlaCitation.Inlines);
//            Clipboard.SetDataObject(buildTheMlaCitation.Inlines);
        }

        private void btnAddAutor_Click(object sender, RoutedEventArgs e)
        {
            MlaAuthorfirst2.Visibility = Visibility.Visible;
            MlaAuthorLast2.Visibility = Visibility.Visible;
            MlaAuthorMiddle2.Visibility = Visibility.Visible;
        }

        private void MlaAuthorfirst_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MlaAuthor3_Click(object sender, RoutedEventArgs e)
        {
            MlaAuthorfirst3.Visibility = Visibility.Visible;
            MlaAuthorMiddle3.Visibility = Visibility.Visible;
            MlaAuthorLast3.Visibility = Visibility.Visible;
        }
    }
}
