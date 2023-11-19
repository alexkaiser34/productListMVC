using ProductListingApp.Models;

namespace ProductListingApp.Data
{
    public class Database
    {
        public IDictionary<string, Toy> datatbaseObjects;
        public Database() {

            datatbaseObjects = new Dictionary<string, Toy>();

            this._addCodingBook();
            this._addMechanicalRobot();
            this._addVolcano();
        }


        private void _addCodingBook()
        {
            this.datatbaseObjects.Add("Coding Book",
                new Toy()
                {
                    Title = "Coding for Beginners!",
                    Description = "Learn the basics of coding with" +
                    " this easy to read book!",
                    Price = 5.99,
                    Features = new List<string>()
                    {
                        "Easy to read!",
                        "Fun to learn!",
                        "Good for all ages!"
                    },
                    Reviews = new List<string>()
                    {
                        "My kid mastered C++ in just 5 minutes after reading this book!",
                        "My kid decided coding was not for him after reading this book :(",
                        "This book was just awful"
                    }

                }
            );
        }

        private void _addMechanicalRobot()
        {
            this.datatbaseObjects.Add("Mechanical Robot",
                new Toy()
                {
                    Title = "Mechanical Robot",
                    Description = "An easy to build mechanical robot" +
                    " that moves around and picks up things!",
                    Price = 12.99,
                    Features = new List<string>()
                    {
                        "Easy to build!",
                        "Fun to move!",
                        "Teaches the basics of mechanical engineering!"
                    },
                    Reviews = new List<string>()
                    { 
                        "My kid wanted to become a mechanical engineer after using this toy!",
                        "This robot evolved and burnt down my house!",
                        "This was a fun project to build!"
                    }

                }
            );
        }

        private void _addVolcano()
        {
            this.datatbaseObjects.Add("Volcano",
                new Toy()
                {
                    Title = "Build your own Volcano Kit!",
                    Description = "A complete kit where you can build" +
                    " and explode a volcano!",
                    Price = 17.99,
                    Features = new List<string>()
                    {
                        "Easy to build!",
                        "Fun to explode!",
                        "Easy cleanup!"
                    },
                    Reviews = new List<string>()
                    {
                        "My kid had so much fun blowing up stuff after" +
                        " making this volcano!",
                        "My kid used this for his science fair project!",
                        "Do not listen to the features, not easy to clean up :/"
                    }

                }
            );
        }

    }
}
