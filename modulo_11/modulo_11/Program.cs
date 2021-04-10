using System;
using System.Collections;

namespace modulo_11
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Start");
            String rut = Console.ReadLine();
            CalculateMod(rut);//-5
            Console.WriteLine("End");
            Console.ReadLine();

            return 0;
        }

        static void CalculateMod(String rut)
        {
            Console.WriteLine("og rut is " + rut);
            //First reverse the string 
            String reversedRut = ReverseString(rut);

            Console.WriteLine("reversed rut is " + reversedRut);
            //Extraer Digitos
            ArrayList Digitos = ExtractArrayFromString(reversedRut);
            //Multiplicar numeros y sumarlos
            int codigoVerificador = MulSumMod11(Digitos);

            if(codigoVerificador == 10)
            {
                Console.WriteLine(rut + "-K");
            }
            else
            {
                Console.WriteLine(rut + "-" + codigoVerificador);
            }
            
        }

        static String ReverseString(String originalString)
        {
            String ReverseString = string.Empty;
            //i es igual al index del ultimo caracter de la originalString.

            for(int i = originalString.Length - 1; i >= 0; i--)
            {
                ReverseString += originalString[i];
            }

            return ReverseString;
        }

        static ArrayList ExtractArrayFromString(String fullNum)
        {
            ArrayList digitos = new ArrayList();
            for(int i = 0; i < fullNum.Length; i++)
            {
                double dig = char.GetNumericValue(fullNum, i);
                digitos.Add(dig);
            }
            return digitos;
        }
        static int MulSumMod11(ArrayList digitos)
        {
            int multiplicador = 2;
            ArrayList sumDigitos = new ArrayList();
            //Multiplicar los numeros
            for (int i = 0; i < digitos.Count; i++)
            {
                if(multiplicador > 7)
                {
                    multiplicador = 2;
                }
                int digito = Convert.ToInt32(digitos[i]);
                sumDigitos.Add(digito * multiplicador);
                Console.WriteLine("producto en iteracion i: " + i + " producto " + (digito * multiplicador) + " multiplicador: " + multiplicador);
                multiplicador++;
            }
            //Sumar los numeros
            int suma = 0;
            for(int i = 0; i < sumDigitos.Count; i++)
            {
                Console.WriteLine("suma en iteracion i: " + i + " suma: " + suma);
                suma += (int)sumDigitos[i];
            }
            Console.WriteLine("suma en iteracion suma: " + suma);
            //modulo
            int codigoVerificador = 11 - (suma % 11);
            Console.WriteLine("codigo " + codigoVerificador);
            return codigoVerificador;
        }
    }
}
