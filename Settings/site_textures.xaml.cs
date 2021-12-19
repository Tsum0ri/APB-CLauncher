using System;
using Launcher;
using System.Collections.Generic;
using System.Linq;
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
using System.IO;

namespace CLauncher2._0.Settings
{
    /// <summary>
    /// Interaktionslogik für site_textures.xaml
    /// </summary>
    public partial class site_textures : Page
    {
        public site_textures()
        {
            InitializeComponent();


            // ========================================== Loading User-Settings ==========================================
            this.EnvironmentSlider.Value = UserSettings.Default.EnvironmentTexS;
            this.EnvironemtText.Content = UserSettings.Default.EnvironmentTextS;
            this.VehicleSlider.Value = UserSettings.Default.VehicleTexS;
            this.VehicleText.Content = UserSettings.Default.VehicleTextS;
            this.UnknownSlider.Value = UserSettings.Default.UnknownTexS;
            this.UnknownText.Content = UserSettings.Default.UnknownTextS;
            this.PropSlider.Value = UserSettings.Default.PropTexS;
            this.PropText.Content = UserSettings.Default.PropTextS;
            this.CharacterSlider.Value = UserSettings.Default.CharacterTexS;
            this.CharacterText.Content = UserSettings.Default.CharacterTextS;
            this.PedestrianSlider.Value = UserSettings.Default.PedestrianTexS;
            this.PedestrianText.Content = UserSettings.Default.PedestrianTextS;
            this.CityVehicleSlider.Value = UserSettings.Default.CityVehicleTexS;
            this.CityVehicleText.Content = UserSettings.Default.CityVehicleTextS;
            this.ItemWeaponSlider.Value = UserSettings.Default.ItemWeaponTexS;
            this.ItemWeaponText.Content = UserSettings.Default.ItemWeaponTextS;
            this.PrimitiveSlider.Value = UserSettings.Default.PrimitiveTexS;
            this.PrimitiveText.Content = UserSettings.Default.PrimitiveTextS;
            this.UISlider.Value = UserSettings.Default.UITexS;
            this.UIText.Content = UserSettings.Default.UITextS;
            this.ShadowSlider.Value = UserSettings.Default.ShadowResTexS;
            this.ShadowResText.Content = UserSettings.Default.ShadowTextS;
            this.VFXSlider.Value = UserSettings.Default.VFXTexS;
            this.VFXText.Content = UserSettings.Default.VFXTextS;
            this.LightShadowSlider.Value = UserSettings.Default.LightShadowMapTexS;
            this.LightShadowMapText.Content = UserSettings.Default.LightShadowTextS;
            this.RenderSlider.Value = UserSettings.Default.RenderTexS;
            this.RenderText.Content = UserSettings.Default.RenderTextS;
            this.SignageSlider.Value = UserSettings.Default.SignageTexS;
            this.SignageText.Content = UserSettings.Default.SignageTextS;
            this.MissionGraffitiSlider.Value = UserSettings.Default.MissionGraffitiTexS;
            this.MissionGraffitiText.Content = UserSettings.Default.MissionGraffitiTextS;
            this.PlayerStatueSlider.Value = UserSettings.Default.PlayerStatueTexS;
            this.PlayerStatueText.Content = UserSettings.Default.PlayerStatueTextS;
            this.SharedCharacterSlider.Value = UserSettings.Default.SharedCharacterTexS;
            this.SharedCharacterText.Content = UserSettings.Default.SharedCharacterTextS;
            this.SharedVehicleSlider.Value = UserSettings.Default.SharedVehicleTexS;
            this.SharedVehicleText.Content = UserSettings.Default.SharedVehicleTextS;
            this.ContactSlider.Value = UserSettings.Default.ContactTexS;
            this.ContactText.Content = UserSettings.Default.ContactTextS;
            this.CharacterDiffNormSlider.Value = UserSettings.Default.CharacterDNTexS;
            this.CharacterDiffNormText.Content = UserSettings.Default.CharacterDNTextS;
            this.PlayerVehicleSlider.Value = UserSettings.Default.PlayerVehicleTexS;
            this.PlayerVehicleText.Content = UserSettings.Default.PlayerVehicleTextS;
        }


        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            // ============================================= APBCompat Textures =============================================
            string[] contents = File.ReadAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            if (this.UnknownSlider.Value == 0)
            {
                contents[621] = "TEXCAT_Unknown=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
                contents[622] = "TEXCAT_Unknown=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
            }
            else
            {
                contents[621] = "TEXCAT_Unknown=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
                contents[622] = "TEXCAT_Unknown=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
            }
            if (this.EnvironmentSlider.Value == 0)
            {
                contents[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
                contents[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
                contents[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
                contents[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
                contents[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
                contents[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.EnvironmentSlider.Value == 1)
            {
                contents[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
                contents[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
                contents[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
                contents[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
                contents[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
                contents[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.EnvironmentSlider.Value == 2)
            {
                contents[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
                contents[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
                contents[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
                contents[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
                contents[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
                contents[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.EnvironmentSlider.Value == 3)
            {
                contents[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
                contents[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
                contents[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
                contents[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
                contents[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
                contents[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.EnvironmentSlider.Value == 4)
            {
                contents[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.EnvironmentSlider.Value == 5)
            {
                contents[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.EnvironmentSlider.Value == 6)
            {
                contents[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.EnvironmentSlider.Value == 7)
            {
                contents[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            else
            {
                contents[623] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[624] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1306] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1307] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1349] = "TEXCAT_Environment=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[1350] = "TEXCAT_Environment=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            if (this.PropSlider.Value == 0)
            {
                contents[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PropSlider.Value == 1)
            {
                contents[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PropSlider.Value == 2)
            {
                contents[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PropSlider.Value == 3)
            {
                contents[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PropSlider.Value == 4)
            {
                contents[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PropSlider.Value == 5)
            {
                contents[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PropSlider.Value == 6)
            {
                contents[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PropSlider.Value == 7)
            {
                contents[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else
            {
                contents[625] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[626] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1308] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1309] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1351] = "TEXCAT_Prop=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1352] = "TEXCAT_Prop=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            if (this.CharacterSlider.Value == 0)
            {
                contents[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=40)";
                contents[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=40)";
                contents[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
                contents[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.CharacterSlider.Value == 1)
            {
                contents[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=40)";
                contents[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=40)";
                contents[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
                contents[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.CharacterSlider.Value == 2)
            {
                contents[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=40)";
                contents[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=40)";
                contents[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
                contents[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.CharacterSlider.Value == 3)
            {
                contents[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=40)";
                contents[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=40)";
                contents[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
                contents[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.CharacterSlider.Value == 4)
            {
                contents[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.CharacterSlider.Value == 5)
            {
                contents[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.CharacterSlider.Value == 6)
            {
                contents[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.CharacterSlider.Value == 7)
            {
                contents[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else
            {
                contents[627] = "TEXCAT_PlayerCharacter=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[628] = "TEXCAT_PlayerCharacter=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=40)";
                contents[637] = "TEXCAT_CharacterSource=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[638] = "TEXCAT_CharacterSource=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            if (this.VehicleSlider.Value == 0)
            {
                contents[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=35)";
                contents[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=35)";
                contents[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
                contents[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.VehicleSlider.Value == 1)
            {
                contents[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=35)";
                contents[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=35)";
                contents[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
                contents[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.VehicleSlider.Value == 2)
            {
                contents[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=35)";
                contents[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=35)";
                contents[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
                contents[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.VehicleSlider.Value == 3)
            {
                contents[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=35)";
                contents[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=35)";
                contents[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
                contents[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.VehicleSlider.Value == 4)
            {
                contents[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.VehicleSlider.Value == 5)
            {
                contents[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.VehicleSlider.Value == 6)
            {
                contents[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.VehicleSlider.Value == 7)
            {
                contents[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else
            {
                contents[629] = "TEXCAT_PlayerVehicle=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[630] = "TEXCAT_PlayerVehicle=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=35)";
                contents[639] = "TEXCAT_VehicleSource=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[640] = "TEXCAT_VehicleSource=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            if (this.PedestrianSlider.Value == 0)
            {
                contents[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.PedestrianSlider.Value == 1)
            {
                contents[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.PedestrianSlider.Value == 2)
            {
                contents[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.PedestrianSlider.Value == 3)
            {
                contents[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.PedestrianSlider.Value == 4)
            {
                contents[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.PedestrianSlider.Value == 5)
            {
                contents[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else
            {
                contents[631] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[632] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1302] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1303] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1345] = "TEXCAT_LCPedestrian=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1346] = "TEXCAT_LCPedestrian=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            if (this.CityVehicleSlider.Value == 0)
            {
                contents[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.CityVehicleSlider.Value == 1)
            {
                contents[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.CityVehicleSlider.Value == 2)
            {
                contents[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.CityVehicleSlider.Value == 3)
            {
                contents[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.CityVehicleSlider.Value == 4)
            {
                contents[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.CityVehicleSlider.Value == 5)
            {
                contents[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.CityVehicleSlider.Value == 6)
            {
                contents[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.CityVehicleSlider.Value == 7)
            {
                contents[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else
            {
                contents[633] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[634] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1304] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1305] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1347] = "TEXCAT_LCVehicle=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1348] = "TEXCAT_LCVehicle=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            if (this.ItemWeaponSlider.Value == 0)
            {
                contents[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.ItemWeaponSlider.Value == 1)
            {
                contents[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.ItemWeaponSlider.Value == 2)
            {
                contents[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.ItemWeaponSlider.Value == 3)
            {
                contents[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.ItemWeaponSlider.Value == 4)
            {
                contents[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.ItemWeaponSlider.Value == 5)
            {
                contents[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.ItemWeaponSlider.Value == 6)
            {
                contents[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.ItemWeaponSlider.Value == 7)
            {
                contents[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else
            {
                contents[635] = "TEXCAT_Pickup=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[636] = "TEXCAT_Pickup=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            if (this.PrimitiveSlider.Value == 0)
            {
                contents[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
                contents[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.PrimitiveSlider.Value == 1)
            {
                contents[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
                contents[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.PrimitiveSlider.Value == 2)
            {
                contents[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
                contents[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.PrimitiveSlider.Value == 3)
            {
                contents[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
                contents[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.PrimitiveSlider.Value == 4)
            {
                contents[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.PrimitiveSlider.Value == 5)
            {
                contents[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.PrimitiveSlider.Value == 6)
            {
                contents[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.PrimitiveSlider.Value == 7)
            {
                contents[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else
            {
                contents[641] = "TEXCAT_PrimitiveSource=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[642] = "TEXCAT_PrimitiveSource=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            if (this.UISlider.Value == 0)
            {
                contents[643] = "TEXCAT_UI=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[644] = "TEXCAT_UI=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else if (this.UISlider.Value == 1)
            {
                contents[643] = "TEXCAT_UI=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[644] = "TEXCAT_UI=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            else
            {
                contents[643] = "TEXCAT_UI=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
                contents[644] = "TEXCAT_UI=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=100)";
            }
            if (this.VFXSlider.Value == 0)
            {
                contents[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
                contents[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.VFXSlider.Value == 1)
            {
                contents[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
                contents[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.VFXSlider.Value == 2)
            {
                contents[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
                contents[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.VFXSlider.Value == 3)
            {
                contents[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
                contents[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.VFXSlider.Value == 4)
            {
                contents[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.VFXSlider.Value == 5)
            {
                contents[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.VFXSlider.Value == 6)
            {
                contents[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            else if (this.VFXSlider.Value == 7)
            {
                contents[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            else
            {
                contents[645] = "TEXCAT_VFX=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
                contents[646] = "TEXCAT_VFX=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=10)";
            }
            if (this.LightShadowSlider.Value == 0)
            {
                contents[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.LightShadowSlider.Value == 1)
            {
                contents[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.LightShadowSlider.Value == 2)
            {
                contents[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.LightShadowSlider.Value == 3)
            {
                contents[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.LightShadowSlider.Value == 4)
            {
                contents[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.LightShadowSlider.Value == 5)
            {
                contents[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.LightShadowSlider.Value == 6)
            {
                contents[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.LightShadowSlider.Value == 7)
            {
                contents[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else
            {
                contents[647] = "TEXCAT_LightAndShadowMap=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[648] = "TEXCAT_LightAndShadowMap=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            if (this.RenderSlider.Value == 0)
            {
                contents[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=0)";
                contents[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=0)";
            }
            else if (this.RenderSlider.Value == 1)
            {
                contents[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=0)";
                contents[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=0)";
            }
            else if (this.RenderSlider.Value == 2)
            {
                contents[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=0)";
                contents[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=0)";
            }
            else if (this.RenderSlider.Value == 3)
            {
                contents[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=0)";
                contents[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=0)";
            }
            else if (this.RenderSlider.Value == 4)
            {
                contents[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
                contents[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
            }
            else if (this.RenderSlider.Value == 5)
            {
                contents[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
                contents[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
            }
            else if (this.RenderSlider.Value == 6)
            {
                contents[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
                contents[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
            }
            else if (this.RenderSlider.Value == 7)
            {
                contents[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
                contents[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
            }
            else
            {
                contents[649] = "TEXCAT_RenderTarget=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
                contents[650] = "TEXCAT_RenderTarget=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=0)";
            }
            if (this.SignageSlider.Value == 0)
            {
                contents[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=50)";
                contents[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.SignageSlider.Value == 1)
            {
                contents[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=50)";
                contents[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.SignageSlider.Value == 2)
            {
                contents[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=50)";
                contents[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.SignageSlider.Value == 3)
            {
                contents[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=50)";
                contents[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.SignageSlider.Value == 4)
            {
                contents[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.SignageSlider.Value == 5)
            {
                contents[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.SignageSlider.Value == 6)
            {
                contents[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.SignageSlider.Value == 7)
            {
                contents[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            else
            {
                contents[651] = "TEXCAT_Signage=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[652] = "TEXCAT_Signage=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            if (this.MissionGraffitiSlider.Value == 0)
            {
                contents[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=50)";
                contents[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.MissionGraffitiSlider.Value == 1)
            {
                contents[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=50)";
                contents[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.MissionGraffitiSlider.Value == 2)
            {
                contents[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=50)";
                contents[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.MissionGraffitiSlider.Value == 3)
            {
                contents[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=50)";
                contents[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.MissionGraffitiSlider.Value == 4)
            {
                contents[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.MissionGraffitiSlider.Value == 5)
            {
                contents[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.MissionGraffitiSlider.Value == 6)
            {
                contents[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            else if (this.MissionGraffitiSlider.Value == 7)
            {
                contents[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            else
            {
                contents[653] = "TEXCAT_PlayerGraffiti=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
                contents[654] = "TEXCAT_PlayerGraffiti=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=50)";
            }
            if (this.PlayerStatueSlider.Value == 0)
            {
                contents[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PlayerStatueSlider.Value == 1)
            {
                contents[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PlayerStatueSlider.Value == 2)
            {
                contents[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PlayerStatueSlider.Value == 3)
            {
                contents[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PlayerStatueSlider.Value == 4)
            {
                contents[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PlayerStatueSlider.Value == 5)
            {
                contents[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PlayerStatueSlider.Value == 6)
            {
                contents[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.PlayerStatueSlider.Value == 7)
            {
                contents[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else
            {
                contents[655] = "TEXCAT_PlayerStatue=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[656] = "TEXCAT_PlayerStatue=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            if (this.SharedCharacterSlider.Value == 0)
            {
                contents[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedCharacterSlider.Value == 1)
            {
                contents[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedCharacterSlider.Value == 2)
            {
                contents[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedCharacterSlider.Value == 3)
            {
                contents[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedCharacterSlider.Value == 4)
            {
                contents[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedCharacterSlider.Value == 5)
            {
                contents[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedCharacterSlider.Value == 6)
            {
                contents[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedCharacterSlider.Value == 7)
            {
                contents[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else
            {
                contents[657] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[658] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1310] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1311] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1353] = "TEXCAT_CharacterShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1354] = "TEXCAT_CharacterShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            if (this.SharedVehicleSlider.Value == 0)
            {
                contents[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
                contents[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedVehicleSlider.Value == 1)
            {
                contents[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
                contents[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedVehicleSlider.Value == 2)
            {
                contents[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
                contents[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedVehicleSlider.Value == 3)
            {
                contents[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
                contents[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedVehicleSlider.Value == 4)
            {
                contents[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedVehicleSlider.Value == 5)
            {
                contents[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedVehicleSlider.Value == 6)
            {
                contents[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else if (this.SharedVehicleSlider.Value == 7)
            {
                contents[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            else
            {
                contents[659] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[660] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1312] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1313] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1355] = "TEXCAT_VehicleShared=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
                contents[1356] = "TEXCAT_VehicleShared=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=20)";
            }
            if (this.ContactSlider.Value == 0)
            {
                contents[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
                contents[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=16,LODBias=4,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.ContactSlider.Value == 1)
            {
                contents[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
                contents[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=32,LODBias=3,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.ContactSlider.Value == 2)
            {
                contents[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
                contents[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=64,LODBias=2,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.ContactSlider.Value == 3)
            {
                contents[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
                contents[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=128,LODBias=1,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.ContactSlider.Value == 4)
            {
                contents[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=256,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.ContactSlider.Value == 5)
            {
                contents[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=512,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.ContactSlider.Value == 6)
            {
                contents[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=1024,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else if (this.ContactSlider.Value == 7)
            {
                contents[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=2048,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            else
            {
                contents[663] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[664] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1314] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1315] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1357] = "TEXCAT_Contact=(Usage=0,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
                contents[1358] = "TEXCAT_Contact=(Usage=1,MinLODSize=1,MaxLODSize=4096,LODBias=0,DisableStreaming=False,FairUsagePriority=30)";
            }
            File.WriteAllLines(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini", contents);


            UserSettings.Default.VehicleTexS = (int)this.VehicleSlider.Value;
            UserSettings.Default.VehicleTextS = (string)this.VehicleText.Content;
            UserSettings.Default.UnknownTexS = (int)this.UnknownSlider.Value;
            UserSettings.Default.UnknownTextS = (string)this.UnknownText.Content;
            UserSettings.Default.EnvironmentTexS = (int)this.EnvironmentSlider.Value;
            UserSettings.Default.EnvironmentTextS = (string)this.EnvironemtText.Content;
            UserSettings.Default.PropTexS = (int)this.PropSlider.Value;
            UserSettings.Default.PropTextS = (string)this.PropText.Content;
            UserSettings.Default.CharacterTexS = (int)this.CharacterSlider.Value;
            UserSettings.Default.CharacterTextS = (string)this.CharacterText.Content;
            UserSettings.Default.PedestrianTexS = (int)this.PedestrianSlider.Value;
            UserSettings.Default.PedestrianTextS = (string)this.PedestrianText.Content;
            UserSettings.Default.CityVehicleTexS = (int)this.CityVehicleSlider.Value;
            UserSettings.Default.CityVehicleTextS = (string)this.CityVehicleText.Content;
            UserSettings.Default.ItemWeaponTexS = (int)this.ItemWeaponSlider.Value;
            UserSettings.Default.ItemWeaponTextS = (string)this.ItemWeaponText.Content;
            UserSettings.Default.PrimitiveTexS = (int)this.PrimitiveSlider.Value;
            UserSettings.Default.PrimitiveTextS = (string)this.PrimitiveText.Content;
            UserSettings.Default.UITexS = (int)this.UISlider.Value;
            UserSettings.Default.UITextS = (string)this.UIText.Content;
            UserSettings.Default.ShadowResTexS = (int)this.ShadowSlider.Value;
            UserSettings.Default.ShadowTextS = (string)this.ShadowResText.Content;
            UserSettings.Default.VFXTexS = (int)this.VFXSlider.Value;
            UserSettings.Default.VFXTextS = (string)this.VFXText.Content;
            UserSettings.Default.LightShadowMapTexS = (int)this.LightShadowSlider.Value;
            UserSettings.Default.LightShadowTextS = (string)this.LightShadowMapText.Content;
            UserSettings.Default.RenderTexS = (int)this.RenderSlider.Value;
            UserSettings.Default.RenderTextS = (string)this.RenderText.Content;
            UserSettings.Default.SignageTexS = (int)this.SignageSlider.Value;
            UserSettings.Default.SignageTextS = (string)this.SignageText.Content;
            UserSettings.Default.MissionGraffitiTexS = (int)this.MissionGraffitiSlider.Value;
            UserSettings.Default.MissionGraffitiTextS = (string)this.MissionGraffitiText.Content;
            UserSettings.Default.PlayerStatueTexS = (int)this.PlayerStatueSlider.Value;
            UserSettings.Default.PlayerStatueTextS = (string)this.PlayerStatueText.Content;
            UserSettings.Default.SharedCharacterTexS = (int)this.SharedCharacterSlider.Value;
            UserSettings.Default.SharedCharacterTextS = (string)this.SharedCharacterText.Content;
            UserSettings.Default.SharedVehicleTexS = (int)this.SharedVehicleSlider.Value;
            UserSettings.Default.SharedVehicleTextS = (string)this.SharedVehicleText.Content;
            UserSettings.Default.ContactTexS = (int)this.ContactSlider.Value;
            UserSettings.Default.ContactTextS = (string)this.ContactText.Content;
            UserSettings.Default.CharacterDNTexS = (int)this.CharacterDiffNormSlider.Value;
            UserSettings.Default.CharacterDNTextS = (string)this.CharacterDiffNormText.Content;
            UserSettings.Default.PlayerVehicleTexS = (int)this.PlayerVehicleSlider.Value;
            UserSettings.Default.PlayerVehicleTextS = (string)this.PlayerVehicleText.Content;

            UserSettings.Default.Save();

        }


        // ---------------------------------------------- APBTextures-Sliders ---------------------------------------------
        private void UnknownSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.UnknownSlider.Value == 0)
                this.UnknownText.Content = "16"; //Default
            else
                this.UnknownText.Content = "32";
        }

        private void EnvironmentSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.EnvironmentSlider.Value == 0)
                this.EnvironemtText.Content = "16";
            else if (this.EnvironmentSlider.Value == 1)
                this.EnvironemtText.Content = "32";
            else if (this.EnvironmentSlider.Value == 2)
                this.EnvironemtText.Content = "64"; //Default
            else if (this.EnvironmentSlider.Value == 3)
                this.EnvironemtText.Content = "128";
            else if (this.EnvironmentSlider.Value == 4)
                this.EnvironemtText.Content = "256";
            else if (this.EnvironmentSlider.Value == 5)
                this.EnvironemtText.Content = "512";
            else if (this.EnvironmentSlider.Value == 6)
                this.EnvironemtText.Content = "1024";
            else if (this.EnvironmentSlider.Value == 7)
                this.EnvironemtText.Content = "2048";
            else
                this.EnvironemtText.Content = "4096";
        }

        private void PropSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.PropSlider.Value == 0)
                this.PropText.Content = "16";
            else if (this.PropSlider.Value == 1)
                this.PropText.Content = "32";
            else if (this.PropSlider.Value == 2)
                this.PropText.Content = "64";//Default
            else if (this.PropSlider.Value == 3)
                this.PropText.Content = "128";
            else if (this.PropSlider.Value == 4)
                this.PropText.Content = "256";
            else if (this.PropSlider.Value == 5)
                this.PropText.Content = "512";
            else if (this.PropSlider.Value == 6)
                this.PropText.Content = "1024";
            else if (this.PropSlider.Value == 7)
                this.PropText.Content = "2048";
            else
                this.PropText.Content = "4096";
        }

        private void CharacterSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.CharacterSlider.Value == 0)
                this.CharacterText.Content = "16";
            else if (this.CharacterSlider.Value == 1)
                this.CharacterText.Content = "32";
            else if (this.CharacterSlider.Value == 2)
                this.CharacterText.Content = "64";
            else if (this.CharacterSlider.Value == 3)
                this.CharacterText.Content = "128";
            else if (this.CharacterSlider.Value == 4)
                this.CharacterText.Content = "256";//Default
            else if (this.CharacterSlider.Value == 5)
                this.CharacterText.Content = "512";
            else if (this.CharacterSlider.Value == 6)
                this.CharacterText.Content = "1024";
            else if (this.CharacterSlider.Value == 7)
                this.CharacterText.Content = "2048";
            else
                this.CharacterText.Content = "4096";
        }

        private void VehicleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.VehicleSlider.Value == 0)
                this.VehicleText.Content = "16";
            else if (this.VehicleSlider.Value == 1)
                this.VehicleText.Content = "32";
            else if (this.VehicleSlider.Value == 2)
                this.VehicleText.Content = "64";
            else if (this.VehicleSlider.Value == 3)
                this.VehicleText.Content = "128";//Default
            else if (this.VehicleSlider.Value == 4)
                this.VehicleText.Content = "256";
            else if (this.VehicleSlider.Value == 5)
                this.VehicleText.Content = "512";
            else if (this.VehicleSlider.Value == 6)
                this.VehicleText.Content = "1024";
            else if (this.VehicleSlider.Value == 7)
                this.VehicleText.Content = "2048";
            else
                this.VehicleText.Content = "4096";
        }

        private void PedestrianSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.PedestrianSlider.Value == 0)
                this.PedestrianText.Content = "16";
            else if (this.PedestrianSlider.Value == 1)
                this.PedestrianText.Content = "32";
            else if (this.PedestrianSlider.Value == 2)
                this.PedestrianText.Content = "64";
            else if (this.PedestrianSlider.Value == 3)
                this.PedestrianText.Content = "128";//Default
            else if (this.PedestrianSlider.Value == 4)
                this.PedestrianText.Content = "256";
            else if (this.PedestrianSlider.Value == 5)
                this.PedestrianText.Content = "512";
            else
                this.PedestrianText.Content = "1024";
        }

        private void CityVehicleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.CityVehicleSlider.Value == 0)
                this.CityVehicleText.Content = "16";
            else if (this.CityVehicleSlider.Value == 1)
                this.CityVehicleText.Content = "32";
            else if (this.CityVehicleSlider.Value == 2)
                this.CityVehicleText.Content = "64";
            else if (this.CityVehicleSlider.Value == 3)
                this.CityVehicleText.Content = "128";//Default
            else if (this.CityVehicleSlider.Value == 4)
                this.CityVehicleText.Content = "256";
            else if (this.CityVehicleSlider.Value == 5)
                this.CityVehicleText.Content = "512";
            else if (this.CityVehicleSlider.Value == 6)
                this.CityVehicleText.Content = "1024";
            else if (this.CityVehicleSlider.Value == 7)
                this.CityVehicleText.Content = "2048";
            else
                this.CityVehicleText.Content = "4096";
        }

        private void ItemWeaponSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.ItemWeaponSlider.Value == 0)
                this.ItemWeaponText.Content = "16";
            else if (this.ItemWeaponSlider.Value == 1)
                this.ItemWeaponText.Content = "32";
            else if (this.ItemWeaponSlider.Value == 2)
                this.ItemWeaponText.Content = "64";//Default
            else if (this.ItemWeaponSlider.Value == 3)
                this.ItemWeaponText.Content = "128";
            else if (this.ItemWeaponSlider.Value == 4)
                this.ItemWeaponText.Content = "256";
            else if (this.ItemWeaponSlider.Value == 5)
                this.ItemWeaponText.Content = "512";
            else if (this.ItemWeaponSlider.Value == 6)
                this.ItemWeaponText.Content = "1024";
            else if (this.ItemWeaponSlider.Value == 7)
                this.ItemWeaponText.Content = "2048";
            else
                this.ItemWeaponText.Content = "4096";
        }

        private void PrimitiveSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.PrimitiveSlider.Value == 0)
                this.PrimitiveText.Content = "16";
            else if (this.PrimitiveSlider.Value == 1)
                this.PrimitiveText.Content = "32";
            else if (this.PrimitiveSlider.Value == 2)
                this.PrimitiveText.Content = "64";//Default
            else if (this.PrimitiveSlider.Value == 3)
                this.PrimitiveText.Content = "128";
            else if (this.PrimitiveSlider.Value == 4)
                this.PrimitiveText.Content = "256";
            else if (this.PrimitiveSlider.Value == 5)
                this.PrimitiveText.Content = "512";
            else if (this.PrimitiveSlider.Value == 6)
                this.PrimitiveText.Content = "1024";
            else if (this.PrimitiveSlider.Value == 7)
                this.PrimitiveText.Content = "2048";
            else
                this.PrimitiveText.Content = "4096";
        }

        private void UISlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.UISlider.Value == 0)
                this.UIText.Content = "1024";//Default
            else if (this.UISlider.Value == 1)
                this.UIText.Content = "2048";
            else
                this.UIText.Content = "4096";
        }

        private void ShadowSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.ShadowSlider.Value == 0)
                this.ShadowResText.Content = "128";//Default
            else if (this.ShadowSlider.Value == 1)
                this.ShadowResText.Content = "256";
            else if (this.ShadowSlider.Value == 2)
                this.ShadowResText.Content = "512";
            else if (this.ShadowSlider.Value == 3)
                this.ShadowResText.Content = "1024";
            else
                this.ShadowResText.Content = "2048";
        }

        private void VFXSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.VFXSlider.Value == 0)
                this.VFXText.Content = "16";
            else if (this.VFXSlider.Value == 1)
                this.VFXText.Content = "32";//Default
            else if (this.VFXSlider.Value == 2)
                this.VFXText.Content = "64";
            else if (this.VFXSlider.Value == 3)
                this.VFXText.Content = "128";
            else if (this.VFXSlider.Value == 4)
                this.VFXText.Content = "256";
            else if (this.VFXSlider.Value == 5)
                this.VFXText.Content = "512";
            else if (this.VFXSlider.Value == 6)
                this.VFXText.Content = "1024";
            else if (this.VFXSlider.Value == 7)
                this.VFXText.Content = "2048";
            else
                this.VFXText.Content = "4096";
        }

        private void LightShadowSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.LightShadowSlider.Value == 0)
                this.LightShadowMapText.Content = "16";//Default
            else if (this.LightShadowSlider.Value == 1)
                this.LightShadowMapText.Content = "32";
            else if (this.LightShadowSlider.Value == 2)
                this.LightShadowMapText.Content = "64";
            else if (this.LightShadowSlider.Value == 3)
                this.LightShadowMapText.Content = "128";
            else if (this.LightShadowSlider.Value == 4)
                this.LightShadowMapText.Content = "256";
            else if (this.LightShadowSlider.Value == 5)
                this.LightShadowMapText.Content = "512";
            else if (this.LightShadowSlider.Value == 6)
                this.LightShadowMapText.Content = "1024";
            else if (this.LightShadowSlider.Value == 7)
                this.LightShadowMapText.Content = "2048";
            else
                this.LightShadowMapText.Content = "4096";
        }

        private void RenderSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.RenderSlider.Value == 0)
                this.RenderText.Content = "16";
            else if (this.RenderSlider.Value == 1)
                this.RenderText.Content = "32";//Default
            else if (this.RenderSlider.Value == 2)
                this.RenderText.Content = "64";
            else if (this.RenderSlider.Value == 3)
                this.RenderText.Content = "128";
            else if (this.RenderSlider.Value == 4)
                this.RenderText.Content = "256";
            else if (this.RenderSlider.Value == 5)
                this.RenderText.Content = "512";
            else if (this.RenderSlider.Value == 6)
                this.RenderText.Content = "1024";
            else if (this.RenderSlider.Value == 7)
                this.RenderText.Content = "2048";
            else
                this.RenderText.Content = "4096";
        }

        private void SignageSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.SignageSlider.Value == 0)
                this.SignageText.Content = "16";
            else if (this.SignageSlider.Value == 1)
                this.SignageText.Content = "32";
            else if (this.SignageSlider.Value == 2)
                this.SignageText.Content = "64";//Default
            else if (this.SignageSlider.Value == 3)
                this.SignageText.Content = "128";
            else if (this.SignageSlider.Value == 4)
                this.SignageText.Content = "256";
            else if (this.SignageSlider.Value == 5)
                this.SignageText.Content = "512";
            else if (this.SignageSlider.Value == 6)
                this.SignageText.Content = "1024";
            else if (this.SignageSlider.Value == 7)
                this.SignageText.Content = "2048";
            else
                this.SignageText.Content = "4096";
        }

        private void MissionGraffitiSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.MissionGraffitiSlider.Value == 0)
                this.MissionGraffitiText.Content = "16";
            else if (this.MissionGraffitiSlider.Value == 1)
                this.MissionGraffitiText.Content = "32";
            else if (this.MissionGraffitiSlider.Value == 2)
                this.MissionGraffitiText.Content = "64";//Default
            else if (this.MissionGraffitiSlider.Value == 3)
                this.MissionGraffitiText.Content = "128";
            else if (this.MissionGraffitiSlider.Value == 4)
                this.MissionGraffitiText.Content = "256";
            else if (this.MissionGraffitiSlider.Value == 5)
                this.MissionGraffitiText.Content = "512";
            else if (this.MissionGraffitiSlider.Value == 6)
                this.MissionGraffitiText.Content = "1024";
            else if (this.MissionGraffitiSlider.Value == 7)
                this.MissionGraffitiText.Content = "2048";
            else
                this.MissionGraffitiText.Content = "4096";
        }

        private void PlayerStatueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.PlayerStatueSlider.Value == 0)
                this.PlayerStatueText.Content = "16";//Default
            else if (this.PlayerStatueSlider.Value == 1)
                this.PlayerStatueText.Content = "32";
            else if (this.PlayerStatueSlider.Value == 2)
                this.PlayerStatueText.Content = "64";
            else if (this.PlayerStatueSlider.Value == 3)
                this.PlayerStatueText.Content = "128";
            else if (this.PlayerStatueSlider.Value == 4)
                this.PlayerStatueText.Content = "256";
            else if (this.PlayerStatueSlider.Value == 5)
                this.PlayerStatueText.Content = "512";
            else if (this.PlayerStatueSlider.Value == 6)
                this.PlayerStatueText.Content = "1024";
            else if (this.PlayerStatueSlider.Value == 7)
                this.PlayerStatueText.Content = "2048";
            else
                this.PlayerStatueText.Content = "4096";
        }

        private void SharedCharacterSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.SharedCharacterSlider.Value == 0)
                this.SharedCharacterText.Content = "16";
            else if (this.SharedCharacterSlider.Value == 1)
                this.SharedCharacterText.Content = "32";
            else if (this.SharedCharacterSlider.Value == 2)
                this.SharedCharacterText.Content = "64";//Default
            else if (this.SharedCharacterSlider.Value == 3)
                this.SharedCharacterText.Content = "128";
            else if (this.SharedCharacterSlider.Value == 4)
                this.SharedCharacterText.Content = "256";
            else if (this.SharedCharacterSlider.Value == 5)
                this.SharedCharacterText.Content = "512";
            else if (this.SharedCharacterSlider.Value == 6)
                this.SharedCharacterText.Content = "1024";
            else if (this.SharedCharacterSlider.Value == 7)
                this.SharedCharacterText.Content = "2048";
            else
                this.SharedCharacterText.Content = "4096";
        }

        private void SharedVehicleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.SharedVehicleSlider.Value == 0)
                this.SharedVehicleText.Content = "16";
            else if (this.SharedVehicleSlider.Value == 1)
                this.SharedVehicleText.Content = "32";
            else if (this.SharedVehicleSlider.Value == 2)
                this.SharedVehicleText.Content = "64";//Default
            else if (this.SharedVehicleSlider.Value == 3)
                this.SharedVehicleText.Content = "128";
            else if (this.SharedVehicleSlider.Value == 4)
                this.SharedVehicleText.Content = "256";
            else if (this.SharedVehicleSlider.Value == 5)
                this.SharedVehicleText.Content = "512";
            else if (this.SharedVehicleSlider.Value == 6)
                this.SharedVehicleText.Content = "1024";
            else if (this.SharedVehicleSlider.Value == 7)
                this.SharedVehicleText.Content = "2048";
            else
                this.SharedVehicleText.Content = "4096";
        }

        private void ContactSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.ContactSlider.Value == 0)
                this.ContactText.Content = "16";
            else if (this.ContactSlider.Value == 1)
                this.ContactText.Content = "32";
            else if (this.ContactSlider.Value == 2)
                this.ContactText.Content = "64";
            else if (this.ContactSlider.Value == 3)
                this.ContactText.Content = "128";
            else if (this.ContactSlider.Value == 4)
                this.ContactText.Content = "256";//Default
            else if (this.ContactSlider.Value == 5)
                this.ContactText.Content = "512";
            else if (this.ContactSlider.Value == 6)
                this.ContactText.Content = "1024";
            else if (this.ContactSlider.Value == 7)
                this.ContactText.Content = "2048";
            else
                this.ContactText.Content = "4096";
        }

        private void CharacterDiffNormSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.CharacterDiffNormSlider.Value == 0)
                this.CharacterDiffNormText.Content = "1";
            else if (this.CharacterDiffNormSlider.Value == 1)
                this.CharacterDiffNormText.Content = "4";
            else if (this.CharacterDiffNormSlider.Value == 2)
                this.CharacterDiffNormText.Content = "8";
            else if (this.CharacterDiffNormSlider.Value == 3)
                this.CharacterDiffNormText.Content = "16";
            else if (this.CharacterDiffNormSlider.Value == 4)
                this.CharacterDiffNormText.Content = "32";
            else if (this.CharacterDiffNormSlider.Value == 5)
                this.CharacterDiffNormText.Content = "64";
            else if (this.CharacterDiffNormSlider.Value == 6)
                this.CharacterDiffNormText.Content = "128";
            else if (this.CharacterDiffNormSlider.Value == 7)
                this.CharacterDiffNormText.Content = "256";
            else if (this.CharacterDiffNormSlider.Value == 8)
                this.CharacterDiffNormText.Content = "512";//Default
            else
                this.CharacterDiffNormText.Content = "1024";
        }

        private void PlayerVehicleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.PlayerVehicleSlider.Value == 0)
                this.PlayerVehicleText.Content = "None";
            else if (this.PlayerVehicleSlider.Value == 1)
                this.PlayerVehicleText.Content = "Low Quality";//Default
            else if (this.PlayerVehicleSlider.Value == 2)
                this.PlayerVehicleText.Content = "High Quality";
            else
                this.PlayerVehicleText.Content = "Ultra Quality";
        }
    }
}
