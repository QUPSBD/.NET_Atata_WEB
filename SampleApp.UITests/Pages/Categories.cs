using Atata;
using SampleApp.UITests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Pages
{
    using _ = Categories;
    public class Categories : Page<_>
    {
        [FindByClass(Locators.homepageClass)]
        public Link<_> homepageBtn { get; private set; }

        [FindByClass("category-list--2oS_W right--WcHqY left--2ndlm hide-native-scrollbar--Nj_rv")]
        public UnorderedList<ListItem<_>, _> UnorderedList { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(0)]
        [FindByIndex(0)]
        public Link<_> Mobile { get; private set; }

        [Focus]
        [FindByXPath("//body/div[@id='app-container']/div[@id='app-wrapper']/div[1]/div[3]/div[3]/ul[1]/li[2]/a[1]")]
        public Link<_> Electronics { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(2)]
        [FindByIndex(2)]
        public Link<_> HomeAndLiving { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(3)]
        public Link<_> Vehicles { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(4)]
        public Link<_> Property { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(5)]
        public Link<_> PetAndAnimals { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(6)]
        public Link<_> FashionAndBeauty { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(7)]
        public Link<_> Hobies { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(8)]
        public Link<_> BusinessAndindustry { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(9)]
        public Link<_> Education { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(10)]
        public Link<_> Essentials { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(11)]
        public Link<_> Jobs { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(12)]
        public Link<_> Services { get; private set; }

        [Focus]
        [FindByClass(Locators.categoriesClass), FindByIndex(14)]
        public Link<_> OverseasJobs { get; private set; }

        [FindByClass(Locators.categoriesValidateClass)]
        public Text<_> CategoriesValidate { get; private set; }
    }
}
