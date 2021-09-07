using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record CreatedItemDto
    {
        [Required]
        public string Name {get; init;}

        [Required]
        [Range(1, 1000)]
        public decimal Price {get; init;}
    }
}