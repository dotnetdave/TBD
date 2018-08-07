using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBD;
using TBD.Controllers;
using Xunit;
using Xunit.Abstractions;

namespace TBD.Tests
{
    public class FirstTest
    {
        [Fact]
        public void FirstFact()
        {
            ICustomerRepository repo = new CustomerRepository();
            Assert.Equal("Local", repo.Test());
        }
    }
}
