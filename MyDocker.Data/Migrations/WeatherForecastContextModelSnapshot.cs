﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyDocker.Data;

namespace MyDocker.Data.Migrations
{
    [DbContext(typeof(WeatherForecastContext))]
    partial class WeatherForecastContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyDocker.Domain.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2020, 9, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 1",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 9, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 2",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 3",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 4",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 5",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 6",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 7",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 8",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 9",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Summary = "forecast 10",
                            TemperatureC = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
