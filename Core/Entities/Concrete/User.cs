using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class User : IEntity

    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string TrendyolSupplierId { get; set; }
        public string TrendyolUserName { get; set; }
        public string TrendyolPassword { get; set; }
        public string ParasutCompanyId { get; set; }
        public string ParasutClientId { get; set; }
        public string ParasutClientSecret { get; set; }
        public string ParasutUserName { get; set; }
        public string ParasutPassword { get; set; }
        public bool Status { get; set; }
    }
}
