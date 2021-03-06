﻿// <auto-generated />
using System;
using Hogwarts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hogwarts.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191218090825_init1")]
    partial class init1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hogwarts.DB.Model.ApplicationIdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("IdentityRole");
                });

            modelBuilder.Entity("Hogwarts.DB.Model.ApplicationIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("RoleName");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("TId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserDescription");

                    b.Property<string>("UserFaceImgUrl");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("TId")
                        .IsUnique();

                    b.ToTable("IdentityUser");
                });

            modelBuilder.Entity("Hogwarts.DB.Model.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("classId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .HasColumnName("className")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Dean")
                        .HasColumnName("dean")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("ClassId");

                    b.ToTable("tb_class");
                });

            modelBuilder.Entity("Hogwarts.DB.Model.Course", b =>
                {
                    b.Property<int>("Cno")
                        .HasColumnName("cno");

                    b.Property<string>("CScore");

                    b.Property<string>("Cname")
                        .HasColumnName("cname")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("EnglishName");

                    b.HasKey("Cno");

                    b.ToTable("tb_course");
                });

            modelBuilder.Entity("Hogwarts.DB.Model.Sc", b =>
                {
                    b.Property<int>("Sno")
                        .HasColumnName("sno");

                    b.Property<int>("Cno")
                        .HasColumnName("cno");

                    b.Property<string>("Score")
                        .HasColumnName("score")
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<int>("Tid");

                    b.HasKey("Sno", "Cno");

                    b.HasIndex("Cno");

                    b.ToTable("tb_SC");
                });

            modelBuilder.Entity("Hogwarts.DB.Model.Student", b =>
                {
                    b.Property<int>("Sno")
                        .HasColumnName("sno");

                    b.Property<string>("Area");

                    b.Property<string>("Birthday")
                        .HasColumnName("birthday");

                    b.Property<string>("Character")
                        .HasColumnName("character")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("City");

                    b.Property<int?>("ClassId")
                        .HasColumnName("classId");

                    b.Property<string>("EnglishName");

                    b.Property<string>("Province");

                    b.Property<string>("Pwd")
                        .HasColumnName("pwd")
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<string>("Sex")
                        .HasColumnName("sex")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Sname")
                        .HasColumnName("sname")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("Year")
                        .HasColumnName("year");

                    b.HasKey("Sno");

                    b.HasIndex("ClassId");

                    b.ToTable("tb_student");
                });

            modelBuilder.Entity("Hogwarts.DB.Model.Teacher", b =>
                {
                    b.Property<int>("TId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Area");

                    b.Property<string>("Birthday")
                        .HasColumnName("birthday");

                    b.Property<string>("City");

                    b.Property<int?>("Cno")
                        .HasColumnName("cno")
                        .HasMaxLength(10);

                    b.Property<string>("EnglishName");

                    b.Property<string>("NickName");

                    b.Property<string>("Province");

                    b.Property<string>("Sex")
                        .HasColumnName("sex")
                        .HasMaxLength(10);

                    b.Property<string>("TName")
                        .HasColumnName("t_name")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("TId");

                    b.HasIndex("Cno");

                    b.ToTable("tb_teacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Hogwarts.DB.Model.ApplicationIdentityUser", b =>
                {
                    b.HasOne("Hogwarts.DB.Model.Teacher", "Teacher")
                        .WithOne("IdentityUser")
                        .HasForeignKey("Hogwarts.DB.Model.ApplicationIdentityUser", "TId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hogwarts.DB.Model.Sc", b =>
                {
                    b.HasOne("Hogwarts.DB.Model.Course", "CourseNavigation")
                        .WithMany("Sc")
                        .HasForeignKey("Cno")
                        .HasConstraintName("FK_tb_SC_tb_course")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hogwarts.DB.Model.Student", "StudentNavigation")
                        .WithMany("Sc")
                        .HasForeignKey("Sno")
                        .HasConstraintName("FK_tb_SC_tb_student")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hogwarts.DB.Model.Student", b =>
                {
                    b.HasOne("Hogwarts.DB.Model.Class", "ClassNavigation")
                        .WithMany("TbStudent")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK_tb_student_tb_class")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hogwarts.DB.Model.Teacher", b =>
                {
                    b.HasOne("Hogwarts.DB.Model.Course", "Course")
                        .WithMany("Teachers")
                        .HasForeignKey("Cno")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Hogwarts.DB.Model.ApplicationIdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Hogwarts.DB.Model.ApplicationIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Hogwarts.DB.Model.ApplicationIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Hogwarts.DB.Model.ApplicationIdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hogwarts.DB.Model.ApplicationIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Hogwarts.DB.Model.ApplicationIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
