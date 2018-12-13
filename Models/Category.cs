using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace DotNetCoreMvcPractices.Models
{
    //public class Category
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public ICollection<Category> CategoryItems { get; set; }
    //}

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public ICollection<Category> ChildCategories { get; set; }

        public ICollection<Product> Products { get; set; }



    }
}
