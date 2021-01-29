﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(DbContextClass))]
    partial class DbContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ModelLayer.Match", b =>
                {
                    b.Property<Guid>("matchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Player1playerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Player2playerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("p1RoundWins")
                        .HasColumnType("int");

                    b.Property<int>("p2RoundWins")
                        .HasColumnType("int");

                    b.Property<int>("ties")
                        .HasColumnType("int");

                    b.HasKey("matchId");

                    b.HasIndex("Player1playerId");

                    b.HasIndex("Player2playerId");

                    b.ToTable("matches");
                });

            modelBuilder.Entity("ModelLayer.Player", b =>
                {
                    b.Property<Guid>("playerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ByteArrayImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("numLosses")
                        .HasColumnType("int");

                    b.Property<int>("numWins")
                        .HasColumnType("int");

                    b.HasKey("playerId");

                    b.ToTable("players");
                });

            modelBuilder.Entity("ModelLayer.Round", b =>
                {
                    b.Property<Guid>("RoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MatchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Player1Choice")
                        .HasColumnType("int");

                    b.Property<int>("Player2Choice")
                        .HasColumnType("int");

                    b.Property<Guid?>("WinningPlayerplayerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoundId");

                    b.HasIndex("MatchId");

                    b.HasIndex("WinningPlayerplayerId");

                    b.ToTable("rounds");
                });

            modelBuilder.Entity("ModelLayer.Match", b =>
                {
                    b.HasOne("ModelLayer.Player", "Player1")
                        .WithMany()
                        .HasForeignKey("Player1playerId");

                    b.HasOne("ModelLayer.Player", "Player2")
                        .WithMany()
                        .HasForeignKey("Player2playerId");

                    b.Navigation("Player1");

                    b.Navigation("Player2");
                });

            modelBuilder.Entity("ModelLayer.Round", b =>
                {
                    b.HasOne("ModelLayer.Match", null)
                        .WithMany("Rounds")
                        .HasForeignKey("MatchId");

                    b.HasOne("ModelLayer.Player", "WinningPlayer")
                        .WithMany()
                        .HasForeignKey("WinningPlayerplayerId");

                    b.Navigation("WinningPlayer");
                });

            modelBuilder.Entity("ModelLayer.Match", b =>
                {
                    b.Navigation("Rounds");
                });
#pragma warning restore 612, 618
        }
    }
}
