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
    /// Логика взаимодействия для Translate.xaml
    /// </summary>
    public partial class Translate : Window
    {
        public Translate()
        {
            InitializeComponent();
        }
        //сортировка полей на ввод только чисел
        private void Digit_Check(object sender, TextCompositionEventArgs e)
        {
            if (meth_trans.Digit_Check1(e.Text) == false)
            {
                e.Handled = true;
            }
        }
        Meth_Trans meth_trans = new Meth_Trans();
        private void Trans_Click(object sender, RoutedEventArgs e)
        {
            char[] digit = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string number = Numb.Text,
                   result = "";
            int digit_10 = 0, 
                degree = 0;

            if (meth_trans.Button(Numb.Text, From.Text, To.Text) == true)
            {
                int f = Convert.ToInt32(From.Text),
                    t = Convert.ToInt32(To.Text);
                //перевод числа в 10-ую систему
                for (int i = number.Length - 1; i >= 0; --i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        if (number[i] == digit[j])
                        {
                            digit_10 += (int)(j * Math.Pow(f, degree));
                            ++degree;
                            break;
                        }
                    }
                }

                //перевод числа в нужную систему счислений путём взятия остатка
                if (t == 10)
                {
                    Result.Text = digit_10.ToString();
                    return;
                }
                else while (digit_10 != 0)
                    {
                        result = digit[digit_10 % t].ToString() + result;//ищем остаток в массиве и пишем в строку
                        digit_10 /= t;
                    }
                Result.Text = result;
            }
        }
    }
}
