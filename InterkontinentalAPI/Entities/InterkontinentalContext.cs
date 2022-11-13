using Microsoft.EntityFrameworkCore;

namespace InterkontinentalAPI.Entities
{
    public class InterkontinentalContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Counter> Counters { get; set; }

        public InterkontinentalContext(DbContextOptions<InterkontinentalContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Field>()
                .HasData(SeedFields());

            modelBuilder.Entity<Counter>()
                .HasOne(c => c.Field)
                .WithMany(f => f.Counters)
                .HasForeignKey(c => c.FieldId);

            modelBuilder.Entity<Counter>()
                .HasOne(c => c.Game)
                .WithMany(g => g.Counters)
                .HasForeignKey(c => c.GameId);

            modelBuilder.Entity<Game>()
                .Property(g => g.Start)
                .HasDefaultValueSql("getutcdate()");

            modelBuilder.Entity<Game>()
                .Property(g => g.HasEnded)
                .HasDefaultValue(false);

            modelBuilder.Entity<Counter>()
                .Property(c => c.Count)
                .HasDefaultValue(0);

        }

        private List<Field> SeedFields() => new List<Field>
                {
                    new Field
                    {
                        Id = 1,
                        Name = "Praga",
                        Type = "Czechy"
                    },
                    new Field
                    {
                        Id = 2,
                        Name = "Kompostownik",
                        Type = "Inne"
                    },
                    new Field
                    {
                        Id = 3,
                        Name = "Kolin",
                        Type = "Czechy"
                    },
                    new Field
                    {
                        Id = 4,
                        Name = "Kutna Hora",
                        Type = "Czechy"
                    },
                    new Field
                    {
                        Id = 5,
                        Name = "Szansa 1",
                        Type = "Szansy"
                    },
                    new Field
                    {
                        Id = 6,
                        Name = "Kolej Europejska",
                        Type = "Koleje"
                    },
                    new Field
                    {
                        Id = 7,
                        Name = "Prypeć",
                        Type = "Ukraina"
                    },new Field
                    {
                        Id = 8,
                        Name = "Gazownia",
                        Type = "Inne"
                    },new Field
                    {
                        Id = 9,
                        Name = "Kijów",
                        Type = "Ukraina"
                    },
                    new Field
                    {
                        Id = 10,
                        Name = "Odwiedzanie Gułagu",
                        Type = "Inne"
                    },
                    new Field
                    {
                        Id = 11,
                        Name = "Odessa",
                        Type = "Ukraina"
                    },
                    new Field
                    {
                        Id = 12,
                        Name = "Watykan",
                        Type = "Watykan"
                    },
                    new Field
                    {
                        Id = 13,
                        Name = "Lotnisko",
                        Type = "Inne"
                    },
                    new Field
                    {
                        Id = 14,
                        Name = "Płaza",
                        Type = "Polska"
                    },
                    new Field
                    {
                        Id = 15,
                        Name = "Balin",
                        Type = "Polska"
                    },
                    new Field
                    {
                        Id = 16,
                        Name = "Regulice",
                        Type = "Polska"
                    },new Field
                    {
                        Id = 17,
                        Name = "Szansa 2",
                        Type = "Szansy"
                    },new Field
                    {
                        Id = 18,
                        Name = "Kolej Transsyberyjska",
                        Type = "Koleje"
                    },
                    new Field
                    {
                        Id = 19,
                        Name = "Zaginiona Wioska",
                        Type = "Polska"
                    },new Field
                    {
                        Id = 20,
                        Name = "Berlin Wschodni",
                        Type = "Niemcy"
                    },new Field
                    {
                        Id = 21,
                        Name = "Drezno",
                        Type = "Niemcy"
                    },new Field
                    {
                        Id = 22,
                        Name = "Zwickau",
                        Type = "Niemcy"
                    },new Field
                    {
                        Id = 23,
                        Name = "Koksownia",
                        Type = "Inne"
                    },new Field
                    {
                        Id = 24,
                        Name = "Władywostok",
                        Type = "Rosja"
                    },new Field
                    {
                        Id = 25,
                        Name = "Partyjna Działka",
                        Type = "Inne"
                    },new Field
                    {
                        Id = 26,
                        Name = "Jekaterynburg",
                        Type = "Rosja"
                    },new Field
                    {
                        Id = 27,
                        Name = "Nowosybirsk",
                        Type = "Rosja"
                    },new Field
                    {
                        Id = 28,
                        Name = "Bogota",
                        Type = "Ameryka"
                    },new Field
                    {
                        Id = 29,
                        Name = "Szansa 3",
                        Type = "Szansy"
                    },new Field
                    {
                        Id = 30,
                        Name = "Kolej Światowa",
                        Type = "Koleje"
                    },new Field
                    {
                        Id = 31,
                        Name = "Hawana",
                        Type = "Ameryka"
                    },new Field
                    {
                        Id = 32,
                        Name = "Grill",
                        Type = "Inne"
                    },new Field
                    {
                        Id = 33,
                        Name = "Meksyk",
                        Type = "Ameryka"
                    },new Field
                    {
                        Id = 34,
                        Name = "Sydney",
                        Type = "Australia"
                    },new Field
                    {
                        Id = 35,
                        Name = "Gułag",
                        Type = "Inne"
                    },new Field
                    {
                        Id = 36,
                        Name = "Melbourne",
                        Type = "Australia"
                    },new Field
                    {
                        Id = 37,
                        Name = "Wellington",
                        Type = "Australia"
                    },new Field
                    {
                        Id = 38,
                        Name = "Zanzibar",
                        Type = "Egipt"
                    },new Field
                    {
                        Id = 39,
                        Name = "Port",
                        Type = "Inne"
                    },new Field
                    {
                        Id = 40,
                        Name = "Dakar",
                        Type = "Egipt"
                    },new Field
                    {
                        Id = 41,
                        Name = "Kair",
                        Type = "Egipt"
                    },new Field
                    {
                        Id = 42,
                        Name = "Singapur",
                        Type = "Bogate"
                    },new Field
                    {
                        Id = 43,
                        Name = "Szansa 4",
                        Type = "Szansy"
                    },new Field
                    {
                        Id = 44,
                        Name = "Kolej Towarowa",
                        Type = "Koleje"
                    },new Field
                    {
                        Id = 45,
                        Name = "Tajwan",
                        Type = "Bogate"
                    },new Field
                    {
                        Id = 46,
                        Name = "Truskawki",
                        Type = "Inne"
                    },new Field
                    {
                        Id = 47,
                        Name = "Sosnowiec",
                        Type = "Dziwne"
                    },new Field
                    {
                        Id = 48,
                        Name = "Kopalnia Uranu",
                        Type = "Inne"
                    },new Field
                    {
                        Id = 49,
                        Name = "Bukareszt",
                        Type = "Dziwne"
                    },new Field
                    {
                        Id = 50,
                        Name = "Start",
                        Type = "Inne"
                    },
                };
    }
}
