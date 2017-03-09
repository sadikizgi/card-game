using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13042016_week7
{
    public class Kart
    {
        private string yuz;
        private string tip;

        public Kart(string kartYuzu, string kartTipi)
        {
            yuz = kartYuzu;
            tip = kartTipi;
        }

        public override string ToString()
        {
            return tip + ": "+ yuz;
        } 
    }
}
