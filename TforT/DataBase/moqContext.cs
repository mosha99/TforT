using Microsoft.EntityFrameworkCore;

namespace TforT.DataBase
{
    public class moqContext : BaseContext
    {
        private string ConectionString = "MoqDatabase";
        protected virtual string GetConectionString() => ConectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(GetConectionString());
            base.OnConfiguring(optionsBuilder);

        }


    }
}
