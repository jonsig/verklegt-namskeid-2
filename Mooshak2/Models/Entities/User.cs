using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mooshak2.Models.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
    }
}