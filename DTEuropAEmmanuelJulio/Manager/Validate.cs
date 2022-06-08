using DTEuropAEmmanuelJulio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTEuropAEmmanuelJulio.Manager
{
    public class Validate : IValidate
    {
        public bool ValidateFractionFormat(string fraction)
        {
            if (ValidateInput(fraction))
            {

                try
                {
                   var arr= fraction.Split("/");
                    if(arr.Length==2)
                        return true;
                    else
                        return false;
                }
                catch (Exception)
                {

                    return false;
                }

            }
            else { return false; }
        }

        public bool ValidateInput(string dato)
        {
           if(dato is null)
                return false;


           if(dato is string)
             return true;
           else return false;

        }
    }
}
