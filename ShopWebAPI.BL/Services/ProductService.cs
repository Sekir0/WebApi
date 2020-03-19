﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopWebAPI.BL.Services.Interfaices;
using ShopWebAPI.DAL.Models;

namespace ShopWebAPI.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>();
            for (var i = 0; i < 5; i++)
            {
                _products.Add(new Product { Id = Guid.NewGuid(), Name = $"Product Name {i}" });
            }
        }

        public Product GetProductById(Guid productId)
        {
            return _products.SingleOrDefault(x => x.Id == productId);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
