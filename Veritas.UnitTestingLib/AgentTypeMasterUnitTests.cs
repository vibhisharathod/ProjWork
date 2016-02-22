using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.UnitTestingLib
{
    [TestClass]
   public class AgentTypeMasterUnitTests
    {
        [TestMethod]
        public async Task TestGetAllAgentTypeMasterRecords()
        {
            IAgentTypeMasterDA test = new AgentTypeMasterDA();

            var result = await test.GetAll();
            result.Should().HaveCount(2, "This is awesome");
        }
    }
}
