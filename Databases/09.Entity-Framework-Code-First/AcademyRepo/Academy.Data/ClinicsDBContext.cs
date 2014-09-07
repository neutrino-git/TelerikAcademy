﻿namespace Academy.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Academy.Data.Migrations;
    using Academy.Models;

    public class ClinicsDBContext : DbContext, IClinicsDBContext
    {
        public ClinicsDBContext()
            : base("AcademyLite")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ClinicsDBContext, Configuration>());
        }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}
