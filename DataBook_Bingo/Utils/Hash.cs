using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataBook_Bingo.Utils
{
    public class Hash
    {
        public static string GerarHash(string texto, string texto2) //recebe um texto como parametro.
        {
            string resultado = texto + texto2;

            SHA256 sha256 = SHA256Managed.Create(); // função interna para conversão.
            byte[] bytes = Encoding.UTF8.GetBytes(resultado);   //convert em bytes
            byte[] hash = sha256.ComputeHash(bytes);  //gera o hash  
            StringBuilder result = new StringBuilder(); //retorna um array
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("x")); //realiza a conversão
            }
            return result.ToString(); //retorna
        }
    }
}
