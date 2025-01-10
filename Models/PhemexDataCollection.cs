
namespace PhemexClient.Models
{
    public class PhemexDataCollection<T>
    {
        public List<T> Rows { get; set; } = new List<T>();
    }
}
