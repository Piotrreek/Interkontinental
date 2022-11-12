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
                        Name = "Praga"
                    },
                    new Field
                    {
                        Id = 2,
                        Name = "Kompostownik"
                    },
                    new Field
                    {
                        Id = 3,
                        Name = "Kolin"
                    },
                    new Field
                    {
                        Id = 4,
                        Name = "Kutna Hora"
                    },
                    new Field
                    {
                        Id = 5,
                        Name = "Szansa 1"
                    },
                    new Field
                    {
                        Id = 6,
                        Name = "Kolej Europejska"
                    },
                    new Field
                    {
                        Id = 7,
                        Name = "Prypeć"
                    },new Field
                    {
                        Id = 8,
                        Name = "Gazownia"
                    },new Field
                    {
                        Id = 9,
                        Name = "Kijów"
                    },
                    new Field
                    {
                        Id = 10,
                        Name = "Odwiedzanie Gułagu"
                    },
                    new Field
                    {
                        Id = 11,
                        Name = "Odessa"
                    },
                    new Field
                    {
                        Id = 12,
                        Name = "Watykan"
                    },
                    new Field
                    {
                        Id = 13,
                        Name = "Lotnisko"
                    },
                    new Field
                    {
                        Id = 14,
                        Name = "Płaza"
                    },
                    new Field
                    {
                        Id = 15,
                        Name = "Balin"
                    },
                    new Field
                    {
                        Id = 16,
                        Name = "Regulice"
                    },new Field
                    {
                        Id = 17,
                        Name = "Szansa 2"
                    },new Field
                    {
                        Id = 18,
                        Name = "Kolej Transsyberyjska"
                    },
                    new Field
                    {
                        Id = 19,
                        Name = "Zaginiona Wioska"
                    },new Field
                    {
                        Id = 20,
                        Name = "Berlin Wschodni"
                    },new Field
                    {
                        Id = 21,
                        Name = "Drezno"
                    },new Field
                    {
                        Id = 22,
                        Name = "Zwickau"
                    },new Field
                    {
                        Id = 23,
                        Name = "Koksownia"
                    },new Field
                    {
                        Id = 24,
                        Name = "Władywostok"
                    },new Field
                    {
                        Id = 25,
                        Name = "Partyjna Działka"
                    },new Field
                    {
                        Id = 26,
                        Name = "Jekaterynburg"
                    },new Field
                    {
                        Id = 27,
                        Name = "Nowosybirsk"
                    },new Field
                    {
                        Id = 28,
                        Name = "Bogota"
                    },new Field
                    {
                        Id = 29,
                        Name = "Szansa 3"
                    },new Field
                    {
                        Id = 30,
                        Name = "Kolej Światowa"
                    },new Field
                    {
                        Id = 31,
                        Name = "Hawana"
                    },new Field
                    {
                        Id = 32,
                        Name = "Grill"
                    },new Field
                    {
                        Id = 33,
                        Name = "Meksyk"
                    },new Field
                    {
                        Id = 34,
                        Name = "Sydney"
                    },new Field
                    {
                        Id = 35,
                        Name = "Gułag"
                    },new Field
                    {
                        Id = 36,
                        Name = "Melbourne"
                    },new Field
                    {
                        Id = 37,
                        Name = "Wellington"
                    },new Field
                    {
                        Id = 38,
                        Name = "Zanzibar"
                    },new Field
                    {
                        Id = 39,
                        Name = "Port"
                    },new Field
                    {
                        Id = 40,
                        Name = "Dakar"
                    },new Field
                    {
                        Id = 41,
                        Name = "Kair"
                    },new Field
                    {
                        Id = 42,
                        Name = "Singapur"
                    },new Field
                    {
                        Id = 43,
                        Name = "Szansa 4"
                    },new Field
                    {
                        Id = 44,
                        Name = "Kolej Towarowa"
                    },new Field
                    {
                        Id = 45,
                        Name = "Tajwan"
                    },new Field
                    {
                        Id = 46,
                        Name = "Truskawki"
                    },new Field
                    {
                        Id = 47,
                        Name = "Sosnowiec"
                    },new Field
                    {
                        Id = 48,
                        Name = "Kopalnia Uranu"
                    },new Field
                    {
                        Id = 49,
                        Name = "Bukareszt"
                    },new Field
                    {
                        Id = 50,
                        Name = "Start"
                    },
                };
    }
}
