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

namespace SubtitlesFixer
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            TextRange textRange = new TextRange(
                // TextPointer to the start of content in the RichTextBox.
                rtbSubtitles.Document.ContentStart,
                // TextPointer to the end of content in the RichTextBox.
                rtbSubtitles.Document.ContentEnd
            );

            string fileText = textRange.Text;

            string ansiCharUpperA = "";
            string ansiCharUpperC = "";
            string ansiCharUpperE = "";
            string ansiCharUpperL = "";
            string ansiCharUpperN = "";
            string ansiCharUpperO = "";
            string ansiCharUpperS = "";
            string ansiCharUpperZ1 = "";
            string ansiCharUpperZ2 = "";

            string ansiCharLowerA = "¹";
            string ansiCharLowerC = "æ";
            string ansiCharLowerE = "ê";
            string ansiCharLowerL = "³";
            string ansiCharLowerN = "";
            string ansiCharLowerO = "";
            string ansiCharLowerS = "";
            string ansiCharLowerZ1 = "Ÿ";
            string ansiCharLowerZ2 = "¿";

            string letterUpperA = "Ą";
            string letterUpperC = "Ć";
            string letterUpperE = "Ę";
            string letterUpperL = "Ł";
            string letterUpperN = "Ń";
            string letterUpperO = "Ó";
            string letterUpperS = "Ś";
            string letterUpperZ1 = "Ź";
            string letterUpperZ2 = "Ż";

            string letterLowerA = "ą";
            string letterLowerC = "ć";
            string letterLowerE = "ę";
            string letterLowerL = "ł";
            string letterLowerN = "ń";
            string letterLowerO = "ó";
            string letterLowerS = "ś";
            string letterLowerZ1 = "ź";
            string letterLowerZ2 = "ż";

            //            fileText.Replace(ansiCharUpperA, letterUpperA);
            //            fileText.Replace(ansiCharUpperC, letterUpperC);
            //            fileText.Replace(ansiCharUpperE, letterUpperE);
            //            fileText.Replace(ansiCharUpperL, letterUpperL);
            //            fileText.Replace(ansiCharUpperN, letterUpperN);
            //            fileText.Replace(ansiCharUpperO, letterUpperO);
            //            fileText.Replace(ansiCharUpperS, letterUpperS);
            //            fileText.Replace(ansiCharUpperZ1, letterUpperZ1);
            //            fileText.Replace(ansiCharUpperZ2, letterUpperZ2);

            fileText.Replace(ansiCharLowerA, letterLowerA);
            fileText.Replace(ansiCharLowerC, letterLowerC);
            fileText.Replace(ansiCharLowerE, letterLowerE);
//            fileText.Replace(ansiCharLowerL, letterLowerL);
//            fileText.Replace(ansiCharLowerN, letterLowerN);
//            fileText.Replace(ansiCharLowerO, letterLowerO);
//            fileText.Replace(ansiCharLowerS, letterLowerS);
            fileText.Replace(ansiCharLowerZ1, letterLowerZ1);
            fileText.Replace(ansiCharLowerZ2, letterLowerZ2);

            MessageBox.Show(fileText);

            rtbSubtitles.Document.Blocks.Clear();
            rtbSubtitles.Document.Blocks.Add(new Paragraph(new Run(fileText)));
        }
    }
}