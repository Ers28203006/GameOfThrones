using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones.Models
{
    public class Pagerank
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}
