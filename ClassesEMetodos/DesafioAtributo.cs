using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class DesafioAtributo {

        int a = 10;

        public static void Executar() {

            DesafioAtributo desafio = new DesafioAtributo();
            

            //Acessar variável 'a' dentro do método Executar!
            Console.WriteLine(desafio.a);

        }
    }
}
