﻿using System.Collections.Generic;

namespace MovieRank.Contracts
{
    public class MovieRankRequest
    {
        public string MovieName { get; set; }
        public string Description { get; set; }
        public List<string> Actors { get; set; }
        public int Ranking { get; set; }
    }
}
