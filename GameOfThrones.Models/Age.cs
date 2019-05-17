using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones.Models
{
    public class Age
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        public int AgeCharacter { get; set; }
    }
}
