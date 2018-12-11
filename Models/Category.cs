using System;
using System.Collections.Generic;
using System.Linq;
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
        //public Category Category { get; set; }
        //public int CategoryId { get; set; }

    }
}
