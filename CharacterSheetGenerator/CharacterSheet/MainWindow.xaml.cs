using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CharacterSheet.Models;

namespace CharacterSheet
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CharacterGenerator.ResetCharacter();
            CharacterGenerator.AbilityScores();
            // general traits
            txtName.Text = CharacterGenerator.GetName();
            txtAlignment.Text = CharacterGenerator.GetAlignment();
            txtRace.Text = CharacterGenerator.GetRace();
            txtSize.Text = CharacterGenerator.GetSize();
            txtClass.Text = CharacterGenerator.GetClass();
            txtGender.Text = CharacterGenerator.GetGender();
            txtHP.Text = CharacterGenerator.GetHitPoints();
            txtSpeed.Text = CharacterGenerator.GetSpeed();

            // abilities
            txtStrength.Text = CharacterGenerator.GetStrength();
            txtDexterity.Text = CharacterGenerator.GetDexterity();
            txtConstituion.Text = CharacterGenerator.GetConstitution();
            txtIntelligence.Text = CharacterGenerator.GetIntelligence();
            txtWisdom.Text = CharacterGenerator.GetWisdom();
            txtCharisma.Text = CharacterGenerator.GetCharisma();

            // skills
            chkBoxAcrobatics.IsChecked = CharacterGenerator.GetAcrobatcis();
            chkBoxBluff.IsChecked = CharacterGenerator.GetBluff();
            chkBoxClimb.IsChecked = CharacterGenerator.GetClimb();
            chkBoxDiplomacy.IsChecked = CharacterGenerator.GetDiplomacy();
            chkBoxFly.IsChecked = CharacterGenerator.GetFly();
            chkBoxHeal.IsChecked = CharacterGenerator.GetHeal();
            chkBoxIntimidate.IsChecked = CharacterGenerator.GetIntimidate();
            chkBoxPerception.IsChecked = CharacterGenerator.GetPerception();
            chkBoxStealth.IsChecked = CharacterGenerator.GetStealth();

        }
    }
}
