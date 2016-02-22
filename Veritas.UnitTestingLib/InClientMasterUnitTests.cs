using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.UnitTestingLib
{
    [TestClass]
    public class InClientMasterUnitTests
    {
        [TestMethod]
        public async Task TestGetAllInClientMasterRecords()
        {
            IClientMasterDA test = new ClientMasterDA();

            var result = await test.GetAll();
            result.Should().HaveCount(5, "This is awesome");
        }
    }
}