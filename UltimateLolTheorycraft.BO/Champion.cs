using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLolTheorycraft.BO
{
    /// <summary>
    /// DAO of champion data
    /// </summary>
    public class Champion
    {
        public string version { get; set; }
        public string id { get; set; }
        public int key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Stats stats { get; set; }
    }

    public class Stats
    {
        public double hp { get; set; }
        public double hpperlevel { get; set; }
        public double mp { get; set; }
        public double mpperlevel { get; set; }
        public double movespeed { get; set; }
        public double armor { get; set; }
        public double armorperlevel { get; set; }
        public double spellblock { get; set; }
        public double spellblockperlevel { get; set; }
        public double attackrange { get; set; }
        public double hpregen { get; set; }
        public double hpregenperlevel { get; set; }
        public double mpregen { get; set; }
        public double mpregenperlevel { get; set; }
        public double crit { get; set; }
        public double critperlevel { get; set; }
        public double attackdamage { get; set; }
        public double attackdamageperlevel { get; set; }
        public double attackspeedoffset { get; set; }
        public double attackspeedperlevel { get; set; }
    }
}
