using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DataLogic.Weapons.Models
{

    public class WeaponStatsModel
    {
        public string Name { get; set; }
        public string UniqueName { get; set; }
        public bool CodexSecret { get; set; }
        public float[] DamagePerShot { get; set; }
        public int TotalDamage { get; set; }
        public string Description { get; set; }
        public float CriticalChance { get; set; }
        public float CriticalMultiplier { get; set; }
        public float ProcChance { get; set; }
        public float FireRate { get; set; }
        public int MasteryReq { get; set; }
        public string ProductCategory { get; set; }
        public int Slot { get; set; }
        public float Accuracy { get; set; }
        public float OmegaAttenuation { get; set; }
        public string Noise { get; set; }
        public string Trigger { get; set; }
        public int MagazineSize { get; set; }
        public int ReloadTime { get; set; }
        public int Multishot { get; set; }
        public int BuildPrice { get; set; }
        public int BuildTime { get; set; }
        public int SkipBuildTimePrice { get; set; }
        public int BuildQuantity { get; set; }
        public bool ConsumeOnBuild { get; set; }
        //public Component[] Components { get; set; }
        public string Type { get; set; }
        public Damage Damage { get; set; }
        public string ImageName { get; set; }
        public string Category { get; set; }
        public bool Tradable { get; set; }
        public bool WikiAvailable { get; set; }
        public Attack[] Attacks { get; set; }
        public int MarketCost { get; set; }
        public string[] Polarities { get; set; }
        public string[] Tags { get; set; }
        public string ExilusPolarity { get; set; }
        public string WikiaThumbnail { get; set; }
        public string WikiaUrl { get; set; }
        public Introduced Introduced { get; set; }
        public int Disposition { get; set; }
        public string ReleaseDate { get; set; }
        public bool IsPrime { get; set; }
        public bool Masterable { get; set; }
    }

    public class Damage
    {
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
        [JsonPropertyName("_void")]
        public int Void { get; set; }
        public int Tau { get; set; }
        public int Cinematic { get; set; }
        public int ShieldDrain { get; set; }
        public int HealthDrain { get; set; }
        public int EnergyDrain { get; set; }
        [JsonPropertyName("_true")]
        public int True { get; set; }
    }

    public class Introduced
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string[] Aliases { get; set; }
        public string Parent { get; set; }
        public string Date { get; set; }
    }

    //public class Component
    //{
    //    public string UniqueName { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public int ItemCount { get; set; }
    //    public string ImageName { get; set; }
    //    public Drop[] Drops { get; set; }
    //    public bool Tradable { get; set; }
    //    public bool Masterable { get; set; }
    //    public bool CodexSecret { get; set; }
    //    public string Type { get; set; }
    //}

    //public class Drop
    //{
    //    public string Location { get; set; }
    //    public string Type { get; set; }
    //    public float Chance { get; set; }
    //    public string Rarity { get; set; }
    //}

    public class Attack
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Crit_chance { get; set; }
        public float Crit_mult { get; set; }
        public int Status_chance { get; set; }
        public string Shot_type { get; set; }
        public int Shot_speed { get; set; }
        public int Flight { get; set; }
        public Damage1 Damage { get; set; }
        public Falloff Falloff { get; set; }
    }

    public class Damage1
    {
        public int Impact { get; set; }
        public float Slash { get; set; }
        public float Puncture { get; set; }
    }

    public class Falloff
    {
        public int Start { get; set; }
        public int End { get; set; }
        public float Reduction { get; set; }
    }

}
