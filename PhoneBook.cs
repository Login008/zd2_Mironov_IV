﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_2
{
    class PhoneBook
    {
        List<Contact> contacts;
        public PhoneBook() //Конструктор
        {
            contacts = new List<Contact>();
        }

        public void AddContact(string Name, string Phone) //Добавление контакта в список
        {
            Contact contact = new Contact();
            contact.Name = Name;
            contact.Phone = Phone;

            Contact contact1 = FindContact(Name);

            if (contact1 == null)
                AddContact(contact);
            else
                MessageBox.Show("Нельзя добавлять в список контакты с одинаковым именем");
        }
        public void AddContact(Contact contact) //Перегрузка метода добавления
        {
            contacts.Add(contact);
        }
        public void RemoveContact(string Name) //Удаление контакта из записной книги
        {
            Contact contact1 = FindContact(Name);
            if (contact1 != null)
                contacts.Remove(contact1);
            else
                MessageBox.Show("Такого контакта нет в записной книге");
        }
        public Contact FindContactByName(string Name) //Поиск контакта в списке по имени
        {
            foreach (var item in contacts)
            {
                if (item.Name.Contains(Name))
                    return item;
            }
            return null;
        }
        public Contact FindContact(string Name) //Поиск контакта в списке по полному совпадению для метода добавления
        {
            foreach (var item in contacts)
            {
                if (item.Name == Name)
                    return item;
            }
            return null;
        }
        public List<string> GetAllContacts() //Получаем список контактов
        {
            List<string> list = new List<string>();
            foreach (var item in contacts)
            {
                list.Add(item.Name + "~" + item.Phone);
            }
            list.Sort();
            return list;
        }
        public void EditContact(Contact contact, string Name, string Phone) //Редактирование контакта
        {
            RemoveContact(contact.Name);
            AddContact(Name, Phone);
        }
    }
}
