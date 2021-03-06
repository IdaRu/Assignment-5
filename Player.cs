using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Assignment_3
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsBanned { get; set; }
        public int Level { get; set; }
        public DateTime CreationTime { get; set; }
        public List <Item> items { get; set; }
        public string tag { get; set; }
    }
}