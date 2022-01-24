using RD_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_Challenge.Core.Operations
{
    public class CustomerSuccessBalancing
    {
        private List<Customer> _customers;
        private List<CustomerSuccess> _customersSuccess;
        private List<int> _customersSuccessAway;

        public CustomerSuccessBalancing(List<Customer> customers, List<CustomerSuccess> customerSuccesses,
            List<int> customerSuccessesAway)
        {
            _customers = customers;
            _customersSuccess = customerSuccesses.OrderBy(x => x.Score).ToList();
            _customersSuccessAway = customerSuccessesAway;
        }

        public int Run()
        {
            CustomerSuccessCompare customerSuccessWithMoreCustomers = new CustomerSuccessCompare(0,new List<Customer>());

            // Remove Away SCs from avaible SCs list
            RemoveCustomerSuccessAway();

            foreach(var customerSuccess in _customersSuccess)
            {
                var customersOfSCs = _customers.Where(x => x.Score <= customerSuccess.Score).ToList();
                
                if (customerSuccessWithMoreCustomers.Customers.Count < customersOfSCs.Count)
                {
                    customerSuccessWithMoreCustomers.Id = customerSuccess.Id;
                    customerSuccessWithMoreCustomers.Customers = customersOfSCs;
                }
                else if (customerSuccessWithMoreCustomers.Customers.Count == customersOfSCs.Count)
                {
                    customerSuccessWithMoreCustomers.Id = 0;
                }

                RemoveCustomers(customersOfSCs);
            }

            return customerSuccessWithMoreCustomers.Id;
        }

        private void RemoveCustomerSuccessAway()
        {
            foreach(var customerSuccessAway in _customersSuccessAway)
            {
                var customerSuccess = _customersSuccess.FirstOrDefault(x => x.Id == customerSuccessAway);
                _customersSuccess.Remove(customerSuccess);
            }
        }

        private void RemoveCustomers(List<Customer> customersToRemove)
        {
            foreach (var customerToRemove in customersToRemove)
            {
                var customer = _customers.FirstOrDefault(x => x.Id == customerToRemove.Id);
                _customers.Remove(customer);
            }
        }
    }
}
