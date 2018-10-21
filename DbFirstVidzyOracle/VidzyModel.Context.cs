﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbFirstVidzyOracle
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VidzyDbContext : DbContext
    {
        public VidzyDbContext()
            : base("name=VidzyDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GENRE> GENRES { get; set; }
        public virtual DbSet<VIDEO> VIDEOS { get; set; }
    
        public virtual int AddVideo(string aNAME, Nullable<System.DateTime> aRELEASE_DATE, string aGENRE)
        {
            var aNAMEParameter = aNAME != null ?
                new ObjectParameter("ANAME", aNAME) :
                new ObjectParameter("ANAME", typeof(string));
    
            var aRELEASE_DATEParameter = aRELEASE_DATE.HasValue ?
                new ObjectParameter("ARELEASE_DATE", aRELEASE_DATE) :
                new ObjectParameter("ARELEASE_DATE", typeof(System.DateTime));
    
            var aGENREParameter = aGENRE != null ?
                new ObjectParameter("AGENRE", aGENRE) :
                new ObjectParameter("AGENRE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddVideo", aNAMEParameter, aRELEASE_DATEParameter, aGENREParameter);
        }
    }
}
