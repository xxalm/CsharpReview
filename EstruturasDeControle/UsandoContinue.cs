﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class UsandoContinue {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Os números pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue;
                }

                Console.WriteLine(i + " ");
            }
        }
    }
}   
