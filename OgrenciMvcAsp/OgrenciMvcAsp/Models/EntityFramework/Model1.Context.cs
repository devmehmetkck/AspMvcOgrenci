﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciMvcAsp.Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMvcOkulEntities : DbContext
    {
        public DbMvcOkulEntities()
            : base("name=DbMvcOkulEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblDersler> TblDersler { get; set; }
        public virtual DbSet<TblKulupler> TblKulupler { get; set; }
        public virtual DbSet<TblNotlar> TblNotlar { get; set; }
        public virtual DbSet<TblOgrenciler> TblOgrenciler { get; set; }
    }
}
