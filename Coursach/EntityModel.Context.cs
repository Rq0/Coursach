﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coursach
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MenuUnitEntities : DbContext
    {
        public MenuUnitEntities()
            : base("name=MenuUnitEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<DishComposition> DishComposition { get; set; }
        public virtual DbSet<DishTypes> DishTypes { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuComposition> MenuComposition { get; set; }
        public virtual DbSet<MenuRequirement> MenuRequirement { get; set; }
        public virtual DbSet<Entrance> Entrance { get; set; }
        public virtual DbSet<EntranceComposition> EntranceComposition { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
    }
}
