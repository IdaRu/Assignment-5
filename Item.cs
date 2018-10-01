using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_3
{
    
    public class Item
    {
        public Guid Id { get; set; }

        public string Name {get; set;}

        [Range(1, 99)]
        public int Level {get; set;}

        [ItemType]
        public string Type {get; set;}

        [DateType]
        public DateTime CreationTime {get; set;}
    }
}