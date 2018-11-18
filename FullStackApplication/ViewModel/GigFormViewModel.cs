﻿
using FullStackApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace FullStackApplication.ViewModel
{
    public class GigFormViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
        public DateTime getDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}