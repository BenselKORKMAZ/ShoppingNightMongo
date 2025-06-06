﻿namespace ShoppingNightMongo.Dtos.ProductDtos
{
    public class GetProductByIdDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public int StockCount { get; set; }
    }
}
