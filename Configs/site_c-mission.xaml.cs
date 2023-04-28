using System;
using Launcher;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using Wpf.Ui.Common;
using Wpf.Ui.Controls.Interfaces;
using Wpf.Ui.Mvvm.Contracts;

namespace CLauncher2._0.Configs
{
    /// <summary>
    /// Interaktionslogik für site_c_mission.xaml
    /// </summary>
    public partial class site_c_mission : Page
    {

        public site_c_mission()
        {
            InitializeComponent();


            // ========================================== Loading User-Configs ==========================================
            TDM = config.Default.tdmS;
            Takeover = config.Default.takeoverS;
            VIP = config.Default.vipS;
            ItemDrop = config.Default.dropS;
            ItemHold = config.Default.holdS;
            Spray = config.Default.sprayS;
            Capture = config.Default.captureS;
            Bomb = config.Default.bombS;
            FightClub = config.Default.fcS;
            Truck = config.Default.truckS;

            Color_Enemy = config.Default.Color_EnemyS;
            Color_Team = config.Default.Color_TeamS;
            Color_Assist = config.Default.Color_AssistS;


            tdmComboBox.SelectedIndex = config.Default.Color_TDM;
            vipComboBox.SelectedIndex = config.Default.Color_VIP;
            takeoverComboBox.SelectedIndex = config.Default.Color_Takeover;
            holdComboBox.SelectedIndex = config.Default.Color_Hold;
            dropComboBox.SelectedIndex = config.Default.Color_Drop;
            sprayComboBox.SelectedIndex = config.Default.Color_Spray;
            captureComboBox.SelectedIndex = config.Default.Color_Capture;
            bombComboBox.SelectedIndex = config.Default.Color_Bomb;
            fcComboBox.SelectedIndex = config.Default.Color_FightClub;
            truckComboBox.SelectedIndex = config.Default.Color_Truck;
            // ========================================== Loading Current Prefix ==========================================
            tdmBox.Text = TDM;
            takeoverBox.Text = Takeover;
            vipBox.Text = VIP;
            dropBox.Text = ItemDrop;
            holdBox.Text = ItemHold;
            sprayBox.Text = Spray;
            captureBox.Text = Capture;
            bombBox.Text = Bomb;
            fcBox.Text = FightClub;
            truckBox.Text = Truck;

        }



        // ========================================== DefaultPrefix-Missions ==========================================


        string TDM = "DM";
        string Takeover = "DM+";
        string VIP = "VIP";
        string ItemHold = "HOLD";
        string ItemDrop = "DROP";
        string Spray = "SPRAY";
        string Capture = "AREA";
        string Bomb = "BOMB";
        string FightClub = "FIGHTCLUB";
        string Truck = "TRUCK";



        // ========================================== Colors-Missions ==========================================
        string ColorLeft_TDM;
        string ColorRight_TDM;

        string ColorLeft_VIP;
        string ColorRight_VIP;

        string ColorLeft_Takeover;
        string ColorRight_Takeover;

        string ColorLeft_ItemHold;
        string ColorRight_ItemHold;

        string ColorLeft_ItemDrop;
        string ColorRight_ItemDrop;

        string ColorLeft_Spray;
        string ColorRight_Spray;

        string ColorLeft_Capture;
        string ColorRight_Capture;

        string ColorLeft_Bomb;
        string ColorRight_Bomb;

        string ColorLeft_FightClub;
        string ColorRight_FightClub;

        string ColorLeft_Truck;
        string ColorRight_Truck;

        // ========================================== Colors-Killfeed ==========================================
        string Red = "<col:Action_Enemy>";
        string Faded_Red = "<col:Scoreboard_Opponents_Offline>";
        string Blue = "<col:Blue>";
        string Light_Blue = "<col:Mailbox>";
        string Baby_Blue = "<col:TaskCheckpoint_TaintedDefend>";
        string Darker_Blue = "<col:Blue_Enforcer>";
        string Very_Pale_Blue = "<col:Blue_Pale>";
        string Mild_Blue = "<col:Blue_mid>";
        string Green = "<col:Green>";
        string Light_Green = "<col:Chat_Group>";
        string Minty_Green = "<col:ElectiveCorpse_Teammate>";
        string Light_Vibrant_Green = "<col:Group_Player_Arrested>";
        string Pale_Green = "<col:Green_TaskMarker>";
        string Dark_Green = "<col:Green_VeryDark>";
        string Yellow = "<col:Chat_Mission>";
        string Goldenish_Yellow = "<col:Minigame_FindTarget_DevOps>";
        string Light_Yellow = "<col:Waypoint_Leader>";
        string Paler_Yellow = "<col:Chat_Name>";
        string Dark_Yellow = "<col:ED_persona>";
        string Purple = "<col:ED_wardrobe>";
        string Purple_Magenta = "<col:Halloween_Zombicine>";
        string Slightly_Lighter_Purple = "<col:Purple_Bright>";
        string Light_Pink = "<col:Valentine_Pink>";
        string Orange = "<col:Halloween_Orange>";
        string Dark_Orange = "<col:Orange_Dark>";
        string White = "<col:ScoreBreakdown_Name>";
        string Yellowish_White = "<col:Yellow_Pale>";
        string Grey = "<col:openworld_marker>";
        string Light_Grey = "<col:Faction_Friendly>";
        string Grey_Darkish = "<col:Inactive>";
        string Very_Light_Grey = "<col:Chat_Broadcast>";
        string Black = "<col:Black>";

        string Color_Team;
        string Color_Enemy;
        string Color_Assist;
        string ColorEnd = "</col>";



