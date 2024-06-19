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

namespace SEBeginner6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loopBtn_Click(object sender, RoutedEventArgs e)
        {
            string myString = "Hello man";

            List<int> myList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            myList.Clear();

            for (int i = 0; i < 10; i = i + 4)
            {
                myList.Add(i);
                i = i - 2;
            }

            //int i = 20;

            //for (; i < 50;)
            //{
            //    myList.Add(i);

            //}
            for (int i = 0; i < myList.Count; i++)
            {
                MessageBox.Show(myList[i].ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> myGuns = new List<string>() { "M24", "Kar98", "AUG" };
            myGuns.AddRange(new List<string>() { "M416", "AWM" });
            myGuns.Add("UMP");
            myGuns.Add("Beryl");

            foreach (var item in myGuns.ToList())
            {
                if (item == myGuns[myGuns.Count-3])
                {
                    myGuns[5] = "MK14";
                    
                }
                MessageBox.Show(item);
            }


            //for (int i = 0; i < myGuns.Count; i++)
            //{
            //    if (i == 2)
            //    {
            //        myGuns.Insert(5, "P90");
            //    }

            //    MessageBox.Show(myGuns[i]);

            //}

            int[,] Array2D = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        }

        

        private void While_Click(object sender, RoutedEventArgs e)
        {

            int i = 6;
            while (true)
            {

                MessageBox.Show(i.ToString());
                if (i % 5 == 0 && i > 7)
                    break;

                i++;
            }
        }

        private void DoWhile_Click(object sender, RoutedEventArgs e)
        {
            int i=6;
            do
            {
                MessageBox.Show(i.ToString());
                i++;
            } while (i<6);
        }

        private void Thread_Click(object sender, RoutedEventArgs e)
        {
            labelCounter.Content = "test content";
            int i = 0;

            int iThreadSleepsMs = 500;

            bool ParsResult = int.TryParse(txtSleepsMs.Text,out iThreadSleepsMs);

            if (!ParsResult)
            {
                iThreadSleepsMs = 500;
            }

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    labelCounter.Dispatcher.Invoke(new Action(() =>
                    {
                        labelCounter.Content = i.ToString();
                    }));


                    System.Threading.Thread.Sleep(iThreadSleepsMs);
                    i++;
                }
            });
            //List<string> myDates = new List<string>();

            //for (int i = 0; i < 7; i++)
            //{
            //    myDates.Add(DateTime.Now.ToString());
            //    System.Threading.Thread.Sleep(2* 1000);
            //}

        }
    }
}