using _07_StreamingContent_Rpository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        StreamingContentRepository _repo = new StreamingContentRepository();
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content by Title\n" +
                    "4. Update xisting Content\n" +
                    "5. Delte Existing Content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        //CreateNewContent
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":
                        //ViewAllContent
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        //ViewContentByTitle
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        //updateExistingContent
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        //DeleteExistingContent
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        //Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("STOOPID");
                        break;

                }
                Console.WriteLine("Please press any key to contnue");
                Console.ReadKey();
                Console.Clear();
            }

        }
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("what is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //Star Rating 
            Console.WriteLine("Enter the star rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //Genre
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //Maturity Rating
            Console.WriteLine("Enter the number for Maturity Rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());
           bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("the content was added correctly");
            }
            else
            {
                Console.WriteLine("Could not add the content");
            }
        }
        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach(StreamingContent content in allContent)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                Console.ResetColor();


            }
        }

        private void DisplayContentByTitle() //get a title from the user then display all properties of the content that has that title
        {
            Console.Clear();
            Console.WriteLine("what is the title?");
            StreamingContent matchedContent = _repo.GetContentByTitle(Console.ReadLine());
            Console.WriteLine($"Title: {matchedContent.Title}\n" +
                $"Description: {matchedContent.Description}\n" +
                $"Star Rating: {matchedContent.StarRating}\n" +
                $"Genre: {matchedContent.TypeOfGenre}\n" +
                $"Maturity Rating: {matchedContent.MaturityRating}\n" +
                $"Is Family Friendly: {matchedContent.IsFamilyFriendly}");


        }

        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title of the content you want to updat");

            string oldTitle = Console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("what is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //Star Rating 
            Console.WriteLine("Enter the star rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //Genre
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //Maturity Rating
            Console.WriteLine("Enter the number for Maturity Rating:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

            bool wasUpdated = _repo.updateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("The content was updated successfullly");
            }
            else
            {
                Console.WriteLine("No content by that title exists");
            }

        }

        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title for the content yuou want to delete");

            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());

            if (wasDeleted)
            {
                Console.WriteLine("Content was succesfully deleted");
            }
            else
            {
                Console.WriteLine("Contnet cuold not be deleted :(");
            }
        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty gets transported", 1.0, GenreType.SciFi, MaturityRating.PG);
            StreamingContent Rubber = new StreamingContent("Rubber", "death by tire", 1.0, GenreType.Horror, MaturityRating.R);
            StreamingContent starWars = new StreamingContent("Star Wars", "Jar Jar saves the day", 5.0, GenreType.SciFi, MaturityRating.PG-13);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(Rubber);
            _repo.AddContentToDirectory(starWars);
        }
        
    }
}
