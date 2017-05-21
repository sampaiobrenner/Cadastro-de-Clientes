using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Cadastro;

namespace Cadastro.Migrations
{
    [DbContext(typeof(EntidadeContext))]
    [Migration("20170521224159_4")]
    partial class _4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cadastro.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EstadoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Cadastro.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<int>("CidadeId");

                    b.Property<string>("Complemento");

                    b.Property<string>("CpfCnpj");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("RgIe");

                    b.Property<string>("TelefonePrincipal");

                    b.Property<string>("TelefoneSecundario");

                    b.Property<string>("TipoPessoa");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Cadastro.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Sigla");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Cadastro.Cidade", b =>
                {
                    b.HasOne("Cadastro.Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId");
                });

            modelBuilder.Entity("Cadastro.Cliente", b =>
                {
                    b.HasOne("Cadastro.Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId");
                });
        }
    }
}
