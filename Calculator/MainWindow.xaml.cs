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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _firstNumber;
        private double _secondNumber;
        private string _operation;
        private double _result;
        public MainWindow()
        {
            InitializeComponent();
            btn0.Click += Btn_Click;
            btn1.Click += Btn_Click;
            btn2.Click += Btn_Click;
            btn3.Click += Btn_Click;
            btn4.Click += Btn_Click;
            btn5.Click += Btn_Click;
            btn6.Click += Btn_Click;
            btn7.Click += Btn_Click;
            btn8.Click += Btn_Click;
            btn9.Click += Btn_Click;
            btn0.Click += Btn_Click;
            btnPlus.Click += Btn_Click;
            btnMinus.Click += Btn_Click;
            btnMulti.Click += Btn_Click;
            btnDiv.Click += Btn_Click;
            btnResult.Click += Btn_Click;
            btnClear.Click += Btn_Click;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            _operation = btn.Content.ToString();

            if (_operation == "+")
            {
                _result = _firstNumber + _secondNumber;
                text.Text = Convert.ToString(_result);
            }
            else if (_operation == "-")
            {
                _result = _firstNumber - _secondNumber;
                text.Text = Convert.ToString(_result);
            }
            else if (_operation == "*")
            {
                _result = _firstNumber * _secondNumber;
                text.Text = Convert.ToString(_result);
            }
            else if (_operation == "/")
            {
                if(_secondNumber != 0)
                {
                    _result = _firstNumber / _secondNumber;
                    text.Text = Convert.ToString(_result);
                }
            }

        }
    }
}
