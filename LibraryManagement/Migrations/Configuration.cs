using System;
using System.Collections.Generic;
using System.Data.Entity;
using LibraryManagement.Models;
using System.Data.Entity.Migrations;
using LibraryManagement.Models.Enums;

namespace LibraryManagement.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppDbContext context)
        {
            base.Seed(context);
        }
    }

    public class DbInitializer : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            var mainLibrary = new Library
            {
                Address = "آدرس تست",
                MemberCount = "4",
                Name = "کتابخانه مرکزی"
            };

            var library = new Library
            {
                Address = "آدرس تست 2",
                MemberCount = "0",
                Name = "کتابخانه دانشکده فنی"
            };

            context.Libraries.AddOrUpdate(mainLibrary, library);

            context.SaveChanges();

            var adminMember = new Member
            {
                LibraryId = mainLibrary.Id,
                RegisterDate = DateTime.Now,
                MemberType = MemberType.Employee,
                Username = "admin",
                Password = "admin",
                Name = "مسئول کتابخانه"
            };

            context.Members.AddOrUpdate(adminMember);

            context.SaveChanges();

            var book1 = new Book
            {
                Title = "ریاضی مهندسی",
                ISBN = "212323453",
                AvailableCount = 5,
                LibraryId = mainLibrary.Id,
                Price = 100000,
                Publisher = "توماس"
            };

            var book2 = new Book
            {
                Title = "ریاضی گسسته",
                ISBN = "23435456",
                AvailableCount = 10,
                LibraryId = mainLibrary.Id,
                Price = 200000,
                Publisher = "گریمالدی"
            };

            var book3 = new Book
            {
                Title = "برنامه نویسی پیشرفته",
                ISBN = "45645634",
                AvailableCount = 3,
                LibraryId = mainLibrary.Id,
                Price = 250000,
                Publisher = "دایتل"
            };

            var book4 = new Book
            {
                Title = "دین و زندگی دبیرستان",
                ISBN = "14232354",
                AvailableCount = 7,
                LibraryId = mainLibrary.Id,
                Price = 50000,
                Publisher = "ابراهیم صولتی"
            };

            context.Books.AddOrUpdate(book1, book2, book3, book4);

            context.SaveChanges();

            var member1 = new Member
            {
                Name = "علیرضا جهانبخش",
                RegisterDate = DateTime.Now,
                LibraryId = mainLibrary.Id,
                MemberType = MemberType.User,
                Username = "alireza",
                Password = "alireza"
            };

            var member2 = new Member
            {
                Name = "مینا اسدی",
                RegisterDate = DateTime.Now,
                LibraryId = mainLibrary.Id,
                MemberType = MemberType.User,
                Username = "mina",
                Password = "mina"
            };

            context.Members.AddOrUpdate(member1, member2);

            context.SaveChanges();
        }
    }
}
