using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_2
{
    class Contact //Класс контакта со свойствами
    {
        private string name;
        private string phone;
        public string Name
        {
            get { return name; }
            set
            {
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch) && !char.IsWhiteSpace(ch)) //Проверка на ввод только букв и пробелов
                    {
                        MessageBox.Show("Разрешенно вводить только буквы");
                        name = "";
                        return;
                    }
                }
                name = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.Length != 14 || value[0] != '(' || value[4] != ')' || value[8] != '-' || value[11] != '-') //Проверка на введение номера в строгом формате (000)000-00-00
                {
                    MessageBox.Show("Некорректный формат номера");
                    phone = null;
                    return;
                }
                foreach (var ch in value)
                {
                    if (!char.IsDigit(ch) && !char.IsPunctuation(ch)) //проверка на цифры
                    {
                        MessageBox.Show("Разрешенно вводить только цифры, знаки << ( >>, << ) >> и << - >>");
                        phone = "";
                        return;
                    }
                }
                phone = value;
            }
        }
    }
}
