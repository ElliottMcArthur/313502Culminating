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
    /// Interaction logic for APA.xaml
    /// </summary>
    public partial class APA : Window
    { //Everything APA coded by aidan
        public APA()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, RoutedEventArgs e)
        {
            TextBlock buildTheApaCitation = new TextBlock();
            string outputForClipboard = ""; //When the text is copied to notepad, it is not pasted with the correct format with the so that it is entered down two lines

            Paragraph paragraph = new Paragraph();

            buildTheApaCitation.Inlines.Add(new Run(LastName.Text + ", " + FirstName.Text + ", "));
            outputForClipboard += LastName.Text + ", " + FirstName.Text + ", ";
            if (MidName.Text != "")
            {
                buildTheApaCitation.Inlines.Add(new Run(MidName.Text + ". "));
                outputForClipboard += MidName.Text;
            }

            buildTheApaCitation.Inlines.Add(new Italic(new Run(WebsiteName.Text)));
            outputForClipboard += WebsiteName.Text;

            buildTheApaCitation.Inlines.Add(new Run(", " + "\n\n\t" +
                " (" + Year.Text + ") " + ArticleName.Text + ", " + Day.Text + "/" + Month.Text + ". " + APAlink.Text + "."));
            outputForClipboard += ", " + "\n\n\t" +
                " (" + Year.Text + ") " + ArticleName.Text + ", " + Day.Text + "/" + Month.Text + ". " + APAlink.Text + ".";

            lblOutput.Content = buildTheApaCitation;

            foreach (object o in buildTheApaCitation.Inlines)
            {
                //MessageBox.Show(o.GetType().ToString());
            }


            Clipboard.SetText(outputForClipboard);
        }
    }
}
