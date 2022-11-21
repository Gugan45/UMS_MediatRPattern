using System.ComponentModel.DataAnnotations.Schema;

namespace UMS.Domain.Login
{
    [NotMapped]
    public class UserLogin
    {
        public string ?UserName { get; set; }
        public string ? Password { get; set; }
    }
}