﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxiBookingApp.Infrastucture.Data;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TaxiBookingApp.Infrastucture.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dea1286-c198-4129-b3f3-b89d839581",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4f37492f-07eb-4886-9372-564c934ac995",
                            Email = "agent@mail.com",
                            EmailConfirmed = false,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "agent@mail.com",
                            NormalizedUserName = "agent@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAELPMop1QtiCzxPB11aX6W96G2L9bvyFFuamuKRL62q8JrAUCvrR7eT/ZFckvIClBBA==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "agent@mail.com"
                        },
                        new
                        {
                            Id = "6d5800-d726-4fc8-83d9-d6b3ac1f582e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e545edc6-0aae-43f9-a744-034083252a22",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            IsActive = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEMcMCZbYdUMutGvhRt0HOuPvmgQovibKFu+lSodD8oZtsbYddelRsCmNYvpbOU7C7Q==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        });
                });

            modelBuilder.Entity("TaxiBookingApp.Infrastucture.Data.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorieses");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "InerCitySingle"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "InerCityShared"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "OneWayLocal"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "RoundTripLocal"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Luxury"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Charter"
                        });
                });

            modelBuilder.Entity("TaxiBookingApp.Infrastucture.Data.DriverCar", b =>
                {
                    b.Property<int>("DriverCarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DriverCarId"), 1L, 1);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DriverCarId");

                    b.HasIndex("UserId");

                    b.ToTable("DriversCars");

                    b.HasData(
                        new
                        {
                            DriverCarId = 1,
                            PhoneNumber = "00359123456",
                            UserId = "dea1286-c198-4129-b3f3-b89d839581"
                        });
                });

            modelBuilder.Entity("TaxiBookingApp.Infrastucture.Data.Office", b =>
                {
                    b.Property<string>("OfficeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OfficeImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OfficeId");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            OfficeId = "1",
                            City = "Plovdiv",
                            Country = "Bulgaria",
                            IsActive = true,
                            OfficeImageUrl = "https://media.istockphoto.com/photos/outside-view-of-a-office-building-with-blue-windows-picture-id157439187",
                            Phone = "0035932111111"
                        },
                        new
                        {
                            OfficeId = "2",
                            City = "Plovdiv",
                            Country = "Sofia",
                            IsActive = true,
                            OfficeImageUrl = "https://th.bing.com/th/id/R.ea2068b541126d4df2a90dda8af3a849?rik=R7U0u2Gyiwjx6g&riu=http%3a%2f%2fwww.theboutiqueoffice.com%2fwp-content%2fuploads%2f2015%2f04%2fAked-Esplanad-For-Rent-in-Bukit-Jalil-03.png&ehk=4yTgJ6%2ftN%2f8PkOiP%2fsuwRbu2Qse0NDJ6p5QeCndFGeY%3d&risl=&pid=ImgRaw&r=0",
                            Phone = "0035932111111"
                        },
                        new
                        {
                            OfficeId = "3",
                            City = "Wien",
                            Country = "Austria",
                            IsActive = true,
                            OfficeImageUrl = "https://www.s2architecture.com/uploads/gallery/Truman-Office-Building/02.jpg",
                            Phone = "00431111111"
                        },
                        new
                        {
                            OfficeId = "4",
                            City = "Paris",
                            Country = "France",
                            IsActive = true,
                            OfficeImageUrl = "https://th.bing.com/th/id/R.71dc3e07a5b246f95b10290d63d07d76?rik=Evh2RFKPJOVltA&riu=http%3a%2f%2fwww.buildingbutler.com%2fimages%2fgallery%2flarge%2fbuilding-facades-3463-13832.jpg&ehk=DVp9ap9ScbrjzkKQi9SLz9RYrm82XS8RqsUgwYwmmSw%3d&risl=&pid=ImgRaw&r=0",
                            Phone = "00336111111"
                        });
                });

            modelBuilder.Entity("TaxiBookingApp.Infrastucture.Data.TaxiRoute", b =>
                {
                    b.Property<int>("TaxiRouteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaxiRouteId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("DriverCarId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrlRouteGoogleMaps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("OfficeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PickUpAddress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("money");

                    b.Property<string>("RenterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TaxiRouteId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DriverCarId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("RenterId");

                    b.ToTable("TaxiRoutes");

                    b.HasData(
                        new
                        {
                            TaxiRouteId = 11,
                            CategoryId = 5,
                            DeliveryAddress = "Bulgaria, Sofia, Bul, Alexander malinov, 78",
                            Description = "Wheather you want a tourist tour from Plovdiv to Sofia, or simply buizness trip, this trip is private with a luxary limousine",
                            DriverCarId = 1,
                            ImageUrlRouteGoogleMaps = "https://le-cdn.hibuwebsites.com/8978d127e39b497da77df2a4b91f33eb/dms3rep/multi/opt/RSshutterstock_120889072-1920w.jpg",
                            IsActive = true,
                            OfficeId = "1",
                            PickUpAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                            Price = 316.80m,
                            RenterId = "6d5800-d726-4fc8-83d9-d6b3ac1f582e",
                            Title = "Pivate Luxury"
                        },
                        new
                        {
                            TaxiRouteId = 22,
                            CategoryId = 2,
                            DeliveryAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                            Description = "Wheather you want a tourist tour from Sofia to Plovdiv, or simply buizness trip, this trip is private with a luxary limousine",
                            DriverCarId = 1,
                            ImageUrlRouteGoogleMaps = "https://content.fortune.com/wp-content/uploads/2014/09/170030873.jpg?resize=1200,600",
                            IsActive = true,
                            OfficeId = "2",
                            PickUpAddress = "Bulgaria, Sofia, Bul, Alexander malinov, 78",
                            Price = 316.80m,
                            Title = "Sared"
                        },
                        new
                        {
                            TaxiRouteId = 33,
                            CategoryId = 2,
                            DeliveryAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                            Description = "Wheather you want a tourist tour from Sofia to Plovdiv, or simply buizness trip, this trip is private with a luxary limousine",
                            DriverCarId = 1,
                            ImageUrlRouteGoogleMaps = "https://bulgaria-infoguide.com/wp-content/uploads/2018/10/green-taxi-1024x768.jpg",
                            IsActive = true,
                            OfficeId = "2",
                            PickUpAddress = "Bulgaria, Sofia, Bul, Alexander malinov, 78",
                            Price = 158.40m,
                            Title = "Sared with One"
                        },
                        new
                        {
                            TaxiRouteId = 44,
                            CategoryId = 3,
                            DeliveryAddress = "Antique Theartre, str. Tsar Ivaylo 4, Plovdiv, Bulgaria",
                            Description = "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine",
                            DriverCarId = 1,
                            ImageUrlRouteGoogleMaps = "https://ekotaxi.bg/wp-content/uploads/2020/03/single_cab_redone-min-1-2048x1536.png",
                            IsActive = true,
                            OfficeId = "1",
                            PickUpAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                            Price = 6.20m,
                            Title = "OneWayLocal"
                        },
                        new
                        {
                            TaxiRouteId = 55,
                            CategoryId = 4,
                            DeliveryAddress = "Antique Theartre, str. Tsar Ivaylo 4, Plovdiv, Bulgaria",
                            Description = "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine",
                            DriverCarId = 1,
                            ImageUrlRouteGoogleMaps = "https://content.fortune.com/wp-content/uploads/2014/09/170030873.jpg?resize=1200,600",
                            IsActive = true,
                            OfficeId = "1",
                            PickUpAddress = "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31",
                            Price = 10.20m,
                            Title = "RoundTripLocal"
                        },
                        new
                        {
                            TaxiRouteId = 66,
                            CategoryId = 6,
                            DeliveryAddress = "Hartmann Road, London E16 2PX",
                            Description = "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine",
                            DriverCarId = 1,
                            ImageUrlRouteGoogleMaps = "https://th.bing.com/th/id/R.4f634d4c26e3f1a1cda6459f649713d1?rik=GYIFZQe3lUWPJA&pid=ImgRaw&r=0",
                            IsActive = true,
                            OfficeId = "1",
                            PickUpAddress = "Krumovo 4009, Rodopi Municipality, Plovdiv District",
                            Price = 10.20m,
                            Title = "Charter"
                        });
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
                    b.HasOne("TaxiBookingApp.Infrastucture.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TaxiBookingApp.Infrastucture.Data.ApplicationUser", null)
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

                    b.HasOne("TaxiBookingApp.Infrastucture.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TaxiBookingApp.Infrastucture.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaxiBookingApp.Infrastucture.Data.DriverCar", b =>
                {
                    b.HasOne("TaxiBookingApp.Infrastucture.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaxiBookingApp.Infrastucture.Data.TaxiRoute", b =>
                {
                    b.HasOne("TaxiBookingApp.Infrastucture.Data.Category", "Category")
                        .WithMany("TaxiRoutes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaxiBookingApp.Infrastucture.Data.DriverCar", "DriverCar")
                        .WithMany()
                        .HasForeignKey("DriverCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaxiBookingApp.Infrastucture.Data.Office", "Office")
                        .WithMany("TaxiRoutes")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaxiBookingApp.Infrastucture.Data.ApplicationUser", "Renter")
                        .WithMany()
                        .HasForeignKey("RenterId");

                    b.Navigation("Category");

                    b.Navigation("DriverCar");

                    b.Navigation("Office");

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("TaxiBookingApp.Infrastucture.Data.Category", b =>
                {
                    b.Navigation("TaxiRoutes");
                });

            modelBuilder.Entity("TaxiBookingApp.Infrastucture.Data.Office", b =>
                {
                    b.Navigation("TaxiRoutes");
                });
#pragma warning restore 612, 618
        }
    }
}
