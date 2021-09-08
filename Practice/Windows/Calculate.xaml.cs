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
using System.Text.RegularExpressions;

namespace Practice
{
    /// <summary>
    /// Логика взаимодействия для Calculate.xaml
    /// </summary>
    public partial class Calculate : Window
    {
        public Calculate()
        {
            InitializeComponent();
        }
        //сортировка полей на ввод только чисел
        private void Digit_Check(object sender, TextCompositionEventArgs e)
        {
            if (meth_calc.Digit_Check1(e.Text) == false)
            {
                e.Handled = true;
            }
        }
        Meth_Calc meth_calc = new Meth_Calc();
        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            char[] digit = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string n1 = Numb1.Text,
                   n2 = Numb2.Text,
                   result = "";
            int digit1_10 = 0,
                digit2_10 = 0,
                degree_1 = 0,
                degree_2 = 0,
                result_10 = 0;
            if (meth_calc.Button(Numb1.Text, Numb2.Text, Systm.Text) == true)
            {
                //перевод чисел в 10-ую систему
                int s = Convert.ToInt32(Systm.Text);
                for (int i = n1.Length - 1; i >= 0; --i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        if (n1[i] == digit[j])
                        {
                            digit1_10 += (int)(j * Math.Pow(s, degree_1));
                            ++degree_1;
                            break;
                        }
                    }
                }
                for (int i = n2.Length - 1; i >= 0; --i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        if (n2[i] == digit[j])
                        {
                            digit2_10 += (int)(j * Math.Pow(s, degree_2));
                            ++degree_2;
                            break;
                        }
                    }
                }
                //выбор операций
                switch (Cb_Operation.SelectedIndex)
                {
                    case 0: //сложение
                        result_10 = digit1_10 + digit2_10;
                        break;
                    case 1: //вычитание
                        result_10 = digit1_10 - digit2_10;
                        break;
                    case 2: //умножение
                        result_10 = digit1_10 * digit2_10;
                        break;
                }
                //перевод числа в нужную систему счислений путём взятия остатка
                if (s == 10)
                {
                    if (result_10 < 0)
                    {
                        Result.Text = result_10.ToString();
                    }
                    else if (result_10 > 0)
                    {
                        Result.Text = result_10.ToString();
                    }
                    else Result.Text = "0";
                    return;
                }
                if (result_10 < 0)
                {
                    while (Math.Abs(result_10) != 0)
                    {
                        result = digit[Math.Abs(result_10) % s].ToString() + result;//ищем остаток в массиве и пишем в строку
                        result_10 = Math.Abs(result_10) / s;
                    }
                    Result.Text = "−" + result;
                }
                else if (result_10 > 0)
                {
                    while (result_10 != 0)
                    {
                        result = digit[result_10 % s].ToString() + result;
                        result_10 /= s;
                    }
                    Result.Text = result;
                }
                else Result.Text = "0";
            }
        }
    }
}
