using src.url.services.hash;

namespace test.url.services
{
    public class CRC32HashServiceTest
    {
        [Theory]
        [InlineData("long url", "64a0712d")]
        [InlineData("https://www.google.com", "6b5b1e33")]
        [InlineData("https://www.youtube.com/video", "64cf59fb")]
        public void TestHash(string longUrl, string shortUrl)
        {
            CRC32HashService service = new CRC32HashService();
            string actualShortUrl = service.Hash(longUrl);
            Assert.Equal(shortUrl, service.Hash(longUrl));
            Assert.Equal(actualShortUrl.Length, 8);
        }
    }
}