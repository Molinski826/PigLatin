//PigLatin



using System.ComponentModel.Design;
bool runProgram = true;
while (runProgram == true)
{
    Console.WriteLine("Welcome to the Pig Latin Translator!");

    Console.Write("Please enter a word: ");
    string sentence = Console.ReadLine();

    bool value = hasSpecialChar(sentence);


    //split
    string[] words = sentence.Split(" ");
    foreach (string word in words)

        if (hasSpecialChar(word) == true)
        {
            Console.WriteLine(word);
        }
        else
        {

            string pigWord = "";
            string beforeV = "";
            string afterV = "";

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];

                if (currentLetter == 'a' || currentLetter == 'e' || currentLetter == 'i' || currentLetter == 'o' || currentLetter == 'u' || currentLetter == 'A' || currentLetter == 'E' || currentLetter == 'I' || currentLetter == 'O' || currentLetter == 'U')
                {
                    if (i == 0)
                    {
                        pigWord = word + "way";
                        break;


                    }

                    else
                    {
                        beforeV = word.Substring(0, i);
                        afterV = word.Substring(i);
                        pigWord = afterV + beforeV + "ay";
                        break;
                    }

                }

            }
            Console.Write(pigWord + " ");
        }




    static bool hasSpecialChar(string input)
    {
        string specialChar = ("@|#$%&/()=»«@£§€{}-;<>_0123456789");
        foreach (var item in specialChar)
        {
            if (input.Contains(item)) return true;
            break;

        }

        return false;


    }
    while (true)
    {
        Console.WriteLine("");
        Console.Write("Would you like to translate more words?:  y/n");
        string loopChoice = Console.ReadLine();
        if (loopChoice == "y")
        {
            break;
        }
        else if (loopChoice == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}

