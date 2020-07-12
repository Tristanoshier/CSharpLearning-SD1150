using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content is Show)
                {
                    return (Show)content;
                }
            }
            return null;
        }

        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();

            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
            return allMovies;
        }

        //GET by Runtime/averageTime
        public List<Movie> GetByRunTime(double runtime)
        {
            List<Movie> movies = new List<Movie>();

            foreach(StreamingContent content in  _contentDirectory)
            {
                Movie movie = (Movie)content;
                if(movie.RunTime == runtime)
                {
                    movies.Add(movie);
                }
            }
            return movies;
        }

        //GET shows with over x episodes
        public List<Show> GetShowsWithXEpisodes(int numOfEpisodes)
        {
            List<Show> shows = new List<Show>();

            foreach(Show show in _contentDirectory)
            {
                if(show.EpisodeCount > numOfEpisodes)
                {
                    shows.Add(show);
                }
            }
            return shows;
        }

        //Get Shows/Movie by Rating
        public List<StreamingContent> GetContentByRating(MaturityRating rating)
        {
            List<StreamingContent> listOfContent = new List<StreamingContent>();

            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.MaturityRating == rating)
                {
                    listOfContent.Add(content);
                }
            }
            return listOfContent;
        }
    }
}
