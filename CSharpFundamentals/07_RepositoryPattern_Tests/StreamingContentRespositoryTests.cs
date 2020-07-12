using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRespositoryTests
    {
        //Test for POST method
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            //Act
            bool addResult = repo.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(addResult);
        }

        //Test for GET method
        [TestMethod]
        public void GetContents_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(content);

            //Act
            List<StreamingContent> contents = repo.GetContent();

            bool directoryHasContent = contents.Contains(content); //Checks if list contains that item(content)

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Spirited Away", "An animated film where a girl gets lost in a world of spirits", MaturityRating.PG, 100, GenreType.Anime);

            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Spirited Away");

            //Assert
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent newContent = new StreamingContent("Spirited Away", "An animated film where a girl gets lost in a world of spirits", MaturityRating.PG, 100, GenreType.Action);

            //Act
            bool updatedResult = _repo.UpdateExistingContent("Spirited Away", newContent);

            //Assert
            Assert.IsTrue(updatedResult);
            Assert.AreEqual(GenreType.Action, _content.TypeOfGenre);

        }
        
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Spirited Away");

            //Act 
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}
