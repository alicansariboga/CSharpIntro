using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class House
    {
        public House()
        {

        }
        public int Id { get; set; }
        public string City { get; set; }
        protected string Suburb { get; set; }
    }
    public class HouseTest:House
    {
        public HouseTest()
        {
            Suburb = "dsgsd"; //protected
        }
    }
}
