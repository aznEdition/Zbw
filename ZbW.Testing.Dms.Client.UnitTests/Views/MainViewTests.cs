using System;
using NUnit.Framework;
using ZbW.Testing.Dms.Client.Repositories;
using ZbW.Testing.Dms.Client.ViewModels;
using ZbW.Testing.Dms.Client.Views;

namespace ZbW.Testing.Dms.Client.UnitTests.Views
{
    [TestFixture, RequiresSTA]
    public class MainViewTests
    {

        [Test]
        public void MainView_Create_IsTrue()
        {
            //arrange
            MainView mainView = new MainView("Test");
            //assert
            Assert.IsNotNull(mainView);

            //arrange
            MainViewModel mainViewModel = new MainViewModel("Test");
            //assert
            Assert.IsNotNull(mainViewModel);

            //arrange
            mainViewModel.OnCmdNavigateToDocumentDetail();
            //assert
            Assert.IsNotNull(mainViewModel.Content);

            //arrange
            mainViewModel.OnCmdNavigateToSearch();
            //arrange
            Assert.IsNotNull(mainViewModel.Content);
        }

    }
}