        public void checkIfUsingNormalFiles()
        {
            string ConfigFile = Environment.CurrentDirectory + "\\APBGame\\Localization\\GER\\MissionTemplates.GER";
            List<String> lines = File.ReadAllLines(ConfigFile).ToList();

            if (lines.Contains(";;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;"))
            {

            }
            else
            {
                Windows.Fatal_Error FatalError = new Windows.Fatal_Error();
                FatalError.Show();
                FatalError.ErrorCode.Content = "<Error:FatalError Informations=" + '\u0022' + "You are already using modified GameFiles, please use the vanilla one to avoid crashing." + '\u0022' + ">";
            }

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            // ================================================== Mission Names ==================================================





            string[] contents_mission = File.ReadAllLines(Environment.CurrentDirectory + "\\APBGame\\Localization\\GER\\MissionTemplates.GER");
            //TDM
            contents_mission[1] = "MissionTemplates_DB_BEM1_For1_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - MIA VICE";
            contents_mission[2] = "MissionTemplates_DB_BES2_Inv1_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - FIRE AND BRIMSTONE";
            contents_mission[3] = "MissionTemplates_JG_BCL0_Exemplar_B_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - IT'S A STEAL!";
            contents_mission[4] = "MissionTemplates_JG_BCL0_Exemplar_G_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - IT'S A STEAL!";
            contents_mission[5] = "MissionTemplates_JG_BCL1_Bom1_B_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - PAY UP OR BLOW UP";
            contents_mission[6] = "MissionTemplates_JG_BCL1_Bom1_G_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - AN EXPLOSIVE TRIAL";
            contents_mission[7] = "MissionTemplates_JG_BCL1_VTh1_B_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - TIGER TROUBLE";
            contents_mission[8] = "MissionTemplates_JG_BCL1_VTh1_G_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - TOUGH LOVE";
            contents_mission[9] = "MissionTemplates_JG_BCL2_Bom1_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - THE HOBBY HOODS";
            contents_mission[10] = "MissionTemplates_JG_BCL2_VLo2_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - GOODY GUNDROPS";
            contents_mission[11] = "MissionTemplates_JG_BCM0_Exemplar_B_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - POWDER TRAIL";
            contents_mission[12] = "MissionTemplates_JG_BCM0_Exemplar_G_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - POWDER TRAIL";
            contents_mission[13] = "MissionTemplates_JG_BCM2_Sab1_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - I AM NOT A CROOK";
            contents_mission[14] = "MissionTemplates_JG_BCM2_VLo1_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - TASTYBURGER BANDIT";
            contents_mission[15] = "MissionTemplates_JG_BEL2_AGr2_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - DARING DEEDS";
            contents_mission[16] = "MissionTemplates_JG_BEM2_Inv1_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - SEEK AND DEFUSE";
            contents_mission[17] = "MissionTemplates_JG_BEM3_Dis1_MissionTitle=<Color:>" + "[" + ColorLeft_TDM + TDM + ColorRight_TDM + "]" + " - PAINTING THE APOCOLYPSE";

            //Takeover
            contents_mission[18] = "MissionTemplates_DB_BCM2_Vlo1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - GUN RUN GANG";
            contents_mission[19] = "MissionTemplates_JG_BCL1_Ars1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - LOOK AT ME, LOOK AT ME";
            contents_mission[20] = "MissionTemplates_JG_BCL1_Ars1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - BURN TO EARN";
            contents_mission[21] = "MissionTemplates_JG_BCL1_Gra1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - IN, OUT, SPRAY IT ALL ABOUT";
            contents_mission[22] = "MissionTemplates_JG_BCL2_Ars1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - SEA MIST";
            contents_mission[23] = "MissionTemplates_JG_BCL2_Bom2_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - A TAX ATTACK";
            contents_mission[24] = "MissionTemplates_JG_BCL2_Gra1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - FAMILY FUN DAY";
            contents_mission[25] = "MissionTemplates_JG_BCL3_Ars1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - ELECTRICAL FAULT";
            contents_mission[26] = "MissionTemplates_JG_BCM1_Exemplar_B_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - POP3 A CAP";
            contents_mission[27] = "MissionTemplates_JG_BCM1_Exemplar_G_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - POP3 A CAP";
            contents_mission[28] = "MissionTemplates_JG_BCM2_Bom1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - THE CUCKOLD STRIKES BACK";
            contents_mission[29] = "MissionTemplates_JG_BCM2_VTh1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - EYEWITNESS TESTIMONY";
            contents_mission[30] = "MissionTemplates_JG_BCS2_Ars1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - SHOCK FOR THE JOCK";
            contents_mission[31] = "MissionTemplates_JG_BCS2_Bom1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - A DISH BEST SERVED COLD";
            contents_mission[32] = "MissionTemplates_JG_BCS3_Ars1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - RUSSIAN REGRETS";
            contents_mission[33] = "MissionTemplates_JG_BEM2_Dis1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - DEFUSING THE SITUATION";
            contents_mission[34] = "MissionTemplates_JG_BEM2_FoE2_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - ON THE FENCE";
            contents_mission[35] = "MissionTemplates_JG_BEM2_VPi1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - PICKUP PICK-UP";
            contents_mission[36] = "MissionTemplates_JG_BES2_Dis1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - FEELING INSECURE";
            contents_mission[37] = "MissionTemplates_JG_BES2_Inv1_MissionTitle=<Color:>" + "[" + ColorLeft_Takeover + Takeover + ColorRight_Takeover + "]" + " - URANIUM IS SHOWING";

            //VIP
            contents_mission[38] = "MissionTemplates_AE_BCL4_BoB4_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - DR. BORIOUS'S SNAKE OIL";
            contents_mission[39] = "MissionTemplates_DB_BCM1_Del1_B_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - WAR OF THE WAGGLE";
            contents_mission[40] = "MissionTemplates_DB_BCM1_Del1_G_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - OBJECTION!";
            contents_mission[41] = "MissionTemplates_DB_BCM1_Vlo1_B_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - ALL IN A TWIZZY";
            contents_mission[42] = "MissionTemplates_DB_BCM1_Vlo1_G_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - GUN-KINGS";
            contents_mission[43] = "MissionTemplates_DB_BEL0_For1_P_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - SHOW OF FORCE";
            contents_mission[44] = "MissionTemplates_DB_BEL0_For1_T_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - SMILE FOR THE CAMERAS";
            contents_mission[45] = "MissionTemplates_DB_BEL1_Bus1_T_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - CRIME DOES PAY";
            contents_mission[46] = "MissionTemplates_DB_BEL1_For1_P_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - GUNS AND ROSES";
            contents_mission[47] = "MissionTemplates_DB_BEL1_VLo1_P_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - HIGH POWERED MICROWAVES";
            contents_mission[48] = "MissionTemplates_DB_BEL1_VLo1_T_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - SAVING SURVEILLANCE";
            contents_mission[49] = "MissionTemplates_DB_BEM0_Pic1_P_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - OPERATION: NO JUNKIE";
            contents_mission[50] = "MissionTemplates_DB_BEM0_Pic1_T_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - NOPE 2 DOPE";
            contents_mission[51] = "MissionTemplates_DB_BEM2_Del1_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - INTELLIGENCE GATHERING";
            contents_mission[52] = "MissionTemplates_JG_BCL4_Ars1_MissionTitle=<Color:>" + "[" + ColorLeft_VIP + VIP + ColorRight_VIP + "]" + " - SIDE EFFECTS MAY VARY";

            //ItemHold #!!!!!!!!!
            contents_mission[53] = "MissionTemplates_AE_BEL0_Inv3_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - CHINA BLUES";
            contents_mission[54] = "MissionTemplates_AE_BEM0_Inv7_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - WORKIN' LIKE A DOGGI";
            contents_mission[55] = "MissionTemplates_DB_BCL0_VTh1_B_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - SPARE WHEELS";
            contents_mission[56] = "MissionTemplates_DB_BCL0_VTh1_G_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - SKIDMARKS";
            contents_mission[57] = "MissionTemplates_DB_BEL0_Del1_P_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - DEALER BUSTS";
            contents_mission[58] = "MissionTemplates_DB_BEL0_Del1_T_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - JUMP THE FENCE";
            contents_mission[59] = "MissionTemplates_DB_BEL3_Del1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - SOME CONVENIENT PROOF";
            contents_mission[60] = "MissionTemplates_DB_BES0_Del2_P_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - ORGAN GRINDER";
            contents_mission[61] = "MissionTemplates_DB_BES0_Del2_T_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - NO GUTS, NO GORY";
            contents_mission[62] = "MissionTemplates_DB_BES0_Inv2_P_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - EXPLOSIVE INVESTIGATION";
            contents_mission[63] = "MissionTemplates_DB_BES0_Inv2_T_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - MORTARGATE";
            contents_mission[64] = "MissionTemplates_DB_BES3_Pic1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - UNDERCOVER RUNNER";
            contents_mission[65] = "MissionTemplates_JG_BCL0_VTh1_G_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " -DELIVER THE LIVER";
            contents_mission[66] = "MissionTemplates_JG_BCL2_VLo1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - STEREO TYPES";
            contents_mission[67] = "MissionTemplates_JG_BCL3_Exemplar_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - DIRTY WHITE COLLARS";
            contents_mission[68] = "MissionTemplates_JG_BCM0_Bur1_B_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - THE PRICE OF FAME";
            contents_mission[69] = "MissionTemplates_JG_BCM0_Bur1_G_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - CLEANING UP CONTROVERSY";
            contents_mission[70] = "MissionTemplates_JG_BCM2_Bur1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - BUTTON MASHERS";
            contents_mission[71] = "MissionTemplates_JG_BCM3_Exemplar_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - DON'T DRINK THE WATER";
            contents_mission[72] = "MissionTemplates_JG_BCS0_VCa1_B_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - DO THE GAS CASH MASH";
            contents_mission[73] = "MissionTemplates_JG_BCS0_VCa1_G_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - ROUTERS AND SHOOTERS";
            contents_mission[74] = "MissionTemplates_JG_BCS3_Bur1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - OPAL ROUTES";
            contents_mission[75] = "MissionTemplates_JG_BCS3_Exemplar_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - OPEN AND SHUT VIP";
            contents_mission[76] = "MissionTemplates_JG_BEL2_FoE2_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - BUGGING OUT";
            contents_mission[77] = "MissionTemplates_JG_BEL2_VPi1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - POLITICAL FAVOR";
            contents_mission[78] = "MissionTemplates_JG_BEL4_Inv2_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - MANILA VICE";
            contents_mission[79] = "MissionTemplates_JG_BEM2_FoE1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - RAID AND RECOVERY";
            contents_mission[80] = "MissionTemplates_JG_BES2_FoE1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemHold + ItemHold + ColorRight_ItemHold + "]" + " - SAFEHOUSE CALLS";

