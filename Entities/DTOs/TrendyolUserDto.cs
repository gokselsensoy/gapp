using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    [Keyless]
    public class TrendyolUserDto : IDTO
    {
        public int UserId { get; set; }
        public string SupplierId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
