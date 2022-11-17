using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Lab_NewtonSoft
{
    public class Book : IComparable
    {
        public string? Id { get; set; }

        [JsonProperty("volumeInfo")]
        public VolumeInfo Information { get; set; }

        public string? SelfLink { get; set; }

        public int CompareTo(object? obj)
        {
            Book other = obj as Book;

            return this.Information.Title!.CompareTo(other.Information.Title);
        }

        public override string ToString()
        {
            return $"{Information}\nBook Id: {Id}, Link: {SelfLink}\n\n";
        }
    }

    public class VolumeInfo
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public List<string>? Authors { get; set; }

        public override string ToString()
        {
            return $"{Title} by {string.Join(", ", Authors!)}\nDescription: {Description}";
        }
    }
}
