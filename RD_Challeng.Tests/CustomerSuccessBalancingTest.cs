using NUnit.Framework;
using RD_Challeng.Tests.Mock;
using RD_Challenge.Core.Operations;
using RD_Challenge.Models;
using System.Collections.Generic;

namespace RD_Challeng.Tests
{
    public class Tests
    {
        [Test]
        public void Scenario1()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();     
            List<Customer> customers = new List<Customer>();
            List<int> customerSuccessAway = new List<int>();

            (customers, customerSuccess, customerSuccessAway) = MockValues.Scenario1();

            CustomerSuccessBalancing customerSuccessBalancing = new CustomerSuccessBalancing(customers, customerSuccess, customerSuccessAway);

            Assert.AreEqual(customerSuccessBalancing.Run(), 1);
        }

        [Test]
        public void Scenario2()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            List<Customer> customers = new List<Customer>();
            List<int> customerSuccessAway = new List<int>();

            (customers, customerSuccess, customerSuccessAway) = MockValues.Scenario2();

            CustomerSuccessBalancing customerSuccessBalancing = new CustomerSuccessBalancing(customers, customerSuccess, customerSuccessAway);

            Assert.AreEqual(customerSuccessBalancing.Run(), 0);
        }

        [Test]
        public void Scenario3()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            List<Customer> customers = new List<Customer>();
            List<int> customerSuccessAway = new List<int>();

            (customers, customerSuccess, customerSuccessAway) = MockValues.Scenario3();

            CustomerSuccessBalancing customerSuccessBalancing = new CustomerSuccessBalancing(customers, customerSuccess, customerSuccessAway);

            Assert.AreEqual(customerSuccessBalancing.Run(), 998);
        }

        [Test]
        public void Scenario4()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            List<Customer> customers = new List<Customer>();
            List<int> customerSuccessAway = new List<int>();

            (customers, customerSuccess, customerSuccessAway) = MockValues.Scenario4();

            CustomerSuccessBalancing customerSuccessBalancing = new CustomerSuccessBalancing(customers, customerSuccess, customerSuccessAway);

            Assert.AreEqual(customerSuccessBalancing.Run(), 0);
        }

        [Test]
        public void Scenario5()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            List<Customer> customers = new List<Customer>();
            List<int> customerSuccessAway = new List<int>();

            (customers, customerSuccess, customerSuccessAway) = MockValues.Scenario5();

            CustomerSuccessBalancing customerSuccessBalancing = new CustomerSuccessBalancing(customers, customerSuccess, customerSuccessAway);

            Assert.AreEqual(customerSuccessBalancing.Run(), 1);
        }

        [Test]
        public void Scenario6()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            List<Customer> customers = new List<Customer>();
            List<int> customerSuccessAway = new List<int>();

            (customers, customerSuccess, customerSuccessAway) = MockValues.Scenario6();

            CustomerSuccessBalancing customerSuccessBalancing = new CustomerSuccessBalancing(customers, customerSuccess, customerSuccessAway);

            Assert.AreEqual(customerSuccessBalancing.Run(), 0);
        }

        [Test]
        public void Scenario7()
        {
            List<CustomerSuccess> customerSuccess = new List<CustomerSuccess>();
            List<Customer> customers = new List<Customer>();
            List<int> customerSuccessAway = new List<int>();

            (customers, customerSuccess, customerSuccessAway) = MockValues.Scenario7();

            CustomerSuccessBalancing customerSuccessBalancing = new CustomerSuccessBalancing(customers, customerSuccess, customerSuccessAway);

            Assert.AreEqual(customerSuccessBalancing.Run(), 3);
        }
    }
}