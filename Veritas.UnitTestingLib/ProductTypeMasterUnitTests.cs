using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.UnitTestingLib
{
    [TestClass]
    class ProductTypeMasterUnitTests
    {
        [TestMethod]
        public async Task TestGetAllProductTypeMasterRecords()
        {
            IGiProductTypeMasterDA test = new GiProductTypeMasterDA();

            var result = await test.GetAll();
            result.Should().HaveCount(1, "This is awesome");
        }
    }
}
