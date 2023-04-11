using System;
using System.Collections.Generic;

//dbcontext in data model
namespace PlayerDomain.classes
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public List<PlayerStats> StatsForPlayer { get; set; }
    }

    public class PlayerStats
    {
        public int Id { get; set; }
        public Player Player { get; set; }

        public StatsType Type { get; set; }
    }
}