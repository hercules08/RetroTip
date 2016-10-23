using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroTip.Web.Models
{

    public class Category
    {
        public string categoryName { get; set; }
        public int probability { get; set; }
    }

    public class LikelyPurchase
    {
        public string id { get; set; }
        public int accountNum { get; set; }
        public string lastTransDate { get; set; }
        public List<Category> categories { get; set; }
    }
}