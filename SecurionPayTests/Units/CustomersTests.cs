﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurionPayTests.Units.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SecurionPay.Request;

namespace SecurionPayTests.Units
{
    [TestClass]
    public class CustomersTests:BaseUnitTestsSet
    {
        [TestMethod]
        public async Task CreateCustomerTest()
        {
            var requestTester = GetRequestTester();
            var customerRequest = new CustomerRequest() { Email="test@example.com",Description="description"};
            await requestTester.TestMethod(
                async (api) =>
                {
                    await api.CreateCustomer(customerRequest);
                },
                new RequestDescriptor()
                {
                    Method = HttpMethod.Post,
                    Address = GatewayAdress + "/customers",
                    Header = GetDesiredHeader(),
                    Content = ToJson(customerRequest)
                }
            );
        }


        [TestMethod]
        public async Task CreateCustomerWithCardTest()
        {
            var requestTester = GetRequestTester();
            var cardRequest = new CardRequest() { Number = "404129331232", ExpMonth = "6", ExpYear = "2015", CardholderName = "John Smith" };
            var customerRequest = new CustomerRequest() { Card= cardRequest, Email = "test@example.com", Description = "description" };
            await requestTester.TestMethod(
                async (api) =>
                {
                    await api.CreateCustomer(customerRequest);
                },
                new RequestDescriptor()
                {
                    Method = HttpMethod.Post,
                    Address = GatewayAdress + "/customers",
                    Header = GetDesiredHeader(),
                    Content = ToJson(customerRequest)
                }
            );
        }

        [TestMethod]
        public async Task RetrieveCustomerTest()
        {
            var requestTester = GetRequestTester();
            var customerId = "1";
            await requestTester.TestMethod(
                async (api) =>
                {
                    await api.RetrieveCustomer(customerId);
                },
                new RequestDescriptor()
                {
                    Method = HttpMethod.Get,
                    Address =  string.Format("{0}/customers/{1}", GatewayAdress,customerId),
                    Header = GetDesiredHeader(),
                    Content = null
                }
            );
        }

        [TestMethod]
        public async Task UpdateCustomerTest()
        {
            var requestTester = GetRequestTester();
            var customerId = "1";
            var cardRequest = new CardRequest() { Number = "404129331232", ExpMonth = "6", ExpYear = "2015", CardholderName = "John Smith" };
            var customerUpdaterequest = new CustomerUpdateRequest() {CustomerId= customerId, Card= cardRequest,DefaultCardId="2" };
            await requestTester.TestMethod(
                async (api) =>
                {
                    await api.UpdateCustomer(customerUpdaterequest);
                },
                new RequestDescriptor()
                {
                    Method = HttpMethod.Post,
                    Address = string.Format("{0}/customers/{1}", GatewayAdress, customerId),
                    Header = GetDesiredHeader(),
                    Content = ToJson(customerUpdaterequest)
                }
            );
        }

        [TestMethod]
        public async Task DeleteCustomerTest()
        {
            var requestTester = GetRequestTester();
            var customerId = "1";
            await requestTester.TestMethod(
                async (api) =>
                {
                    await api.DeleteCustomer(customerId);
                },
                new RequestDescriptor()
                {
                    Method = HttpMethod.Delete,
                    Address = string.Format("{0}/customers/{1}", GatewayAdress, customerId),
                    Header = GetDesiredHeader(),
                    Content = null
                }
            );
        }

        [TestMethod]
        public async Task ListCustomerTest()
        {
            var requestTester = GetRequestTester();
            await requestTester.TestMethod(
                async (api) =>
                {
                    await api.ListCustomers();
                },
                new RequestDescriptor()
                {
                    Method = HttpMethod.Get,
                    Address = string.Format("{0}/customers", GatewayAdress),
                    Header = GetDesiredHeader(),
                    Content = null
                }
            );
        }

    }
}
