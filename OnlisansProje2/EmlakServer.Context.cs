﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlisansProje2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmlakServerEntitiess : DbContext
    {
        public EmlakServerEntitiess()
            : base("name=EmlakServerEntitiess")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<foto> fotoes { get; set; }
        public virtual DbSet<il> ils { get; set; }
        public virtual DbSet<ilan> ilans { get; set; }
        public virtual DbSet<ilanDetay> ilanDetays { get; set; }
        public virtual DbSet<ilce> ilces { get; set; }
        public virtual DbSet<kategori> kategoris { get; set; }
        public virtual DbSet<kullanici> kullanicis { get; set; }
        public virtual DbSet<semt> semts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tur> turs { get; set; }
    }
}
