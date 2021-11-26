using Atata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests
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
        public Button<_> LoginBtn { get; private set; }
    }
}
