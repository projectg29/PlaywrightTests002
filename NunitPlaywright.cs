using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests001;

public class NunitPlaywright : PageTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        await Page.GotoAsync("http://www.eaapp.somee.com");
        await Page.ClickAsync("text=Login");
        await Page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "PTest001.jpg"
        });

        await Page.FillAsync("#UserName", "admin");
        await Page.FillAsync("#Password", "password");
        await Page.ClickAsync("text=Log in");
      
        await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync();





    }
}