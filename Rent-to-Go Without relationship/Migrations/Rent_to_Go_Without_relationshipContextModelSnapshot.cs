﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rent_to_Go_Without_relationship.Data;

namespace Rent_to_Go_Without_relationship.Migrations
{
    [DbContext(typeof(Rent_to_Go_Without_relationshipContext))]
    partial class Rent_to_Go_Without_relationshipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rent_to_Go_Without_relationship.Models.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agent_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agent_Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agent_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office_Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("Rent_to_Go_Without_relationship.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cust_Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cust_Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Rent_to_Go_Without_relationship.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Property_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property_Number_of_Bathrooms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property_Number_of_Bedrooms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Property_WeeklyRent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Property");
                });
#pragma warning restore 612, 618
        }
    }
}
