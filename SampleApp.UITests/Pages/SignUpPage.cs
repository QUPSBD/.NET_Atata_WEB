using Atata;
using SampleApp.UITests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Pages
{
    using _ = SignUpPage;
    public class SignUpPage : Page<_>
    {
        [FindByClass(Locators.signInClass)]
        public Link<_> SignIn { get; private set; }

        [FindByXPath(Locators.continueWithEmailXpath)]
        public Button<_> ContinueWithEmail { get; private set; }

        [FindByClass(Locators.registerClass)]
        public Button<_> RegisterBtn { get; private set; }

        [FindById(Locators.nameId)]
        public TextInput<_> Name { get; private set; }

        [FindById(Locators.emailId)]
        public EmailInput<_> Email { get; private set; }

        [FindById(Locators.passwordId)]
        public PasswordInput<_> Password { get; private set; }

        [FindById(Locators.confirmPasswordId)]
        public PasswordInput<_> ConfirmPassword { get; private set; }

        [FindByClass(Locators.signUpClass)]
        public Button<_> SignUp { get; private set; }
    }
}
