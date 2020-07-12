using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            //This seeds in our sample data to work with
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;

            while (continueToRun)
            {
                _console.Clear();
                _console.WriteLine(
                    "Enter the number of the option you'd like to select: \n" +
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new streaming content \n" +
                    "4. Remove streaming content \n" +
                    "5. Exit");
                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":
                        ShowContentByTitle();
                        break;
                    case "3":
                        CreateNewContent();
                        break;
                    case "4":
                        RemoveContentFromList();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number between 1 and 5. \n" +
                            "Press any key to continue....");
                        _console.ReadKey();
                        break;
                }
            }
        }

        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title} \n" +
                $"Description: {content.Description} \n" +
                $"Genre Type: {content.TypeOfGenre} \n" +
                $"Star Rating: {content.StarRating} \n" +
                $"Family Friendly: {content.IsFamilyFriendly} \n" +
                $"Rating: {content.MaturityRating}");
        }
        
        private void SeedContentList()
        {
            StreamingContent movieOne = new StreamingContent("Spirited Away", "test", MaturityRating.PG, 5, GenreType.Anime);
            StreamingContent movieTwo = new StreamingContent("2001", "test", MaturityRating.PG_13, 5, GenreType.SciFi);
            StreamingContent movieThree = new StreamingContent("A Clockwork Orange", "test", MaturityRating.R, 4, GenreType.Thriller);

            //This is posting them to the our _streamingRepo directory (fake database)
            _streamingRepo.AddContentToDirectory(movieOne);
            _streamingRepo.AddContentToDirectory(movieTwo);
            _streamingRepo.AddContentToDirectory(movieThree);
        }

        private void CreateNewContent()
        {
            _console.Clear();
            StreamingContent content = new StreamingContent();

            //title
            _console.WriteLine("Please enter the title of the content: ");
            content.Title = _console.ReadLine();

            //description
            _console.WriteLine("Please enter the description: ");
            content.Description = _console.ReadLine();

            //Maturity Rating
            _console.WriteLine("Select a Maturity Rating: \n" +
                "1) G \n" +
                "2) PG \n" +
                "3) PG-13 \n" +
                "4) R \n" +
                "5) NC-17" +
                "6) TV MA");
            string maturityString = _console.ReadLine();
            switch (maturityString)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
            }

            //star rating
            _console.WriteLine("Please enter the star-rating (1-5): ");
            content.StarRating = int.Parse(_console.ReadLine());

            //genre type
            _console.WriteLine("Select a Genre: \n" +
                "1: Horror \n" +
                "2: Sci-Fi \n" +
                "3: Drama \n" +
                "4: Action \n" +
                "5: Comedy \n" +
                "6: Anime \n" +
                "7: Documentary \n" +
                "8: Thriller \n" +
                "9: Romance");
            string genreInput = _console.ReadLine();
            int genreId = int.Parse(genreInput);
            content.TypeOfGenre = (GenreType)genreId;
            _streamingRepo.AddContentToDirectory(content);
        }

        private void ShowAllContent()
        {
            _console.Clear();
            List<StreamingContent> listOfContent = _streamingRepo.GetContent();

            foreach (StreamingContent contentVariable in listOfContent)
            {
                _console.WriteLine("-----------------");
                DisplayContent(contentVariable);
            }

            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            _console.Clear();
            _console.WriteLine("Please enter a title");
            string title = _console.ReadLine();
            StreamingContent foundTitle = _streamingRepo.GetContentByTitle(title);
            if(foundTitle != null)
            {
                DisplayContent(foundTitle);
            } else
            {
                _console.WriteLine("Invalid title. Could not find any results.");
            }
            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }

        private void RemoveContentFromList()
        {
            _console.WriteLine("Which item would you like to remove?");
            List<StreamingContent> contentList = _streamingRepo.GetContent();

            int count = 0;
            foreach(StreamingContent content in contentList)
            {
                count++;
                _console.WriteLine($"{count}.) {content.Title}");
            }

            int targetContentId = int.Parse(_console.ReadLine());
            int targetIndex = targetContentId - 1;
            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title} successfully removed");
                } else
                {
                    _console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            } else
            {
                _console.WriteLine("No content has that ID");
            }
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }
    }
}
