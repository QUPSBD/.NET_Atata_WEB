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
        public Button<_> LookForSomethingToBuy { get; private set; }

        [ScrollDown]
        [FindByXPath(Locators.sellItemXpath)]
        public Button<_> SellAnItem { get; private set; }

        [ScrollDown]
        [FindByXPath(Locators.postAJob)]
        public Button<_> PostAJob { get; private set; }

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

        [WaitForElement(WaitBy.Class, "textarea-field-error--2M0rR textarea--a2X6r themed-form-input--2Q2dw", Until.VisibleThenMissingOrHidden)]
        public TextArea<_> Description { get; private set; }

        [ScrollDown]
        [FindByClass(Locators.phoneNumberClass)]
        public TextInput<_> PhoneNumber { get; private set; }

        [ScrollDown]
        [FindByClass(Locators.addNumberClass)]
        public Button<_> Add { get; private set; }

        [ScrollDown]
        [FindById(Locators.acceptId)]
        public CheckBox<_> Accept { get; private set; }

        [FindByXPath(Locators.usedXpath)]
        public RadioButton<_> Used { get; private set; }

        [FindByXPath(Locators.brandXpath)]
        public Button<_> Brand { get; private set; }

        [FindById("downshift-1-item-0")]
        public ListItem<_> UnorderedList { get; private set; }

        [FindById(Locators.modelId)]
        public TextInput<_> Model { get; private set; }

        [FindById(Locators.priceId)]
        public NumberInput<_> Price { get; private set; }

        [FindById(Locators.negotiableId)]
        public CheckBox<_> Negotiable { get; private set; }
    }
}
