﻿// <auto-generated />
using DB_Conection_Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB_Conection_Models.Migrations
{
    [DbContext(typeof(PCDbContext))]
    partial class PCDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB_Conection_Models.Models.PC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdComponent")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdComponent");

                    b.ToTable("PCs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdComponent = 1,
                            Name = "Cool Gamer"
                        });
                });

            modelBuilder.Entity("DB_Conection_Models.Models.PCComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Motherboard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCCase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerSupply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSDM2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PCComponents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Motherboard = "AsRock B550",
                            PCCase = "DeapCool",
                            PowerSupply = "Asus 600W",
                            Processor = "Amd Ryzen 5 3600",
                            RAM = "HyperX 2x16gb",
                            SSDM2 = "Sumsung 980gb",
                            VideoCard = "NVidia 3080"
                        });
                });

            modelBuilder.Entity("DB_Conection_Models.Models.PC", b =>
                {
                    b.HasOne("DB_Conection_Models.Models.PCComponent", "PCComponent")
                        .WithMany()
                        .HasForeignKey("IdComponent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PCComponent");
                });
#pragma warning restore 612, 618
        }
    }
}
