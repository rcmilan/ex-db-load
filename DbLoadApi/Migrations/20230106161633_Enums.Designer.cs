﻿// <auto-generated />
using System;
using DbLoadApi.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbLoadApi.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230106161633_Enums")]
    partial class Enums
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DbLoadApi.Entities.Enchantment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("WeaponId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("WeaponId");

                    b.ToTable("Enchantment");
                });

            modelBuilder.Entity("DbLoadApi.Entities.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Resistance")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("DbLoadApi.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("DbLoadApi.Entities.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Weapon");
                });

            modelBuilder.Entity("DbLoadApi.Entities.Enchantment", b =>
                {
                    b.HasOne("DbLoadApi.Entities.Equipment", null)
                        .WithMany("Enchantments")
                        .HasForeignKey("EquipmentId");

                    b.HasOne("DbLoadApi.Entities.Weapon", null)
                        .WithMany("Enchantments")
                        .HasForeignKey("WeaponId");
                });

            modelBuilder.Entity("DbLoadApi.Entities.Player", b =>
                {
                    b.OwnsMany("DbLoadApi.Entities.PlayerEquipmentInventory", "EquipmentInventory", b1 =>
                        {
                            b1.Property<int>("PlayerId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            b1.Property<int>("InventoryId")
                                .HasColumnType("int");

                            b1.Property<bool>("IsActive")
                                .HasColumnType("tinyint(1)");

                            b1.HasKey("PlayerId", "Id");

                            b1.HasIndex("InventoryId");

                            b1.ToTable("PlayerEquipmentInventory");

                            b1.HasOne("DbLoadApi.Entities.Equipment", "Inventory")
                                .WithMany()
                                .HasForeignKey("InventoryId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.WithOwner()
                                .HasForeignKey("PlayerId");

                            b1.Navigation("Inventory");
                        });

                    b.OwnsMany("DbLoadApi.Entities.PlayerWeaponInventory", "WeaponInventory", b1 =>
                        {
                            b1.Property<int>("PlayerId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            b1.Property<int>("InventoryId")
                                .HasColumnType("int");

                            b1.Property<bool>("IsActive")
                                .HasColumnType("tinyint(1)");

                            b1.HasKey("PlayerId", "Id");

                            b1.HasIndex("InventoryId");

                            b1.ToTable("PlayerWeaponInventory");

                            b1.HasOne("DbLoadApi.Entities.Weapon", "Inventory")
                                .WithMany()
                                .HasForeignKey("InventoryId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.WithOwner()
                                .HasForeignKey("PlayerId");

                            b1.Navigation("Inventory");
                        });

                    b.Navigation("EquipmentInventory");

                    b.Navigation("WeaponInventory");
                });

            modelBuilder.Entity("DbLoadApi.Entities.Equipment", b =>
                {
                    b.Navigation("Enchantments");
                });

            modelBuilder.Entity("DbLoadApi.Entities.Weapon", b =>
                {
                    b.Navigation("Enchantments");
                });
#pragma warning restore 612, 618
        }
    }
}
