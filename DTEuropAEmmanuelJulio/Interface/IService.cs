using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTEuropAEmmanuelJulio.Interface
{
    public interface IService
    {
        public string Simplificar(string fraction);
        public bool ValidName(string name);
    }
}
