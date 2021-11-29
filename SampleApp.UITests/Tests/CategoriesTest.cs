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
    public class CategoriesTest : UITestFixture
    {
        [Test]
        public void Categories()
        {
            Login().Wait(3);
            Go.To<Categories>().Wait(2)
                .UnorderedList.Items[0].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.mobile)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[1].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.electronics)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[2].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.homeAndLiving)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[3].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.Vehicles)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[4].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.Property)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[5].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.PetsAndAnimals)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[6].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.FashionAndBeauty)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[7].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.HobbiesSportsKids)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[8].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.BusinessIndustry)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[9].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.Education)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[10].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.Essentials)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[12].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.Services)
                .homepageBtn.Click().Wait(2)
                .UnorderedList.Items[14].Click().Wait(2)
                .CategoriesValidate.Should.Equal(Locators.OverseasJobs);





            /*.Electronics.Click().Wait(2)
            //.CategoriesValidate.Should.Equal(Locators.electronics)
            .ScrollDown()
            .ScrollUp()
            .homepageBtn.Click().Wait(2)
            .HomeAndLiving.Click().Wait(2)
            //.CategoriesValidate.Should.Equal(Locators.homeAndLiving)
            .ScrollDown()
            .ScrollUp()
            .homepageBtn.Click().Wait(2)
            .Vehicles.Click().Wait(2)
            .CategoriesValidate.Should.Equal(Locators.Vehicles)
            .ScrollDown()
            .ScrollUp()
            .homepageBtn.Click().Wait(2)
            .Property.Click().Wait(2)
            .CategoriesValidate.Should.Equal(Locators.Property)
            .ScrollDown()
            .ScrollUp()
            .homepageBtn.Click().Wait(2)
            .PetAndAnimals.Click().Wait(2)
            .CategoriesValidate.Should.Equal(Locators.PetsAndAnimals)
            .ScrollDown()
            .ScrollUp()
            .homepageBtn.Click().Wait(2)
            .FashionAndBeauty.Click().Wait(2)
            .CategoriesValidate.Should.Equal(Locators.FashionAndBeauty)
            .ScrollDown()
            .ScrollUp()
            .homepageBtn.Click().Wait(2)
            .Hobies.Click().Wait(2)
            .CategoriesValidate.Should.Equal(Locators.HobbiesSportsKids)
            .ScrollDown()
            .ScrollUp()
            .homepageBtn.Click().Wait(2);*/
        }
    }
}
