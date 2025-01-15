using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace;
using url.services.hash;
using url.services;

public class UrlServiceTest
{
    [Theory]
    [InlineData("long url", "short url")]
    [InlineData("a big long url", "short url")]
    public void TestGetUrl(string longUrl, string shortUrl)
    {
        UrlService service = new UrlService(new SimpleHashService());
        Assert.Equal(shortUrl, service.getUrl(longUrl));
    }
}