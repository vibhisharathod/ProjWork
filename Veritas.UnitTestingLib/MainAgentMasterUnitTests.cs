using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;



namespace Veritas.UnitTestingLib
{
    [TestClass]
    public class MainAgentMasterUnitTests
    {
        [TestMethod]
        public async Task TestGetAllMainAgentMasterRecords()
        {
            IMainAgentMasterDA test = new MainAgentMasterDA();

            var result = await test.GetAll();
            result.Should().HaveCount(1, "This is awesome");
        }
    }
}
