using Eventora.Application.Contracts.Tenants;
using Eventora.Domain.Bookings;
using Eventora.Domain.Common.MultiTenants;
using Eventora.Domain.Customers;
using Eventora.Domain.Events;
using Eventora.Domain.EventServices;
using Eventora.Domain.Halls;
using Eventora.Domain.Services;
using Eventora.Domain.Tenants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Eventora.Infrastructure.EventoraDBContexts
{
     public class EventoraDBContext : DbContext
    {
        public Guid TenantId { get; set; }
        public EventoraDBContext(DbContextOptions<EventoraDBContext> options) 
            : base(options)
        {
             
        }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Event>  Events { get; set; }
        public DbSet<EventService>   EventServices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Customer>  Customers { get; set; }
        public DbSet<Tenant>  Tenants { get; set; }

        public void SetTenant(Guid tenantId)
        {
            TenantId = tenantId;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eventora.Domain.Tenants.Tenant>()
                .ToTable("Tenants", schema: "Sass");

            #region Query Filter
                modelBuilder.Entity<Booking>()
                    .HasQueryFilter(a => a.TenantId == TenantId);
                modelBuilder.Entity<Event>()
                .HasQueryFilter(a => a.TenantId == TenantId);
                modelBuilder.Entity<EventService>()
                .HasQueryFilter(a => a.TenantId == TenantId);
                modelBuilder.Entity<Service>()
                .HasQueryFilter(a => a.TenantId == TenantId);
                modelBuilder.Entity<Hall>()
                .HasQueryFilter(a => a.TenantId == TenantId);
                modelBuilder.Entity<Customer>()
                .HasQueryFilter(a => a.TenantId == TenantId);
                modelBuilder.Entity<Customer>()
                .HasQueryFilter(a => a.TenantId == TenantId);
            #endregion
        }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var entity in ChangeTracker.Entries<IMultiTenant> ().Where(a=>a.State == EntityState.Added))
            {
                entity.Entity.TenantId = TenantId;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
