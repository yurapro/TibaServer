using System;
using System.Collections.Generic;
using System.Text;

namespace Tiba.Domain
{
    public class Favorit: BaseEntity
    {
        public int? UserID { get; set; }
        public string Name { get; set; }
        public string Repository { get; set; }
    }
}
