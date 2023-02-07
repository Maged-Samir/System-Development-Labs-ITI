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

namespace Day_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Student> students { get; set; }

                public MainWindow()
        {
            InitializeComponent();
            students = new List<Student>()
            {
                new Student(){Id=1,Name="Ahmed",Age=20,TotalGrade=100,Image="c:\\users\\maged\\desktop\\day 03\\day 03\\imgs\\1.avif" },
                    new Student(){Id=2,Name="Mona",Age=21,TotalGrade=90,Image="c:\\users\\maged\\desktop\\day 03\\day 03\\imgs\\2.avif"},
                    new Student(){Id=3,Name="Omnia",Age=22,TotalGrade=96,Image="c:\\users\\maged\\desktop\\day 03\\day 03\\imgs\\3.avif"},
                    new Student(){Id=4,Name="Reham",Age=20,TotalGrade=94,Image="c:\\users\\maged\\desktop\\day 03\\day 03\\imgs\\4.avif"},
                    new Student(){Id=5,Name="Ali",Age=22,TotalGrade=98,Image="c:\\users\\maged\\desktop\\day 03\\day 03\\imgs\\5.avif"},
                };

            
            lst.ItemsSource = students;

        }

    }
}
