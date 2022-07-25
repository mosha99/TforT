using Microsoft.EntityFrameworkCore;
using TforT.Models;

namespace TforT.DataBase
{
    public class realContext:BaseContext
    {
        private string ConectionString = "Filename=RealDatabase.db";
        protected virtual string GetConectionString() => ConectionString;
        public override void Migrate()
        {
            Database.Migrate();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(GetConectionString());
            base.OnConfiguring(optionsBuilder);

        }

    }
}
