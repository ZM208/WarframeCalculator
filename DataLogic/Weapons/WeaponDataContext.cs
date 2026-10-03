using DataLogic.Weapons.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLogic.Weapons
{
    public class WeaponDataContext : DbContext
    {
        public WeaponDataContext(DbContextOptions<WeaponDataContext> options) : base(options)
        {

        }
        public DbSet<WeaponStatsModel> WeaponStats { get; set; }
    }
}
