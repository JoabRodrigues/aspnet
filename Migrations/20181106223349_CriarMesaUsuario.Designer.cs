﻿// <auto-generated />
using FirstProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirstProject.Migrations
{
    [DbContext(typeof(FirstProjectContext))]
    [Migration("20181106223349_CriarMesaUsuario")]
    partial class CriarMesaUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FirstProject.Data.Mesa", b =>
                {
                    b.Property<int>("MesaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("MesaId");

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("FirstProject.Data.MesaUsuario", b =>
                {
                    b.Property<int>("MesaId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("MesaId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("MesasUsuarios");
                });

            modelBuilder.Entity("FirstProject.Data.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Numero");

                    b.Property<string>("Senha");

                    b.Property<int>("Tipo");

                    b.Property<string>("Uf");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("FirstProject.Data.MesaUsuario", b =>
                {
                    b.HasOne("FirstProject.Data.Mesa", "Mesa")
                        .WithMany("MesasUsuarios")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FirstProject.Data.Usuario", "Usuario")
                        .WithMany("MesasUsuarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
