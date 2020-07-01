﻿// <auto-generated />
using System;
using If.Itc.Integrations.Web.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace If.Itc.Integrations.Web.Migrations
{
    [DbContext(typeof(IntegrationsDbContext))]
    partial class IntegrationsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0-preview1.19506.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("If.Itc.Integrations.Web.Context.Asset", b =>
                {
                    b.Property<string>("AssetCode")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("AssetName")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("ResponsibleEmail")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("AssetCode");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("If.Itc.Integrations.Web.Context.Environment", b =>
                {
                    b.Property<string>("EnvironmentCode")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnvironmentCode");

                    b.ToTable("Environments");
                });

            modelBuilder.Entity("If.Itc.Integrations.Web.Context.Integration", b =>
                {
                    b.Property<Guid>("IntegrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("AssetCode")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("AssetCode1")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("CallerSenderCode")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("DataObject")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvironmentCode")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("EnvironmentCode1")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("IntegrationName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ProtocolCode")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("ProtocolCode1")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("ProviderReceiverCode")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2")
                        .HasMaxLength(150);

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IntegrationId");

                    b.HasIndex("AssetCode1");

                    b.HasIndex("EnvironmentCode1");

                    b.HasIndex("ProtocolCode1");

                    b.ToTable("Integrations");
                });

            modelBuilder.Entity("If.Itc.Integrations.Web.Context.Protocol", b =>
                {
                    b.Property<string>("ProtocolCode")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProtocolCode");

                    b.ToTable("Protocols");
                });

            modelBuilder.Entity("If.Itc.Integrations.Web.Context.Integration", b =>
                {
                    b.HasOne("If.Itc.Integrations.Web.Context.Asset", "Asset")
                        .WithMany("Integrations")
                        .HasForeignKey("AssetCode1");

                    b.HasOne("If.Itc.Integrations.Web.Context.Environment", "Environment")
                        .WithMany("Integrations")
                        .HasForeignKey("EnvironmentCode1");

                    b.HasOne("If.Itc.Integrations.Web.Context.Protocol", "Protocol")
                        .WithMany("Integrations")
                        .HasForeignKey("ProtocolCode1");
                });
#pragma warning restore 612, 618
        }
    }
}
