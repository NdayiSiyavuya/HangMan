using System;


namespace Topics
{
    class TopicChoice
    {
       public static string topics = "Welcome to Hangman!!!\n" +
            " \n" +
            "Please choose from our topics that you want to play:\n" +
            "1.Anime\n" +
            "2.Games\n" +
            "3.Music Artists\n" +
            "4.Movies\n" +
            "What is your choice?\n";

        static string[] anime = { "mirai nikki", "god of highschool", "naruto", "bleach", "dragonball" };
        static string[] games = { "minecraft", "paladins", "fornite", "god of war","pokemon","league of legends","skyrim","world of warcraft" };
        static string[] musicArtisit = { "adele", "joji", "drake", "linkin park","ed sheeran","nickelback","the killers","evanescence","paramore", "kings of leon" };
        static string[] movies = { "avengers", "mulan", "joker", "the lord of the rings","parasite","the dark knight"};


        public static int UserChoice()
        {
            Console.Clear();
            Console.WriteLine(TopicChoice.topics);

            string topic = Console.ReadLine();


            if (topic == "1" || topic == "2" || topic == "3" || topic == "4")
            {
                return int.Parse(topic);
                
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Error with input!!!");
                Console.WriteLine(" ");
                Console.ReadKey();
                return UserChoice();
            }
            
        }

        public static string ChoiceTopic(int topicNum,char[] word )
        {
            string choiceTopic = string.Empty;
            Random rnd = new Random();

            switch (topicNum)
            {
                case 1:
                    int animeIndex = rnd.Next(anime.Length);
                    choiceTopic = anime[animeIndex];
                    for (int i = 0; i < choiceTopic.Length; i++)
                    {
                        word[i] = '-';
                    }


                    break;

                case 2:
                    int gamesIndex = rnd.Next(games.Length);
                    choiceTopic = games[gamesIndex];
                    for (int i = 0; i < choiceTopic.Length; i++)
                    {
                        word[i] = '-';
                    }

                    break;

                case 3:
                    int musicIndex = rnd.Next(musicArtisit.Length);
                    choiceTopic = musicArtisit[musicIndex];
                    for (int i = 0; i < choiceTopic.Length; i++)
                    {
                        word[i] = '-';
                    }

                    break;

                case 4:
                    int movieIndex = rnd.Next(movies.Length);
                    choiceTopic = movies[movieIndex];
                    for (int i = 0; i < choiceTopic.Length; i++)
                    {
                        word[i] = '-';
                    }

                    break;


                default:
                    break;
            }


            for (int i = 0; i < choiceTopic.Length; i++)
            {
                if (choiceTopic[i] == ' ')
                {
                    word[i] = ' ';

                }
            }
            return choiceTopic;
        }

    }
}
