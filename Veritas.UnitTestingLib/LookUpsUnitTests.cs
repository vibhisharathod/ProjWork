using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;
using FluentAssertions;
using System.Linq;

namespace Veritas.UnitTestingLib
{
    [TestClass]
    public class LookUpsUnitTests
    {
        [TestMethod]
        public async Task TestGetTMLookUp()
        {
            ILookUpTables test = new LookUpTables();

            var result = await test.GetTMLookUp();
            result.Should().HaveCount(1, "This is awesome");
        }

        [TestMethod]
        public async Task TestGetCompanyLookUp()
        {
            ILookUpTables test = new LookUpTables();

            var result = await test.GetCompanyLookUp();
            result.Should().HaveCount(28, "This is awesome");            
        }
    }
}
