using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightTests002.Pages
{
    public class LoginPage
    {
        private IPage _page;
        private readonly ILocator _lnkLogin;
        private readonly ILocator _txtUserName;
        private readonly ILocator _txtPassword;
        private readonly ILocator _btnLogin;
        private readonly ILocator _lnkEmployeeDetails;
        

        public LoginPage(IPage page)
        {
            _page = page;
            _btnLogin = _page.Locator("text=Login");
            _txtUserName = _page.Locator("#UserName");
            _txtPassword = _page.Locator("#Password");
            _btnLogin = _page.Locator("text=Log in");
            _lnkEmployeeDetails = _page.Locator("text='Employee Details'");


        }

        public async Task ClickLogin() => await _lnkLogin.CheckAsync(); // This is call expression body syntax. It reduces the line of code in C# code


    }
}
