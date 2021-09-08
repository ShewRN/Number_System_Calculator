using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows;

namespace Practice
{
    public class Meth_Calc
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
        public bool Button(string number1, string number2, string systm)
        {
            char[] digit = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //Проверка введенных данных
            if (number1 != "" && number2 != "" && systm != "") //если все поля заполнены, проверяем правильность
            {
                int s = Convert.ToInt32(systm);
                if (!(s > 1 && s < 11))
                {
                    MessageBox.Show("Неверная система счисления! Введите число от 2 до 10.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                };
                for (int i = 0; i < number1.Length; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        if (number1[i] == digit[j])
                        {
                            if (j > (s - 1))
                            {
                                MessageBox.Show("Первое число не соответствует системе счисления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                return false;
                            }
                        }
                    }
                }
                for (int i = 0; i < number2.Length; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        if (number2[i] == digit[j])
                        {
                            if (j > (s - 1))
                            {
                                MessageBox.Show("Второе число не соответствует системе счисления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
