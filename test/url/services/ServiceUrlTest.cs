using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace;
namespace url.services;

public class UrlServiceTest
{
    [Theory]
    [InlineData("long url")]
    [InlineData("test url")]
    public void TestGetUrl(string url)
    {
        UrlService service = new UrlService();
        Assert.Equal(url, service.getUrl(url));
    }
}