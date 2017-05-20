using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Cadastro;

namespace Cadastro.Migrations
{
    [DbContext(typeof(EntidadeContext))]
    [Migration("20170520174344_3")]
    partial class _3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cadastro.Cidade", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("estadoid");

                    b.Property<string>("nome");

                    b.HasKey("id");
                });

            modelBuilder.Entity("Cadastro.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cep");

                    b.Property<int>("cidadeid");

                    b.Property<string>("complemento");

                    b.Property<string>("cpfCnpj");

                    b.Property<DateTime>("dataNascimento");

                    b.Property<string>("email");

                    b.Property<string>("logradouro");

                    b.Property<string>("nome");

                    b.Property<string>("numero");

                    b.Property<string>("rgIe");

                    b.Property<string>("telefonePrincipal");

                    b.Property<string>("telefoneSecundario");

                    b.Property<string>("tipoPessoa");

                    b.HasKey("id");
                });

            modelBuilder.Entity("Cadastro.Estado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nome");

                    b.Property<string>("sigla");

                    b.HasKey("id");
                });

            modelBuilder.Entity("Cadastro.Cidade", b =>
                {
                    b.HasOne("Cadastro.Estado")
                        .WithMany()
                        .HasForeignKey("estadoid");
                });

            modelBuilder.Entity("Cadastro.Cliente", b =>
                {
                    b.HasOne("Cadastro.Cidade")
                        .WithMany()
                        .HasForeignKey("cidadeid");
                });
        }
    }
}
