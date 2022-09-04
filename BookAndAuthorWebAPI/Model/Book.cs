﻿namespace BookAndAuthorWebAPI.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadDate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string CoverURL { get; set; }
        public DateTime AddedDate { get; set; }
        public int? Rate { get; set; }

    }
}
