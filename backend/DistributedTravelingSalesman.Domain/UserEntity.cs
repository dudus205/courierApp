using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace DistributedTravelingSalesman.Domain
{
    public class UserEntity : BaseEntity
    {
        [EmailAddress]
        public string Email { get; set; }
        public string PasswordHash { get; protected internal set; }

        public void SetPassword(string plainText)
        {
            using var md5 = MD5.Create();
            PasswordHash = Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(plainText)));
        }

        public bool CheckPassword(string plainText)
        {
            using var md5 = MD5.Create();
            var hash = Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(plainText)));
            return hash == PasswordHash;
        }
    }
}