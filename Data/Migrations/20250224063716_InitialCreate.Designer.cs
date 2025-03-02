﻿// <auto-generated />
using System;
using BlazorScoreAppPostgre.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlazorScoreAppPostgre.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250224063716_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlazorScoreAppPostgre.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BlazorScoreAppPostgre.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("integer")
                        .HasColumnName("PlayerID");

                    b.Property<string>("LoginUserId")
                        .HasColumnType("text")
                        .HasColumnName("LoginUserID");

                    b.Property<string>("PlayerName")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("PlayerName");

                    b.HasKey("PlayerId");

                    b.HasIndex("PlayerName")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("BlazorScoreAppPostgre.Models.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("TableID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TableId"));

                    b.Property<string>("LoginUserId")
                        .HasColumnType("text")
                        .HasColumnName("LoginUserID");

                    b.Property<int?>("Rank")
                        .HasColumnType("integer")
                        .HasColumnName("Rank");

                    b.Property<int?>("Score")
                        .HasColumnType("integer")
                        .HasColumnName("Score");

                    b.Property<int>("TableCountId")
                        .HasColumnType("integer")
                        .HasColumnName("TableCountID");

                    b.Property<int>("TrialSeatId")
                        .HasColumnType("integer")
                        .HasColumnName("TrialSeatID");

                    b.HasKey("TableId");

                    b.HasIndex("TrialSeatId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("BlazorScoreAppPostgre.Models.Trial", b =>
                {
                    b.Property<int>("TrialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("TrialID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TrialId"));

                    b.Property<string>("BonusByRanking")
                        .HasColumnType("text")
                        .HasColumnName("BonusByRanking");

                    b.Property<int?>("ChipsPrice")
                        .HasColumnType("integer")
                        .HasColumnName("ChipsPrice");

                    b.Property<string>("LoginUserId")
                        .HasColumnType("text")
                        .HasColumnName("LoginUserID");

                    b.Property<string>("StartReturn")
                        .HasColumnType("text")
                        .HasColumnName("StartReturn");

                    b.Property<int?>("TobiPrice")
                        .HasColumnType("integer")
                        .HasColumnName("TobiPrice");

                    b.Property<DateTime?>("TrialDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("TrialDateTime");

                    b.Property<int?>("YakitoriPrice")
                        .HasColumnType("integer")
                        .HasColumnName("YakitoriPrice");

                    b.Property<int?>("YakumanPrice")
                        .HasColumnType("integer")
                        .HasColumnName("YakumanPrice");

                    b.HasKey("TrialId");

                    b.ToTable("Trials");
                });

            modelBuilder.Entity("BlazorScoreAppPostgre.Models.TrialSeat", b =>
                {
                    b.Property<int>("TrialSeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("TrialSeatID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TrialSeatId"));

                    b.Property<string>("LoginUserId")
                        .HasColumnType("text")
                        .HasColumnName("LoginUserID");

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer")
                        .HasColumnName("PlayerID");

                    b.Property<int>("SeatId")
                        .HasColumnType("integer")
                        .HasColumnName("SeatID");

                    b.Property<int>("TrialId")
                        .HasColumnType("integer")
                        .HasColumnName("TrialID");

                    b.HasKey("TrialSeatId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TrialId");

                    b.ToTable("TrialSeats");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BlazorScoreAppPostgre.Models.Table", b =>
                {
                    b.HasOne("BlazorScoreAppPostgre.Models.TrialSeat", "TrialSeat")
                        .WithMany("Tables")
                        .HasForeignKey("TrialSeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrialSeat");
                });

            modelBuilder.Entity("BlazorScoreAppPostgre.Models.TrialSeat", b =>
                {
                    b.HasOne("BlazorScoreAppPostgre.Models.Player", "Player")
                        .WithMany("TrialSeats")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorScoreAppPostgre.Models.Trial", "Trial")
                        .WithMany("TrialSeats")
                        .HasForeignKey("TrialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Trial");
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
                    b.HasOne("BlazorScoreAppPostgre.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BlazorScoreAppPostgre.Data.ApplicationUser", null)
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

                    b.HasOne("BlazorScoreAppPostgre.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BlazorScoreAppPostgre.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorScoreAppPostgre.Models.Player", b =>
                {
                    b.Navigation("TrialSeats");
                });

            modelBuilder.Entity("BlazorScoreAppPostgre.Models.Trial", b =>
                {
                    b.Navigation("TrialSeats");
                });

            modelBuilder.Entity("BlazorScoreAppPostgre.Models.TrialSeat", b =>
                {
                    b.Navigation("Tables");
                });
#pragma warning restore 612, 618
        }
    }
}
