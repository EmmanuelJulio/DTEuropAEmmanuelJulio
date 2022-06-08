using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTEuropAEmmanuelJulio.Interface
{
    public interface IValidate
    {
        public bool ValidateFractionFormat(string fraction);
        public bool ValidateInput(string dato);

        public bool validateInitial(string initial);

        

    }
}
