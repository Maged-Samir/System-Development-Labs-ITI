using AngleSharp.Text;
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

namespace Day_01
{
    /// <summary>
    /// Interaction logic for TextEditor.xaml
    /// </summary>
    public partial class TextEditor : Window
    {
        public TextEditor()
        {
            InitializeComponent();
           
        }

        private void Set_text(object sender, RoutedEventArgs e)
        {
            //textbox1.Document.Blocks.Clear();
            //textbox1.Document.Blocks.Add(new Paragraph(new Run("Replase Default text with Intial Default value")));
            textbox1.Text = "Replase Default text with Intial Default value";
        }

        private void Select_All_Text(object sender, RoutedEventArgs e)
        {
            textbox1.SelectAll();
            textbox1.Focus();
        }

        private void Clear_Text(object sender, RoutedEventArgs e)
        {
            textbox1.Clear();
        }

        private void Prepend_Text(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "**Prepended Text**" + textbox1.Text;
        }

        private void Insert_Text(object sender, RoutedEventArgs e)
        {
            textbox1.Text = textbox1.Text.Insert(textbox1.CaretIndex, "**Inserted text**");
        }

        private void Append_Text(object sender, RoutedEventArgs e)
        {
            textbox1.Text =  textbox1.Text + "**Appended Text**";
        }

        private void Cut_Text(object sender, RoutedEventArgs e)
        {
            //textbox1.SelectAll();
            if (textbox1.SelectionLength > 0)
            {
                Clipboard.SetDataObject(textbox1.SelectedText);
            }
            textbox1.SelectedText = "";
        }

        private void Past_Text(object sender, RoutedEventArgs e)
        {
            textbox1.Text = textbox1.Text + Clipboard.GetText();
        }

        private void Undo_Text(object sender, RoutedEventArgs e)
        {
            textbox1.Undo();
        }

        private void Change_Accecability(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "ReadOnly":
                    textbox1.IsReadOnly = true;
                    break;

                case "Edatible":
                    textbox1.IsReadOnly = false;
                    break;
            }
        }

        private void Change_Alignment(object sender, RoutedEventArgs e)
        {
            
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Right":
                    textbox1.TextAlignment = TextAlignment.Right;
                    break;

                case "Center":
                    textbox1.TextAlignment = TextAlignment.Center;
                    break;
                case "Left":
                    textbox1.TextAlignment = TextAlignment.Left;
                    break;
            }
        }
    }
}
