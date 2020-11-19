using System;


namespace Update
{
    class UpdateScreen
    {

        public static bool EndGame(bool win, string choiceTopic, int hangIndex)
        {
            if (win)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine($"The word/word's was  = {choiceTopic} ");
                Console.WriteLine(" ");
                Console.WriteLine("YOU WIN!!!!!");
                Console.WriteLine(" ");
                return true;
            }

            if (hangIndex == 6)
            {
                Console.Clear();
                Console.WriteLine(" ");
                UpdateHang(hangIndex); 
                Console.WriteLine($"The word/word's was  = {choiceTopic} ");
                Console.WriteLine(" ");
                Console.WriteLine("GAME OVER");
                Console.WriteLine(" ");
                return true;
            }
            return false;
        }
        public static string PlayerInput(string[] alphabet,string usedletters)
        {
            string letter = string.Empty;
            Console.SetCursorPosition(0, 23);
            Console.Write("Choose a letter :             ");
            Console.SetCursorPosition(18, 23);
            letter = Console.ReadLine();
            Console.SetCursorPosition(0, 25);

            for (int i = 0; i < alphabet.Length; i++)
            {

                if (letter == " ")
                {

                    Console.WriteLine(" ");
                    Console.Write("You typed nothing! Try again                   ");
                    Console.WriteLine(" ");

                    i = 0;
                    return PlayerInput(alphabet, usedletters);
                }
                else if (letter.Length > 1)
                {

                    Console.WriteLine(" ");
                    Console.Write("Only type one letter at a time! Try again      ");
                    Console.WriteLine(" ");

                    i = 0;
                    return PlayerInput(alphabet, usedletters);
                }
                else if (usedletters.Contains(letter))
                {

                    Console.WriteLine(" ");
                    Console.Write("Letter already used!! please pick another one :");
                    Console.WriteLine(" ");

                    i = 0;
                    return PlayerInput(alphabet, usedletters);


                }
                else if (letter.Contains("1") || letter.Contains("2") || letter.Contains("3") || letter.Contains("4") || letter.Contains("5") || letter.Contains("6") || letter.Contains("7") || letter.Contains("8") || letter.Contains("9"))
                {

                    Console.WriteLine(" ");
                    Console.Write("You inputed a number, Please try again!!       ");
                    Console.WriteLine(" ");

                    i = 0;
                    return PlayerInput(alphabet, usedletters);
                }
                
            }
            return letter;
        }
        public static void ScreenUpdate(string[] alphabet,char[] word, string usedletters)
        {

            foreach (char item in word)
            {
                Console.Write($"{item}");
            }

            Console.WriteLine(" ");


            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.Write($"{alphabet[i]}, ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"The letters used are = {usedletters}");
            Console.WriteLine(" ");
        }
        public static void UpdateHang(int x)
        {
            string hang = string.Empty;
            if (x == 0)
            {
                hang = ("                              \n" +
                "                              \n" +
                "             =================\n" +
                "             ||            |||\n" +
                "             ||            |||\n" +
                "             ||            |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "                           |||\n" +
                "        ===============================\n" +
                " ");
                Console.WriteLine(hang);

            }

            if (x == 1)
            {
                hang = ("                              \n" +
            "                              \n" +
            "             =================\n" +
            "             ||            |||\n" +
            "             ||            |||\n" +
            "             ||            |||\n" +
            "             oo            |||\n" +
            "            o  o           |||\n" +
            "             oo            |||\n" +
            "                           |||\n" +
            "                           |||\n" +
            "                           |||\n" +
            "                           |||\n" +
            "                           |||\n" +
            "                           |||\n" +
            "                           |||\n" +
            "                           |||\n" +
            "        ===============================\n" +
                " ");
                Console.WriteLine(hang);
            }

            if (x == 2)
            {
                hang = ("                              \n" +
               "                              \n" +
               "             =================\n" +
               "             ||            |||\n" +
               "             ||            |||\n" +
               "             ||            |||\n" +
               "             oo            |||\n" +
               "            o  o           |||\n" +
               "             oo            |||\n" +
               "             oo            |||\n" +
               "             oo            |||\n" +
               "             oo            |||\n" +
               "             oo            |||\n" +
               "                           |||\n" +
               "                           |||\n" +
               "                           |||\n" +
               "                           |||\n" +
               "        ===============================\n" +
                " ");
                Console.WriteLine(hang);
            }
            if (x == 3)
            {

                hang = ("                              \n" +
              "                              \n" +
              "             =================\n" +
              "             ||            |||\n" +
              "             ||            |||\n" +
              "             ||            |||\n" +
              "             oo            |||\n" +
              "            o  o           |||\n" +
              "             oo            |||\n" +
              "             oo            |||\n" +
              "             oo            |||\n" +
              "             oo            |||\n" +
              "             oo            |||\n" +
              "            o              |||\n" +
              "           o               |||\n" +
              "          o                |||\n" +
              "                           |||\n" +
              "        ===============================\n" +
                " ");
                Console.WriteLine(hang);
            }

            if (x == 4)
            {
                hang = ("                              \n" +
            "                              \n" +
            "             =================\n" +
            "             ||            |||\n" +
            "             ||            |||\n" +
            "             ||            |||\n" +
            "             oo            |||\n" +
            "            o  o           |||\n" +
            "             oo            |||\n" +
            "             oo            |||\n" +
            "             oo            |||\n" +
            "             oo            |||\n" +
            "             oo            |||\n" +
            "            o  o           |||\n" +
            "           o    o          |||\n" +
            "          o      o         |||\n" +
            "                           |||\n" +
            "        ===============================\n" +
                " ");
                Console.WriteLine(hang);
            }
            if (x == 5)
            {
                hang = ("                              \n" +
               "                              \n" +
               "             =================\n" +
               "             ||            |||\n" +
               "             ||            |||\n" +
               "             ||            |||\n" +
               "             oo            |||\n" +
               "            o  o           |||\n" +
               "             oo            |||\n" +
               "             oooooooo      |||\n" +
               "             oo            |||\n" +
               "             oo            |||\n" +
               "             oo            |||\n" +
               "            o  o           |||\n" +
               "           o    o          |||\n" +
               "          o      o         |||\n" +
               "                           |||\n" +
               "        ===============================\n" +
                " ");
                Console.WriteLine(hang);
            }
            if (x == 6)
            {
                hang = ("                              \n" +
                   "                              \n" +
                   "             =================\n" +
                   "             ||            |||\n" +
                   "             ||            |||\n" +
                   "             ||            |||\n" +
                   "             oo            |||\n" +
                   "            o  o           |||\n" +
                   "             oo            |||\n" +
                   "       oooooooooooooo      |||\n" +
                   "             oo            |||\n" +
                   "             oo            |||\n" +
                   "             oo            |||\n" +
                   "            o  o           |||\n" +
                   "           o    o          |||\n" +
                   "          o      o         |||\n" +
                   "                           |||\n" +
                   "        ===============================\n" +
                " ");
                Console.WriteLine(hang);
            }


        }
    }
}
