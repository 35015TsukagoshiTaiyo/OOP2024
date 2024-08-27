using System;
using System.Runtime.Serialization;

namespace Exercise01 {
    [DataContract]
    public class Employee {
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime HireDate { get; set; }
    }
}
