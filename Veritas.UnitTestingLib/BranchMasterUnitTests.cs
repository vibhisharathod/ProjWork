using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.UnitTestingLib
{
    [TestClass]
   public class BranchMasterUnitTests
    {
        [TestMethod]
        public async Task TestGetAllBranchMasterRecords()
        {
            IAsmMasterDA test = new AsmMasterDA();

            var result = await test.GetAll();
            result.Should().HaveCount(1, "This is awesome");
        }
    }
}