            //ItemDrop
            contents_mission[81] = "MissionTemplates_AE_BES4_Inv5_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - DIRTY BUSINESS";
            contents_mission[82] = "MissionTemplates_DB_BCL3_Pic1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - NOT IN MY BACKYARD";
            contents_mission[83] = "MissionTemplates_DB_BCS2_VTh1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - DIRT ON THE DEPARTMENT";
            contents_mission[84] = "MissionTemplates_DB_BCS2_VTh3_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - JUST WHAT THE DOCTOR ORDERED";
            contents_mission[85] = "MissionTemplates_DB_BCS3_Ars1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - BOX-LOCK AND .52 BARREL";
            contents_mission[86] = "MissionTemplates_DB_BEL0_For2_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - GET THE LOOK";
            contents_mission[87] = "MissionTemplates_DB_BEL0_Inv2_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - ENEMY AT THE CRATES";
            contents_mission[88] = "MissionTemplates_DB_BEM0_Pic2_P_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - ECONOMIC RECOVERY";
            contents_mission[89] = "MissionTemplates_DB_BEM0_Pic2_T_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - THE DITCHED RICHES";
            contents_mission[90] = "MissionTemplates_DB_BEM2_VLo1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - PINEAPPLE COCKTAIL";
            contents_mission[91] = "MissionTemplates_DB_BEM3_Inv1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - LONNY DORENGO IS CRAZY";
            contents_mission[92] = "MissionTemplates_DB_BEM3_Pic1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - CASH ON THE CURB";
            contents_mission[93] = "MissionTemplates_DB_BES0_Inv1_P_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - BOGUS BURGLARY";
            contents_mission[94] = "MissionTemplates_DB_BES0_Inv1_T_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - HACK ATTACK";
            contents_mission[95] = "MissionTemplates_DB_BES2_Inv2_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - BOOKIE ON THE RUN";
            contents_mission[96] = "MissionTemplates_DB_BES3_For1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - BUGS AND DRUGS";
            contents_mission[97] = "MissionTemplates_JG_BCL2_Bur1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - CREME DE LA CRIME!!!";
            contents_mission[98] = "MissionTemplates_JG_BCL2_VTh1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - MAH-JONG MONEY";
            contents_mission[99] = "MissionTemplates_JG_BCL4_Exemplar_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - WHAT GOES AROUND...";
            contents_mission[100] = "MissionTemplates_JG_BCL4_Sab1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - SEEK AND DESTROY";
            contents_mission[101] = "MissionTemplates_JG_BCM3_Bur1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - BAD INVESTMENT";
            contents_mission[102] = "MissionTemplates_JG_BCM4_Exemplar_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - ONLY A GAME";
            contents_mission[103] = "MissionTemplates_JG_BCS1_Exemplar3_B_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - CRYING OVER SPILT MAGNESIUM";
            contents_mission[104] = "MissionTemplates_JG_BCS1_Exemplar3_G_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - THERE'S NO EYE IN TEAM";
            contents_mission[105] = "MissionTemplates_JG_BCS4_Exemplar_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - THE WAGES OF SIN";
            contents_mission[106] = "MissionTemplates_JG_BEL0_Inv1_P_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - GAME COPY CRACKDOWN";
            contents_mission[107] = "MissionTemplates_JG_BEL0_Inv1_T_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - PIRACY PURGE";
            contents_mission[108] = "MissionTemplates_JG_BEL0_Inv2_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - BRUSH WITH THE LAW";
            contents_mission[109] = "MissionTemplates_JG_BEL1_Inv1_P_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - CHEMICAL WARFARE";
            contents_mission[110] = "MissionTemplates_JG_BEL1_Inv1_T_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - MY, GRAMMA, HOW YOUNG YOU LOOK";
            contents_mission[111] = "MissionTemplates_JG_BEL2_Dis2_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - EXPLOSIVE MATERIAL";
            contents_mission[112] = "MissionTemplates_JG_BEL3_Dis1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - DIAL-A-DETONATOR";
            contents_mission[113] = "MissionTemplates_JG_BEL4_Inv1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - CAUGHT 'NAPPING";
            contents_mission[114] = "MissionTemplates_JG_BEM0_FoE1_P_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - ROUGH DIAMOND";
            contents_mission[115] = "MissionTemplates_JG_BEM0_FoE1_T_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - BRIDE AND BOOM";
            contents_mission[116] = "MissionTemplates_JG_BEM1_FoE1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - TOP COP CHOP-SHOP SHOCK";
            contents_mission[117] = "MissionTemplates_JG_BEM4_Dis1_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - DIVIDE AND CONQUER";
            contents_mission[118] = "MissionTemplates_JG_BES4_FoE2_MissionTitle=<Color:>" + "[" + ColorLeft_ItemDrop + ItemDrop + ColorRight_ItemDrop + "]" + " - FORT KNOX HARD KNOCKS";

