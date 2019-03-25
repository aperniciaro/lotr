﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using lotr;

namespace lotr.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("lotr.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("HasWieldedRing");

                    b.Property<string>("Name");

                    b.Property<string>("Profession");

                    b.Property<string>("Residence");

                    b.Property<string>("WeaponOfChoice");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("lotr.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsImmortal");

                    b.Property<string>("PrimaryLanguage");

                    b.Property<string>("RaceName");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });
#pragma warning restore 612, 618
        }
    }
}