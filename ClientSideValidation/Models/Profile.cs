using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientSideValidation.Models
{
    public class Profile
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirm { get; set; }
    }
}
