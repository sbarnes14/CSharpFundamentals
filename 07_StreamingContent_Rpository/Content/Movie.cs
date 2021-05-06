using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Rpository.Content
{
    public class Movie : StreamingContent
    {
        public Movie() { }
        public Movie(string title, string description, double stars, MaturityRating maturityRating, GenreType genre, double runTime) : base(title, description, stars, genre, maturityRating) 
        {
            // setting properties that aren't included in base constructor
            RunTime = runTime;
        }

        public double RunTime { get; set; }
    }
}
