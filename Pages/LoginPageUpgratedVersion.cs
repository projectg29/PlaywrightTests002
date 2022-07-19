using Microsoft.Playwright;

namespace PlaywrightTests002.Pages
{
    public class LoginPageUpgratedVersion
    {
        private IPage _page;
        public LoginPageUpgratedVersion(IPage page) => _page = page;
        private ILocator _lnkLogin => _page.Locator("text=Login");
        private  ILocator _txtUserName => _page.Locator("#UserName");
        private  ILocator _txtPassword => _page.Locator("#Password");
        private  ILocator _btnLogin => _page.Locator("text=Log in");
        private  ILocator _lnkEmployeeDetails => _page.Locator("text='Employee Details'");

        public async Task ClickLogin() => await _lnkLogin.ClickAsync(); // This is call expression body syntax. It reduces the line of code in C# code

        public async Task Login(string UserName, string Password)
        {
            await _txtUserName.FillAsync(UserName);
            await _txtPassword.FillAsync(Password);
            await _btnLogin.ClickAsync();
        }

        public async Task<bool> IsEmployeeDetailsExists() => await _lnkEmployeeDetails.IsVisibleAsync();

    }
}