namespace BookAndAuthorWebAPI.Model.DTOs
{
    public class BookAndAuthorDBModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadDate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string CoverUrl { get; set; }
        public int? Rate { get; set; }
    }
}
