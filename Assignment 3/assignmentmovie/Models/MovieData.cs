using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignmentmovie.Models {
    public class MovieData {

        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string ReleaseDate { get; set; }
        
    }
}