﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using AmbAPI.Models;

namespace AmbAPI.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("AmbConn")
        {
            Database.SetInitializer(new CreateDatabaseWithSeedData<MyContext>());
           // Database.Initialize(true);

            //Database.SetInitializer<MyContext>(null);

        }

        public DbSet<User> User { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<SBU> SBU { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Notice> Notice { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<AmbToken> AmbToken { get; set; }
        public DbSet<Test> Test { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //禁止生成数据表名的时候使用复数形式
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();



           
        }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Report> Reports { get; set; }
    }
}