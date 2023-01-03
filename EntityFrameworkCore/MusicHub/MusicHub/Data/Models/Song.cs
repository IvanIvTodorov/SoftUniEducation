﻿using MusicHub.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicHub.Data.Models
{
    public class Song
    {
      
            public Song()
            {
                this.SongPerformers = new HashSet<SongPerformer>();
            }

            [Key]
            public int Id { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public TimeSpan Duration { get; set; }
            [Required]
            public DateTime CreatedOn { get; set; }
            [Required]
            public Genre Genre { get; set; }

            public int? AlbumId { get; set; }

            public Album Album { get; set; }
            [Required]
            public int WriterId { get; set; }

            public Writer Writer { get; set; }
            [Required]
            public decimal Price { get; set; }

            public ICollection<SongPerformer> SongPerformers { get; set; }
        }
}
