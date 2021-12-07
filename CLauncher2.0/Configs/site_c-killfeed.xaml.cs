using System;
using Launcher;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Threading;
using System.Windows.Threading;

namespace CLauncher2._0.Configs
{
    /// <summary>
    /// Interaktionslogik für site_c_killfeed.xaml
    /// </summary>
    public partial class site_c_killfeed : Page
    {
        public site_c_killfeed()
        {
            InitializeComponent();

            // ========================================== Loading User-Configs ==========================================
            Team_Kill = config.Default.Team_KillS;
            Team_Killed = config.Default.Team_KilledS;
            Assist = config.Default.AssistS;
            Enemy_Kill = config.Default.Enemy_KillS;
            Enemy_Killed = config.Default.Enemy_KilledS;

            Color_Enemy = config.Default.Color_EnemyS;
            Color_Team = config.Default.Color_TeamS;
            Color_Assist = config.Default.Color_AssistS;

            teamComboBox.SelectedIndex = config.Default.team_Color;
            assistComboBox.SelectedIndex = config.Default.assist_Color;
            enemyComboBox.SelectedIndex = config.Default.enemy_Color;

            teamKilledComboBox.SelectedIndex = config.Default.teamKilled_Color;
            enemyKilledComboBox.SelectedIndex = config.Default.enemyKilled_Color;

            TeamKill_Preview.Content = Team_Kill;
            EnemyKilled_Preview.Content = Enemy_Kill;


            TeamKill_Box.Text = Team_Kill;
            EnemyKill_Box.Text = Enemy_Kill;
            Assist_Box.Text = Assist;
            TeamKilled_Box.Text = Team_Killed;
            EnemyKilled_Box.Text = Enemy_Killed;
        }


        //Colors-Killfeed
        string Red = "<col:Action_Enemy>";//
        string Red2 = "<col:Action_Enemy>";
        string Faded_Red = "<col:Scoreboard_Opponents_Offline>";//
        string Faded_Red2 = "<col:Scoreboard_Opponents_Offline>";
        string Blue = "<col:Blue>";//
        string Blue2 = "<col:Blue>";
        string Light_Blue = "<col:Mailbox>";//<Color:R=0 G=0.420 B=1>
        string Light_Blue2 = "<Color:R=0 G=0.420 B=1>";
        string Baby_Blue = "<col:TaskCheckpoint_TaintedDefend>";//
        string Baby_Blue2 = "<col:TaskCheckpoint_TaintedDefend>";
        string Darker_Blue = "<col:Blue_Enforcer>";//<Color:R=0.004 G=0.110 B=239>
        string Darker_Blue2 = "<Color:R=0.004 G=0.110 B=239>";
        string Very_Pale_Blue = "<col:Blue_Pale>"; //<Color:R=0.667 G=0.667 B=1>
        string Very_Pale_Blue2 = "<Color:R=0.667 G=0.667 B=1>";
        string Mild_Blue = "<col:Blue_mid>";//<Color:R=0.196 G=0.416 B=1>
        string Mild_Blue2 = "<Color:R=0.196 G=0.416 B=1>";
        string Green = "<col:Green>";//<Color:R=0 G=1 B=0>
        string Green2 = "<Color:R=0 G=1 B=0>";
        string Light_Green = "<col:Chat_Group>";//
        string Light_Green2 = "<col:Chat_Group>";
        string Minty_Green = "<col:ElectiveCorpse_Teammate>"; //<Color:R=0.400 G=0.675 B=0.008>
        string Minty_Green2 = "<Color:R=0.400 G=0.675 B=0.008>";
        string Light_Vibrant_Green = "<col:Group_Player_Arrested>";//
        string Light_Vibrant_Green2 = "<col:Group_Player_Arrested>";
        string Pale_Green = "<col:Green_TaskMarker>"; //<Color:R=0.400 G=1 B=0>
        string Pale_Green2 = "<Color:R=0.400 G=1 B=0>";
        string Dark_Green = "<col:Green_VeryDark>"; //<Color:R=0.098 G=0.549 B=0.196>
        string Dark_Green2 = "<Color:R=0.098 G=0.549 B=0.196>";
        string Yellow = "<col:Chat_Mission>";//
        string Yellow2 = "<col:Chat_Mission>";
        string Goldenish_Yellow = "<col:Minigame_FindTarget_DevOps>";//<Color:R=0.984 G=0.722 B=0.016>
        string Goldenish_Yellow2 = "<Color:R=0.984 G=0.722 B=0.016>";
        string Light_Yellow = "<col:Waypoint_Leader>";//
        string Light_Yellow2 = "<col:Waypoint_Leader>";
        string Paler_Yellow = "<col:Chat_Name>"; //<Color:R=1 G=1 B=0.725>
        string Paler_Yellow2 = "<Color:R=1 G=1 B=0.725>";
        string Dark_Yellow = "<col:ED_persona>";//<Color:R=1 G=0.8 B=0.3>
        string Dark_Yellow2 = "<Color:R=1 G=0.8 B=0.3>";
        string Purple = "<col:ED_wardrobe>"; //<Color:R=0.596 G=0.082 B=0.769>
        string Purple2 = "<Color:R=0.596 G=0.082 B=0.769>";
        string Purple_Magenta = "<col:Halloween_Zombicine>";//
        string Purple_Magenta2 = "<col:Halloween_Zombicine>";
        string Slightly_Lighter_Purple = "<col:Purple_Bright>"; //<Color:R=0.3 G=0 B=0.5>
        string Slightly_Lighter_Purple2 = "<Color:R=0.3 G=0 B=0.5>";
        string Light_Pink = "<col:Valentine_Pink>"; //<Color:R=1 G=0.518 B=0.863>
        string Light_Pink2 = "<Color:R=1 G=0.518 B=0.863>";
        string Orange = "<col:Halloween_Orange>"; //<Color:R=1 G=0.400 B=0>
        string Orange2 = "<Color:R=1 G=0.400 B=0>";
        string Dark_Orange = "<col:Orange_Dark>";//
        string Dark_Orange2 = "<col:Orange_Dark>";
        string White = "<col:ScoreBreakdown_Name>";//
        string White2 = "<col:ScoreBreakdown_Name>";
        string Yellowish_White = "<col:Yellow_Pale>";//
        string Yellowish_White2 = "<col:Yellow_Pale>";
        string Grey = "<col:openworld_marker>";//
        string Grey2 = "<col:openworld_marker>";
        string Light_Grey = "<col:Faction_Friendly>";//
        string Light_Grey2 = "<col:Faction_Friendly>";
        string Grey_Darkish = "<col:Inactive>";//
        string Grey_Darkish2 = "<col:Inactive>";
        string Very_Light_Grey = "<col:Chat_Broadcast>";//
        string Very_Light_Grey2 = "<col:Chat_Broadcast>";
        string Black = "<col:Black>";//
        string Black2 = "<col:Black>";

