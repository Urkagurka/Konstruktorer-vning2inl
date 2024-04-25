using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktorerövning2inl
{
    class namn
    {
        private string förnamn;
        private string efternamn;
        private string fullnamn;

        public namn(string F, string E) 
        {
            förnamn = F;
            efternamn = E;
            fullnamn = förnamn + " " + efternamn;
        }
        public string getFullnamn() { return fullnamn; }  
    }
}
