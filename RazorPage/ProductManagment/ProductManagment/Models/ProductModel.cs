﻿namespace ProductManagment.Models
{  
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }        
        public string Comment { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int LikeCount { get; set; }
    }
}
