using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindBlowing.Models
{
    public class CustomerDetailViewModel
    {
        public Customer customer;
        public CustomerDetailViewModel(int customerID,string name)
        {
            customer = new Customer()
            {
                CustomerID = customerID,
                Name = name
            };
        }

        private Customer GetCustomer(int customerID)
        {
            //temporary code
            var listOfCustomers = new List<Customer>()
            {
                new Customer{CustomerID=1,Name="Lagaan"},
                new Customer{CustomerID=2,Name="3 Idiots"}
            };
            try
            {
                return listOfCustomers[customerID];
            }
            catch(IndexOutOfRangeException ex)
            {
                return null;
            }
        }
    }
}