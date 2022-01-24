using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_Challenge.Models
{
    public class CustomerSuccessCompare
    {
        public CustomerSuccessCompare(int id, List<Customer> customers)
        {
            this.Id = id;
            this.Customers = customers;
        }

        public int Id { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
