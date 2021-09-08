using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows;

namespace Practice
{
    public class Meth_Trans
    {
        public bool Digit_Check1(string text)
        {
            Regex regex = new Regex("[^0-9]+");
            bool check = regex.IsMatch(text);
            if (check == true)
            {
                return false;
            }
            else return true;
        }
        public bool Button(string number, string from, string to)
        {
            char[] digit = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //Проверка введенных данных
            if (number != "" && from != "" && to != "") //если все поля заполнены, проверяем правильность
            {
                int f = Convert.ToInt32(from),
                    t = Convert.ToInt32(to);

                if (!(f > 1 && f < 11 && t > 1 && t < 11))
                {
                    MessageBox.Show("Неверная система счисления! Введите число от 2 до 10.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                };
                for (int i = 0; i < number.Length; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        if (number[i] == digit[j])
                        {
                            if (j > (f - 1))
                            {
                                MessageBox.Show("Число не соответствует системе счисления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                return false;
                            }
                        }
                    }
                }
            }
            else //если не все поля заполнены
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            };
            return true;
        }
    }
}

