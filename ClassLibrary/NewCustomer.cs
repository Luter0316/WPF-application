using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NewCustomer : Customer
    {
        public NewCustomer(string firstName, string lastName, string patronymic, string phoneNumber): base(firstName, lastName, patronymic, phoneNumber) { }
    }
}
