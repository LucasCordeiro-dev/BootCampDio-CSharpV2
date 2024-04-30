using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioCSharpExemploFundamentos.Common.Models
{
    public class Pessoa
    {
       public string? Nome { get; set; } 
       public int Idade { get; set; }

       public void Apresentar()
       {
        System.Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade} anos");

       }
    }
}