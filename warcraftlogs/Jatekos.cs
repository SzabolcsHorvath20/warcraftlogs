using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warcraftlogs
{
    class Jatekos
    {
        private int parse;
        private string name;
        private int amount;
        private int ilvl;
        private int ilvlpercent;
        private double activepercent;
        private double dps;

        public Jatekos(int parse, string name, int amount, int ilvl, int ilvlpercent, double activepercent, double dps)
        {
            this.Parse = parse;
            this.Name = name;
            this.Amount = amount;
            this.Ilvl = ilvl;
            this.Ilvlpercent = ilvlpercent;
            this.Activepercent = activepercent;
            this.Dps = dps;
        }

        public int Parse { get => parse; set => parse = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Ilvl { get => ilvl; set => ilvl = value; }
        public int Ilvlpercent { get => ilvlpercent; set => ilvlpercent = value; }
        public double Activepercent { get => activepercent; set => activepercent = value; }
        public double Dps { get => dps; set => dps = value; }
    }
}
