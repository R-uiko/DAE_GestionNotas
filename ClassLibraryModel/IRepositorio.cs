using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public interface IRepositorio<Modelo> 
    {
        List<Modelo> GetAll(); 
        int Create(Modelo modelo);
        int Update(Modelo modelo);
        int Delete(int recordID);
    }
    
    
}
