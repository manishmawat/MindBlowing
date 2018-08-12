using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindBlowing.Models
{
    public class CustomerViewModel
    {
        public List<Customer> listOfCutomer;
        public CustomerViewModel()
        {
            //listOfCutomer = new List<Customer>();
            listOfCutomer = new List<Customer>()
            {
                new Customer{CustomerID=1,Name="Manish"},
                new Customer{CustomerID=2,Name="Bindu"}
            };
        }

        public List<Customer> Customers {
            get { return listOfCutomer; }
             }

        public void AddCustomer(Customer customer)
        {
            listOfCutomer.Add(customer);
        }
    }
}