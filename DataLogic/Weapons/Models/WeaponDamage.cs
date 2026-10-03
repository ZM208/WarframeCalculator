using System;
using System.Collections.Generic;
using System.Text;

namespace DataLogic.Weapons.Models
{
    public class WeaponDamage
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public int Impact { get; set; }
        public float Puncture { get; set; }
        public float Slash { get; set; }
        public int Heat { get; set; }
        public int Cold { get; set; }
        public int Electricity { get; set; }
        public int Toxin { get; set; }
        public int Blast { get; set; }
        public int Radiation { get; set; }
        public int Gas { get; set; }
        public int Magnetic { get; set; }
        public int Viral { get; set; }
        public int Corrosive { get; set; }
        public int Void { get; set; }
        public int Tau { get; set; }
        public int ShieldDrain { get; set; }
        public int HealthDrain { get; set; }
        public int EnergyDrain { get; set; }
        public int True { get; set; }
    }
}
