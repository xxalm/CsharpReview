﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho { }

    class Avo {
        public virtual bool HonrarNomeFamília() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HonrarNomeFamília() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
        //public bool HonrarNomeFamilia() {
        //    return false;
        //}
    }

    internal class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamília());
        }
    }
}
