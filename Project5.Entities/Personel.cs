using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Entities
{
    // normally, this class should have called as Employye but this is for testing purpose. So, I called as Personel.
    public class Personel : IEntity
    {
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
    }
}
