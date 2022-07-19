/*using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightTests001;

public class NunitPlaywright : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        // POM is started
        //When you want to run in cmdline mode and with browser open set below env option and run test
        //PS C:\Users\rajan\Automation\DotNet\PlaywrightDemos\PlaywrightTests002 > $env: HEADED = 1
        //PS C:\Users\rajan\Automation\DotNet\PlaywrightDemos\PlaywrightTests002 > dotnet test

        // The default timeout period is 3000 milliseconds
        *//*await Page.GotoAsync("http://www.eaapp.somee.com", new PageGotoOptions 
        { 
            WaitUntil = WaitUntilState.DOMContentLoaded
        });*//*
        await Page.GotoAsync("http://www.eaapp.somee.com");

    }

    [Test]
    public async Task Test1()
    {
        //Also we override the default wait time 3000 ms in one place which applies for whole class
        //Page.SetDefaultTimeout(10);

        var lnkLogin = Page.Locator("text=Login");
        await lnkLogin.ClickAsync();
        //await Page.ClickAsync("text=Login");
        await Page.ScreenshotAsync(new PageScreenshotOptions { Path = "PTest001.jpg" });
        await Page.FillAsync("#UserName", "admin");
        await Page.FillAsync("#Password", "password");
        var btnLogin = Page.Locator("input", new PageLocatorOptions { HasTextString = "Log in" });
        await btnLogin.ClickAsync();
        //await Page.ClickAsync("text=Log in");
        // The default wait time in Playwright is 3000 milliseconds. Still we can increase the wait time to 5000 milliseconds
        await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync();
        //Tips: if you are using .IsVisibleAsync it will not wait for 3000 ms whereas it fails if the locator is not loaded immidiately. But you can override it

        *//*// The default wait time in Playwright is 3000 milliseconds. Still we can increase the wait time to 5000 milliseconds
        await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync(new LocatorAssertionsToBeVisibleOptions
        {
            Timeout = 5000
        });*//*

        // We can override the default wait time 3000 ms to 10 ms
        //await Expect(Page.Locator("text='Employee Details'")).ToBeVisibleAsync(new LocatorAssertionsToBeVisibleOptions { Timeout = 10 });






    }
}*/