            //SPRAY
            contents_mission[119] = "MissionTemplates_DB_BCL0_Gra2_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - THE ARTISTRY OF THE SPRAYCAN";
            contents_mission[120] = "MissionTemplates_DB_BCL0_Van1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - NO SERVICE? NO STORE!";
            contents_mission[121] = "MissionTemplates_DB_BCL0_Van1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - CONSUMER RIGHTS";
            contents_mission[122] = "MissionTemplates_DB_BCM0_Van1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - R. O. A. R.";
            contents_mission[123] = "MissionTemplates_DB_BCM0_Van1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - NO UNACCOMPANIED G-KINGS";
            contents_mission[124] = "MissionTemplates_DB_BEL0_Inv1_P_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - SIGNAL TO NOISE";
            contents_mission[125] = "MissionTemplates_DB_BEL0_Inv1_T_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - BOMBED OUT";
            contents_mission[126] = "MissionTemplates_DB_BES0_For1_P_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - PRAETORIAN STARTS WITH PR";
            contents_mission[127] = "MissionTemplates_DB_BES0_For1_T_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - GOING ALL THE WAY";
            contents_mission[128] = "MissionTemplates_JG_BCL0_Gra1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - BLIND JUSTICE";
            contents_mission[129] = "MissionTemplates_JG_BCL0_Gra1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Spray + Spray + ColorRight_Spray + "]" + " - BLIND JUSTICE";

