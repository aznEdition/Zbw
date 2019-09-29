using System.Collections.Generic;
using NUnit.Framework;
using ZbW.Testing.Dms.Client.Model;
using ZbW.Testing.Dms.Client.Repositories;
using ZbW.Testing.Dms.Client.ViewModels;
using ZbW.Testing.Dms.Client.Views;

namespace ZbW.Testing.Dms.Client.UnitTests.Views
{
    [TestFixture, RequiresSTA]
    public class SearchViewTests
    {

        [Test]
        public void SearchView_FileSearch_IsTrue()
        {
            //arrange
            SearchView searchView = new SearchView();
            //assert
            Assert.IsNotNull(searchView);

            //arrange
            SearchViewModel searchViewModel = new SearchViewModel();
            MetadataItem item = new MetadataItem();
            //act
            item.FilePath = @"..\..\DMSTest\1cbed3d2-0d08-49ad-bd5d-0a1dfb57d499_Content.txt";
            searchViewModel.SelectedTypItem = "Quittungen";
            searchViewModel.Suchbegriff = "Quittungen";
            searchViewModel.TypItems = ComboBoxItems.Typ;
            searchViewModel.SelectedMetadataItem = item;
            //assert
            Assert.IsNotNull(searchViewModel);

            //act
            searchViewModel.OnCmdOeffnen();

            searchViewModel.OnCmdReset();
            //assert
            Assert.AreEqual(0, searchViewModel.FilteredMetadataItems.Count);
            Assert.IsNull(searchViewModel.SelectedTypItem);
            Assert.IsEmpty(searchViewModel.Suchbegriff);

            //act
            searchViewModel.Suchbegriff = "test";
            searchViewModel.OnCmdSuchen();
            //assert
            Assert.IsTrue(searchViewModel.FilteredMetadataItems.Count > 0);

        }

    }
}
