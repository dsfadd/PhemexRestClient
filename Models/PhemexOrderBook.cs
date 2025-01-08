using Newtonsoft.Json;
using PhemexClient.Converters;


namespace PhemexClient.Models
{
    public class PhemexOrderBook
    {
        [JsonConverter(typeof(BookConverter))]
        public Book book { get; set; }
        public int depth { get; set; }
        public long sequence { get; set; }
        public long timestamp { get; set; }
        public string symbol { get; set; }
        public string type { get; set; }
    }
    public class Book
    {
        [JsonConverter(typeof(BookConverter))]
        public List<Ask> asks { get; set; }
        [JsonConverter(typeof(BookConverter))]
        public List<Bid> bids { get; set; }
    }

   public class Bid
    {
       public long priceEP { get; set; }
        public    long size { get; set; }
    }
    public class Ask
    {
     public   long priceEP { get; set; }
      public  long size { get; set; }

    }
}
