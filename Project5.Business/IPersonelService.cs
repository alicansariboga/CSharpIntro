using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.Business
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
    }
}
