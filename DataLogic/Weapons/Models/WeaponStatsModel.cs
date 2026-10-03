using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataLogic.Weapons.Models
{

    public class WeaponStatsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float[] DamagePerShot { get; set; }
        public int TotalDamage { get; set; }
        public string Description { get; set; }
        public float CriticalChance { get; set; }
        public float CriticalMultiplier { get; set; }
        public float ProcChance { get; set; }
        public float FireRate { get; set; }
        public int MasteryReq { get; set; }
        public string ProductCategory { get; set; }
        public float Accuracy { get; set; }
        public float OmegaAttenuation { get; set; }
        public string Trigger { get; set; }
        public int MagazineSize { get; set; }
        public int ReloadTime { get; set; }
        public int Multishot { get; set; }
        public string Type { get; set; }
        public WeaponDamage Damage { get; set; }
        public string Category { get; set; }
        public string[] Polarities { get; set; }
        public string ExilusPolarity { get; set; }
        public int Disposition { get; set; }
        public bool IsPrime { get; set; }
        
    }
}
