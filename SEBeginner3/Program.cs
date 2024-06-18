using Microsoft.VisualBasic;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        var currtime = DateTime.Now;

        Console.WriteLine("first formatted method!");
        var vrformattedTime = FormattedDateTimeMethod(currtime, "{0:t}");
        Console.WriteLine(vrformattedTime);

        Console.WriteLine("second formatted method!");
        vrformattedTime = FormattedDateTimeMethod(currtime, "{0:T}");
        Console.WriteLine(vrformattedTime);

        string formattedDate = string.Format("This is {0:dddd, MMMM dd, yyyy}", currtime);
        Console.WriteLine(formattedDate);

        List<string> myData = new List<string>();
        myData.Add("Navatov");
        myData.Add("Azat");
        myData.Add("anavatov4@gmail.com");

        Console.WriteLine("My name is {0} {1}, and this is my email:{2}", myData[0], myData[1], myData[2]);

        string sentence = string.Format("My name is {0} {1}, and this is my email:{2}", myData[0], myData[1], myData[2]);

        Console.WriteLine(sentence + " ou");

        Console.WriteLine(myData.Capacity.ToString());
        string sentenceInline = string.Format($"My name is {myData[0]} {myData[1]}, and this is my email:{myData[2]} for inline");
        Console.WriteLine(sentenceInline);

        string newsentence = FormattedDate2(currtime, "This is {0:dddd, MMMM dd, yyyy,hh:mm} from my own method");

        Console.WriteLine(newsentence);
        Console.WriteLine(DateTime.Now.Hour);

        var poslezavtra = DateTime.Now.AddDays(2.2);
        string futuresentence = FormattedDate2(poslezavtra, "The day after tomorrow: {0:dd MMMM yyyy, HH mm tt}");
        Console.WriteLine(futuresentence);

        DateTime tomorrow = DateTime.Now.AddHours(24);
        string closefuturesent = FormattedDate3("The day after today: {0:dd MMMM yyyy, HH mm tt}", tomorrow);
        Console.WriteLine(closefuturesent);

        var myNewDate = DateTime.Now + new TimeSpan(24, 30, 0);
        Console.WriteLine("Tomorrow is" + myNewDate);

        var myNum = 35.54 + 30;

        myNum = Math.Round(myNum, 3);
        Console.WriteLine(myNum);

        float myNum2 = 22.32312f;

        Console.WriteLine(myNum2.ToString("N4"));

        double myNum3 = Math.Floor(myNum2);

        Console.WriteLine(myNum3);

        Console.WriteLine("Current culture " + Thread.CurrentThread.CurrentCulture.Name);
        Console.WriteLine("Current culture " + myNum2.ToString("N2"));

        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");

        Console.WriteLine("New culture " + Thread.CurrentThread.CurrentCulture.Name);
        Console.WriteLine("New culture " + myNum2.ToString("N2"));

        var stnum1 = "35,152,773.22";
        var stnum2 = "35.152.773,22";

        double num1;
        double num2;

        if(double.TryParse(stnum1, out num1))
        {
            Console.WriteLine($"{num1}");
        }
        else
        {
            Console.WriteLine("Failed");
        }

        if (double.TryParse(stnum2, out num2))
        {
            Console.WriteLine($"{num2}");
        }
        else
        {
            Console.WriteLine("Failed");
        }

    }

    private static string FormattedDate2(DateTime consideredDate, string format)
    {
        return string.Format(format, consideredDate);
    }

    private static string FormattedDate3(string format, DateTime consideredDate)
    {
        return string.Format(format, consideredDate);
    }















    private static string FormattedDateTimeMethod(DateTime ourDateTime, string srDateFormat)
    {
        return string.Format(srDateFormat, ourDateTime);
    }
}