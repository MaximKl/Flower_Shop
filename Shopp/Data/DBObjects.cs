using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shopp.Data;
using Shopp.Data.Models;
using System.Collections.Generic;
using System.Linq;
using Shopp.Data.Interfaces;


namespace Shopp.Data
{


    public class DBObjects
    {
        //функція для підключення до БД
        public static void Initial(AppDBContent content)
        {
            //якщо не має жодної категорії, то додаємо категорії
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c =>
               c.Value));
            }
            //якщо не має жодного товару, то додаємо товар
            if (!content.Flower.Any())
            {
                content.AddRange(
                new Flower
                {
                    name = "Кактус",
                    shortDesc = "Трошки колиться",
                    longDesc = " Гарна прикраса для вашої кухні ",
                    img = "/img/kaktys.jpg",
                    price = 400,
                    isFavourite = true,
                    available = true,
                    Category = Categories["Домашні рослини"]
                },
               new Flower
               {
                   name = "Роза",
                   shortDesc = "Червона",
                   longDesc = "Чим більше роз у букеті, тим краще!",
                   img = "/img/rose.jpg",
                   price = 100,
                   isFavourite = false,
                   available = true,
                   Category = Categories["Садові рослини"]
               }
                );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    //створення інфомаціїї для занесення в БД
                    var list = new Category[]{
                     new Category {categoryName = "Домашні рослини", desc =
                    "Гарні рослини для прикраси вашої домівки"},

                     new Category {categoryName = "Садові рослини",
                    desc = "Квіти для створення неперевершеного букету"},
                     };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
