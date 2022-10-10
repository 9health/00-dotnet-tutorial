
//========================================================================
//
//  Author: 9Health
//
//  Changelog:
//
//    2022/Sep/21  v0.1    Newly create
//    2022/Sep/26  v0.1.1  Rename to from .db to .sqlite
//    2022/Oct/05  v0.2    Add Meals database
//
//========================================================================

using Microsoft.EntityFrameworkCore;
using System;

public class FoodModel : DbContext {

    public  DbSet<MealVerF>    Meals { get; set; }
    public  DbSet<NHFoodVerF>  Foods { get; set; }

    public  string  DbPath { get; }

    public  FoodModel() {
      //var  folder  =  Environment.SpecialFolder.LocalApplicationData;
      //var  path    =  Environment.GetFolderPath(folder);
        var  path    =  System.IO.Directory.GetCurrentDirectory();
        DbPath       =  System.IO.Path.Join(path, "db", System.IO.Path.DirectorySeparatorChar.ToString() ,"food.sqlite");
    }

    // The following configure EF to create a SQLite database file on
    // special "local" folder.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

}

