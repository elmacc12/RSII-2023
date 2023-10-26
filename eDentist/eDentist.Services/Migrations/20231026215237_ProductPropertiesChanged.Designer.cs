﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eDentist.Services.Database;

#nullable disable

namespace eDentist.Services.Migrations
{
    [DbContext(typeof(EDentistDbContext))]
    [Migration("20231026215237_ProductPropertiesChanged")]
    partial class ProductPropertiesChanged
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eDentist.Services.Database.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CityID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("CountryID");

                    b.HasKey("CityId")
                        .HasName("PK__City__F2D21A960A01C0F5");

                    b.HasIndex("CountryId");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("eDentist.Services.Database.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"));

                    b.Property<string>("ColorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("eDentist.Services.Database.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CountryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId")
                        .HasName("PK__Country__10D160BFBDD7D3F9");

                    b.ToTable("Country", (string)null);
                });

            modelBuilder.Entity("eDentist.Services.Database.DentalService", b =>
                {
                    b.Property<int>("DentalServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DentalServiceID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DentalServiceId"));

                    b.Property<string>("ServiceDescription")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("ServiceName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("ServicePrice")
                        .HasColumnType("int");

                    b.HasKey("DentalServiceId")
                        .HasName("PK__DentalSe__51B93F22BFED9684");

                    b.ToTable("DentalService", (string)null);
                });

            modelBuilder.Entity("eDentist.Services.Database.Favorite", b =>
                {
                    b.Property<int>("FavoriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FavoriteID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavoriteId"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("FavoriteId")
                        .HasName("PK__Favorite__CE74FAF579E6D7C9");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("eDentist.Services.Database.MedicalCard", b =>
                {
                    b.Property<int>("MedicalCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MedicalCardID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicalCardId"));

                    b.Property<int?>("DentalServiceId")
                        .HasColumnType("int")
                        .HasColumnName("DentalServiceID");

                    b.Property<string>("DoctorsOppinion")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("MedicalCardId")
                        .HasName("PK__MedicalC__931EC236004DC9A6");

                    b.HasIndex("DentalServiceId");

                    b.HasIndex("UserId");

                    b.ToTable("MedicalCard", (string)null);
                });

            modelBuilder.Entity("eDentist.Services.Database.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int?>("OrderHeaderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderHeaderID");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("ProductTotal")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId")
                        .HasName("PK__Orders__C3905BAF66B02537");

                    b.HasIndex("OrderHeaderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eDentist.Services.Database.OrderHeader", b =>
                {
                    b.Property<int>("OrderHeaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderHeaderID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderHeaderId"));

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("date");

                    b.Property<int?>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("OrderHeaderId")
                        .HasName("PK__OrderHea__4BEA0BF490A2A873");

                    b.HasIndex("UserId");

                    b.ToTable("OrderHeader", (string)null);
                });

            modelBuilder.Entity("eDentist.Services.Database.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("ColorID")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int")
                        .HasColumnName("ProductTypeID");

                    b.Property<int?>("QuantityLeft")
                        .HasColumnType("int");

                    b.Property<string>("StateMachine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId")
                        .HasName("PK__Products__B40CC6ED012064AE");

                    b.HasIndex("ColorID");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("eDentist.Services.Database.ProductType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"));

                    b.Property<string>("TypeName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("TypeId")
                        .HasName("PK__ProductT__516F0395CFF2B1F5");

                    b.ToTable("ProductType", (string)null);
                });

            modelBuilder.Entity("eDentist.Services.Database.Roles", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("eDentist.Services.Database.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int")
                        .HasColumnName("CityID");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ZIP_Code");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CCAC6A8E000D");

                    b.HasIndex("CityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("eDentist.Services.Database.UserRoles", b =>
                {
                    b.Property<int>("UserRoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleID"));

                    b.Property<DateTime>("ChangedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserRoleID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("eDentist.Services.Database.City", b =>
                {
                    b.HasOne("eDentist.Services.Database.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("fk_country_city");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("eDentist.Services.Database.Favorite", b =>
                {
                    b.HasOne("eDentist.Services.Database.Product", "Product")
                        .WithMany("Favorites")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_favorites_products");

                    b.HasOne("eDentist.Services.Database.User", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_favorites_users");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eDentist.Services.Database.MedicalCard", b =>
                {
                    b.HasOne("eDentist.Services.Database.DentalService", "DentalService")
                        .WithMany("MedicalCards")
                        .HasForeignKey("DentalServiceId")
                        .HasConstraintName("fk_service_card");

                    b.HasOne("eDentist.Services.Database.User", "User")
                        .WithMany("MedicalCards")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_medicalCard");

                    b.Navigation("DentalService");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eDentist.Services.Database.Order", b =>
                {
                    b.HasOne("eDentist.Services.Database.OrderHeader", "OrderHeader")
                        .WithMany("OrderOrderHeaders")
                        .HasForeignKey("OrderHeaderId")
                        .HasConstraintName("fk_order_orderheader");

                    b.HasOne("eDentist.Services.Database.OrderHeader", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_order_product");

                    b.Navigation("OrderHeader");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("eDentist.Services.Database.OrderHeader", b =>
                {
                    b.HasOne("eDentist.Services.Database.User", "User")
                        .WithMany("OrderHeaders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_user_order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eDentist.Services.Database.Product", b =>
                {
                    b.HasOne("eDentist.Services.Database.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentist.Services.Database.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .HasConstraintName("fk_product_type");

                    b.Navigation("Color");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("eDentist.Services.Database.User", b =>
                {
                    b.HasOne("eDentist.Services.Database.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId")
                        .HasConstraintName("pk_user_city");

                    b.Navigation("City");
                });

            modelBuilder.Entity("eDentist.Services.Database.UserRoles", b =>
                {
                    b.HasOne("eDentist.Services.Database.Roles", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentist.Services.Database.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eDentist.Services.Database.City", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("eDentist.Services.Database.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("eDentist.Services.Database.DentalService", b =>
                {
                    b.Navigation("MedicalCards");
                });

            modelBuilder.Entity("eDentist.Services.Database.OrderHeader", b =>
                {
                    b.Navigation("OrderOrderHeaders");

                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("eDentist.Services.Database.Product", b =>
                {
                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("eDentist.Services.Database.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("eDentist.Services.Database.User", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("MedicalCards");

                    b.Navigation("OrderHeaders");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
