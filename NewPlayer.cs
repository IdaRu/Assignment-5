using System.ComponentModel.DataAnnotations;

namespace Assignment_3

{
    public class NewPlayer
    {
        public string Name { get; set; }
        [Range(1, 99)]
        public int Level { get; set; }
        public string tag { get; set; }
    }
    }