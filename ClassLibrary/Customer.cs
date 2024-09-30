using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Customer
    {
        public string FirstName { get; set; } //Имя
        public string LastName { get; set; } //Фамилия
        public string Patronymic { get; set; } //Отчество
        public string PhoneNumber { get; set; } //Номер телефона

        //Конструктор
        public Customer(string lastName, string firstName, string patronymic, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
        }

        //Переопределение метода ToString()
        public override string ToString()
        {
            return LastName + " " + FirstName + " " + Patronymic + ", " + PhoneNumber;
        }

        //Метод для вывода данных в DataGrid
        public string ToDataGrid()
        {
            return FirstName + " " + PhoneNumber;
        }
    }
}
