using System;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        public StreamingContent content = new StreamingContent();

        [TestMethod]
        //what we are testing _ the outcome
        public void SetTitle_ShouldSetCorrectString()
        {
            content.Title = "Toy Story";
            //                expected     what you are testing (actual)
            Assert.AreEqual("Toy Story", content.Title);
        }

        [TestMethod]
        public void SetStarRating_ShouldSetCorrectInteger()
        {
            content.StarRating = 5;
            Assert.AreEqual(5, content.StarRating);
        }

        [DataTestMethod]
        [DataRow(GenreType.Thriller)]
        [DataRow(GenreType.Romance)]
        [DataRow(GenreType.Comedy)]
        public void SetGenre_ShouldSetCorrectGenre(GenreType typeOfGenre)
        {
            //Arrange
            //StreamingContent content = new StreamingContent(); (LINE 10)

            //Act
            content.TypeOfGenre = typeOfGenre;

            //Assert
            Assert.AreEqual(typeOfGenre, content.TypeOfGenre);
        }
    }
}
