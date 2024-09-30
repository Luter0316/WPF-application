using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Order
    {
        public int Number { get; } //Номер заказа
        public DateTime Date { get; } //Дата заказа
        public string Structure { get; set; } //Состав заказа
        //Заказчик
        public Customer Person { get; set; }
        public Order(Customer person)
        {
            this.Person = person;
        }
        //
        public int Cost { get; } //Стоимость заказа
        public bool Status { get; set; } //Статус заказа

        //Конструктор нового заказа
        public Order(string structure, Customer person, int cost, bool status)
        {
            this.Number = new Random().Next(101);
            this.Date = DateTime.Now; //Сделать выбор даты
            this.Structure = structure;
            this.Person = person;
            this.Cost = cost;
            //this.Type = type;
            //this.Address = address;
            this.Status = status;
        }
        //Конструктор существующего заказа
        public Order(int number, DateTime datetime, string structure, Customer person, int cost, bool status)
        {
            this.Number = number;
            this.Date = datetime;
            this.Structure = structure;
            this.Person = person;
            this.Cost = cost;
            //this.Type = type;
            //this.Address = address;
            this.Status = status;
        }

        //Сортировка по дате
        public int DateSort(DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1.CompareTo(dateTime2);
        }

        //Преобразование типа bool в string
        public string BoolStatusToString()
        {
            if (Status) 
            {
                return "Готов";
            }
            return "Не готов";
        }
    }
}
