using Atata;
using NUnit.Framework;
using SampleApp.UITests.Pages;
using SampleApp.UITests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Tests
{
    public class MyAccountTest : UITestFixture
    {
        [Test]
        public void MyAccountElementTest()
        {
            Login()
                .MyAccount.ClickAndGo()
                .ValidAccount.Should.Equal(Locators.accountText)
                .MyMembership.Click()
                .ValidMyMemberShip.Should.Equal(Locators.myMembershipText)
                .Favorites.Click()
                .ValidFavorites.Should.Equal(Locators.favoritesText)
                .Settings.Click()
                .ValidSettings.Should.Equal(Locators.settingText)
                .ValidJobs.Should.Equal(Locators.jobsText)
                .MyProfile.Click()
                .ValidMyProfile.Should.Equal(Locators.myProfileText)
                .MyAccountBtn.Click()
                .ProfileDatabase.Click()
                .ValidProfileDatabase.Should.Equal(Locators.profileDatabaseText).Wait(3);


        }
    }
}
