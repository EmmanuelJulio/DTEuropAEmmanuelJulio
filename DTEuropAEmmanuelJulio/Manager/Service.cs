using DTEuropAEmmanuelJulio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTEuropAEmmanuelJulio.Manager
{
    public class Service : IService
    {
        private readonly IValidate Validate;

        public Service(IValidate validate)
        {
            Validate = validate;
        }

        public string Simplificar(string fraction)
        {
            if (Validate.ValidateFractionFormat(fraction))
            {
                var arr = fraction.Split("/");
                int numerador = Convert.ToInt32(arr[0]);
                int denominador = Convert.ToInt32(arr[1]);
                if (numerador%denominador==0)
                    return (numerador/denominador).ToString();
                else
                {
                    int a = Math.Max(numerador, denominador);
                    int b = Math.Min(numerador, denominador);
                    int resto;
                    do
                    {
                        resto = b;
                        b = a % b;
                        a = resto;
                    }while(b!=0);
                    return (numerador / resto).ToString() + "/" + (denominador / resto).ToString();
                }
            }
            return (Constants.Constants.InvalidFormatFraction);
        }

        public bool ValidName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
