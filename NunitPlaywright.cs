using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests001;

public class NunitPlaywright : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        //When you want to run in cmdline mode and with browser open set below env option and run test
        //PS C:\Users\rajan\Automation\DotNet\PlaywrightDemos\PlaywrightTests002 > $env: HEADED = 1
        //PS C:\Users\rajan\Automation\DotNet\PlaywrightDemos\PlaywrightTests002 > dotnet test
        
        // The default timeout period is 3000 milliseconds
        await Page.GotoAsync("http://www.eaapp.somee.com");

    }

    [Test]
    public async Task Test1()
    {

        var lnkLogin = Page.Locator("text=Login");
        await lnkLogin.ClickAsync();
        //await Page.ClickAsync("text=Login");
        await Page.ScreenshotAsync(new PageScreenshotOptions { Path = "PTest001.jpg" });
        await Page.FillAsync("#UserName", "admin");
        await Page.FillAsync("#Password", "password");
        var btnLogin = Page.Locator("input", new PageLocatorOptions { HasTextString = "Log in" });
        await btnLogin.ClickAsync();
        //await Page.ClickAsync("text=Log in");
        await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync();





    }
}