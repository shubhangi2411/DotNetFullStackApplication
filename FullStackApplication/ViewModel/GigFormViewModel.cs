
using FullStackApplication.Models;
using System.Collections.Generic;
namespace FullStackApplication.ViewModel
{
    public class GigFormViewModel
    {
        public int Id { get; set; }
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}