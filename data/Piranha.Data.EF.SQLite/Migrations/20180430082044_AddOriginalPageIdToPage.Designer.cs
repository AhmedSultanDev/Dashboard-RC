﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Piranha;
using Piranha.Models;
using System;

namespace Piranha.Data.EF.SQLite.Migrations
{
    [NoCoverage]
    [DbContext(typeof(SQLiteDb))]
    [Migration("20180430082044_AddOriginalPageIdToPage")]
    partial class AddOriginalPageIdToPage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Piranha.Data.Alias", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AliasUrl")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("RedirectUrl")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<Guid>("SiteId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SiteId", "AliasUrl")
                        .IsUnique();

                    b.ToTable("Piranha_Aliases");
                });

            modelBuilder.Entity("Piranha.Data.Block", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CLRType")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsReusable");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Title")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Piranha_Blocks");
                });

            modelBuilder.Entity("Piranha.Data.BlockField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BlockId");

                    b.Property<string>("CLRType")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("FieldId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("BlockId", "FieldId", "SortOrder")
                        .IsUnique();

                    b.ToTable("Piranha_BlockFields");
                });

            modelBuilder.Entity("Piranha.Data.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BlogId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("BlogId", "Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Categories");
                });

            modelBuilder.Entity("Piranha.Data.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<Guid?>("FolderId");

                    b.Property<int?>("Height");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("PublicUrl");

                    b.Property<long>("Size");

                    b.Property<int>("Type");

                    b.Property<int?>("Width");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("Piranha_Media");
                });

            modelBuilder.Entity("Piranha.Data.MediaFolder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<Guid?>("ParentId");

                    b.HasKey("Id");

                    b.ToTable("Piranha_MediaFolders");
                });

            modelBuilder.Entity("Piranha.Data.MediaVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Height");

                    b.Property<Guid>("MediaId");

                    b.Property<long>("Size");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.HasIndex("MediaId", "Width", "Height")
                        .IsUnique();

                    b.ToTable("Piranha_MediaVersions");
                });

            modelBuilder.Entity("Piranha.Data.Page", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("Page")
                        .HasMaxLength(255);

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsHidden");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(256);

                    b.Property<string>("MetaKeywords")
                        .HasMaxLength(128);

                    b.Property<string>("NavigationTitle")
                        .HasMaxLength(128);

                    b.Property<Guid?>("OriginalPageId");

                    b.Property<string>("PageTypeId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<Guid?>("ParentId");

                    b.Property<DateTime?>("Published");

                    b.Property<int>("RedirectType");

                    b.Property<string>("RedirectUrl")
                        .HasMaxLength(256);

                    b.Property<string>("Route")
                        .HasMaxLength(256);

                    b.Property<Guid>("SiteId");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("PageTypeId");

                    b.HasIndex("ParentId");

                    b.HasIndex("SiteId", "Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Pages");
                });

            modelBuilder.Entity("Piranha.Data.PageBlock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BlockId");

                    b.Property<Guid>("PageId");

                    b.Property<int>("SortOrder");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.HasIndex("PageId", "SortOrder")
                        .IsUnique();

                    b.ToTable("Piranha_PageBlocks");
                });

            modelBuilder.Entity("Piranha.Data.PageField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CLRType")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("FieldId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<Guid>("PageId");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("PageId", "RegionId", "FieldId", "SortOrder");

                    b.ToTable("Piranha_PageFields");
                });

            modelBuilder.Entity("Piranha.Data.PageType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64);

                    b.Property<string>("Body");

                    b.Property<string>("CLRType")
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.HasKey("Id");

                    b.ToTable("Piranha_PageTypes");
                });

            modelBuilder.Entity("Piranha.Data.Param", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("Piranha_Params");
                });

            modelBuilder.Entity("Piranha.Data.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BlogId");

                    b.Property<Guid>("CategoryId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(256);

                    b.Property<string>("MetaKeywords")
                        .HasMaxLength(128);

                    b.Property<string>("PostTypeId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTime?>("Published");

                    b.Property<int>("RedirectType");

                    b.Property<string>("RedirectUrl")
                        .HasMaxLength(256);

                    b.Property<string>("Route")
                        .HasMaxLength(256);

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PostTypeId");

                    b.HasIndex("BlogId", "Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Posts");
                });

            modelBuilder.Entity("Piranha.Data.PostField", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CLRType")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("FieldId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<Guid>("PostId");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("SortOrder");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("PostId", "RegionId", "FieldId", "SortOrder");

                    b.ToTable("Piranha_PostFields");
                });

            modelBuilder.Entity("Piranha.Data.PostTag", b =>
                {
                    b.Property<Guid>("PostId");

                    b.Property<Guid>("TagId");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("Piranha_PostTags");
                });

            modelBuilder.Entity("Piranha.Data.PostType", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64);

                    b.Property<string>("Body");

                    b.Property<string>("CLRType")
                        .HasMaxLength(256);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.HasKey("Id");

                    b.ToTable("Piranha_PostTypes");
                });

            modelBuilder.Entity("Piranha.Data.Site", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<string>("Hostnames")
                        .HasMaxLength(256);

                    b.Property<string>("InternalId")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<bool>("IsDefault");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Title")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("InternalId")
                        .IsUnique();

                    b.ToTable("Piranha_Sites");
                });

            modelBuilder.Entity("Piranha.Data.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BlogId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("BlogId", "Slug")
                        .IsUnique();

                    b.ToTable("Piranha_Tags");
                });

            modelBuilder.Entity("Piranha.Data.Alias", b =>
                {
                    b.HasOne("Piranha.Data.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.Data.BlockField", b =>
                {
                    b.HasOne("Piranha.Data.Block", "Block")
                        .WithMany("Fields")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.Data.Category", b =>
                {
                    b.HasOne("Piranha.Data.Page", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.Data.Media", b =>
                {
                    b.HasOne("Piranha.Data.MediaFolder", "Folder")
                        .WithMany("Media")
                        .HasForeignKey("FolderId");
                });

            modelBuilder.Entity("Piranha.Data.MediaVersion", b =>
                {
                    b.HasOne("Piranha.Data.Media", "Media")
                        .WithMany("Versions")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.Data.Page", b =>
                {
                    b.HasOne("Piranha.Data.PageType", "PageType")
                        .WithMany()
                        .HasForeignKey("PageTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Piranha.Data.Page", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("Piranha.Data.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.Data.PageBlock", b =>
                {
                    b.HasOne("Piranha.Data.Block", "Block")
                        .WithMany("PageBlocks")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Piranha.Data.Page", "Page")
                        .WithMany("Blocks")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.Data.PageField", b =>
                {
                    b.HasOne("Piranha.Data.Page", "Page")
                        .WithMany("Fields")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.Data.Post", b =>
                {
                    b.HasOne("Piranha.Data.Page", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Piranha.Data.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Piranha.Data.PostType", "PostType")
                        .WithMany()
                        .HasForeignKey("PostTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.Data.PostField", b =>
                {
                    b.HasOne("Piranha.Data.Post", "Post")
                        .WithMany("Fields")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Piranha.Data.PostTag", b =>
                {
                    b.HasOne("Piranha.Data.Post", "Post")
                        .WithMany("Tags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Piranha.Data.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Piranha.Data.Tag", b =>
                {
                    b.HasOne("Piranha.Data.Page", "Blog")
                        .WithMany()
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
