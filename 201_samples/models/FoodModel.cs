
using Microsoft.EntityFrameworkCore;
using System;

public class FoodModel : DbContext {

    public  DbSet<NHFoodVerF>  Foods { get; set; }

    public  string  DbPath { get; }

    public  FoodModel() {
        var  folder  =  Environment.SpecialFolder.LocalApplicationData;
        var  path    =  Environment.GetFolderPath(folder);
        DbPath       =  System.IO.Path.Join(path, "food.db");
    }

    // The following configure EF to create a SQLite database file on
    // special "local" folder.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

}

