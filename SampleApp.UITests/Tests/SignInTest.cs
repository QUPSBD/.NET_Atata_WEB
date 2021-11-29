using Atata;
using NUnit.Framework;

using SampleApp.UITests;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Tests
{
    public class SignInTest : UITestFixture
    {
        [Test]
        public void LoginTest()
        {
            Login();
        }
    }
}
