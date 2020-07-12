using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD

        //POST
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //GET
        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }

        //GET by ID(in this case title)
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

        //GET by IsFamilyFriendly
        public List<StreamingContent> GetContentByFamilyFriendly(bool isFamilyFriendly)
        {
            List<StreamingContent> sortedList = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly == isFamilyFriendly)
                {
                    sortedList.Add(content);
                }
            }
            return sortedList;
        }

        //UPDATE
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }

        //DELETE
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

        
    }
}
