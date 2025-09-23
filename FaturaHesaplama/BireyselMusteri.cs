using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaHesaplama
{
    internal class BireyselMusteri : TemelMusteri
    {
        

        public override void indirimYuzdesiHesapla()
        {
            this.indirimYuzdesi = 5;
        }
    }
}
