using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.UnitTestingLib
{
    [TestClass]
   public class ProductMasterUnitTests
    {
        [TestMethod]
        public async Task TestGetAllProductMasterRecords()
        {
            IProductMasterDA test = new GiProductMasterDA();

            var result = await test.GetAll();
            result.Should().HaveCount(8, "This is awesome");
        }
    }
}
