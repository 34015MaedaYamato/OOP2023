﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models {　
    internal class Configuration : DbMigrationsConfiguration<BooksDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = true; //自動マイグレーション
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SampleEntityFramework.Models.BooksDbContext";
        }
    }
}
