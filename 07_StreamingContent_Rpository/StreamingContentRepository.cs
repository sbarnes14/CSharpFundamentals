﻿using _07_StreamingContent_Rpository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Rpository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD methods below (create, read, update, delete)
        //create
        //content

        public bool AddContentToDirectory(StreamingContent newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Movie
        public bool AddContentToDirectory(Movie newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Show

        //Episode

        //Read All
        //Content Read All

        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        //Movie read All
        public List<Movie> GetMovies()
        {
            //initialize empty list
            List<Movie> allMovies = new List<Movie>();
            //Look through our directory
            foreach(StreamingContent content in _contentDirectory)
            {
                //check if object is a Movie class
                if (content is Movie)
                {
                    //Load ninto our list
                    allMovies.Add((Movie)(content));
                }
            }
            return allMovies;
        }
        //Show Read All
        public List<Show> GetShows()
        {
            // setup our list
            List<Show> allShows = new List<Show>();
            //Find our shows
            foreach(StreamingContent content in _contentDirectory)
            {
                //Check that it is a show
                if (content.GetType() == typeof(Show))
                {
                    //Yes? add to the list
                    allShows.Add((Show)content);
                }
            }
            //Give back shows
            return allShows;
        }

        //Episode Read All

        //Get by id
        //Content

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        //movie 
        public Movie GetMovieByTitle(string title)
        {
            foreach(StreamingContent movie in _contentDirectory)
            {
                if(movie.Title.ToLower() == title.ToLower() && movie is Movie)
                {
                    return (Movie)movie; 
                }
            }
            return null;
        }
        //show
        //Get show by title
        //Accessor //Return rtype //Name (paramenters)
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;
        }
        //episode

        public bool updateExistingContent(string originalTitle, StreamingContent newContentValues)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if(oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.MaturityRating = newContentValues.MaturityRating;
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(string titleToDelete)
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete);
            if(contentToDelete == null)
            {
                return false;
            }
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }
    }
}
