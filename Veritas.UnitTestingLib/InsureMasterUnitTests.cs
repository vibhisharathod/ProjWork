using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.UnitTestingLib
{
    [TestClass]
    public class InsureMasterUnitTests
    {
        [TestMethod]
        public async Task TestGetAllInsureMasterRecords()
        {
            IInsureMasterDA test = new InsureMasterDA();

            var result = await test.GetAll();
            result.Should().HaveCount(1, "This is awesome");
        }
    }
}
