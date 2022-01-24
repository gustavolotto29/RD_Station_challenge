using RD_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_Challeng.Tests.Mock
{
    public static class MockValues
    {
        public static (List<Customer>, List<CustomerSuccess>, List<int>) Scenario1()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            customerSuccess.Add(new CustomerSuccess(1, 60));
            customerSuccess.Add(new CustomerSuccess(2, 20));
            customerSuccess.Add(new CustomerSuccess(3, 95));
            customerSuccess.Add(new CustomerSuccess(4, 75));

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, 90));
            customers.Add(new Customer(2, 20));
            customers.Add(new Customer(3, 70));
            customers.Add(new Customer(4, 40));
            customers.Add(new Customer(5, 60));
            customers.Add(new Customer(6, 10));

            List<int> customerSuccessAway = new List<int> { 2, 4 };

            return (customers, customerSuccess, customerSuccessAway);
        }
        public static (List<Customer>, List<CustomerSuccess>, List<int>) Scenario2()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            customerSuccess.Add(new CustomerSuccess(1, 11));
            customerSuccess.Add(new CustomerSuccess(2, 21));
            customerSuccess.Add(new CustomerSuccess(3, 31));
            customerSuccess.Add(new CustomerSuccess(4, 3));
            customerSuccess.Add(new CustomerSuccess(5, 4));
            customerSuccess.Add(new CustomerSuccess(6, 5));

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, 10));
            customers.Add(new Customer(2, 10));
            customers.Add(new Customer(3, 10));
            customers.Add(new Customer(4, 20));
            customers.Add(new Customer(5, 20));
            customers.Add(new Customer(6, 30));
            customers.Add(new Customer(7, 30));
            customers.Add(new Customer(8, 30));
            customers.Add(new Customer(9, 20));
            customers.Add(new Customer(10, 60));

            List<int> customerSuccessAway = new List<int>();

            return (customers, customerSuccess, customerSuccessAway);
        }
        public static (List<Customer>, List<CustomerSuccess>, List<int>) Scenario3()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();

            for (int score = 1; score <= 999; score++)
            {
                customerSuccess.Add(new CustomerSuccess(score, score));
            }

            List<Customer> customers = new List<Customer>();
            for (int size = 0; size < 100000; size++)
            {
                customers.Add(new Customer(size, 998));
            }

            List<int> customerSuccessAway = new List<int>() { 999 };

            return (customers, customerSuccess, customerSuccessAway);
        }

        public static (List<Customer>, List<CustomerSuccess>, List<int>) Scenario4()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            customerSuccess.Add(new CustomerSuccess(1, 1));
            customerSuccess.Add(new CustomerSuccess(2, 2));
            customerSuccess.Add(new CustomerSuccess(3, 3));
            customerSuccess.Add(new CustomerSuccess(4, 4));
            customerSuccess.Add(new CustomerSuccess(5, 5));
            customerSuccess.Add(new CustomerSuccess(6, 6));

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, 10));
            customers.Add(new Customer(2, 10));
            customers.Add(new Customer(3, 10));
            customers.Add(new Customer(4, 20));
            customers.Add(new Customer(5, 20));
            customers.Add(new Customer(6, 30));
            customers.Add(new Customer(7, 30));
            customers.Add(new Customer(8, 30));
            customers.Add(new Customer(9, 20));
            customers.Add(new Customer(10, 60));

            List<int> customerSuccessAway = new List<int>();

            return (customers, customerSuccess, customerSuccessAway);
        }

        public static (List<Customer>, List<CustomerSuccess>, List<int>) Scenario5()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            customerSuccess.Add(new CustomerSuccess(1, 100));
            customerSuccess.Add(new CustomerSuccess(2, 2));
            customerSuccess.Add(new CustomerSuccess(3, 3));
            customerSuccess.Add(new CustomerSuccess(4, 3));
            customerSuccess.Add(new CustomerSuccess(5, 4));
            customerSuccess.Add(new CustomerSuccess(6, 5));

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, 10));
            customers.Add(new Customer(2, 10));
            customers.Add(new Customer(3, 10));
            customers.Add(new Customer(4, 20));
            customers.Add(new Customer(5, 20));
            customers.Add(new Customer(6, 30));
            customers.Add(new Customer(7, 30));
            customers.Add(new Customer(8, 30));
            customers.Add(new Customer(9, 20));
            customers.Add(new Customer(10, 60));

            List<int> customerSuccessAway = new List<int>();

            return (customers, customerSuccess, customerSuccessAway);
        }

        public static (List<Customer>, List<CustomerSuccess>, List<int>) Scenario6()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            customerSuccess.Add(new CustomerSuccess(1, 100));
            customerSuccess.Add(new CustomerSuccess(2, 99));
            customerSuccess.Add(new CustomerSuccess(3, 88));
            customerSuccess.Add(new CustomerSuccess(4, 3));
            customerSuccess.Add(new CustomerSuccess(5, 4));
            customerSuccess.Add(new CustomerSuccess(6, 5));

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, 10));
            customers.Add(new Customer(2, 10));
            customers.Add(new Customer(3, 10));
            customers.Add(new Customer(4, 20));
            customers.Add(new Customer(5, 20));
            customers.Add(new Customer(6, 30));
            customers.Add(new Customer(7, 30));
            customers.Add(new Customer(8, 30));
            customers.Add(new Customer(9, 20));
            customers.Add(new Customer(10, 60));

            List<int> customerSuccessAway = new List<int>() { 1, 3, 2 };

            return (customers, customerSuccess, customerSuccessAway);
        }

        public static (List<Customer>, List<CustomerSuccess>, List<int>) Scenario7()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            customerSuccess.Add(new CustomerSuccess(1, 100));
            customerSuccess.Add(new CustomerSuccess(2, 99));
            customerSuccess.Add(new CustomerSuccess(3, 88));
            customerSuccess.Add(new CustomerSuccess(4, 3));
            customerSuccess.Add(new CustomerSuccess(5, 4));
            customerSuccess.Add(new CustomerSuccess(6, 5));

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, 10));
            customers.Add(new Customer(2, 10));
            customers.Add(new Customer(3, 10));
            customers.Add(new Customer(4, 20));
            customers.Add(new Customer(5, 20));
            customers.Add(new Customer(6, 30));
            customers.Add(new Customer(7, 30));
            customers.Add(new Customer(8, 30));
            customers.Add(new Customer(9, 20));
            customers.Add(new Customer(10, 60));

            List<int> customerSuccessAway = new List<int>() { 4, 5, 6 };

            return (customers, customerSuccess, customerSuccessAway);
        }
    }
}
