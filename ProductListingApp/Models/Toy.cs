namespace ProductListingApp.Models
{
    public class Toy
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public List<string> Features { get; set; }

        public List<string> Reviews { get; set; }
    }
}
