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
    public class ChatTest : UITestFixture
    {
        [Test]
        public void ChatPageTest()
        {
            Login()
                .Chat.ClickAndGo()
                .ChatHeader.Should.Equals("chat");
        }
    }
}
