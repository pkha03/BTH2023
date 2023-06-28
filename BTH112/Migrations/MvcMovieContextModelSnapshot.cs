﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace BTH112.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("BTH112.Models.Lophoc", b =>
                {
                    b.Property<string>("malop")
                        .HasColumnType("TEXT");

                    b.Property<string>("tenlop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("malop");

                    b.ToTable("Lophoc");
                });

            modelBuilder.Entity("BTH112.Models.Sinhvien", b =>
                {
                    b.Property<string>("tensv")
                        .HasColumnType("TEXT");

                    b.Property<string>("masv")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("tenlop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("tensv");

                    b.HasIndex("tenlop");

                    b.ToTable("Sinhvien");
                });

            modelBuilder.Entity("BTH112.Models.Sinhvien", b =>
                {
                    b.HasOne("BTH112.Models.Lophoc", "Lophoc")
                        .WithMany()
                        .HasForeignKey("tenlop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lophoc");
                });
#pragma warning restore 612, 618
        }
    }
}
