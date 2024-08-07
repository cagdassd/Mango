﻿using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IProductService
    {
        Task<ResponseDto?> GetProductAsync(string ProductCode);
        Task<ResponseDto?> GetAllProductsAsync();
        Task<ResponseDto?> GetProductByIdAsync(int id);
        Task<ResponseDto?> CreateProductsAsync(ProductDto ProductDto);
        Task<ResponseDto?> UpdateProductAsync(ProductDto ProductDto);
        Task<ResponseDto?> DeleteProductAsync(int id);
    }
}
