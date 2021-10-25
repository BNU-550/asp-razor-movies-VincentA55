using System;
using System.ComponentModel.DataAnnotations;

namespace RazorMoviesVincentA55.Models
{
    public enum Genres
    {
        Comedy, Drama, Thriller, Action, SciFi, Adventure, Children
    }
    /// <summary>
    /// Class for the movies being stored in the database
    /// </summary>
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Genres Genre { get; set; }
        public decimal Price { get; set; }
    }
}
