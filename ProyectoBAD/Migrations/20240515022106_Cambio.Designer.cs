﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoBAD.Models;

#nullable disable

namespace ProyectoBAD.Migrations
{
    [DbContext(typeof(sisencuestasContext))]
    [Migration("20240515022106_Cambio")]
    partial class Cambio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProyectoBAD.Models.Encuestado", b =>
                {
                    b.Property<int>("IdEncuestado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_ENCUESTADO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEncuestado"), 1L, 1);

                    b.Property<string>("EmailEncuestado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("EMAIL_ENCUESTADO");

                    b.Property<DateTime>("FechaNacEncuesta")
                        .HasColumnType("datetime")
                        .HasColumnName("FECHA_NAC_ENCUESTA");

                    b.Property<string>("GenEncuestado")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("GEN_ENCUESTADO")
                        .IsFixedLength();

                    b.HasKey("IdEncuestado");

                    b.ToTable("ENCUESTADO", (string)null);
                });

            modelBuilder.Entity("ProyectoBAD.Models.Encuestum", b =>
                {
                    b.Property<int>("IdEncuesta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_ENCUESTA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEncuesta"), 1L, 1);

                    b.Property<bool?>("EstadoEncuesta")
                        .HasColumnType("bit")
                        .HasColumnName("ESTADO_ENCUESTA");

                    b.Property<DateTime?>("FechaEncuesta")
                        .HasColumnType("datetime")
                        .HasColumnName("FECHA_ENCUESTA");

                    b.Property<string>("GrupometaEncuesta")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("GRUPOMETA_ENCUESTA");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ID_USUARIO");

                    b.Property<string>("IndicacionesEncuesta")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("INDICACIONES_ENCUESTA");

                    b.Property<string>("ObjetivoEncuesta")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("OBJETIVO_ENCUESTA");

                    b.Property<string>("TituloEncuesta")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("TITULO_ENCUESTA");

                    b.HasKey("IdEncuesta");

                    b.HasIndex(new[] { "IdUsuario" }, "USUARIO_ENCUESTA_FK");

                    b.ToTable("ENCUESTA", (string)null);
                });

            modelBuilder.Entity("ProyectoBAD.Models.Opcionpreguntum", b =>
                {
                    b.Property<int>("OpcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OPCION_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OpcionId"), 1L, 1);

                    b.Property<string>("DescripcionOpcion")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("DESCRIPCION_OPCION");

                    b.Property<bool?>("EstadoOpcion")
                        .HasColumnType("bit")
                        .HasColumnName("ESTADO_OPCION");

                    b.Property<int?>("IdPregunta")
                        .HasColumnType("int")
                        .HasColumnName("ID_PREGUNTA");

                    b.Property<int?>("OrdenOpcion")
                        .HasColumnType("int")
                        .HasColumnName("ORDEN_OPCION");

                    b.Property<string>("ValorOpcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("VALOR_OPCION");

                    b.HasKey("OpcionId");

                    b.HasIndex(new[] { "IdPregunta" }, "REL_PREGUNTA_OPCIONPREGUNTA_FK");

                    b.ToTable("OPCIONPREGUNTA", (string)null);
                });

            modelBuilder.Entity("ProyectoBAD.Models.Preguntum", b =>
                {
                    b.Property<int>("IdPregunta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PREGUNTA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPregunta"), 1L, 1);

                    b.Property<string>("DescripcionPregunta")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("DESCRIPCION_PREGUNTA");

                    b.Property<int?>("IdEncuesta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ENCUESTA");

                    b.Property<int>("OrdenPregunta")
                        .HasColumnType("int")
                        .HasColumnName("ORDEN_PREGUNTA");

                    b.Property<bool?>("RequeridaPregunta")
                        .HasColumnType("bit")
                        .HasColumnName("REQUERIDA_PREGUNTA");

                    b.Property<int?>("TipoPreguntaId")
                        .HasColumnType("int")
                        .HasColumnName("TIPO_PREGUNTA_ID");

                    b.HasKey("IdPregunta");

                    b.HasIndex(new[] { "IdEncuesta" }, "REL_ENCUESTA_PREGUNTA_FK");

                    b.HasIndex(new[] { "TipoPreguntaId" }, "REL_TIPOPREGUNTA_PREGUNTA_FK");

                    b.ToTable("PREGUNTA", (string)null);
                });

            modelBuilder.Entity("ProyectoBAD.Models.Respuestum", b =>
                {
                    b.Property<int>("RespuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RESPUESTA_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RespuestaId"), 1L, 1);

                    b.Property<DateTime?>("FechaRespuesta")
                        .HasColumnType("datetime")
                        .HasColumnName("FECHA_RESPUESTA");

                    b.Property<int?>("IdEncuesta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ENCUESTA");

                    b.Property<int?>("IdEncuestado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ENCUESTADO");

                    b.Property<int?>("IdPregunta")
                        .HasColumnType("int")
                        .HasColumnName("ID_PREGUNTA");

                    b.Property<int?>("OpcionId")
                        .HasColumnType("int")
                        .HasColumnName("OPCION_ID");

                    b.Property<string>("TextoRespuesta")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("TEXTO_RESPUESTA");

                    b.HasKey("RespuestaId");

                    b.HasIndex(new[] { "IdEncuesta" }, "RELATIONSHIP_7_FK");

                    b.HasIndex(new[] { "IdEncuestado" }, "REL_ENCUESTADO_RESPUESTA_FK");

                    b.HasIndex(new[] { "OpcionId" }, "REL_RESPUESTA_OPCIONPREGUNTA_FK");

                    b.HasIndex(new[] { "IdPregunta" }, "REL_RESPUESTA_PREGUNTA_FK");

                    b.ToTable("RESPUESTA", (string)null);
                });

            modelBuilder.Entity("ProyectoBAD.Models.Tipopreguntum", b =>
                {
                    b.Property<int>("TipoPreguntaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TIPO_PREGUNTA_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoPreguntaId"), 1L, 1);

                    b.Property<string>("DescripcionTipoPregunta")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("DESCRIPCION_TIPO_PREGUNTA");

                    b.Property<string>("NombreTipoPregunta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("NOMBRE_TIPO_PREGUNTA");

                    b.HasKey("TipoPreguntaId");

                    b.ToTable("TIPOPREGUNTA", (string)null);
                });

            modelBuilder.Entity("ProyectoBAD.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ID_USUARIO");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("EMAIL_USUARIO");

                    b.Property<string>("GenUsuario")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("GEN_USUARIO")
                        .IsFixedLength();

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PrimerApellidoUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("PRIMER_APELLIDO_USUARIO");

                    b.Property<string>("PrimerNombreUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("PRIMER_NOMBRE_USUARIO");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellidoUsuario")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("SEGUNDO_APELLIDO_USUARIO");

                    b.Property<string>("SegundoNombreUsuario")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("SEGUNDO_NOMBRE_USUARIO");

                    b.Property<string>("TelefonoUsuario")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("TELEFONO_USUARIO");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("USUARIO", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProyectoBAD.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProyectoBAD.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoBAD.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProyectoBAD.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectoBAD.Models.Encuestum", b =>
                {
                    b.HasOne("ProyectoBAD.Models.Usuario", "IdUsuarioNavigation")
                        .WithMany("Encuesta")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK_ENCUESTA_USUARIO_E_USUARIO");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("ProyectoBAD.Models.Opcionpreguntum", b =>
                {
                    b.HasOne("ProyectoBAD.Models.Preguntum", "IdPreguntaNavigation")
                        .WithMany("Opcionpregunta")
                        .HasForeignKey("IdPregunta")
                        .HasConstraintName("FK_OPCIONPR_REL_PREGU_PREGUNTA");

                    b.Navigation("IdPreguntaNavigation");
                });

            modelBuilder.Entity("ProyectoBAD.Models.Preguntum", b =>
                {
                    b.HasOne("ProyectoBAD.Models.Encuestum", "IdEncuestaNavigation")
                        .WithMany("Pregunta")
                        .HasForeignKey("IdEncuesta")
                        .HasConstraintName("FK_PREGUNTA_REL_ENCUE_ENCUESTA");

                    b.HasOne("ProyectoBAD.Models.Tipopreguntum", "TipoPregunta")
                        .WithMany("Pregunta")
                        .HasForeignKey("TipoPreguntaId")
                        .HasConstraintName("FK_PREGUNTA_REL_TIPOP_TIPOPREG");

                    b.Navigation("IdEncuestaNavigation");

                    b.Navigation("TipoPregunta");
                });

            modelBuilder.Entity("ProyectoBAD.Models.Respuestum", b =>
                {
                    b.HasOne("ProyectoBAD.Models.Encuestum", "IdEncuestaNavigation")
                        .WithMany("Respuesta")
                        .HasForeignKey("IdEncuesta")
                        .HasConstraintName("FK_RESPUEST_RELATIONS_ENCUESTA");

                    b.HasOne("ProyectoBAD.Models.Encuestado", "IdEncuestadoNavigation")
                        .WithMany("Respuesta")
                        .HasForeignKey("IdEncuestado")
                        .HasConstraintName("FK_RESPUEST_REL_ENCUE_ENCUESTA");

                    b.HasOne("ProyectoBAD.Models.Preguntum", "IdPreguntaNavigation")
                        .WithMany("Respuesta")
                        .HasForeignKey("IdPregunta")
                        .HasConstraintName("FK_RESPUEST_REL_RESPU_PREGUNTA");

                    b.HasOne("ProyectoBAD.Models.Opcionpreguntum", "Opcion")
                        .WithMany("Respuesta")
                        .HasForeignKey("OpcionId")
                        .HasConstraintName("FK_RESPUEST_REL_RESPU_OPCIONPR");

                    b.Navigation("IdEncuestaNavigation");

                    b.Navigation("IdEncuestadoNavigation");

                    b.Navigation("IdPreguntaNavigation");

                    b.Navigation("Opcion");
                });

            modelBuilder.Entity("ProyectoBAD.Models.Encuestado", b =>
                {
                    b.Navigation("Respuesta");
                });

            modelBuilder.Entity("ProyectoBAD.Models.Encuestum", b =>
                {
                    b.Navigation("Pregunta");

                    b.Navigation("Respuesta");
                });

            modelBuilder.Entity("ProyectoBAD.Models.Opcionpreguntum", b =>
                {
                    b.Navigation("Respuesta");
                });

            modelBuilder.Entity("ProyectoBAD.Models.Preguntum", b =>
                {
                    b.Navigation("Opcionpregunta");

                    b.Navigation("Respuesta");
                });

            modelBuilder.Entity("ProyectoBAD.Models.Tipopreguntum", b =>
                {
                    b.Navigation("Pregunta");
                });

            modelBuilder.Entity("ProyectoBAD.Models.Usuario", b =>
                {
                    b.Navigation("Encuesta");
                });
#pragma warning restore 612, 618
        }
    }
}
