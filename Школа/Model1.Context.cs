﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Школа
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ШколаEntitis1 : DbContext
    {
        public ШколаEntitis1()
            : base("name=ШколаEntitis1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Оценка> Оценка { get; set; }
        public virtual DbSet<Предметы> Предметы { get; set; }
        public virtual DbSet<Ученики> Ученики { get; set; }
        public virtual DbSet<Учителя> Учителя { get; set; }
    }
}