            //CAPTURE
            contents_mission[130] = "MissionTemplates_AE_BCS0_Ter1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - GANGLAND ANNEXATION";
            contents_mission[131] = "MissionTemplates_AE_BCS0_Ter1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - ORDERS FROM ON HIGH";
            contents_mission[132] = "MissionTemplates_AE_BES2_Dis1_P_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - THE CHOP SHOP SHOW";
            contents_mission[133] = "MissionTemplates_AE_BES2_Dis1_T_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - CHOP SHOP";
            contents_mission[134] = "MissionTemplates_DB_BCL3_VTh1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - REPO RACERS";
            contents_mission[135] = "MissionTemplates_DB_BCM0_Ars1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - CASH FOR CLUNKERS";
            contents_mission[136] = "MissionTemplates_DB_BCS0_Ars1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - CONFLAGRATE TO ACCUMULATE";
            contents_mission[137] = "MissionTemplates_DB_BCS0_Ars1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - YOU'RE FIRED!";
            contents_mission[138] = "MissionTemplates_DB_BCS0_Del1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - THE BIG CONTE";
            contents_mission[139] = "MissionTemplates_DB_BCS0_Del1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - THE MAN KNOWS HIS JEWELRY";
            contents_mission[140] = "MissionTemplates_DB_BCS0_Del2_B_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - DOUGH FOR THE DOORMAN";
            contents_mission[141] = "MissionTemplates_DB_BCS0_Del2_G_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - ONE NIGHT IN SOFIA";
            contents_mission[142] = "MissionTemplates_DB_BCS1_Del1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - DINNER DATE";
            contents_mission[143] = "MissionTemplates_DB_BCS1_Del1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - EVERYBODY COMES TO RICK'S";
            contents_mission[144] = "MissionTemplates_DB_BEL1_For1_P_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - CEO SHOWDOWN";
            contents_mission[145] = "MissionTemplates_DB_BEL1_For1_T_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - TIGERS ON PARADE";
            contents_mission[146] = "MissionTemplates_DB_BEL1_Pic2_P_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - G AND G";
            contents_mission[147] = "MissionTemplates_DB_BEL1_Pic2_T_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - GHOSTS OF THE PAST";
            contents_mission[148] = "MissionTemplates_DB_BEM2_Del2_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - COLD HOLD CHECK UP";
            contents_mission[149] = "MissionTemplates_DB_BES0_Del1_P_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - GETTING ON THE BALANCE SHEET";
            contents_mission[150] = "MissionTemplates_DB_BES0_Del1_T_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - THE TIGER MOLE";
            contents_mission[151] = "MissionTemplates_DB_BES0_Pic1_P_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - BANKROLL COLLECTION";
            contents_mission[152] = "MissionTemplates_DB_BES0_Pic1_T_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - ALWAYS USE PROTECTION";
            contents_mission[153] = "MissionTemplates_DB_BES1_Pic4_P_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - AVENGE THE FALLEN";
            contents_mission[154] = "MissionTemplates_DB_BES1_Pic4_T_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - SPRAY GUN FOR HIRE";
            contents_mission[155] = "MissionTemplates_DB_BES3_Inv1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - INTERNAL AFFAIRS";
            contents_mission[156] = "MissionTemplates_JG_BCL2_Exemplar_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - MAKING A RACKET";
            contents_mission[157] = "MissionTemplates_JG_BCL4_VCa1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - ANTISOCIAL NETWORKING";
            contents_mission[158] = "MissionTemplates_JG_BCM2_Exemplar_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - UP THE ARSENAL";
            contents_mission[159] = "MissionTemplates_JG_BCM2_Gra1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - LET US SPRAY";
            contents_mission[160] = "MissionTemplates_JG_BCS0_Exemplar_B_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - KLEPTOMANIA";
            contents_mission[161] = "MissionTemplates_JG_BCS0_Exemplar_G_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - KLEPTOMANIA";
            contents_mission[162] = "MissionTemplates_JG_BCS0_FoE1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - A BLOOD ROSE WITH A BADGE";
            contents_mission[163] = "MissionTemplates_JG_BCS0_FoE1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - BADGE OF DISHONOR";
            contents_mission[164] = "MissionTemplates_JG_BCS2_Exemplar1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - THE BIG SCOOP";
            contents_mission[165] = "MissionTemplates_JG_BCS2_VTh1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - THAT TV'S BIGGER THAN MY HOUSE";
            contents_mission[166] = "MissionTemplates_JG_BEL2_AGr1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - COVER UP";
            contents_mission[167] = "MissionTemplates_JG_BEL2_FoE3_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - CARD-HACK ARREST";
            contents_mission[168] = "MissionTemplates_JG_BEL4_FoE1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - BANG FOR YOUR BUCK";
            contents_mission[169] = "MissionTemplates_JG_BEM1_AGr1_P_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - HEARTS AND MINDS";
            contents_mission[170] = "MissionTemplates_JG_BEM1_AGr1_T_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - PR PAINTING";
            contents_mission[171] = "MissionTemplates_JG_BES2_Inv2_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - THREATENING CALLS";
            contents_mission[172] = "MissionTemplates_JG_BES3_Dis1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - IMMIGRANT STORY";
            contents_mission[173] = "MissionTemplates_JG_FEL4_FoE1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - CONSTRUCTIVE CRITICISM";
            contents_mission[174] = "MissionTemplates_JG_WEL4_FoE1_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - FREIGHT EXPECTATIONS";
            contents_mission[175] = "MissionTemplates_JP_BCS0_TagBag_B_MissionTitle=<Color:>" + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - SPRAY TO PLAY";
            contents_mission[176] = "MissionTemplates_JP_BCS0_TagBag_G_MissionTitle=<Color:> " + "[" + ColorLeft_Capture + Capture + ColorRight_Capture + "]" + " - TAGGED AND BAGGED";

            //BOMB
            contents_mission[177] = "MissionTemplates_DB_BCL0_Gra1_B_MissionTitle=<Color:>" + "[" + ColorLeft_Bomb + Bomb + ColorRight_Bomb + "]" + " - STANDING OUT FROM THE CROWD";
            contents_mission[178] = "MissionTemplates_DB_BCL0_Gra1_G_MissionTitle=<Color:>" + "[" + ColorLeft_Bomb + Bomb + ColorRight_Bomb + "]" + " - SPRAY ME UP, BUTTERCUP";
            contents_mission[179] = "MissionTemplates_DB_BCS4_Del1_MissionTitle=<Color:>" + "[" + ColorLeft_Bomb + Bomb + ColorRight_Bomb + "]" + " - PIMP MY CRIB";
            contents_mission[180] = "MissionTemplates_DB_BEL4_Dis1_MissionTitle=<Color:>" + "[" + ColorLeft_Bomb + Bomb + ColorRight_Bomb + "]" + " - THE HIDDEN MENACE";
            contents_mission[181] = "MissionTemplates_DB_BES1_For1_P_MissionTitle=<Color:>" + "[" + ColorLeft_Bomb + Bomb + ColorRight_Bomb + "]" + " - PRESS ON PRAETORIAN";
            contents_mission[182] = "MissionTemplates_DB_BES1_For1_T_MissionTitle=<Color:>" + "[" + ColorLeft_Bomb + Bomb + ColorRight_Bomb + "]" + " - MR. & MRS. NICE";
            contents_mission[183] = "MissionTemplates_JG_BCS4_Bom1_MissionTitle=<Color:>" + "[" + ColorLeft_Bomb + Bomb + ColorRight_Bomb + "]" + " - 2,4,6-TRINITROTOLUENE";


            //TRUCK
            contents_mission[184] = "MissionTemplates_DB_BEL3_DelV1_MissionTitle=<Color:>" + "[" + ColorLeft_Truck + Truck + ColorRight_Truck + "]" + " - JUST ABANDONMISSION!";

