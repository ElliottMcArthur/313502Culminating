/* MLA
 * 313502
 * Coded By Elliott
 * Website information is inputted and is outputted in MLA format
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
    /// Interaction logic for MLA.xaml
    /// </summary>
    public partial class MLA : Window
    {
        public MLA()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //Coded By Elliott
            TextBlock buildTheMlaCitation = new TextBlock();
            string outputForClipboard = ""; //When the text is copied to notepad, it is not pasted with the correct format with the so that it is entered down two lines

            Paragraph paragraph = new Paragraph();

            buildTheMlaCitation.Inlines.Add(new Run(MlaAuthorlast.Text + ", " + MlaAuthorfirst.Text + ", "));
            outputForClipboard += MlaAuthorlast.Text + ", " + MlaAuthorfirst.Text + ", ";

            if (MlaAuthorMiddle.Text != "")
            {
                buildTheMlaCitation.Inlines.Add(new Run(MlaAuthorMiddle.Text + ". "));
                outputForClipboard += MlaAuthorMiddle.Text + ". ";
            }

            buildTheMlaCitation.Inlines.Add(new Run(PageTitle.Text + ". "));
            outputForClipboard += PageTitle.Text;

            buildTheMlaCitation.Inlines.Add(new Italic(new Run(WebsiteTitle.Text)));
            outputForClipboard += WebsiteTitle.Text;
            buildTheMlaCitation.Inlines.Add(new Run(", " + "\n\n\t" +
                 Publisher.Text + ". " + Date.Text + "/" + Month.Text + "/" + Year.Text + ", " + Web.Text + " " + URL.Text + ". " + DateAccessed.Text + ": " + Date2.Text + "/" + Month2.Text + "/" + Year2.Text));
            outputForClipboard += ", " + "\n\n\t" +
                 Publisher.Text + ". " + Date.Text + "/" + Month.Text + "/" + Year.Text + ", " + Web.Text + " " + URL.Text + ". " + DateAccessed.Text + ": " + Date2.Text + "/" + Month2.Text + "/" + Year2.Text;

            lblOutput.Content = buildTheMlaCitation;

            foreach (object o in buildTheMlaCitation.Inlines)
            {
                //MessageBox.Show(o.GetType().ToString());
            }


            Clipboard.SetText(outputForClipboard);
        }
    }
}
