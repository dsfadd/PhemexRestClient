
namespace PhemexClient.Models
{
    public class PhemexDataCollection<T>
    {
        public List<T> rows { get; set; } = new List<T>();
    }
}
