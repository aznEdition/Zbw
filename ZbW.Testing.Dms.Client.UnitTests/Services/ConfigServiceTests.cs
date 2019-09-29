using NUnit.Framework;
using ZbW.Testing.Dms.Client.Services;

namespace ZbW.Testing.Dms.Client.UnitTests
{
    [TestFixture]
    public class ConfigServiceTest
    {
        [Test]
        public void ConfigService_Config_IsTrue()
        {
            //arrange
            string repositoryDir = ConfigService.GetConfigValueByKey("RepositoryDir");

            //act and assert
            Assert.IsNotNull(repositoryDir);
            Assert.AreEqual(repositoryDir, @"..\..\DMSTest");
        }
    }
}
