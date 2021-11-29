using Atata;
using SampleApp.UITests.Utils;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Pages
{
    using _ = HomePage;
    public class HomePage : Page<_>
    {
        [FindByClass(Locators.signInClass)]
        public Link<_> SignIn { get; private set; }

        [FindByXPath(Locators.continueWithEmailXpath)]
        public Button<_> ContinueWithEmail { get; private set; }

        [FindById(Locators.emailId)]
        public EmailInput<_> Email { get; private set; }

        [FindById(Locators.passwordId)]
        public PasswordInput<_> Password { get; private set; }

        [FindByXPath(Locators.loginXpath)]
        public Button<HomePage, _> LoginBtn { get; private set; }

        [FindByClass(Locators.homepageClass)]
        public Link<_> homepageBtn { get; private set; }

        [FindByClass(Locators.myAccountClass)]
        public Link<MyAccount, _> MyAccount { get; private set; }

        [FindByXPath("//*[@id='app - wrapper']/div[1]/div[2]/div/nav/div/ul[2]/li[1]/div/a")]
        public Link<ChatPage, _> Chat { get; private set; }

        public H1<_> ChatHeader { get; private set; }

        [FindByClass(Locators.postyourAddClass)]
        public Link<PostAdd, _> PostYourAdd { get; private set; }

        [FindByClass(Locators.searchBoxClass)]
        public SearchInput<_> SearchBox { get; private set; }

        [FindByClass(Locators.searchBtnClass)]
        public Button<_> SearchBtn { get; private set; }

        [FindByClass(Locators.searchPageClass)]
        public H1<_> SearchPageText { get; private set; }

        [FindByClass("link--1t8hM gtm-home-category-link-click"), FindByIndex(0)]
        public Link<_> Mobile { get; private set; }
    }
}
