﻿// <auto-generated />
using System;
using Dashboard_iSupport.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dashboard_iSupport.Migrations
{
    [DbContext(typeof(iSupportDbContext))]
    partial class iSupportDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dashboard_iSupport.Models.ApplicationName", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Application")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ApplicationName");
                });

            modelBuilder.Entity("Dashboard_iSupport.Models.Error", b =>
                {
                    b.Property<int>("EID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Error_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SID")
                        .HasColumnType("int");

                    b.HasKey("EID");

                    b.ToTable("Error");
                });

            modelBuilder.Entity("Dashboard_iSupport.Models.SubCategory", b =>
                {
                    b.Property<int>("SID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Sub_Category")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SID");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("Dashboard_iSupport.Models.iSupportData", b =>
                {
                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Actual_Person_Handling_the_ticket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Application_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Assignee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Count_of_Errors")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date_Closed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Error_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Missing_Ticket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason_for_Escalation_to_the_SME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status_Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sub_Categorization_of_Error")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TAT")
                        .HasColumnType("float");

                    b.Property<double>("Time_Open__Min_")
                        .HasColumnType("float");

                    b.HasKey("Number");

                    b.ToTable("iSupportData");
                });
#pragma warning restore 612, 618
        }
    }
}