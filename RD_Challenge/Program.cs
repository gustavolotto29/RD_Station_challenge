using RD_Challenge.Core.Operations;
using RD_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_Challenge
{
    public static class Program
    {
        public static void Main()
        {
            List<Customer> customers = new List<Customer>();
            List<CustomerSuccess> customerSuccesses = new List<CustomerSuccess>();
            List<int> customerSuccessesAway = new List<int>();

            customers.Add(new Customer(1, 20));
            customers.Add(new Customer(2, 55));
            customers.Add(new Customer(3, 60));
            customers.Add(new Customer(4, 80));
            customers.Add(new Customer(6, 45));

            customerSuccesses.Add(new CustomerSuccess(1, 55));
            customerSuccesses.Add(new CustomerSuccess(2, 100));
            customerSuccesses.Add(new CustomerSuccess(3, 50));

            CustomerSuccessBalancing customerSuccessBalancing = new CustomerSuccessBalancing(customers, customerSuccesses, customerSuccessesAway);
            customerSuccessBalancing.Run();
        }
    }
}
