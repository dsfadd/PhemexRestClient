using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhemexClient.Models
{
    public class PhemexSpotTicker
    {
        public long askEp { get; set; }
        public long bidEp { get; set; }
        public long highEp { get; set; }
        public long lastEp { get; set; }
        public long lowEp { get; set; }
        public long openEp { get; set; }
        public string symbol { get; set; }
        public long timestamp { get; set; }
        public long turnoverEv { get; set; }
        public long volumeEv { get; set; }
    }
}
