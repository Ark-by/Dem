using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace pz4.Models;

public partial class Ispr2525AvetisyanAaLazarev1Context : DbContext
{
    public Ispr2525AvetisyanAaLazarev1Context()
    {
    }

    public Ispr2525AvetisyanAaLazarev1Context(DbContextOptions<Ispr2525AvetisyanAaLazarev1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Tovar> Tovars { get; set; }

    public virtual DbSet<UserImport> UserImports { get; set; }

    public virtual DbSet<ЗаказImport> ЗаказImports { get; set; }

    public virtual DbSet<ПунктыВыдачиImport> ПунктыВыдачиImports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;username=ISPr25-25_AvetisyanAA;password=ISPr25-25_AvetisyanAA;database=ISPr25-25_AvetisyanAA_lazarev1", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Tovar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Tovar");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Артикул).HasColumnType("text");
            entity.Property(e => e.ДействующаяСкидка).HasColumnName("Действующая скидка");
            entity.Property(e => e.ЕдиницаИзмерения)
                .HasColumnType("text")
                .HasColumnName("Единица измерения");
            entity.Property(e => e.КатегорияТовара)
                .HasColumnType("text")
                .HasColumnName("Категория товара");
            entity.Property(e => e.КолВоНаСкладе).HasColumnName("Кол-во на складе");
            entity.Property(e => e.НаименованиеТовара)
                .HasColumnType("text")
                .HasColumnName("Наименование товара");
            entity.Property(e => e.ОписаниеТовара)
                .HasColumnType("text")
                .HasColumnName("Описание товара");
            entity.Property(e => e.Поставщик).HasColumnType("text");
            entity.Property(e => e.Производитель).HasColumnType("text");
            entity.Property(e => e.Фото).HasColumnType("text");
        });

        modelBuilder.Entity<UserImport>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("user_import");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userId");
            entity.Property(e => e.Логин).HasColumnType("text");
            entity.Property(e => e.Пароль).HasColumnType("text");
            entity.Property(e => e.РольСотрудника)
                .HasColumnType("text")
                .HasColumnName("Роль сотрудника");
            entity.Property(e => e.Фио)
                .HasColumnType("text")
                .HasColumnName("ФИО");
        });

        modelBuilder.Entity<ЗаказImport>(entity =>
        {
            entity.HasKey(e => e.НомерЗаказа).HasName("PRIMARY");

            entity.ToTable("Заказ_import");

            entity.Property(e => e.НомерЗаказа)
                .ValueGeneratedNever()
                .HasColumnName("Номер заказа");
            entity.Property(e => e.АдресПунктаВыдачи).HasColumnName("Адрес пункта выдачи");
            entity.Property(e => e.АртикулЗаказа)
                .HasColumnType("text")
                .HasColumnName("Артикул заказа");
            entity.Property(e => e.ДатаДоставки)
                .HasColumnType("text")
                .HasColumnName("Дата доставки");
            entity.Property(e => e.ДатаЗаказа)
                .HasColumnType("text")
                .HasColumnName("Дата заказа");
            entity.Property(e => e.КодДляПолучения).HasColumnName("Код для получения");
            entity.Property(e => e.СтатусЗаказа)
                .HasColumnType("text")
                .HasColumnName("Статус заказа");
            entity.Property(e => e.ФиоАвторизированногоКлиента)
                .HasColumnType("text")
                .HasColumnName("ФИО авторизированного клиента");
            entity.HasOne(d => d.АдресПунктаВыдачиNavigation)
                .WithMany()
                .HasForeignKey(d => d.АдресПунктаВыдачи)
                .HasConstraintName("FK_Заказ_import_Пункты_выдачи");
        });

        modelBuilder.Entity<ПунктыВыдачиImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("Пункты выдачи_import");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Город).HasColumnType("text");
            entity.Property(e => e.Улица).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
