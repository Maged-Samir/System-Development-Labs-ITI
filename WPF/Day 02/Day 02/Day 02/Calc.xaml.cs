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

namespace Day_02
{
    /// <summary>
    /// Interaction logic for Calc.xaml
    /// </summary>
    public partial class Calc : Window
    {
        public Calc()
        {
            InitializeComponent();
        }

        private Operator currentOperator;
        private double firstNumber;
        private double secondNumber;
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (txtResult.Text != "0")
            {
                txtResult.Text = $"{txtResult.Text}{btn.Content}";
            }
            else
            {
                txtResult.Text = btn.Content.ToString();
            }
        }
        //Clear --> Reset all Variables
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentOperator = 0;
            txtResult.Text = "0";
        }
      
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Add;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
        //Add event 
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            secondNumber = double.Parse(txtResult.Text);
            txtResult.Text = GetResult(firstNumber, currentOperator, secondNumber);
        }
        private string GetResult(double firstNumber, Operator currentOperator, double secondNumber)
        {
            if (currentOperator == Operator.Add)
            {
                return (firstNumber + secondNumber).ToString();
            }
            else if (currentOperator == Operator.Substract)
            {
                return (firstNumber - secondNumber).ToString();
            }
            else if (currentOperator == Operator.Multiply)
            {
                return (firstNumber * secondNumber).ToString();
            }
            else if (currentOperator == Operator.Divide)
            {
                return (firstNumber / secondNumber).ToString();
            }
            else
            {
                return "0";
            }
        }
        //Subtract event
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Substract;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
        //Multiplication
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Multiply;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
        //Division
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            currentOperator = Operator.Divide;
            firstNumber = double.Parse(txtResult.Text);
            txtResult.Text = "0";
        }
       
    }
    public enum Operator
    {
        Add,
        Substract,
        Multiply,
        Divide
    }

}

