using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace TestingPlaywright
{
    public class Tests : PageTest
    {

        [Test]
        public async Task OperatorAuthorization()
        {
            var chrome = Playwright.Chromium;
            var browser = await chrome.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            var page = await browser.NewPageAsync();
            await page.GotoAsync($"https://vg.no");

            await Expect(page).ToHaveURLAsync("https://www.vg.no/");

            await browser.CloseAsync();
        }

    }
}
