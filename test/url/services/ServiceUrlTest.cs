using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace;
namespace url.services;

public class UrlServiceTest
{
    [Theory]
    [InlineData("long url", "long url")]
    [InlineData("test url", "test url")]
    public void TestGetUrl(string longUrl, string shortUrl)
    {
        UrlService service = new UrlService();
        Assert.Equal(shortUrl, service.getUrl(longUrl));
    }
}