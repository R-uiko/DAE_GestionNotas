using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    
    public class RTipoUsuario : IRepositorio<Usuario>
    {
        private Entities entidadModel = new Entities();
        public int Create(Usuario modelo)
        {
            throw new NotImplementedException();
        }

        public int Delete(int recordID)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            return entidadModel.Usuario.ToList();
        }

        public int Update(Usuario modelo)
        {
            throw new NotImplementedException();
        }
    }
}
