internal class Program
{
    private static void Main(string[] args)
    {
        //FirstPart();
        int[][] JgArray = new int[2][];

        Random myRand = new Random();

        for (int i = 0; i < JgArray.GetLength(0); i++)
        {
            JgArray[i] = new int[myRand.Next(80, 92)];
        }


        List<int> myList = new List<int>();
        myList.Add(25);
        myList.Add(30);
        myList.Add(50);
        myList.Add(35);

        myList.Remove(35);

        myList.RemoveAt(myList.Count - 1);
        Console.WriteLine(string.Join(";", myList));

        int[] myListArray = myList.ToArray();
        myList.AddRange(new List<int> { 88, 99 });

        bool Contain88 = myList.Contains(88);
        bool Contain2000 = myList.Contains(200);
        Console.WriteLine($"Our list contains contains 88:" + Contain88 +
            Environment.NewLine + "Our list contains 2000:" + Contain2000);

        int[] myArray = new int[] { 10, 20, 30, 40, 55, 20 };

        myList.CopyTo(myArray, 1);

        Console.WriteLine(string.Join(",", myArray));
        Console.WriteLine(string.Join(",", myList));

        myList.RemoveAll(x => x > 50);
        Console.WriteLine(string.Join(",", myList));

        bool Contain25 = myList.Exists(a => a == 25);
        bool Contain1000 = myList.Exists(a => a == 1000);
        Console.WriteLine($"{Contain25} + {Contain1000}");


        int[] myArrayOp = new int[] { 2, 5, 10 };

        if (myArrayOp.Length > 4 & myArrayOp[1] == 12)
        {
            Console.WriteLine("&");
        }

        if (myArrayOp.Length > 4 && myArrayOp[1] == 12)
        {
            Console.WriteLine("&&");
        }


    }
    static void FirstPart()
    {
        int[] oneDimArray = new int[] { 10, 20, 30, 40, 55 };

        oneDimArray[1] = 25;

        int[] tempOneDimArray = new int[oneDimArray.Length];
        Array.Copy(oneDimArray, tempOneDimArray, oneDimArray.Length);

        oneDimArray = new int[10];

        Array.Copy(tempOneDimArray, oneDimArray, tempOneDimArray.Length);

        int[,,,,] Dim5Array = new int[2, 5, 10, 20, 2];


        Console.WriteLine($"Length of our 5D Array {Dim5Array.Length.ToString("N0")}");


        Console.WriteLine($"Length of our 5D Array {Dim5Array.GetLength(0).ToString("N0")}");


    }
}