using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas
{
    class Ember
    {
        private string nev;
        private string szuldatum;
        private Nem nem;
        private List<string> hobbik = new List<string>();

        public Ember(string nev, string szuldatum, Nem nem, List<string> hobbik)
        {
            this.nev = nev;
            this.szuldatum = szuldatum;
            this.nem = nem;
            this.hobbik = hobbik;
        }

        public string Nev { get; set; }
        public string Szuldatum { get; set; }
        public Nem Nem{ get; set; }
        public List<string> Hobbik { get; set; }

        public override string ToString()
        {
            string s = this.nev + ";" + this.szuldatum + ";" + this.nem + ";";
            foreach (string str in this.hobbik)
            {
                s += str + ";";
            }
            return String.Format(s);
        }
    }
}
