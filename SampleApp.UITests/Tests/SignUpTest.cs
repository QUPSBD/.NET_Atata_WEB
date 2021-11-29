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
     public class SignUpTest : UITestFixture
    {
        [Test]
        public void SignUpTests()
        {
            Go.To<SignUpPage>()
                .SignIn.Click()
                .ContinueWithEmail.Click()
                .RegisterBtn.Click()
                .Name.Set(Locators.name)
                .Email.Set(Locators.newEmail)
                .Password.Set(Locators.password)
                .ConfirmPassword.Set(Locators.password)
                .SignUp.Click();

        }
    }
}
