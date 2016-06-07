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
        public MyContext() : base("AmbConn") { }

        public DbSet<User> User { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<ReportCell> ReportCell { get; set; }
        public DbSet<ReportGroup> ReportGroup { get; set; }
        public DbSet<SBU> SBU { get; set; }
        public DbSet<About> About { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //禁止生成数据表名的时候使用复数形式
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}