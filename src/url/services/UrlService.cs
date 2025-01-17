using src.url.services.hash;

namespace src.url.services;

public class UrlService(IHashService hashService)
{
    private readonly IHashService _hashService = hashService;

    public string getUrl(string url)
    {
        return _hashService.Hash(url);
    }
}
