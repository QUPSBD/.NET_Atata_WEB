using Atata;
using SampleApp.UITests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Pages
{
    using _ = MyAccount;

    public class MyAccount : Page<_>
    {
        [FindByXPath(Locators.accountXpath)]
        public H4<_> ValidAccount { get; private set; }

        [FindByXPath(Locators.myMembershipXpath)]
        public Link<_> MyMembership { get; private set; }

        [FindByXPath(Locators.myMembershipValidateXpath)]
        public H2<_> ValidMyMemberShip { get; private set; }

        [FindByXPath(Locators.favoritesXpath)]
        public Link<_> Favorites { get; private set; }

        [FindByXPath(Locators.settingXpath)]
        public Link<_> Settings { get; private set; }

        [FindByXPath(Locators.myProfileXpath)]
        public Link<_> MyProfile { get; private set; }

        [FindByXPath(Locators.profileDatabaseXpath)]
        public Link<_> ProfileDatabase { get; private set; }

        [FindByXPath(Locators.favoritesvalidateXpath)]
        public H2<_> ValidFavorites { get; private set; }

        [FindByXPath(Locators.settingValidateXpath)]
        public H2<_> ValidSettings { get; private set; }

        [FindByXPath(Locators.jobsvalidateXpath)]
        public H4<_> ValidJobs { get; private set; }

        [FindByXPath(Locators.myProfileValidateXPath)]
        public H1<_> ValidMyProfile { get; private set; }

        [FindByXPath(Locators.profileDatabaseValidateXpath)]
        public H2<_> ValidProfileDatabase { get; private set; }

        [FindByXPath(Locators.myAccountXPath)]
        public Link<_> MyAccountBtn { get; private set; }


    }
}