            //Tutorial
            //Line 186 - 219
            //ToDo Edit/Add Tutorial missions

            //FIGHTCLUB
            contents_mission[219] = "MissionTemplates_PGA_MovingTargetTaskItem_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[220] = "MissionTemplates_PGA_MovingTargetTaskItem_Large_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[221] = "MissionTemplates_PGA_TerritoryControl_1Point_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[222] = "MissionTemplates_PGA_TerritoryControl_3Points_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[223] = "MissionTemplates_PGA_TerritoryControl_5Points_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[224] = "MissionTemplates_PGA_VIPSurvival_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[225] = "MissionTemplates_PGB_Scavenger_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[226] = "MissionTemplates_PGB_TerritoryControl_3Points_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[227] = "MissionTemplates_PGB_TerritoryControl_5Points_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[228] = "MissionTemplates_PGC_Scavenger_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[229] = "MissionTemplates_PGC_TerritoryControl_All_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[230] = "MissionTemplates_PGC_TerritoryControl_Buildings_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[231] = "MissionTemplates_PGC_TerritoryControl_Crates_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[232] = "MissionTemplates_PG_TeamDeathmatch_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[233] = "MissionTemplates_PGvB_MovingTargetTaskItem_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[234] = "MissionTemplates_PGvB_Scavenger_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[235] = "MissionTemplates_PGvB_TerritoryControl_3Points_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[236] = "MissionTemplates_PGvC_MovingTargetTaskItem_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[237] = "MissionTemplates_PGvC_Scavenger_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[238] = "MissionTemplates_PGvC_TerritoryControl_Crates_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[239] = "MissionTemplates_PGv_TeamDeathmatch_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";
            contents_mission[240] = "MissionTemplates_WitnessingDropoff_MissionTitle=" + "[" + ColorLeft_FightClub + FightClub + ColorRight_FightClub + "]";

            //EVENT
            contents_mission[240] = "MissionTemplates_Holiday_HW_Escort_MissionTitle=<Color:>" + "[" + ColorLeft_FightClub + "EVENT" + ColorRight_FightClub + "]";
            contents_mission[240] = "MissionTemplates_JG_BCL0_VTh1_B_MissionTitle=<Color:>" + "[" + ColorLeft_FightClub + "EVENT" + ColorRight_FightClub + "]";


            File.WriteAllLines(Environment.CurrentDirectory + "\\APBGame\\Localization\\GER\\MissionTemplates.GER", contents_mission);






            //Change string
            tdmBox.Text = TDM;
            takeoverBox.Text = Takeover;
            vipBox.Text = VIP;
            dropBox.Text = ItemDrop;
            holdBox.Text = ItemHold;
            sprayBox.Text = Spray;
            captureBox.Text = Capture;
            bombBox.Text = Bomb;
            fcBox.Text = FightClub;
            truckBox.Text = Truck;


            //Saving config
            config.Default.tdmS = TDM;
            config.Default.takeoverS = Takeover;
            config.Default.vipS = VIP;
            config.Default.dropS = ItemDrop;
            config.Default.holdS = ItemHold;
            config.Default.sprayS = Spray;
            config.Default.captureS = Capture;
            config.Default.bombS = Bomb;
            config.Default.fcS = FightClub;
            config.Default.truckS = Truck;

            config.Default.Color_EnemyS = Color_Enemy;
            config.Default.Color_TeamS = Color_Team;
            config.Default.Color_AssistS = Color_Assist;


            config.Default.Color_TDM = tdmComboBox.SelectedIndex;
            config.Default.Color_VIP = vipComboBox.SelectedIndex;
            config.Default.Color_Takeover = takeoverComboBox.SelectedIndex;
            config.Default.Color_Hold = holdComboBox.SelectedIndex;
            config.Default.Color_Drop = dropComboBox.SelectedIndex;
            config.Default.Color_Spray = sprayComboBox.SelectedIndex;
            config.Default.Color_Capture = captureComboBox.SelectedIndex;
            config.Default.Color_Bomb = bombComboBox.SelectedIndex;
            config.Default.Color_FightClub = fcComboBox.SelectedIndex;
            config.Default.Color_Truck = truckComboBox.SelectedIndex;


