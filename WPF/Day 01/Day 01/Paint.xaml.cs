using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Day_01
{
    /// <summary>
    /// Interaction logic for Paint.xaml
    /// </summary>
    public partial class Paint : Window
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void Change_Color(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Red":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Red;
                    break;

                case "Green":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Green;
                    break;

                case "Blue":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }
        }

        private void Change_Mode(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ink":

                    InkCan.EditingMode = InkCanvasEditingMode.Ink;
                    break;

                case "Select":

                    InkCan.EditingMode = InkCanvasEditingMode.Select;
                    break;

                case "Erase":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;

                case "Erase by strock":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
            }
        }

        private void Change_Shape(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "ellipse":

                    
                    break;

                case "rectangel":

                    InkCan.EditingMode = InkCanvasEditingMode.Select;
                    break;

            }
        }

        private void Brush_Size(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "small":
                    var drawingAttributes = InkCan.DefaultDrawingAttributes;
                    drawingAttributes.Width = 10;
                    drawingAttributes.Height = 10;
                    break;

                case "normal":
                    var drawingAttributes2 = InkCan.DefaultDrawingAttributes;
                    drawingAttributes2.Width = 20;
                    drawingAttributes2.Height = 20;
                    break;

                case "large":
                    var drawingAttributes3 = InkCan.DefaultDrawingAttributes;
                    drawingAttributes3.Width = 30;
                    drawingAttributes3.Height = 30;
                    break;

            }
        }

        private void Set_Canvas(object sender, RoutedEventArgs e)
        {
            InkCan.Strokes.Clear();
        }

        private void Save_Canvas(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "isf files (*.jpg)|*.jpg";

            if (saveFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName,
                                               FileMode.Create);
                InkCan.Strokes.Save(fs);
                fs.Close();
            }

        }

        private void Load_Canvas(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "isf files (*.jpg)|*.jpg";

            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,
                                               FileMode.Open);
                InkCan.Strokes = new StrokeCollection(fs);
                fs.Close();
            }
        }

        private void Cut_Canvas(object sender, RoutedEventArgs e)
        {
            InkCan.CutSelection();
        }

        private void Past_Canvas(object sender, RoutedEventArgs e)
        {
            InkCan.Paste();
        }
    }
}
