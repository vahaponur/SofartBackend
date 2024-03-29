﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SofartBackend.DataAccess.EfCore.Concrete;

namespace SofartBackend.DataAccess.Migrations
{
    [DbContext(typeof(SofartDbContext))]
    partial class SofartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CreatorPost", b =>
                {
                    b.Property<int>("CreatorsId")
                        .HasColumnType("int");

                    b.Property<int>("PostsId")
                        .HasColumnType("int");

                    b.HasKey("CreatorsId", "PostsId");

                    b.HasIndex("PostsId");

                    b.ToTable("CreatorPost");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.SocialMedia.SocialAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialMediaTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SocialMediaTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("SocialAccounts");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.SocialMedia.SocialMediaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Svg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SocialMediaTypes");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.Creator", b =>
                {
                    b.HasBaseType("SofartBackend.Entities.Concrete.User");

                    b.HasDiscriminator().HasValue("Creator");
                });

            modelBuilder.Entity("CreatorPost", b =>
                {
                    b.HasOne("SofartBackend.Entities.Concrete.Creator", null)
                        .WithMany()
                        .HasForeignKey("CreatorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SofartBackend.Entities.Concrete.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.Image", b =>
                {
                    b.HasOne("SofartBackend.Entities.Concrete.Post", null)
                        .WithMany("Images")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.SocialMedia.SocialAccount", b =>
                {
                    b.HasOne("SofartBackend.Entities.Concrete.SocialMedia.SocialMediaType", "SocialMediaType")
                        .WithMany()
                        .HasForeignKey("SocialMediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SofartBackend.Entities.Concrete.User", null)
                        .WithMany("SocialAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SocialMediaType");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.User", b =>
                {
                    b.HasOne("SofartBackend.Entities.Concrete.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.Post", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("SofartBackend.Entities.Concrete.User", b =>
                {
                    b.Navigation("SocialAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
