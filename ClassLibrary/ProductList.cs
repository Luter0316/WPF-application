using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProductList
    {
        public string Name { get; } //Название продукции
        public int Price { get; } //Цена

        //Конструктор
        public ProductList(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
