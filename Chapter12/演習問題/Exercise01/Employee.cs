using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Exercise01 {
    public class Employee {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("hiredate")]
        public DateTime HireDate { get; set; }
    }
}
