using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonProeject.Core.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tax { get; set; }
        public string Code { get; set; }
        public bool IsAvailable { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public double DiscountPercent { get; set; }
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }

        public int AuthorId { get; set; }
        public Author? author { get; set; }
        public List<BookTag>? BookTags { get; set; }
        public List<BookImage>? BookImages { get; set; } //relation

        [NotMapped]
        public IFormFile? BookPosterImagefiles { get; set; }
        [NotMapped]
        public IFormFile? BookHoverImageFiles { get; set; }
        [NotMapped]
        public List<IFormFile>? BookImageFiles { get; set; }

        [NotMapped]
        public List<int>? BookImageIds { get; set; }
    }
}
