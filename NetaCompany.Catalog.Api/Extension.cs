﻿using NetaCompany.Catalog.Api.Dtos;
using NetaCompany.Catalog.Api.Entities;

namespace NetaCompany.Catalog.Api
{
    public static class Extension
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }

    }
}
