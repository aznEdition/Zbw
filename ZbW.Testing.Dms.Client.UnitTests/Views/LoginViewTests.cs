using NUnit.Framework;
using ZbW.Testing.Dms.Client.ViewModels;
using ZbW.Testing.Dms.Client.Views;

namespace ZbW.Testing.Dms.Client.UnitTests.Views
{
    [TestFixture, RequiresSTA]
    public class LoginViewTests
    {

        [Test]
        public void LoginView_Login_IsTrue()
        {
            //arrange
            LoginView loginView = new LoginView();
            // act and assert
            Assert.IsNotNull(loginView);

            //arrange
            LoginViewModel loginViewModel = new LoginViewModel(loginView);
            //act
            loginViewModel.Benutzername = "TestBenutzer";
            //assert
            Assert.IsNotNull(loginViewModel);

            //act
            bool canLogin = loginViewModel.OnCanLogin();
            //assert
            Assert.IsTrue(canLogin);
            loginViewModel.OnCmdLogin();
        }

    }
}
