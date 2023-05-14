using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string City { get; set; }
        [MaxLength(20)]
        public string Coach { get; set; }
        [MaxLength(40)]
        public string Colors { get; set; }

        //Navigation attributes
        public List<Player> Players { get; set; }

        public Team(string name, string city, string coach, string colors)
        {
            Name = name;
            City = city;
            Coach = coach;
            Colors = colors;
            Players = new List<Player>();
        }
    }
}