using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment_3
{
    public class NewItem
    {
        public string Name { get; set; }

        [Range(1, 99)]
        public int Level {get; set;}

        [ItemType]
        public string Type {get; set;}

        [DateType]
        [DataType(DataType.Date)]
        public DateTime CreationDate {get; set;}
        }
    }