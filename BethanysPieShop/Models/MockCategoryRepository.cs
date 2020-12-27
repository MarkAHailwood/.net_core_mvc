﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Pies", Description="Fruity" },
                new Category{CategoryId=2, CategoryName="Cheese Cake", Description="Cheesy AF" },
                new Category{CategoryId=3, CategoryName="Seasonal Pies", Description="Horse meat 100%" }
            };
    }
}