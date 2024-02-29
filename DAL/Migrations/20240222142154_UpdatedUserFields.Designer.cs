﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using megamart_api.Context;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(MegamartContext))]
    [Migration("20240222142154_UpdatedUserFields")]
    partial class UpdatedUserFields
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CategoryGood", b =>
                {
                    b.Property<string>("CategoriesId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("GoodsId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("CategoriesId", "GoodsId");

                    b.HasIndex("GoodsId");

                    b.ToTable("CategoryGood");
                });

            modelBuilder.Entity("Core.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasDefaultValue("ccbd1ccb-1bf0-4fa3-ba6a-dbe5fc45f6d8");

                    b.Property<string>("BackgroundColor")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("FFFFFF");

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("No description");

                    b.Property<string>("FontColor")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("000000");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("https://icons.veryicon.com/png/o/commerce-shopping/basic-icon-of-e-commerce/empty-21.png");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Core.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasDefaultValue("29fc45b1-a5fd-4062-9a0e-5a699f884a71");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 2, 22, 14, 21, 54, 786, DateTimeKind.Utc).AddTicks(5478));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePicUrl")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("https://www.freeiconspng.com/thumbs/no-image-icon/no-image-icon-15.png");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Core.Models.DeliveryAddress", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasDefaultValue("35ae939c-b219-4773-a0c3-efbd0416ca13");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EntryWay")
                        .HasColumnType("int");

                    b.Property<int>("FlatNumber")
                        .HasColumnType("int");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DeliveryAddresses");
                });

            modelBuilder.Entity("Core.Models.DeliveryMethod", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasDefaultValue("41d0e967-daa6-4103-9bf9-e5052ea59d85");

                    b.Property<string>("LogoUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("https://w7.pngwing.com/pngs/7/387/png-transparent-delivery-computer-icons-timely-delivery-miscellaneous-angle-text.png");

                    b.Property<int>("MinimalPrice")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DeliveryMethods");
                });

            modelBuilder.Entity("Core.Models.Good", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasDefaultValue("f673e8e4-4152-4f8a-b65a-09f85384e37c");

                    b.Property<int>("AvailabilityStatus")
                        .HasColumnType("int");

                    b.Property<int>("CreationStatus")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("SellerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("Core.Models.GoodOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("GoodId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("OptionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("GoodId");

                    b.ToTable("GoodOptions");
                });

            modelBuilder.Entity("Core.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasDefaultValue("0d2cb51d-0b20-4012-90b8-b1690dedc0d4");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 2, 22, 14, 21, 54, 787, DateTimeKind.Utc).AddTicks(2766));

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DeliveryAddressId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DeliveryMethodId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("OrderStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DeliveryAddressId");

                    b.HasIndex("DeliveryMethodId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Core.Models.OrderPosition", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasDefaultValue("d0e7d0bb-7935-4319-babd-cb7d814bd19c");

                    b.Property<string>("GoodId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("GoodId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderPositions");
                });

            modelBuilder.Entity("Core.Models.Seller", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasDefaultValue("6b31dfe0-1fd0-41c3-9be7-1d0ffe405961");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePicUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("WebsiteUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("CategoryGood", b =>
                {
                    b.HasOne("Core.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Good", null)
                        .WithMany()
                        .HasForeignKey("GoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Models.Good", b =>
                {
                    b.HasOne("Core.Models.Seller", "Seller")
                        .WithMany("Goods")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("Core.Models.GoodOption", b =>
                {
                    b.HasOne("Core.Models.Good", "Good")
                        .WithMany("GoodOptions")
                        .HasForeignKey("GoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Good");
                });

            modelBuilder.Entity("Core.Models.Order", b =>
                {
                    b.HasOne("Core.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.DeliveryAddress", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.DeliveryMethod", "DeliveryMethod")
                        .WithMany()
                        .HasForeignKey("DeliveryMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("DeliveryAddress");

                    b.Navigation("DeliveryMethod");
                });

            modelBuilder.Entity("Core.Models.OrderPosition", b =>
                {
                    b.HasOne("Core.Models.Good", "Good")
                        .WithMany()
                        .HasForeignKey("GoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Order", "Order")
                        .WithMany("OrderPositions")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Good");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Core.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Core.Models.Good", b =>
                {
                    b.Navigation("GoodOptions");
                });

            modelBuilder.Entity("Core.Models.Order", b =>
                {
                    b.Navigation("OrderPositions");
                });

            modelBuilder.Entity("Core.Models.Seller", b =>
                {
                    b.Navigation("Goods");
                });
#pragma warning restore 612, 618
        }
    }
}
