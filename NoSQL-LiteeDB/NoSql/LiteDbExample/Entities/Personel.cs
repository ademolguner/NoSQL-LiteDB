using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteDbExample.Entities
{
  public class Personel
    {
        public Guid UniqGuid { get; set; }
        public int PersonelId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}
