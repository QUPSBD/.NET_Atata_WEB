using Atata;
using SampleApp.UITests.Tests;
using SampleApp.UITests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Pages
{
    using _ = PostAdd;
    public class PostAdd : Page<_>
    {
        [ScrollDown]
        [FindByXPath(Locators.lookForSomethingToBuyXpath)]
        public Button<_> LoogForSomethingToBuy { get; private set; }

        [FindByXPath(Locators.electronicsXpath)]
        public Button<_> Electronics { get; private set; }

        [FindByXPath(Locators.laptopXpath)]
        public Button<_> Laptops { get; private set; }

        [FindByXPath(Locators.rajshahiXpath)]
        public Button<_> Rajshahi { get; private set; }

        [FindByXPath(Locators.uposohorXpath)]
        public Button<_> Uposohor { get; private set; }

        [FindById(Locators.titleId)]
        public TextInput<_> Title { get; private set; }

        [FindByXPath(Locators.descripTionXpath)]
        public TextArea<_> Description { get; private set; }

        [ScrollDown]
        [FindByClass("input-field--3A-bW themed-form-input--2Q2dw add-input--2HBu_")]
        public TextInput<_> PhoneNumber { get; private set; }

        [ScrollDown]
        [FindByClass(Locators.addNumberClass)]
        public Button<_> Add { get; private set; }

        [ScrollDown]
        [FindByXPath("//*[@id='app - wrapper']/div[1]/div[3]/div[5]/form/div[3]/div[2]/label/span")]
        public CheckBox<_> Accept { get; private set; }

    }
}
