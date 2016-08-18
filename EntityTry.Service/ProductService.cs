using System;
using System.Collections.Generic;
using EntityTry.Repository;
using EntityTry.DTO;
using EntityTry.DTO.Product;
using EntityTry.ORM.Models;

namespace EntityTry.Service
{
    public class ProductService
    {
        ProductRepository repository = new ProductRepository();
        public IList<ProductListDTO> ListMake()
        {
            return repository.Listele().Select(
                x => new ProductListDTO
                {
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice,
                    UnitsInStock = x.UnitsInStock,
                    ProductID = x.ProductID,
                    CategoryID = x.CategoryID,
                    SupplierID = x.SupplierID,
                    Discontinued = x.Discontinued
                }).ToList();
        }
        public void mAdd(ProductAddDTO entity)
        {
            Product pro = new Product {
                ProductName=entity.ProductName,
                UnitPrice = entity.Price,
                UnitsInStock = entity.ProductStock,
                CategoryID = entity.iCategoryID,
                SupplierID = entity.iSupplierID
            };
            repository.mAdd(pro);
        }
    }
}
