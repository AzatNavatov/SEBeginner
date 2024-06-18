internal class Program
{
    private static void Main(string[] args)
    {
        string[] myItems = new string[] { "Laptop", "bottle", "mouse", "backpack" };
        Console.WriteLine(myItems[1]);

        char[] someChars = new char[33];

        Console.WriteLine(someChars[0]);

        int[] digits;

        digits = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine(digits[7]);
        Console.WriteLine(myItems.Length);

        string joinedMyItems = string.Join("+", myItems);
        Console.WriteLine($"{joinedMyItems}");
        Console.WriteLine($"{{joinedMyItems}}");
        Console.WriteLine($"{{{joinedMyItems}}}");

        string sentence = "my items are: ";

        for (int i = 0; i < myItems.Length; i++)
        {
            sentence += myItems[i];
            if ((i + 1) < myItems.Length)
            {
                sentence = sentence + ",";
            }
        }
        Console.WriteLine(sentence);


        int irCounter = 0;
        foreach (string item in myItems)
        {
            if (irCounter == 0)
            {
                Console.WriteLine("This is my: " + item + " and");
            }
            else if (irCounter + 1 < myItems.Length)
            {
                Console.WriteLine("this is my: " + item + " and");
            }

            else
            {
                Console.WriteLine("this is my: " + item + ".");
            }
            irCounter++;
        }

        string myName = "Navatov Azat";

        string myInitials = myName.Substring(0,1) +"."+ myName.Substring(8,1)+".";
        Console.WriteLine(myInitials);

        Console.Clear();

        Random myRand = new Random();
        int[] my11 = new int[11];

        string frArray = string.Join("\t", my11);
        Console.WriteLine("my list without adding values: " + Environment.NewLine + frArray);

        for (int i = 0;i < my11.Length;i++) 
        {
            my11[i] = myRand.Next(8000,10000);
        }

        frArray = string.Join("\t", my11);
        Console.WriteLine("my list after adding values: " + Environment.NewLine + frArray);

        frArray = "";

        for (int i = 0; i < my11.Length; i++)
        {
            frArray += my11[i].ToString("N0");
            if((i)<my11.Length) 
            { 
                frArray = frArray + "\t";
            }
        }

        Console.WriteLine("my list after formatting woth 1000 point:" + Environment.NewLine + frArray);

        Array.Sort(my11);

        frArray = string.Join("\t", my11.Select(a=>a.ToString("N0")));

        Console.WriteLine("After asc sorting and 1000 formattong: " + Environment.NewLine + frArray);

        Array.Reverse(my11);

        frArray = string.Join("\t", my11.Select(a => a.ToString("N0")));

        Console.WriteLine("After desc sorting and 1000 formattong: " + Environment.NewLine + frArray);

        my11[9] = 12500;
        frArray = string.Join("\t", my11.Select(a => a.ToString("N0")));

        Console.WriteLine("After adding new number: " + Environment.NewLine + frArray);

     

        int[] my12 = new int[12];
        my11.CopyTo(my12, 0);

        my12[10] = 12000;

        frArray = string.Join("\t", my12.Select(a => a.ToString("N0")));
        Console.WriteLine("After adding new number after copying the previous array to new one: " + Environment.NewLine + frArray);







    }
}