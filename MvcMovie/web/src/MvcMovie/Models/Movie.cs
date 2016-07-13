using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("movie")]
    public class Movie
    {
        [Column("id")]
        public int ID { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("releasedate")]
        public DateTime ReleaseDate { get; set; }
        [Column("genre")]
        public string Genre { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
    }
}