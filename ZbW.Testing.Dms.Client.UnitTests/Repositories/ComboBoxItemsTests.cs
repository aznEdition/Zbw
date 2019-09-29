using System.Collections.Generic;
using NUnit.Framework;
using ZbW.Testing.Dms.Client.Repositories;

namespace ZbW.Testing.Dms.Client.UnitTests.Repositories
{
    [TestFixture]
    public class ComboBoxItemsTests
    {

        [Test]
        public void Item_Exist_IsTrue()
        {
            //arrange
            List<string> typList = ComboBoxItems.Typ;

            // act and assert
            Assert.IsNotNull(typList);
            Assert.AreEqual("Verträge", typList[0]);
            Assert.AreEqual("Quittungen", typList[1]);
        }

    }
}
