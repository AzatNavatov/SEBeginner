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

namespace SEBeginner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboboxUserIF();
            MultipleCmbCombobox();
        }
        void ComboboxUserIF()
        {
            cmbUser.Items.Add("Hook");
            cmbUser.Items.Add("Uppercut");
            cmbUser.Items.Add("Jab");
            cmbUser.Items.Add("Cross");
            cmbUser.Items.Add("LegKick");

            cmbUser.SelectedIndex = 2;
        }
        public class MultiplePunchCmb
        {
            public string Name { get; set; } = "SomeComboName";
            public int NumberOfPunches { get; set; } = 0;
        }
        List<MultiplePunchCmb> multiplePunchCmbs = new List<MultiplePunchCmb>();
        private void MultipleCmbCombobox()
        {
                     
            MultiplePunchCmb firstCombo = new MultiplePunchCmb();
            firstCombo.Name = "JabCross";
            firstCombo.NumberOfPunches = 2;

            MultiplePunchCmb defaultCombo = new MultiplePunchCmb();

            MultiplePunchCmb SecondCombo = new MultiplePunchCmb() {Name="JabCrossHook", NumberOfPunches = 3 };

            multiplePunchCmbs.Add(firstCombo);
            multiplePunchCmbs.Add(SecondCombo);

            multiplePunchCmbs.Add(new MultiplePunchCmb() {Name="HookCroosHookUppercut", NumberOfPunches=4});


            multiplePunchCmbs.Add(new MultiplePunchCmb());
            multiplePunchCmbs.Last().Name = "HookUppercut";
            multiplePunchCmbs.Last().NumberOfPunches = 2;

            MultiplePunchCombobox.ItemsSource = multiplePunchCmbs;
            MultiplePunchCombobox.DisplayMemberPath = "DisplayMemberTEST";
            MultiplePunchCombobox.SelectedValuePath = "SelectedValuePathTEST";

            MultiplePunchCombobox.SelectedIndex = 0;

        }
        


        private void mmaButton_Click(object sender, RoutedEventArgs e)
        {

            var SelectedPunch = cmbUser.SelectedItem.ToString();

            int SpeedPoint;
            int DamagePoint;
            int ReachPoint;

            switch (SelectedPunch)
            {
                case "Jab":
                    SpeedPoint = 5;
                    DamagePoint = 1;
                    ReachPoint = 3;
                    break;

                case "Cross":
                    SpeedPoint = 3;
                    DamagePoint = 3;
                    ReachPoint = 4;
                    break;
                case "Hook":
                    SpeedPoint = 3;
                    DamagePoint = 4;
                    ReachPoint = 2;
                    break;
                case "Uppercut":
                    SpeedPoint = 2;
                    DamagePoint = 4;
                    ReachPoint = 2;
                    break;
                default: 
                    SpeedPoint = 0;
                    DamagePoint = 0;
                    ReachPoint = 0;
                    SelectedPunch = "No punch selected";
                    break;
            }
            MessageBox.Show($@"{SelectedPunch} has Speed of {SpeedPoint} units 
                                Damage of {DamagePoint} units and
                                Range of {ReachPoint} units");
        }

        

      
    }
}