            config.Default.Save();
        }







        // ============================================= Mission-TextBox =============================================
        private void tdmBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TDM = tdmBox.Text;
        }

        private void takeoverBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Takeover = takeoverBox.Text;
        }

        private void vipBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            VIP = vipBox.Text;
        }

        private void holdBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ItemHold = holdBox.Text;
        }

        private void dropBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ItemDrop = dropBox.Text;
        }

        private void sprayBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Spray = sprayBox.Text;
        }

        private void captureBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Capture = captureBox.Text;
        }

        private void bombBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Bomb = bombBox.Text;
        }

        private void fcBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FightClub = fcBox.Text;
        }

        private void truckBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Truck = truckBox.Text;
        }









        // ============================================= Mission-Dropmenu =============================================
        private void tdmComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.tdmComboBox.SelectedIndex == 0)
            {
                    ColorLeft_TDM = "<Color:R=0.882 G=0.0 B=0.0>";
                    ColorRight_TDM = "<Color:/>";
            }
            //Blue
           else if (this.tdmComboBox.SelectedIndex == 1)
            {
                ColorLeft_TDM = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_TDM = "<Color:/>";
            }
            //Green
            else if (this.tdmComboBox.SelectedIndex == 2)
            {
                ColorLeft_TDM = "<Color:R=0 G=0.9 B=0>";
                ColorRight_TDM = "<Color:/>";
            }
            //Yellow
            else if (this.tdmComboBox.SelectedIndex == 3)
            {
                ColorLeft_TDM = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_TDM = "<Color:/>";
            }
            //Turquoise
            else if (this.tdmComboBox.SelectedIndex == 4)
            {
                ColorLeft_TDM = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_TDM = "<Color:/>";
            }
            //Pink
            else if (this.tdmComboBox.SelectedIndex == 5)
            {
                ColorLeft_TDM = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_TDM = "<Color:/>";
            }
            //None
            else if (this.tdmComboBox.SelectedIndex == 6)
            {
                ColorLeft_TDM = "_";
                ColorRight_TDM = "<Color:/>";
            }
        }

        private void takeoverComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.takeoverComboBox.SelectedIndex == 0)
            {
                ColorLeft_Takeover = "<Color:R=0.882 G=0.0 B=0.0>";
                ColorRight_Takeover = "<Color:/>";
            }
            //Blue
            else if (this.takeoverComboBox.SelectedIndex == 1)
            {
                ColorLeft_Takeover = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_Takeover = "<Color:/>";
            }
            //Green
            else if (this.takeoverComboBox.SelectedIndex == 2)
            {
                ColorLeft_Takeover = "<Color:R=0 G=0.9 B=0>";
                ColorRight_Takeover = "<Color:/>";
            }
            //Yellow
            else if (this.takeoverComboBox.SelectedIndex == 3)
            {
                ColorLeft_Takeover = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_Takeover = "<Color:/>";
            }
            //Turquoise
            else if (this.takeoverComboBox.SelectedIndex == 4)
            {
                ColorLeft_Takeover = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_Takeover = "<Color:/>";
            }
            //Pink
            else if (this.takeoverComboBox.SelectedIndex == 5)
            {
                ColorLeft_Takeover = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_Takeover = "<Color:/>";
            }
            //None
            else if (this.takeoverComboBox.SelectedIndex == 6)
            {
                ColorLeft_Takeover = " ";
                ColorRight_Takeover = "<Color:/>";
            }
        }

        private void vipComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.vipComboBox.SelectedIndex == 0)
            {
                ColorLeft_VIP = "<Color:R=0.6 G=0.0 B=0.0>";
                ColorRight_VIP = "<Color:/>";
            }
            //Blue
            else if (this.vipComboBox.SelectedIndex == 1)
            {
                ColorLeft_VIP = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_VIP = "<Color:/>";
            }
            //Green
            else if (this.vipComboBox.SelectedIndex == 2)
            {
                ColorLeft_VIP = "<Color:R=0 G=0.9 B=0>";
                ColorRight_VIP = "<Color:/>";
            }
            //Yellow
            else if (this.vipComboBox.SelectedIndex == 3)
            {
                ColorLeft_VIP = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_VIP = "<Color:/>";
            }
            //Turquoise
            else if (this.vipComboBox.SelectedIndex == 4)
            {
                ColorLeft_VIP = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_VIP = "<Color:/>";
            }
            //Pink
            else if (this.vipComboBox.SelectedIndex == 5)
            {
                ColorLeft_VIP = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_VIP = "<Color:/>";
            }
            //None
            else if (this.vipComboBox.SelectedIndex == 6)
            {
                ColorLeft_VIP = " ";
                ColorRight_VIP = "<Color:/>";
            }
        }

        private void holdComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.holdComboBox.SelectedIndex == 0)
            {
                ColorLeft_ItemHold = "<Color:R=0.6 G=0.0 B=0.0>";
                ColorRight_ItemHold = "<Color:/>";
            }
            //Blue
            else if (this.holdComboBox.SelectedIndex == 1)
            {
                ColorLeft_ItemHold = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_ItemHold = "<Color:/>";
            }
            //Green
            else if (this.holdComboBox.SelectedIndex == 2)
            {
                ColorLeft_ItemHold = "<Color:R=0 G=0.9 B=0>";
                ColorRight_ItemHold = "<Color:/>";
            }
            //Yellow
            else if (this.holdComboBox.SelectedIndex == 3)
            {
                ColorLeft_ItemHold = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_ItemHold = "<Color:/>";
            }
            //Turquoise
            else if (this.holdComboBox.SelectedIndex == 4)
            {
                ColorLeft_ItemHold = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_ItemHold = "<Color:/>";
            }
            //Pink
            else if (this.holdComboBox.SelectedIndex == 5)
            {
                ColorLeft_ItemHold = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_ItemHold = "<Color:/>";
            }
            //None
            else if (this.holdComboBox.SelectedIndex == 6)
            {
                ColorLeft_ItemHold = " ";
                ColorRight_ItemHold = "<Color:/>";
            }
        }

        private void dropComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.dropComboBox.SelectedIndex == 0)
            {
                ColorLeft_ItemDrop = "<Color:R=0.6 G=0.0 B=0.0>";
                ColorRight_ItemDrop = "<Color:/>";
            }
            //Blue
            else if (this.dropComboBox.SelectedIndex == 1)
            {
                ColorLeft_ItemDrop = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_ItemDrop = "<Color:/>";
            }
            //Green
            else if (this.dropComboBox.SelectedIndex == 2)
            {
                ColorLeft_ItemDrop = "<Color:R=0 G=0.9 B=0>";
                ColorRight_ItemDrop = "<Color:/>";
            }
            //Yellow
            else if (this.dropComboBox.SelectedIndex == 3)
            {
                ColorLeft_ItemDrop = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_ItemDrop = "<Color:/>";
            }
            //Turquoise
            else if (this.dropComboBox.SelectedIndex == 4)
            {
                ColorLeft_ItemDrop = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_ItemDrop = "<Color:/>";
            }
            //Pink
            else if (this.dropComboBox.SelectedIndex == 5)
            {
                ColorLeft_ItemDrop = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_ItemDrop = "<Color:/>";
            }
            //None
            else if (this.dropComboBox.SelectedIndex == 6)
            {
                ColorLeft_ItemDrop = " ";
                ColorRight_ItemDrop = "<Color:/>";
            }
        }

        private void sprayComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.sprayComboBox.SelectedIndex == 0)
            {
                ColorLeft_Spray = "<Color:R=0.6 G=0.0 B=0.0>";
                ColorRight_Spray = "<Color:/>";
            }
            //Blue
            else if (this.sprayComboBox.SelectedIndex == 1)
            {
                ColorLeft_Spray = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_Spray = "<Color:/>";
            }
            //Green
            else if (this.sprayComboBox.SelectedIndex == 2)
            {
                ColorLeft_Spray = "<Color:R=0 G=0.9 B=0>";
                ColorRight_Spray = "<Color:/>";
            }
            //Yellow
            else if (this.sprayComboBox.SelectedIndex == 3)
            {
                ColorLeft_Spray = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_Spray = "<Color:/>";
            }
            //Turquoise
            else if (this.sprayComboBox.SelectedIndex == 4)
            {
                ColorLeft_Spray = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_Spray = "<Color:/>";
            }
            //Pink
            else if (this.sprayComboBox.SelectedIndex == 5)
            {
                ColorLeft_Spray = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_Spray = "<Color:/>";
            }
            //None
            else if (this.sprayComboBox.SelectedIndex == 6)
            {
                ColorLeft_Spray = " ";
                ColorRight_Spray = "<Color:/>";
            }
        }

        private void captureComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.captureComboBox.SelectedIndex == 0)
            {
                ColorLeft_Capture = "<Color:R=0.6 G=0.0 B=0.0>";
                ColorRight_Capture = "<Color:/>";
            }
            //Blue
            else if (this.captureComboBox.SelectedIndex == 1)
            {
                ColorLeft_Capture = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_Capture = "<Color:/>";
            }
            //Green
            else if (this.captureComboBox.SelectedIndex == 2)
            {
                ColorLeft_Capture = "<Color:R=0 G=0.9 B=0>";
                ColorRight_Capture = "<Color:/>";
            }
            //Yellow
            else if (this.captureComboBox.SelectedIndex == 3)
            {
                ColorLeft_Capture = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_Capture = "<Color:/>";
            }
            //Turquoise
            else if (this.captureComboBox.SelectedIndex == 4)
            {
                ColorLeft_Capture = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_Capture = "<Color:/>";
            }
            //Pink
            else if (this.captureComboBox.SelectedIndex == 5)
            {
                ColorLeft_Capture = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_Capture = "<Color:/>";
            }
            //None
            else if (this.captureComboBox.SelectedIndex == 6)
            {
                ColorLeft_Capture = " ";
                ColorRight_Capture = "<Color:/>";
            }
        }

        private void bombComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.bombComboBox.SelectedIndex == 0)
            {
                ColorLeft_Bomb = "<Color:R=0.6 G=0.0 B=0.0>";
                ColorRight_Bomb = "<Color:/>";
            }
            //Blue
            else if (this.bombComboBox.SelectedIndex == 1)
            {
                ColorLeft_Bomb = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_Bomb = "<Color:/>";
            }
            //Green
            else if (this.bombComboBox.SelectedIndex == 2)
            {
                ColorLeft_Bomb = "<Color:R=0 G=0.9 B=0>";
                ColorRight_Bomb = "<Color:/>";
            }
            //Yellow
            else if (this.bombComboBox.SelectedIndex == 3)
            {
                ColorLeft_Bomb = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_Bomb = "<Color:/>";
            }
            //Turquoise
            else if (this.bombComboBox.SelectedIndex == 4)
            {
                ColorLeft_Bomb = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_Bomb = "<Color:/>";
            }
            //Pink
            else if (this.bombComboBox.SelectedIndex == 5)
            {
                ColorLeft_Bomb = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_Bomb = "<Color:/>";
            }
            //None
            else if (this.bombComboBox.SelectedIndex == 6)
            {
                ColorLeft_Bomb = "_";
                ColorRight_Bomb = "<Color:/>";
            }
        }

        private void fcComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.fcComboBox.SelectedIndex == 0)
            {
                ColorLeft_FightClub = "<Color:R=0.6 G=0.0 B=0.0>";
                ColorRight_FightClub = "<Color:/>";
            }
            //Blue
            else if (this.fcComboBox.SelectedIndex == 1)
            {
                ColorLeft_FightClub = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_FightClub = "<Color:/>";
            }
            //Green
            else if (this.fcComboBox.SelectedIndex == 2)
            {
                ColorLeft_FightClub = "<Color:R=0 G=0.9 B=0>";
                ColorRight_FightClub = "<Color:/>";
            }
            //Yellow
            else if (this.fcComboBox.SelectedIndex == 3)
            {
                ColorLeft_FightClub = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_FightClub = "<Color:/>";
            }
            //Turquoise
            else if (this.fcComboBox.SelectedIndex == 4)
            {
                ColorLeft_FightClub = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_FightClub = "<Color:/>";
            }
            //Pink
            else if (this.fcComboBox.SelectedIndex == 5)
            {
                ColorLeft_FightClub = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_FightClub = "<Color:/>";
            }
            //None
            else if (this.fcComboBox.SelectedIndex == 6)
            {
                ColorLeft_FightClub = " ";
                ColorRight_FightClub = "<Color:/>";
            }
        }

        private void truckComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Red
            if (this.truckComboBox.SelectedIndex == 0)
            {
                ColorLeft_Truck = "<Color:R=0.6 G=0.0 B=0.0>";
                ColorRight_Truck = "<Color:/>";
            }
            //Blue
            else if (this.truckComboBox.SelectedIndex == 1)
            {
                ColorLeft_Truck = "<Color:R=0 G=0.3 B=0.7>";
                ColorRight_Truck = "<Color:/>";
            }
            //Green
            else if (this.truckComboBox.SelectedIndex == 2)
            {
                ColorLeft_Truck = "<Color:R=0 G=0.9 B=0>";
                ColorRight_Truck = "<Color:/>";
            }
            //Yellow
            else if (this.truckComboBox.SelectedIndex == 3)
            {
                ColorLeft_Truck = "<Color:R=0.6 G=0.2 B=0.0>";
                ColorRight_Truck = "<Color:/>";
            }
            //Turquoise
            else if (this.truckComboBox.SelectedIndex == 4)
            {
                ColorLeft_Truck = "<Color:R=0.0 G=0.4 B=0.6>";
                ColorRight_Truck = "<Color:/>";
            }
            //Pink
            else if (this.truckComboBox.SelectedIndex == 5)
            {
                ColorLeft_Truck = "<Color:R=0.6 G=0.0 B=0.7>";
                ColorRight_Truck = "<Color:/>";
            }
            //None
            else if (this.truckComboBox.SelectedIndex == 6)
            {
                ColorLeft_Truck = " ";
                ColorRight_Truck = "<Color:/>";
            }
        }

    }
}
