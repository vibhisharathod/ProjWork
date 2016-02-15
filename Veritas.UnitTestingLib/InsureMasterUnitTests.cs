using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;
using FluentAssertions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Veritas.Entities;

namespace Veritas.UnitTestingLib
{
    [TestClass]
    public class InsureMasterUnitTests
    {
        [TestMethod]
        public async Task GetAllInsureMasterRecords()
        {
            IInsureMasterDA test = new InsureMasterDA();

            var result = await test.GetAll();
            result.Should().HaveCount(1, "This is awesome");
        }
    }
}
