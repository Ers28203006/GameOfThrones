using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones.Models
{
    public class Show
    {

        [JsonProperty("titles")]
        public IList<string> Titles { get; set; }

        [JsonProperty("origin")]
        public IList<string> Origin { get; set; }

        [JsonProperty("siblings")]
        public IList<string> Siblings { get; set; }

        [JsonProperty("spouse")]
        public IList<string> Spouse { get; set; }

        [JsonProperty("lovers")]
        public IList<string> Lovers { get; set; }

        [JsonProperty("plod")]
        public int Plod { get; set; }

        [JsonProperty("longevity")]
        public IList<object> Longevity { get; set; }

        [JsonProperty("plodB")]
        public double PlodB { get; set; }

        [JsonProperty("plodC")]
        public int PlodC { get; set; }

        [JsonProperty("longevityB")]
        public IList<double> LongevityB { get; set; }

        [JsonProperty("longevityC")]
        public IList<object> LongevityC { get; set; }

        [JsonProperty("culture")]
        public IList<string> Culture { get; set; }

        [JsonProperty("religion")]
        public IList<string> Religion { get; set; }

        [JsonProperty("allegiances")]
        public IList<string> Allegiances { get; set; }

        [JsonProperty("seasons")]
        public IList<int?> Seasons { get; set; }

        [JsonProperty("appearances")]
        public IList<string> Appearances { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("death")]
        public int Death { get; set; }

        [JsonProperty("father")]
        public string Father { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("first_seen")]
        public string FirstSeen { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("related")]
        public IList<Related> Related { get; set; }

        [JsonProperty("pagerank")]
        public Pagerank Pagerank {get;set;}

        [JsonProperty("age")]
        public Age Age { get; set; }

        [JsonProperty("mother")]
        public string Mother { get; set; }

        [JsonProperty("birth")]
        public int? Birth { get; set; }

        [JsonProperty("longevityStartB")]
        public int? LongevityStartB { get; set; }
    }
}
