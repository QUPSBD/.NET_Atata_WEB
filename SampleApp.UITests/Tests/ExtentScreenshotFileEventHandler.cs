using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using AventStack.ExtentReports;

namespace SampleApp.UITests.Tests
{
    public class ExtentScreenshotFileEventHandler : IEventHandler<ScreenshotFileSavedEvent>
    {
        public void Handle(ScreenshotFileSavedEvent eventData, AtataContext context)
        {
            string relativeFilePath = eventData.FilePath.Replace(ExtentContext.WorkingDirectoryPath, null);

            ExtentContext.ResolveFor(AtataContext.Current).Test.Log(
                Status.Info,
                MediaEntityBuilder.CreateScreenCaptureFromPath(relativeFilePath, eventData.ScreenshotInfo.Title).Build());
        }
    }
}
