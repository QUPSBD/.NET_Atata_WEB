using Atata;
using Atata.ExtentReports;
using NUnit.Framework;


namespace SampleApp.UITests.Tests
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            AtataContext.GlobalConfiguration
                .UseChrome()
                    .WithArguments("start-maximized")
                .UseBaseUrl("https://bikroy.com/")
                .UseCulture("en-US")
                .UseAllNUnitFeatures()
                //extentreportsconfigurations
                .AddLogConsumer(new ExtentLogConsumer())
                .AddScreenshotConsumer(new ExtentScreenshotConsumer());

            //.Attributes.Global.Add(new VerifyTitleSettingsAttribute { Format = "{0} - Atata Sample App" });

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }

        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            ExtentContext.Reports.Flush();
        }
    }
}
