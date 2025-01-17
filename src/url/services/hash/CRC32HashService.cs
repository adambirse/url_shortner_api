using System.IO.Hashing;
using System.Text;

namespace src.url.services.hash
{
    public class CRC32HashService : IHashService
    {
        public string Hash(string url)
        {
            var crc32 = new Crc32();
            crc32.Append(Encoding.UTF8.GetBytes(url));
            byte[] result = crc32.GetCurrentHash();
            StringBuilder hashString = new StringBuilder();
            foreach (byte b in result)
            {
                hashString.Append(b.ToString("x2"));//x2 format string means hexadecimal
            }

            return hashString.ToString();
        }
    }
}
