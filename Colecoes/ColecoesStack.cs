using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    static class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"Pop: {pilha.Pop()}");

            foreach (var item in pilha) {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"Peek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
