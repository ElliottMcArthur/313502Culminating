/* Aidan Hobman
 * APA Book cite format
 * 6/12/2019
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
    /// Interaction logic for APABook.xaml
    /// </summary>
    public partial class APABook : Window
    {
        public APABook()
        {   
            InitializeComponent();
        }
        //Coded by Aidan
        private void btnCalculate2_Click(object sender, RoutedEventArgs e)
        {
            TextBlock buildTheApaCitation = new TextBlock();
            string outputForClipboard = ""; //When the text is copied to notepad, it is not pasted with the correct format with the so that it is entered down two lines
            Paragraph paragraph = new Paragraph();
            buildTheApaCitation.Inlines.Add(new Run(LastName.Text + ", " + FirstName.Text + ". " + MidName.Text + ". "));
            outputForClipboard += LastName.Text + ", " + FirstName.Text + ". " + MidName.Text + ". ";
            //if statements by Elliott
            if  (LastName2.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(LastName2.Text + ", "));
                outputForClipboard += LastName2.Text;
            }

            if (FirstName2.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(FirstName2.Text + ". "));
                outputForClipboard += FirstName2.Text;
            }

            if (MidName2.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(MidName2.Text + ". "));
                outputForClipboard += MidName2.Text;
            }

            if (LastName3.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(LastName3.Text + ", "));
                outputForClipboard += LastName3.Text;
            }
             
            if (FirstName3.Text != "" )
            {
                buildTheApaCitation.Inlines.Add(new Run(FirstName3.Text + ". "));
                outputForClipboard += FirstName3.Text;
            }

            if (MidName3.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(MidName3.Text + ". "));
                outputForClipboard += MidName3.Text;
            }

            if (LastName4.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(LastName4.Text + ", "));
                outputForClipboard += LastName4.Text;
            }

            if (FirstName4.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(FirstName4.Text + ". "));
                outputForClipboard += FirstName4.Text;
            }

            if (MidName4.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(MidName4.Text + ". "));
                outputForClipboard += MidName4.Text;
            }

            if(LastName.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(LastName5.Text + ", "));
                outputForClipboard += LastName5.Text;
            }

            if (FirstName5.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(FirstName5.Text + ". "));
                outputForClipboard += FirstName5.Text;
            }

            if (MidName5.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(MidName5.Text + ". "));
                outputForClipboard += MidName5.Text;
            }
            //Aidan
            buildTheApaCitation.Inlines.Add(new Run(" (" + Year.Text + "). " + ChapterTitle.Text + ". "));
            outputForClipboard += " (" + Year.Text + "). " + ChapterTitle.Text + ". ";
            buildTheApaCitation.Inlines.Add(new Italic(new Run("\n\n\t" + BookTitle.Text)));
            outputForClipboard += "\n\n\t" + BookTitle.Text;

            buildTheApaCitation.Inlines.Add(new Run(" (" + Edition.Text + "). " + Location.Text + ". " + Publisher.Text + "."));
            outputForClipboard += " (" + Edition.Text + "). " + Location.Text + ". " + Publisher.Text + ".";
            lblOutput.Content = buildTheApaCitation;

            foreach (object o in buildTheApaCitation.Inlines)
            {
                //MessageBox.Show(o.GetType().ToString());
            }


            Clipboard.SetText(outputForClipboard);
        }


        private void btnAddAutor_Click(object sender, RoutedEventArgs e)
        {
            LastName2.Visibility = Visibility.Visible;
            FirstName2.Visibility = Visibility.Visible;
            MidName2.Visibility = Visibility.Visible;
        }

        private void btnAddAuthor_Click(object sender, RoutedEventArgs e)
        {
            LastName3.Visibility = Visibility.Visible;
            FirstName3.Visibility = Visibility.Visible;
            MidName3.Visibility = Visibility.Visible;
        }

        private void btnAddAuthor3_Click(object sender, RoutedEventArgs e)
        {
            LastName4.Visibility = Visibility.Visible;
            FirstName4.Visibility = Visibility.Visible;
            MidName4.Visibility = Visibility.Visible;
        }

        private void btnAddAuthor4_Click(object sender, RoutedEventArgs e)
        {
            LastName5.Visibility = Visibility.Visible;
            FirstName5.Visibility = Visibility.Visible;
            MidName5.Visibility = Visibility.Visible;
        }

        private void btnAddAuthor5_Click(object sender, RoutedEventArgs e)
        {
            LastName6.Visibility = Visibility.Visible;
            FirstName6.Visibility = Visibility.Visible;
            MidName6.Visibility = Visibility.Visible;
        }
    }
}
