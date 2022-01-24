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

            CustomerSuccessBalancing customerSuccessBalancing = new CustomerSuccessBalancing(customers, customerSuccesses, customerSuccessesAway);
            customerSuccessBalancing.Run();
        }
    }
}
