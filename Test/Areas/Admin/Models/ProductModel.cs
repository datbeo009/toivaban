﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Areas.Admin.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public int? Price { get; set; }

        public int? CategoryID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public string Image { get; set; }
        public string ListImage { get; set; }
        public bool Status { get; set; }
        public bool Active { get; set; }
    }
}