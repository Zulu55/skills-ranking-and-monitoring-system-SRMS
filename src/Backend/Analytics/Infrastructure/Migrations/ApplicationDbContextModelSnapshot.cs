﻿// <auto-generated />
using System;
using Analytics.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Analytics.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Analytics.Infrastructure.Persistence.Models.LevelModel", b =>
                {
                    b.Property<Guid>("LevelId")
                        .HasColumnType("uuid")
                        .HasColumnName("rol_level_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)")
                        .HasColumnName("rol_description");

                    b.Property<bool>("Disabled")
                        .HasColumnType("boolean")
                        .HasColumnName("rol_disabled");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("rol_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("LevelId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("level");

                    b.HasData(
                        new
                        {
                            LevelId = new Guid("6857f7b0-0cb8-4f2d-b022-4dee55ce61db"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9397),
                            Disabled = false,
                            Name = "Backend"
                        },
                        new
                        {
                            LevelId = new Guid("ad9e8525-55e4-468e-a433-2897d98977d7"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9404),
                            Disabled = false,
                            Name = "Frontend"
                        },
                        new
                        {
                            LevelId = new Guid("3c19c0ce-5309-4343-b732-a34feacd7fdb"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9408),
                            Disabled = false,
                            Name = "Fullstack"
                        },
                        new
                        {
                            LevelId = new Guid("6a680d88-c0a7-43f5-8b5c-2d9872501156"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9412),
                            Disabled = false,
                            Name = "DevOps"
                        },
                        new
                        {
                            LevelId = new Guid("084d2830-bc7a-4661-898f-b6fdb637d4a4"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9416),
                            Disabled = false,
                            Name = "QA"
                        },
                        new
                        {
                            LevelId = new Guid("b6cabb2b-a19d-4d15-9bb8-1fc6a4b26901"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9421),
                            Disabled = false,
                            Name = "UX/UI"
                        },
                        new
                        {
                            LevelId = new Guid("5321c1c8-50f1-44ba-9b9c-4d4be3492675"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9425),
                            Disabled = false,
                            Name = "DataScience"
                        },
                        new
                        {
                            LevelId = new Guid("75715d56-0026-4894-af50-13d71e051914"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9429),
                            Disabled = false,
                            Name = "Cybersecurity"
                        },
                        new
                        {
                            LevelId = new Guid("84d04e2a-8fbb-4524-8cff-edd1712b3e1e"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9433),
                            Disabled = false,
                            Name = "Product"
                        },
                        new
                        {
                            LevelId = new Guid("b67bd192-d78e-455f-a78d-a26829f6473a"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9437),
                            Disabled = false,
                            Name = "Project"
                        },
                        new
                        {
                            LevelId = new Guid("00f2acaf-a65c-4681-9b0b-6c6dab9e7391"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9441),
                            Disabled = false,
                            Name = "Management"
                        },
                        new
                        {
                            LevelId = new Guid("10059232-c12b-41e3-a496-01c3f1515d1c"),
                            CreatedAt = new DateTime(2024, 4, 28, 6, 57, 55, 307, DateTimeKind.Utc).AddTicks(9445),
                            Disabled = false,
                            Name = "Other"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
