using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace SEBeginner7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            initPunchComboBox();
            initMultiplePunchComboBox();



        }

        public class MultiplePunchCombination
        {
            public string Name { get; set; } = "NoCombo";
            public int NumberOfPunches { get; set; } = 0;


        }
        private void initMultiplePunchComboBox()
        {
            List<MultiplePunchCombination> myFavCombos = new List<MultiplePunchCombination>();

            myFavCombos.Add(new MultiplePunchCombination { Name = "JabCross", NumberOfPunches = 2 });

            

            MultiplePunchCombination secondCombo = new MultiplePunchCombination();
            secondCombo.Name = "HookUppercut";
            secondCombo.NumberOfPunches = 2;

            MultiplePunchCombination thirdCombo = new MultiplePunchCombination() { Name ="JabHookCross",NumberOfPunches=3};
            myFavCombos.Add(secondCombo);
            myFavCombos.Add(thirdCombo);

            MultiplePunchCombination defaultCombo = new MultiplePunchCombination();
            myFavCombos.Add(defaultCombo);

            myFavCombos.Add(new MultiplePunchCombination());
            myFavCombos.Last().Name = "JabJab";
            myFavCombos.Last().NumberOfPunches = 2;

            ComboTypesBox.ItemsSource = myFavCombos;
            ComboTypesBox.DisplayMemberPath = "Name";
            ComboTypesBox.SelectedValuePath = "NumberOfPunches";

            ComboTypesBox.SelectedIndex = 0;

            for (int i = 0; i < myFavCombos.Count; i++)
            {
                myFavCombos[i].Name = myFavCombos[i].Name + $"({myFavCombos[i].NumberOfPunches.ToString("N0")})";
            }

        }
        private void initPunchComboBox()
        {
            PunchTypesBox.Items.Add("Jab");
            PunchTypesBox.Items.Add("Cross");
            PunchTypesBox.Items.Add("Hook");
            PunchTypesBox.Items.Add("Uppercut");
            PunchTypesBox.Items.Add("Clap");


            PunchTypesBox.SelectedIndex = 0;
        }



        private void PunchInfo_Click(object sender, RoutedEventArgs e)
        {
            var SelectedPunch = PunchTypesBox.SelectedItem.ToString();

            int speedPoint;
            int damagePiont;
            int reachPiont;

            //switch (SelectedPunch)
            //{
            //    case "Jab":
            //        speedPoint = 5;
            //        damagePiont = 1;
            //        reachPiont = 3;
            //        break;
            //    case "Cross":
            //        speedPoint = 4;
            //        damagePiont = 2;
            //        reachPiont = 4;
            //        break;
            //    case "Hook":
            //        speedPoint = 3;
            //        damagePiont = 3;
            //        reachPiont = 2;
            //        break;
            //    case "Uppercut":
            //        speedPoint = 2;
            //        damagePiont = 4;
            //        reachPiont = 2;
            //        break;
            //    default:
            //        speedPoint = 0;
            //        damagePiont = 0;
            //        reachPiont = 0;
            //        SelectedPunch = "No punch Selected";
            //        break;
            //}

            if (SelectedPunch == "Jab")
            {
                speedPoint = 5;
                damagePiont = 1;
                reachPiont = 3;
            }
            else if (SelectedPunch == "Cross")
            {
                speedPoint = 4;
                damagePiont = 2;
                reachPiont = 4;
            }
            else if (SelectedPunch == "Hook")
            {
                speedPoint = 3;
                damagePiont = 3;
                reachPiont = 2;
            }
            else if (SelectedPunch == "Uppercut")
            {
                speedPoint = 2;
                damagePiont = 4;
                reachPiont = 2;
            }
            else
            {
                speedPoint = 0;
                damagePiont = 0;
                reachPiont = 0;
                SelectedPunch = "No punch Selected";
            }

            MessageBox.Show($@"{SelectedPunch} has Speed: {speedPoint}
        damage: {damagePiont} and reach: {reachPiont}");
        }

        private void MultiplePunchCount_Click(object sender, RoutedEventArgs e)
        {
            int SelectedComboCount = (int)ComboTypesBox.SelectedValue;
            
            //WriteAs1String(SelectedComboCount);
            //WriteAsLines(SelectedComboCount);
            //WriteAppendText(SelectedComboCount);
            StreamWriterText(SelectedComboCount);
        }
        private void WriteAs1String(int RndNumberCount)
        {
            Random myRand = new Random();

            string RandomNumbers = "";

            for (int i = 0; i < RndNumberCount; i++)
            {
                RandomNumbers += $"Index {i}" + myRand.Next().ToString("N0");
            }

            File.WriteAllText("WriteAs1String.text", RandomNumbers, Encoding.UTF8);
        }

        private void WriteAsLines(int RndNumberCount)
        {
            Random myRand = new Random();

            List<string>  lines = new List<string>();
            for (int i = 0; i < RndNumberCount; i++)
            {
                lines.Add($"Index {i}" + myRand.Next().ToString("N0"));
            }
            File.WriteAllLines("WriteAsLines", lines, Encoding.UTF8);
        }
        private void WriteAppendText(int RndNumberCount)
        {
            Random myRand = new Random();

            

            for (int i = 0; i < RndNumberCount; i++)
            {
                File.AppendAllText("WriteAppendText.txt", $"Index{i}:\t\t" + myRand.Next().ToString("N0") + Environment.NewLine, Encoding.UTF8);

                File.WriteAllText("WriteAs1String.txt", $"Index{i}:\t\t" + myRand.Next().ToString("N0") + Environment.NewLine, Encoding.UTF8);
            }

            
        }
        private void StreamWriterText(int RndNumberCount)
        {
            Random myRand = new Random();
            StreamWriter myStWriterNoAppend = new StreamWriter("StreamWruterNoAppend.txt",append: false,Encoding.UTF8);

            StreamWriter myStWriterAppend = new StreamWriter("StreamWruterAppend.txt", append: true, Encoding.UTF8);

            StreamWriter myStWriterNoAppend_autoFlush = new StreamWriter("StreamWruterNoAppend_AutoFlush.txt", append: false, Encoding.UTF8);
            myStWriterNoAppend_autoFlush.AutoFlush = true;

            StreamWriter myStWriterAppend_autoFlush = new StreamWriter("StreamWruterAppend_AutoFlush.txt", append: true, Encoding.UTF8);
            myStWriterAppend_autoFlush.AutoFlush = true;

            List<StreamWriter> myStrWritters= new List<StreamWriter>() { myStWriterNoAppend, myStWriterAppend,
                myStWriterNoAppend_autoFlush, myStWriterAppend_autoFlush };

            for (int i = 0; i < RndNumberCount; i++)
            {
                myStWriterNoAppend.WriteLine($"Index {i}: + {myRand.Next().ToString("N0")}");
                myStWriterNoAppend.Flush();

                myStWriterAppend.WriteLine($"Index {i}: + {myRand.Next().ToString("N0")}");
                myStWriterAppend.Flush();

                myStWriterNoAppend_autoFlush.WriteLine($"Index {i}: + {myRand.Next().ToString("N0")}");

                myStWriterAppend_autoFlush.WriteLine($"Index {i}: + {myRand.Next().ToString("N0")}");
            }
            foreach (var item in myStrWritters)
            {
                item.Close();
            }

        }

        private void btnFileReader_Click(object sender, RoutedEventArgs e)
        {
            string wholeFile = File.ReadAllText("StreamWruterAppend.text", Encoding.UTF8);

            string wholeFile_2 = "";
            foreach (string line in File.ReadLines("StreamWruterAppend.text", Encoding.UTF8))
            {
                wholeFile_2 += line + Environment.NewLine;
            }

            string wholeFile_3 = "";
            List<string> myList = File.ReadAllLines("StreamWruterAppend.text", Encoding.UTF8).ToList();
            wholeFile_3 = string.Join("\r\n", myList);

            string wholeFile_4 = "";
            StreamReader myStrmReader = new StreamReader("StreamWruterAppend.text", Encoding.UTF8);
            wholeFile_4 = myStrmReader.ReadToEnd();
            myStrmReader.Close();

            string wholeFile_5 = "";
            myStrmReader = new StreamReader("StreamWruterAppend.text", Encoding.UTF8);
            while (true)
            {
                string newLine = myStrmReader.ReadLine();
                if (string.IsNullOrEmpty(newLine) == true)
                    break;
                wholeFile_5 += newLine;
            }
            myStrmReader.Close();

        }
}