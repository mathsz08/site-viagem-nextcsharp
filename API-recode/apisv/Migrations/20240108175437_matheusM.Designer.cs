﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Usuarios.Data;

#nullable disable

namespace apisv.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240108175437_matheusM")]
    partial class matheusM
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Usuarios.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Usuario_genre");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Usuario_name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("Usuario_price");

                    b.Property<string>("UsuarioURL")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Usuario_url");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "RPG",
                            Name = "The Witcher 3",
                            Price = 59.99m,
                            UsuarioURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "RPG",
                            Name = "The Witcher 2",
                            Price = 19.99m,
                            UsuarioURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "RPG",
                            Name = "The Witcher 1",
                            Price = 9.99m,
                            UsuarioURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "RPG",
                            Name = "The Witcher 3",
                            Price = 59.99m,
                            UsuarioURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}