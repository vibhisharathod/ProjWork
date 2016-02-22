using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.UnitTestingLib
{
    [TestClass]
    public class CityMasterUnitTest
    {
        [TestMethod]
        public async Task TestGetAllCityMasterRecords()
        {
            ICityMasterDA test = new CityMasterDA();

            var result = await test.GetAll();
            result.Should().HaveCount(4, "This is awesome");
        }
    }
}
