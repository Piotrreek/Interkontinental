﻿// <auto-generated />
using System;
using InterkontinentalAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InterkontinentalAPI.Migrations
{
    [DbContext(typeof(InterkontinentalContext))]
    [Migration("20221114222333_RemoveDefaultStartDate")]
    partial class RemoveDefaultStartDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InterkontinentalAPI.Entities.Counter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("GameId");

                    b.ToTable("Counters");
                });

            modelBuilder.Entity("InterkontinentalAPI.Entities.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fields");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Praga",
                            Type = "Czechy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kompostownik",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kolin",
                            Type = "Czechy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kutna Hora",
                            Type = "Czechy"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Szansa 1",
                            Type = "Szansy"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Kolej Europejska",
                            Type = "Koleje"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Prypeć",
                            Type = "Ukraina"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Gazownia",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Kijów",
                            Type = "Ukraina"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Odwiedzanie Gułagu",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Odessa",
                            Type = "Ukraina"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Watykan",
                            Type = "Watykan"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Lotnisko",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Płaza",
                            Type = "Polska"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Balin",
                            Type = "Polska"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Regulice",
                            Type = "Polska"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Szansa 2",
                            Type = "Szansy"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Kolej Transsyberyjska",
                            Type = "Koleje"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Zaginiona Wioska",
                            Type = "Polska"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Berlin Wschodni",
                            Type = "Niemcy"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Drezno",
                            Type = "Niemcy"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Zwickau",
                            Type = "Niemcy"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Koksownia",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Władywostok",
                            Type = "Rosja"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Partyjna Działka",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Jekaterynburg",
                            Type = "Rosja"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Nowosybirsk",
                            Type = "Rosja"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Bogota",
                            Type = "Ameryka"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Szansa 3",
                            Type = "Szansy"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Kolej Światowa",
                            Type = "Koleje"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Hawana",
                            Type = "Ameryka"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Grill",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Meksyk",
                            Type = "Ameryka"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Sydney",
                            Type = "Australia"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Gułag",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Melbourne",
                            Type = "Australia"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Wellington",
                            Type = "Australia"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Zanzibar",
                            Type = "Egipt"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Port",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Dakar",
                            Type = "Egipt"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Kair",
                            Type = "Egipt"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Singapur",
                            Type = "Bogate"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Szansa 4",
                            Type = "Szansy"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Kolej Towarowa",
                            Type = "Koleje"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Tajwan",
                            Type = "Bogate"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Truskawki",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Sosnowiec",
                            Type = "Dziwne"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Kopalnia Uranu",
                            Type = "Inne"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Bukareszt",
                            Type = "Dziwne"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Start",
                            Type = "Inne"
                        });
                });

            modelBuilder.Entity("InterkontinentalAPI.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasEnded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("InterkontinentalAPI.Entities.Counter", b =>
                {
                    b.HasOne("InterkontinentalAPI.Entities.Field", "Field")
                        .WithMany("Counters")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterkontinentalAPI.Entities.Game", "Game")
                        .WithMany("Counters")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("InterkontinentalAPI.Entities.Field", b =>
                {
                    b.Navigation("Counters");
                });

            modelBuilder.Entity("InterkontinentalAPI.Entities.Game", b =>
                {
                    b.Navigation("Counters");
                });
#pragma warning restore 612, 618
        }
    }
}
