using Microsoft.EntityFrameworkCore;
using TforT.Models;

namespace TforT.DataBase
{
    public abstract class BaseContext:DbContext
    {
        public BaseContext()
        {
            Migrate();
        }
        public DbSet<User> users { get; set; }
        public DbSet<Mobile> mobiles { get; set; }
        public DbSet<UserContacts> userContacts { get; set; }
        public DbSet<Product> products { get; set; }

        public virtual void Migrate()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mobile>(x =>
            {
                //x.HasMany(m=>m.Contacts).WithOne(uc=>uc.mobile);
                //x.HasOne(m=>m.user).WithOne(u=>u.mobile);
                x.HasKey(m => m.MobileId);
            });

            modelBuilder.Entity<User>(x =>
            {
                //x.HasOne(u=>u.mobile).WithOne(m=>m.user).HasForeignKey<Mobile>(k=>k.UserId);
                x.HasKey(u => u.UserId);
            });

            modelBuilder.Entity<UserContacts>(x =>
            {
                //x.HasOne(uc=>uc.mobile).WithMany(m=>m.Contacts);
               // x.HasOne(uc=>uc.user);
                x.HasKey(uc => uc.UserContactsId);
            });

            modelBuilder.Entity<Product>(x =>
            {
                x.HasKey(uc => uc.ProductId);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
