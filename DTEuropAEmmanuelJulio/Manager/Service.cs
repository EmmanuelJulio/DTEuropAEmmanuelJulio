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
            if (Validate.ValidateInput(name) && name.Split(" ").Length >= 2)
            {
                var arr = name.Split(" ");
                if (arr.Length == 1)
                    return false;

                bool firstArr, secondArr, thirdArr = true;

                if (Validate.validateInitial(arr[0]))
                    firstArr = true;
                else
                    firstArr = false;
                if (Validate.validateInitial(arr[1]))
                    secondArr = true;
                else
                    secondArr = false;
                if (arr.Length == 3)
                {
                    if (!arr[2].EndsWith(".") && arr[2].Length > 2)
                        thirdArr = true;
                    else thirdArr = false;
                }

                return firstArr && secondArr && thirdArr;
            }
            return false;

        }
    }
}