        string Color_Team;
        string Color_Enemy;
        string Color_Assist;
        string ColorEnd = "</col>";

        string Color_TeamKill;
        string Color_EnemyKill;

        string Team_Kill = "Team Kill";
        string Team_Killed = "Killed by";
        string Assist = "Assist";
        string Enemy_Kill = "Enemy Killed";
        string Enemy_Killed = "Killed by";

        // ============================================= Killfeed below - Dropmenu =============================================
        private void enemyKilledComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.enemyKilledComboBox.SelectedIndex == 0)
            {
                Color_EnemyKill = Red2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.Red);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.Red);

            }
            //Faded Red
            else if (this.enemyKilledComboBox.SelectedIndex == 1)
            {
                Color_EnemyKill = Faded_Red2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 251, 98, 98));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 251, 98, 98));
            }
            //Blue
            else if (this.enemyKilledComboBox.SelectedIndex == 2)
            {
                Color_EnemyKill = Blue2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.Blue);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.Blue);
            }
            //Light Blue
            else if (this.enemyKilledComboBox.SelectedIndex == 3)
            {
                Color_EnemyKill = Light_Blue2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.DodgerBlue);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.DodgerBlue);
            }
            //Baby Blue
            else if (this.enemyKilledComboBox.SelectedIndex == 4)
            {
                Color_EnemyKill = Baby_Blue2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.LightSkyBlue);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.LightSkyBlue);
            }
            //Darker Blue
            else if (this.enemyKilledComboBox.SelectedIndex == 5)
            {
                Color_EnemyKill = Darker_Blue2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkBlue);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.DarkBlue);
            }
            //Very Pale Blue
            else if (this.enemyKilledComboBox.SelectedIndex == 6)
            {
                Color_EnemyKill = Very_Pale_Blue2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.LightSteelBlue);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.LightSteelBlue);
            }
            //Mild Blue
            else if (this.enemyKilledComboBox.SelectedIndex == 7)
            {
                Color_EnemyKill = Mild_Blue2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
            }
            //Green
            else if (this.enemyKilledComboBox.SelectedIndex == 8)
            {
                Color_EnemyKill = Green2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.Green);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.Green);
            }
            //Light Green
            else if (this.enemyKilledComboBox.SelectedIndex == 9)
            {
                Color_EnemyKill = Light_Green2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.LightGreen);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.LightGreen);
            }
            //Minty Green
            else if (this.enemyKilledComboBox.SelectedIndex == 10)
            {
                Color_EnemyKill = Minty_Green2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.MediumAquamarine);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.MediumAquamarine);
            }
            //Light Vibrant Green
            else if (this.enemyKilledComboBox.SelectedIndex == 11)
            {
                Color_EnemyKill = Light_Vibrant_Green2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.MediumSeaGreen);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.MediumSeaGreen);
            }
            //Pale Green
            else if (this.enemyKilledComboBox.SelectedIndex == 12)
            {
                Color_EnemyKill = Pale_Green2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 173, 241, 171));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 173, 241, 171));
            }
            //Dark Green
            else if (this.enemyKilledComboBox.SelectedIndex == 13)
            {
                Color_EnemyKill = Dark_Green2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkGreen);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.DarkGreen);
            }
            //Yellow
            else if (this.enemyKilledComboBox.SelectedIndex == 14)
            {
                Color_EnemyKill = Yellow2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.Yellow);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            //Goldenish Yellow
            else if (this.enemyKilledComboBox.SelectedIndex == 15)
            {
                Color_EnemyKill = Goldenish_Yellow2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 240, 241, 85));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 240, 241, 85));
            }
            //Light Yellow
            else if (this.enemyKilledComboBox.SelectedIndex == 16)
            {
                Color_EnemyKill = Light_Yellow2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 239, 239, 153));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 239, 239, 153));
            }
            //Paler Yellow
            else if (this.enemyKilledComboBox.SelectedIndex == 17)
            {
                Color_EnemyKill = Paler_Yellow2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 237, 237, 182));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 237, 237, 182));
            }
            //Dark Yellow
            else if (this.enemyKilledComboBox.SelectedIndex == 18)
            {
                Color_EnemyKill = Dark_Yellow2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 183, 3));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 183, 3));
            }
            //Purple
            else if (this.enemyKilledComboBox.SelectedIndex == 19)
            {
                Color_EnemyKill = Purple2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.Purple);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.Purple);
            }
            //Purple Magenta
            else if (this.enemyKilledComboBox.SelectedIndex == 20)
            {
                Color_EnemyKill = Purple_Magenta2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 3, 168));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 3, 168));
            }
            //Slightly Lighter Purple
            else if (this.enemyKilledComboBox.SelectedIndex == 21)
            {
                Color_EnemyKill = Slightly_Lighter_Purple2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.MediumPurple);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.MediumPurple);
            }
            //Light Pink
            else if (this.enemyKilledComboBox.SelectedIndex == 22)
            {
                Color_EnemyKill = Light_Pink2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.LightPink);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.LightPink);
            }
            //Orange
            else if (this.enemyKilledComboBox.SelectedIndex == 23)
            {
                Color_EnemyKill = Orange2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.Orange);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.Orange);
            }
            //Dark Orange
            else if (this.enemyKilledComboBox.SelectedIndex == 24)
            {
                Color_EnemyKill = Dark_Orange2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkOrange);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.DarkOrange);
            }
            //White
            else if (this.enemyKilledComboBox.SelectedIndex == 25)
            {
                Color_EnemyKill = White2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.White);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.White);
            }
            //Yellowish White
            else if (this.enemyKilledComboBox.SelectedIndex == 26)
            {
                Color_EnemyKill = Yellowish_White2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 243, 243, 229));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 243, 243, 229));
            }
            //Grey
            else if (this.enemyKilledComboBox.SelectedIndex == 27)
            {
                Color_EnemyKill = Grey2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
            }
            //Light Grey
            else if (this.enemyKilledComboBox.SelectedIndex == 28)
            {
                Color_EnemyKill = Light_Grey2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 191, 191, 191));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 191, 191, 191));
            }
            //Grey Darkish
            else if (this.enemyKilledComboBox.SelectedIndex == 29)
            {
                Color_EnemyKill = Grey_Darkish2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
            }
            //Very Light Grey
            else if (this.enemyKilledComboBox.SelectedIndex == 30)
            {
                Color_EnemyKill = Very_Light_Grey2;
                EnemyKilledPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 224, 224, 224));
                EnemyKilled_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 224, 224, 224));
            }
            //Black
            else if (this.enemyKilledComboBox.SelectedIndex == 31)
            {
                Color_EnemyKill = Black2;
                EnemyKilledPlayer_Preview.Foreground = new SolidColorBrush(Colors.Black);
                EnemyKilled_Preview.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void teamKilledComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.teamKilledComboBox.SelectedIndex == 0)
            {
                Color_TeamKill = Red2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.Red);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.Red);

            }
            //Faded Red
            else if (this.teamKilledComboBox.SelectedIndex == 1)
            {
                Color_TeamKill = Faded_Red2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 251, 98, 98));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 251, 98, 98));
            }
            //Blue
            else if (this.teamKilledComboBox.SelectedIndex == 2)
            {
                Color_TeamKill = Blue2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.Blue);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.Blue);
            }
            //Light Blue
            else if (this.teamKilledComboBox.SelectedIndex == 3)
            {
                Color_TeamKill = Light_Blue2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.DodgerBlue);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.DodgerBlue);
            }
            //Baby Blue
            else if (this.teamKilledComboBox.SelectedIndex == 4)
            {
                Color_TeamKill = Baby_Blue2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.LightSkyBlue);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.LightSkyBlue);
            }
            //Darker Blue
            else if (this.teamKilledComboBox.SelectedIndex == 5)
            {
                Color_TeamKill = Darker_Blue2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkBlue);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.DarkBlue);
            }
            //Very Pale Blue 
            else if (this.teamKilledComboBox.SelectedIndex == 6)
            {
                Color_TeamKill = Very_Pale_Blue2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.LightSteelBlue);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.LightSteelBlue);
            }
            //Mild Blue
            else if (this.teamKilledComboBox.SelectedIndex == 7)
            {
                Color_TeamKill = Mild_Blue2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
            }
            //Green
            else if (this.teamKilledComboBox.SelectedIndex == 8)
            {
                Color_TeamKill = Green2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.Green);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.Green);
            }
            //Light Green
            else if (this.teamKilledComboBox.SelectedIndex == 9)
            {
                Color_TeamKill = Light_Green2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.LightGreen);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.LightGreen);
            }
            //Minty Green
            else if (this.teamKilledComboBox.SelectedIndex == 10)
            {
                Color_TeamKill = Minty_Green2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.MediumAquamarine);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.MediumAquamarine);
            }
            //Light Vibrant Green
            else if (this.teamKilledComboBox.SelectedIndex == 11)
            {
                Color_TeamKill = Light_Vibrant_Green2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.MediumSeaGreen);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.MediumSeaGreen);
            }
            //Pale Green
            else if (this.teamKilledComboBox.SelectedIndex == 12)
            {
                Color_TeamKill = Pale_Green2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 173, 241, 171));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 173, 241, 171));

            }
            //Dark Green
            else if (this.teamKilledComboBox.SelectedIndex == 13)
            {
                Color_TeamKill = Dark_Green2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkGreen);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.DarkGreen);
            }
            //Yellow
            else if (this.teamKilledComboBox.SelectedIndex == 14)
            {
                Color_TeamKill = Yellow2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.Yellow);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            //Goldenish Yellow
            else if (this.teamKilledComboBox.SelectedIndex == 15)
            {
                Color_TeamKill = Goldenish_Yellow2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 240, 241, 85));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 240, 241, 85));
            }
            //Light Yellow
            else if (this.teamKilledComboBox.SelectedIndex == 16)
            {
                Color_TeamKill = Light_Yellow2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 239, 239, 153));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 239, 239, 153));
            }
            //Paler Yellow
            else if (this.teamKilledComboBox.SelectedIndex == 17)
            {
                Color_TeamKill = Paler_Yellow2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 237, 237, 182));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 237, 237, 182));
            }
            //Dark Yellow
            else if (this.teamKilledComboBox.SelectedIndex == 18)
            {
                Color_TeamKill = Dark_Yellow2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 183, 3));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 183, 3));
            }
            //Purple
            else if (this.teamKilledComboBox.SelectedIndex == 19)
            {
                Color_TeamKill = Purple2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.Purple);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.Purple);
            }
            //Purple Magenta
            else if (this.teamKilledComboBox.SelectedIndex == 20)
            {
                Color_TeamKill = Purple_Magenta2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 3, 168));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 3, 168));
            }
            //Slightly Lighter Purple
            else if (this.teamKilledComboBox.SelectedIndex == 21)
            {
                Color_TeamKill = Slightly_Lighter_Purple2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.MediumPurple);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.MediumPurple);
            }
            //Light Pink
            else if (this.teamKilledComboBox.SelectedIndex == 22)
            {
                Color_TeamKill = Light_Pink2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.LightPink);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.LightPink);
            }
            //Orange
            else if (this.teamKilledComboBox.SelectedIndex == 23)
            {
                Color_TeamKill = Orange2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.Orange);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.Orange);
            }
            //Dark Orange
            else if (this.teamKilledComboBox.SelectedIndex == 24)
            {
                Color_TeamKill = Dark_Orange2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkOrange);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.DarkOrange);
            }
            //White
            else if (this.teamKilledComboBox.SelectedIndex == 25)
            {
                Color_TeamKill = White2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.White);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.White);
            }
            //Yellowish White
            else if (this.teamKilledComboBox.SelectedIndex == 26)
            {
                Color_TeamKill = Yellowish_White2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 243, 243, 229));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 243, 243, 229));
            }
            //Gray
            else if (this.teamKilledComboBox.SelectedIndex == 27)
            {
                Color_TeamKill = Grey2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
            }
            //Light Grey
            else if (this.teamKilledComboBox.SelectedIndex == 28)
            {
                Color_TeamKill = Light_Grey2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 191, 191, 191));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 191, 191, 191));
            }
            //Grey Darkish
            else if (this.teamKilledComboBox.SelectedIndex == 29)
            {
                Color_TeamKill = Grey_Darkish2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
            }
            //Very Light Grey
            else if (this.teamKilledComboBox.SelectedIndex == 30)
            {
                Color_TeamKill = Very_Light_Grey2;
                TeamKillPlayer_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 224, 224, 224));
                TeamKill_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 224, 224, 224));
            }
            //Black
            else if (this.teamKilledComboBox.SelectedIndex == 31)
            {
                Color_TeamKill = Black2;
                TeamKillPlayer_Preview.Foreground = new SolidColorBrush(Colors.Black);
                TeamKill_Preview.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
        // ============================================= Killfeed - Dropmenu =============================================
        private void teamComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.teamComboBox.SelectedIndex == 0)
            {
                Color_Team = Red;
                Player_Preview.Foreground = new SolidColorBrush(Colors.Red);

            }
            //Faded Red
            else if (this.teamComboBox.SelectedIndex == 1)
            {
                Color_Team = Faded_Red;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 251, 98, 98));

            }
            //Blue
            else if (this.teamComboBox.SelectedIndex == 2)
            {
                Color_Team = Blue;
                Player_Preview.Foreground = new SolidColorBrush(Colors.Blue);
            }
            //Light Blue
            else if (this.teamComboBox.SelectedIndex == 3)
            {
                Color_Team = Light_Blue;
                Player_Preview.Foreground = new SolidColorBrush(Colors.DodgerBlue);
            }
            //Baby Blue
            else if (this.teamComboBox.SelectedIndex == 4)
            {
                Color_Team = Baby_Blue;
                Player_Preview.Foreground = new SolidColorBrush(Colors.LightSkyBlue);
            }
            //Darker Blue
            else if (this.teamComboBox.SelectedIndex == 5)
            {
                Color_Team = Darker_Blue;
                Player_Preview.Foreground = new SolidColorBrush(Colors.DarkBlue);
            }
            //Very Pale Blue 
            else if (this.teamComboBox.SelectedIndex == 6)
            {
                Color_Team = Very_Pale_Blue;
                Player_Preview.Foreground = new SolidColorBrush(Colors.LightSteelBlue);
            }
            //Mild Blue
            else if (this.teamComboBox.SelectedIndex == 7)
            {
                Color_Team = Mild_Blue;
                Player_Preview.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
            }
            //Green
            else if (this.teamComboBox.SelectedIndex == 8)
            {
                Color_Team = Green;
                Player_Preview.Foreground = new SolidColorBrush(Colors.Green);
            }
            //Light Green
            else if (this.teamComboBox.SelectedIndex == 9)
            {
                Color_Team = Light_Green;
                Player_Preview.Foreground = new SolidColorBrush(Colors.LightGreen);
            }
            //Minty Green
            else if (this.teamComboBox.SelectedIndex == 10)
            {
                Color_Team = Minty_Green;
                Player_Preview.Foreground = new SolidColorBrush(Colors.MediumAquamarine);
            }
            //Light Vibrant Green
            else if (this.teamComboBox.SelectedIndex == 11)
            {
                Color_Team = Light_Vibrant_Green;
                Player_Preview.Foreground = new SolidColorBrush(Colors.MediumSeaGreen);
            }
            //Pale Green
            else if (this.teamComboBox.SelectedIndex == 12)
            {
                Color_Team = Pale_Green;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 173, 241, 171));

            }
            //Dark Green
            else if (this.teamComboBox.SelectedIndex == 13)
            {
                Color_Team = Dark_Green;
                Player_Preview.Foreground = new SolidColorBrush(Colors.DarkGreen);
            }
            //Yellow
            else if (this.teamComboBox.SelectedIndex == 14)
            {
                Color_Team = Yellow;
                Player_Preview.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            //Goldenish Yellow
            else if (this.teamComboBox.SelectedIndex == 15)
            {
                Color_Team = Goldenish_Yellow;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 240, 241, 85));

            }
            //Light Yellow
            else if (this.teamComboBox.SelectedIndex == 16)
            {
                Color_Team = Light_Yellow;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 239, 239, 153));

            }
            //Paler Yellow
            else if (this.teamComboBox.SelectedIndex == 17)
            {
                Color_Team = Paler_Yellow;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 237, 237, 182));
            }
            //Dark Yellow
            else if (this.teamComboBox.SelectedIndex == 18)
            {
                Color_Team = Dark_Yellow;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 183, 3));

            }
            //Purple
            else if (this.teamComboBox.SelectedIndex == 19)
            {
                Color_Team = Purple;
                Player_Preview.Foreground = new SolidColorBrush(Colors.Purple);

            }
            //Purple Magenta
            else if (this.teamComboBox.SelectedIndex == 20)
            {
                Color_Team = Purple_Magenta;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 3, 168));

            }
            //Slightly Lighter Purple
            else if (this.teamComboBox.SelectedIndex == 21)
            {
                Color_Team = Slightly_Lighter_Purple;
                Player_Preview.Foreground = new SolidColorBrush(Colors.MediumPurple);
            }
            //Light Pink
            else if (this.teamComboBox.SelectedIndex == 22)
            {
                Color_Team = Light_Pink;
                Player_Preview.Foreground = new SolidColorBrush(Colors.LightPink);

            }
            //Orange
            else if (this.teamComboBox.SelectedIndex == 23)
            {
                Color_Team = Orange;
                Player_Preview.Foreground = new SolidColorBrush(Colors.Orange);

            }
            //Dark Orange
            else if (this.teamComboBox.SelectedIndex == 24)
            {
                Color_Team = Dark_Orange;
                Player_Preview.Foreground = new SolidColorBrush(Colors.DarkOrange);

            }
            //White
            else if (this.teamComboBox.SelectedIndex == 25)
            {
                Color_Team = White;
                Player_Preview.Foreground = new SolidColorBrush(Colors.White);

            }
            //Yellowish White
            else if (this.teamComboBox.SelectedIndex == 26)
            {
                Color_Team = Yellowish_White;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 243, 243, 229));

            }
            //Gray
            else if (this.teamComboBox.SelectedIndex == 27)
            {
                Color_Team = Grey;
                Player_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
            }
            //Light Grey
            else if (this.teamComboBox.SelectedIndex == 28)
            {
                Color_Team = Light_Grey;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 191, 191, 191));

            }
            //Grey Darkish
            else if (this.teamComboBox.SelectedIndex == 29)
            {
                Color_Team = Grey_Darkish;
                Player_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);

            }
            //Very Light Grey
            else if (this.teamComboBox.SelectedIndex == 30)
            {
                Color_Team = Very_Light_Grey;
                Player_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 224, 224, 224));
            }
            //Black
            else if (this.teamComboBox.SelectedIndex == 31)
            {
                Color_Team = Black;
                Player_Preview.Foreground = new SolidColorBrush(Colors.Black);

            }
        }


        private void assistComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.assistComboBox.SelectedIndex == 0)
            {
                Color_Assist = Red;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.Red);

            }
            //Faded Red
            else if (this.assistComboBox.SelectedIndex == 1)
            {
                Color_Assist = Faded_Red;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 251, 98, 98));

            }
            //Blue
            else if (this.assistComboBox.SelectedIndex == 2)
            {
                Color_Assist = Blue;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.Blue);

            }
            //Light Blue
            else if (this.assistComboBox.SelectedIndex == 3)
            {
                Color_Assist = Light_Blue;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.DodgerBlue);

            }
            //Baby Blue
            else if (this.assistComboBox.SelectedIndex == 4)
            {
                Color_Assist = Baby_Blue;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.LightSkyBlue);

            }
            //Darker Blue
            else if (this.assistComboBox.SelectedIndex == 5)
            {
                Color_Assist = Darker_Blue;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.DarkBlue);

            }
            //Very Pale Blue
            else if (this.assistComboBox.SelectedIndex == 6)
            {
                Color_Assist = Very_Pale_Blue;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.LightSteelBlue);

            }
            //Mild Blue
            else if (this.assistComboBox.SelectedIndex == 7)
            {
                Color_Assist = Mild_Blue;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.CornflowerBlue);

            }
            //Green
            else if (this.assistComboBox.SelectedIndex == 8)
            {
                Color_Assist = Green;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.Green);

            }
            //Light Green
            else if (this.assistComboBox.SelectedIndex == 9)
            {
                Color_Assist = Light_Green;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.LightGreen);

            }
            //Minty Green
            else if (this.assistComboBox.SelectedIndex == 10)
            {
                Color_Assist = Minty_Green;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.MediumAquamarine);

            }
            //Light Vibrant Green
            else if (this.assistComboBox.SelectedIndex == 11)
            {
                Color_Assist = Light_Vibrant_Green;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.MediumSeaGreen);

            }
            //Pale Green
            else if (this.assistComboBox.SelectedIndex == 12)
            {
                Color_Assist = Pale_Green;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 173, 241, 171));

            }
            //Dark Green
            else if (this.assistComboBox.SelectedIndex == 13)
            {
                Color_Assist = Dark_Green;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.DarkGreen);

            }
            //Yellow
            else if (this.assistComboBox.SelectedIndex == 14)
            {
                Color_Assist = Yellow;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.Yellow);

            }
            //Goldenish Yellow
            else if (this.assistComboBox.SelectedIndex == 15)
            {
                Color_Assist = Goldenish_Yellow;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 240, 241, 85));

            }
            //Light Yellow
            else if (this.assistComboBox.SelectedIndex == 16)
            {
                Color_Assist = Light_Yellow;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 239, 239, 153));

            }
            //Paler Yellow
            else if (this.assistComboBox.SelectedIndex == 17)
            {
                Color_Assist = Paler_Yellow;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 237, 237, 182));

            }
            //Dark Yellow
            else if (this.assistComboBox.SelectedIndex == 18)
            {
                Color_Assist = Dark_Yellow;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 183, 3));

            }
            //Purple
            else if (this.assistComboBox.SelectedIndex == 19)
            {
                Color_Assist = Purple;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.Purple);

            }
            //Purple Magenta
            else if (this.assistComboBox.SelectedIndex == 20)
            {
                Color_Assist = Purple_Magenta;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 3, 168));

            }
            //Slightly Lighter Purple
            else if (this.assistComboBox.SelectedIndex == 21)
            {
                Color_Assist = Slightly_Lighter_Purple;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.MediumPurple);

            }
            //Light Pink
            else if (this.assistComboBox.SelectedIndex == 22)
            {
                Color_Assist = Light_Pink;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.LightPink);

            }
            //Orange
            else if (this.assistComboBox.SelectedIndex == 23)
            {
                Color_Assist = Orange;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.Orange);

            }
            //Dark Orange
            else if (this.assistComboBox.SelectedIndex == 24)
            {
                Color_Assist = Dark_Orange;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.DarkOrange);

            }
            //White
            else if (this.assistComboBox.SelectedIndex == 25)
            {
                Color_Assist = White;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.White);

            }
            //Yellowish White
            else if (this.assistComboBox.SelectedIndex == 26)
            {
                Color_Assist = Yellowish_White;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 243, 243, 229));

            }
            //Grey
            else if (this.assistComboBox.SelectedIndex == 27)
            {
                Color_Assist = Grey;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);

            }
            //Light Grey
            else if (this.assistComboBox.SelectedIndex == 28)
            {
                Color_Assist = Light_Grey;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 191, 191, 191));

            }
            //Grey Darkish
            else if (this.assistComboBox.SelectedIndex == 29)
            {
                Color_Assist = Grey_Darkish;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);

            }
            //Very Light Grey
            else if (this.assistComboBox.SelectedIndex == 30)
            {
                Color_Assist = Very_Light_Grey;
                Assist_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 224, 224, 224));

            }
            //Black
            else if (this.assistComboBox.SelectedIndex == 31)
            {
                Color_Assist = Black;
                Assist_Preview.Foreground = new SolidColorBrush(Colors.Black);

            }
        }


        private void enemyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.enemyComboBox.SelectedIndex == 0)
            {
                Color_Enemy = Red;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.Red);

            }
            //Faded Red
            else if (this.enemyComboBox.SelectedIndex == 1)
            {
                Color_Enemy = Faded_Red;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 251, 98, 98));
            }
            //Blue
            else if (this.enemyComboBox.SelectedIndex == 2)
            {
                Color_Enemy = Blue;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.Blue);
            }
            //Light Blue
            else if (this.enemyComboBox.SelectedIndex == 3)
            {
                Color_Enemy = Light_Blue;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.DodgerBlue);
            }
            //Baby Blue
            else if (this.enemyComboBox.SelectedIndex == 4)
            {
                Color_Enemy = Baby_Blue;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.LightSkyBlue);
            }
            //Darker Blue
            else if (this.enemyComboBox.SelectedIndex == 5)
            {
                Color_Enemy = Darker_Blue;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.DarkBlue);
            }
            //Very Pale Blue
            else if (this.enemyComboBox.SelectedIndex == 6)
            {
                Color_Enemy = Very_Pale_Blue;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.LightSteelBlue);
            }
            //Mild Blue
            else if (this.enemyComboBox.SelectedIndex == 7)
            {
                Color_Enemy = Mild_Blue;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
            }
            //Green
            else if (this.enemyComboBox.SelectedIndex == 8)
            {
                Color_Enemy = Green;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.Green);
            }
            //Light Green
            else if (this.enemyComboBox.SelectedIndex == 9)
            {
                Color_Enemy = Light_Green;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.LightGreen);
            }
            //Minty Green
            else if (this.enemyComboBox.SelectedIndex == 10)
            {
                Color_Enemy = Minty_Green;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.MediumAquamarine);
            }
            //Light Vibrant Green
            else if (this.enemyComboBox.SelectedIndex == 11)
            {
                Color_Enemy = Light_Vibrant_Green;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.MediumSeaGreen);
            }
            //Pale Green
            else if (this.enemyComboBox.SelectedIndex == 12)
            {
                Color_Enemy = Pale_Green;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 173, 241, 171));
            }
            //Dark Green
            else if (this.enemyComboBox.SelectedIndex == 13)
            {
                Color_Enemy = Dark_Green;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.DarkGreen);
            }
            //Yellow
            else if (this.enemyComboBox.SelectedIndex == 14)
            {
                Color_Enemy = Yellow;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.Yellow);
            }
            //Goldenish Yellow
            else if (this.enemyComboBox.SelectedIndex == 15)
            {
                Color_Enemy = Goldenish_Yellow;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 240, 241, 85));
            }
            //Light Yellow
            else if (this.enemyComboBox.SelectedIndex == 16)
            {
                Color_Enemy = Light_Yellow;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 239, 239, 153));
            }
            //Paler Yellow
            else if (this.enemyComboBox.SelectedIndex == 17)
            {
                Color_Enemy = Paler_Yellow;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 237, 237, 182));
            }
            //Dark Yellow
            else if (this.enemyComboBox.SelectedIndex == 18)
            {
                Color_Enemy = Dark_Yellow;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 183, 3));
            }
            //Purple
            else if (this.enemyComboBox.SelectedIndex == 19)
            {
                Color_Enemy = Purple;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.Purple);
            }
            //Purple Magenta
            else if (this.enemyComboBox.SelectedIndex == 20)
            {
                Color_Enemy = Purple_Magenta;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 183, 3, 168));
            }
            //Slightly Lighter Purple
            else if (this.enemyComboBox.SelectedIndex == 21)
            {
                Color_Enemy = Slightly_Lighter_Purple;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.MediumPurple);
            }
            //Light Pink
            else if (this.enemyComboBox.SelectedIndex == 22)
            {
                Color_Enemy = Light_Pink;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.LightPink);
            }
            //Orange
            else if (this.enemyComboBox.SelectedIndex == 23)
            {
                Color_Enemy = Orange;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.Orange);
            }
            //Dark Orange
            else if (this.enemyComboBox.SelectedIndex == 24)
            {
                Color_Enemy = Dark_Orange;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.DarkOrange);
            }
            //White
            else if (this.enemyComboBox.SelectedIndex == 25)
            {
                Color_Enemy = White;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.White);
            }
            //Yellowish White
            else if (this.enemyComboBox.SelectedIndex == 26)
            {
                Color_Enemy = Yellowish_White;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 243, 243, 229));
            }
            //Grey
            else if (this.enemyComboBox.SelectedIndex == 27)
            {
                Color_Enemy = Grey;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
            }
            //Light Grey
            else if (this.enemyComboBox.SelectedIndex == 28)
            {
                Color_Enemy = Light_Grey;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 191, 191, 191));
            }
            //Grey Darkish
            else if (this.enemyComboBox.SelectedIndex == 29)
            {
                Color_Enemy = Grey_Darkish;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.DarkGray);
            }
            //Very Light Grey
            else if (this.enemyComboBox.SelectedIndex == 30)
            {
                Color_Enemy = Very_Light_Grey;
                Enemy_Preview.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(100, 224, 224, 224));
            }
            //Black
            else if (this.enemyComboBox.SelectedIndex == 31)
            {
                Color_Enemy = Black;
                Enemy_Preview.Foreground = new SolidColorBrush(Colors.Black);
            }
        }


        // ===================================================== SAVE =====================================================
        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            // ================================================== Killfeed Below ==================================================
            string[] contentsKillfeedB = File.ReadAllLines(Environment.CurrentDirectory + "\\APBGame\\Localization\\GER\\HUDCombatMessages.GER");

            //EVENT
            contentsKillfeedB[1] = "HUDCombatMessages_Score_Combat_ArrestEnemy_Line0=" + Color_EnemyKill + "<CharacterNameA>" + ColorEnd;
            contentsKillfeedB[2] = "HUDCombatMessages_Score_Combat_ArrestEnemy_Line2=" + Color_EnemyKill + Enemy_Kill + ColorEnd;

            contentsKillfeedB[3] = "HUDCombatMessages_Score_Combat_KillEnemy_Line0=" + Color_EnemyKill + "<CharacterNameA>" + ColorEnd;
            contentsKillfeedB[4] = "HUDCombatMessages_Score_Combat_KillEnemy_Line2=" + Color_EnemyKill + Enemy_Kill + ColorEnd;

            contentsKillfeedB[5] = "HUDCombatMessages_Score_Combat_KillEnemyAssist_Line0=" + Color_EnemyKill + "<CharacterNameA>" + ColorEnd;
            contentsKillfeedB[6] = "HUDCombatMessages_Score_Combat_KillEnemyAssist_Line2" + Color_EnemyKill + Assist + ColorEnd;

            contentsKillfeedB[66] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_1_Line2" + Color_TeamKill + Team_Kill + ColorEnd;
            contentsKillfeedB[68] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_10_Line2" + Color_TeamKill + Team_Kill + ColorEnd;
            contentsKillfeedB[70] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_2_Line2" + Color_TeamKill + Team_Kill + ColorEnd;
            contentsKillfeedB[72] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_3_Line2" + Color_TeamKill + Team_Kill + ColorEnd;
            contentsKillfeedB[74] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_4_Line2" + Color_TeamKill + Team_Kill + ColorEnd;
            contentsKillfeedB[76] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_5_Line2" + Color_TeamKill + Team_Kill + ColorEnd;
            contentsKillfeedB[78] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_6_Line2" + Color_TeamKill + Team_Kill + ColorEnd;
            contentsKillfeedB[80] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_7_Line2" + Color_TeamKill + Team_Kill + ColorEnd;
            contentsKillfeedB[82] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_8_Line2" + Color_TeamKill + Team_Kill + ColorEnd;
            contentsKillfeedB[84] = "HUDCombatMessages_Score_Earned_MedalDishonour_FriendlyKill_9_Line2" + Color_TeamKill + Team_Kill + ColorEnd;



            File.WriteAllLines(Environment.CurrentDirectory + "\\APBGame\\Localization\\GER\\HUDCombatMessages.GER", contentsKillfeedB);




            // ================================================== Killfeed ==================================================
            string[] contentsKillfeed = File.ReadAllLines(Environment.CurrentDirectory + "\\APBGame\\Localization\\GER\\HUDMessages.GER");

            //EVENT
            contentsKillfeed[99] = "HUDMessages_AM_CombatArrestOpp_DisplayText=" + Color_Enemy + "<ArrestingCharacterName>" + ColorEnd + " <hudtexture:KillIcon_Arrest> " + Color_Team + "<ArrestedCharacterName>" + ColorEnd;
            contentsKillfeed[101] = "HUDMessages_AM_CombatArrestTeam_DisplayText=" + Color_Team + "<CharacterNameA>" + ColorEnd + " <hudtexture:KillIcon_Arrest> " + Color_Enemy + "<CharacterNameB>" + ColorEnd;
            contentsKillfeed[103] = "HUDMessages_AM_CombatKillOpp_DisplayText=" + Color_Enemy + "<KillerCharacterName>" + ColorEnd + " " + Color_Assist + " <KillerAssistName> " + ColorEnd + "<WeaponIcon> " + Color_Team + "<KilledCharacterName>" + ColorEnd;
            contentsKillfeed[105] = "HUDMessages_AM_CombatKillTeam_DisplayText=" + Color_Team + "<KillerCharacterName>" + ColorEnd + Color_Assist + " <KillerAssistName> " + ColorEnd + "<WeaponIcon>" + " " + Color_Enemy + "<KilledCharacterName>" + ColorEnd;
            contentsKillfeed[107] = "HUDMessages_AM_CombatKillTeamOther_DisplayText=" + Color_Team + "<KillerCharacterName>" + ColorEnd + " <hudtexture:KillIcon_Generic> " + Color_Enemy + "<KilledCharacterName>" + ColorEnd;
            contentsKillfeed[109] = "HUDMessages_AM_CombatMuggedOpp_DisplayText=" + Color_Enemy + "<KillerCharacterName>" + ColorEnd + " <hudtexture:KillIcon_Generic> " + Color_Team + "<KilledCharacterName>" + ColorEnd;
            contentsKillfeed[111] = "HUDMessages_AM_CombatMuggedTeam_DisplayText=" + Color_Team + "<KillerCharacterName>" + ColorEnd + " <hudtexture:KillIcon_Generic> " + Color_Enemy + "<KilledCharacterName>" + ColorEnd;
            contentsKillfeed[113] = "HUDMessages_AM_CombatRescueOpp_DisplayText=" + Color_Enemy + "<CharacterNameA>" + ColorEnd + " <hudtexture:KillIcon_Rescue> " + Color_Enemy + "<CharacterNameB>" + ColorEnd;
            contentsKillfeed[115] = "HUDMessages_AM_CombatRescueTeam_DisplayText=" + Color_Team + "<CharacterNameA>" + ColorEnd + " <hudtexture:KillIcon_Rescue> " + Color_Team + "<CharacterNameB>" + ColorEnd;
            contentsKillfeed[117] = "HUDMessages_AM_CombatStunOpp_DisplayText=" + Color_Enemy + "<CharacterNameA>" + ColorEnd + " <hudtexture:KillIcon_Stun> " + Color_Team + "<CharacterNameB>" + ColorEnd;
            contentsKillfeed[119] = "HUDMessages_AM_CombatStunSelfOpp_DisplayText=" + "<hudtexture:KillIcon_Stun> " + Color_Enemy + "<CharacterNameA>" + ColorEnd;
            contentsKillfeed[121] = "HUDMessages_AM_CombatStunSelfTeam_DisplayText=" + "<hudtexture:KillIcon_Stun> " + Color_Team + "<CharacterNameA>" + ColorEnd;
            contentsKillfeed[123] = "HUDMessages_AM_CombatStunTMOpp_DisplayText=" + Color_Enemy + "<CharacterNameB>" + ColorEnd + " <hudtexture:KillIcon_Stun> " + Color_Enemy + "<CharacterNameA>" + ColorEnd;
            contentsKillfeed[125] = "HUDMessages_AM_CombatStunTMTeam_DisplayText=" + Color_Team + "<CharacterNameB>" + ColorEnd + " <hudtexture:KillIcon_Stun> " + Color_Team + "<CharacterNameA>" + ColorEnd;
            contentsKillfeed[127] = "HUDMessages_AM_CombatStunTeam_DisplayText=" + Color_Team + "<CharacterNameA>" + ColorEnd + " <hudtexture:KillIcon_Stun> " + Color_Enemy + "<CharacterNameB>" + ColorEnd;
            contentsKillfeed[129] = "HUDMessages_AM_CombatSuicideOpp_DisplayText=" + "<hudtexture:KillIcon_Generic> " + Color_Enemy + "<CharacterNameA>" + ColorEnd;
            contentsKillfeed[131] = "HUDMessages_AM_CombatSuicideTeam_DisplayText=" + "<hudtexture:KillIcon_Generic> " + Color_Team + "<CharacterNameA>" + ColorEnd;
            contentsKillfeed[133] = "HUDMessages_AM_CombatTKOpp_DisplayText=" + Color_Enemy + "<KillerCharacterName>" + ColorEnd + Color_Assist + " <KillerAssistName> " + ColorEnd + "<WeaponIcon> " + Color_Enemy + "<KilledCharacterName>" + ColorEnd;
            contentsKillfeed[135] = "HUDMessages_AM_CombatTKOppOther_DisplayText=" + Color_Enemy + "<KillerCharacterName>" + ColorEnd + " <hudtexture:KillIcon_Generic> " + Color_Enemy + "<KilledCharacterName>" + ColorEnd;
            contentsKillfeed[137] = "HUDMessages_AM_CombatTKOpp_DisplayText=" + Color_Team + "<KillerCharacterName>" + ColorEnd + Color_Assist + " <KillerAssistName> " + ColorEnd + "<WeaponIcon> " + Color_Team + "<KilledCharacterName>" + ColorEnd;
            contentsKillfeed[139] = "HUDMessages_AM_CombatTKOppOther_DisplayText=" + Color_Team + "<KillerCharacterName>" + ColorEnd + " <hudtexture:KillIcon_Generic> " + Color_Team + "<KilledCharacterName>" + ColorEnd;

            File.WriteAllLines(Environment.CurrentDirectory + "\\APBGame\\Localization\\GER\\HUDMessages.GER", contentsKillfeed);



            //Change string
            TeamKill_Box.Text = Team_Kill;
            TeamKilled_Box.Text = Team_Killed;
            Assist_Box.Text = Assist;
            EnemyKill_Box.Text = Enemy_Kill;
            EnemyKilled_Box.Text = Enemy_Killed;

            //Saving config

            config.Default.Color_EnemyS = Color_Enemy;
            config.Default.Color_TeamS = Color_Team;
            config.Default.Color_AssistS = Color_Assist;

            config.Default.Team_KillS = Team_Kill;
            config.Default.Team_KilledS = Team_Killed;
            config.Default.AssistS = Assist;
            config.Default.Enemy_KillS = Enemy_Kill;
            config.Default.Enemy_KilledS = Enemy_Killed;

            config.Default.team_Color = teamComboBox.SelectedIndex;
            config.Default.assist_Color = assistComboBox.SelectedIndex;
            config.Default.enemy_Color = enemyComboBox.SelectedIndex;

            config.Default.enemyKilled_Color = enemyKilledComboBox.SelectedIndex;
            config.Default.teamKilled_Color = teamKilledComboBox.SelectedIndex;

            config.Default.Save();
        }


        //============================================= Killfeed - Textbox =============================================
        private void TeamKill_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            Team_Kill = TeamKill_Box.Text;
            var length = 1000;

            Task.Run(() =>
            {
                for (int i = 0; i <= length; i++)
                {
                    Application.Current.Dispatcher.BeginInvoke(new Action(() => {
                        TeamKill_Preview.Content = Team_Kill;
                    }), DispatcherPriority.Render);
                    Thread.Sleep(100);
                }
            });
        }

        private void EnemyKill_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            Enemy_Kill = EnemyKill_Box.Text;
            var length = 1000;

            Task.Run(() =>
            {
                for (int i = 0; i <= length; i++)
                {
                    Application.Current.Dispatcher.BeginInvoke(new Action(() => {
                        EnemyKilled_Preview.Content = Enemy_Kill;
                    }), DispatcherPriority.Render);
                    Thread.Sleep(100);
                }
            });
        }

        private void Assist_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            Assist = Assist_Box.Text;
        }

        private void TeamKilled_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            Team_Killed = TeamKilled_Box.Text;
        }

        private void EnemyKilled_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            Enemy_Killed = EnemyKilled_Box.Text;
        }

        //TeamKill_Preview.Content = Team_Kill;

    }
}
