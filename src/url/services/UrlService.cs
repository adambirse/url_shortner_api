using url.services.hash;

namespace url.services
{
    public class UrlService
    {
        private readonly IHashService _hashService;

        public UrlService(IHashService hashService)
        {
            _hashService = hashService;
        }

        public string getUrl(string url)
        {
            return _hashService.hash(url);
        }
    }
}
