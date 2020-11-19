using System;
using Topics;
using Update;


namespace HangmanCON
{
    class Program
    {

        static void Main(string[] args)
        {

            Random rnd = new Random();

            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            
            bool start = true;

            

            int topicNum = 0;

            
            string choiceTopic = string.Empty;

            
            char[] word = new char[100];

            
            bool win = false;

            
            int hangIndex = 0;

            
            string usedletters = string.Empty;

            topicNum = TopicChoice.UserChoice();
            choiceTopic = TopicChoice.ChoiceTopic(topicNum, word);

            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                UpdateScreen.UpdateHang(hangIndex);
                UpdateScreen.ScreenUpdate(alphabet, word, usedletters);


                string letter = UpdateScreen.PlayerInput(alphabet, usedletters);

                usedletters = usedletters + letter;


                
                char[] letterC = letter.ToCharArray();

                
                bool error = true;

                
                int wincounter = 0;


                for (int i = 0; i < choiceTopic.Length; i++)
                {

                    if (letterC[0] == choiceTopic[i])
                    {
                        word[i] = choiceTopic[i];

                        error = false;
                    }
                    if (word[i] == choiceTopic[i])
                    {
                        wincounter++;
                    }

                    if (wincounter == choiceTopic.Length)
                    {
                        win = true;
                    }
                }

                if (error)
                {
                    hangIndex++;
                }

                if (UpdateScreen.EndGame(win, choiceTopic, hangIndex))
                {
                    break;
                }

            } while (start);
        }
    }

    
}