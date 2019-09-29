using System;
using NUnit.Framework;
using ZbW.Testing.Dms.Client.Repositories;
using ZbW.Testing.Dms.Client.ViewModels;
using ZbW.Testing.Dms.Client.Views;

namespace ZbW.Testing.Dms.Client.UnitTests.Views
{
    [TestFixture, RequiresSTA]
    public class DocumentDetailViewTests
    {

        [Test]
        public void DocumentDetailView_Create_IsTrue()
        {
            //arrange
            DocumentDetailView documentDetailView = new DocumentDetailView("Test", dummyMethod);
            //act and assert
            Assert.IsNotNull(documentDetailView);


            //arrange
            DocumentDetailViewModel documentDetailViewModel = new DocumentDetailViewModel("Test", dummyMethod);

            // act
            documentDetailViewModel.ValutaDatum = DateTime.Now;
            documentDetailViewModel.Benutzer = "TestBenutzer";
            documentDetailViewModel.Bezeichnung = "Test Quittungen";
            documentDetailViewModel.Erfassungsdatum = DateTime.Now;
            documentDetailViewModel.FilePath =
                @"..\..\DMSTest\test.txt";
            documentDetailViewModel.IsRemoveFileEnabled = false;
            documentDetailViewModel.SelectedTypItem = "Quittungen";
            documentDetailViewModel.Stichwoerter = "Test Quittungen";
            documentDetailViewModel.TypItems = ComboBoxItems.Typ;

            // assert
            Assert.IsNotNull(documentDetailViewModel);

            documentDetailViewModel.OnCmdSpeichern();
        }


        public void dummyMethod()
        {

        }

    }
}
