using System;
using Microsoft.VisualBasic.CompilerServices;
using Launcher;
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



namespace CLauncher2._0.Settings
{
    /// <summary>
    /// Interaktionslogik für site_s_settings.xaml
    /// </summary>
    public partial class site_s_settings : Page
    {
        public site_s_settings()
        {
            InitializeComponent();


            this.DynamicDecalsBox.IsChecked = UserSettings.Default.DynamicDecals;
            this.LevelPariclesBox.IsChecked = UserSettings.Default.LevelPariclesS;
            this.DynamicLightsBox.IsChecked = UserSettings.Default.DynamicLightsS;
            this.DepthOfFieldBox.IsChecked = UserSettings.Default.DepthOfFieldS;
            this.CompositeDynamicLightsBox.IsChecked = UserSettings.Default.CompositeDynamicLightsS;
            this.DirectionalLightmapsBox.IsChecked = UserSettings.Default.DirectionalLightmapsS;
            this.MotionBlurBox.IsChecked = UserSettings.Default.MotionBlurS;
            this.DepthOfFieldBox.IsChecked = UserSettings.Default.DepthOfFieldS;
            this.QualityBloomBox.IsChecked = UserSettings.Default.QualityBloomS;
            this.DropParticleDistortionBox.IsChecked = UserSettings.Default.DropParticleDistortionS;
            this.SpeedTreeLeavesBox.IsChecked = UserSettings.Default.SpeedTreeLeavesS;
            this.SpeedTreeFrondsBox.IsChecked = UserSettings.Default.SpeedTreeFrondsS;
            this.OnlyStreamInTexturesBox.IsChecked = UserSettings.Default.OnlyStreamInTexturesS;
            this.LensFlaresBox.IsChecked = UserSettings.Default.LensFlaresS;
            this.FogVolumesBox.IsChecked = UserSettings.Default.FogVolumesS;
            this.FloatingPointRenderBox.IsChecked = UserSettings.Default.FloatingPointRenderS;
            this.OneFrameThreadLagBox.IsChecked = UserSettings.Default.OneFrameThreadLagS;
            this.UpscaleScreenPercBox.IsChecked = UserSettings.Default.UpscaleScreenPercS;
            this.EnableHighPolyBox.IsChecked = UserSettings.Default.EnableHighPolyS;
            this.VSMShadowsBox.IsChecked = UserSettings.Default.VSMShadowsS;
            this.BranchingPCFBox.IsChecked = UserSettings.Default.BranchingPCFS;
            this.BetterModulatedShadowsBox.IsChecked = UserSettings.Default.BetterModulatedShadowsS;
            this.ForegroundShadowsBox.IsChecked = UserSettings.Default.ForegroundShadowsS;
            this.SimplifiedVehicleMaterialsBox.IsChecked = UserSettings.Default.SimplifiedVehicleMaterialsS;
            this.CompressLocalCharacterBox.IsChecked = UserSettings.Default.CompressLocalCharacterS;
            this.CompressLocalVehicleBox.IsChecked = UserSettings.Default.CompressLocalVehicleS;
            this.CompressOtherCharacterBox.IsChecked = UserSettings.Default.CompressOtherCharacterS;
            this.CompressOtherVehicleBox.IsChecked = UserSettings.Default.CompressOtherVehicleS;
            this.CompressNormalBox.IsChecked = UserSettings.Default.CompressNormalS;
        }


        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

            UserSettings.Default.DynamicDecals = (bool)this.DynamicDecalsBox.IsChecked;
            UserSettings.Default.LevelPariclesS = (bool)this.LevelPariclesBox.IsChecked;
            UserSettings.Default.DynamicLightsS = (bool)this.DynamicLightsBox.IsChecked;
            UserSettings.Default.DepthOfFieldS = (bool)this.DepthOfFieldBox.IsChecked;
            UserSettings.Default.CompositeDynamicLightsS = (bool)this.CompositeDynamicLightsBox.IsChecked;
            UserSettings.Default.DirectionalLightmapsS = (bool)this.DirectionalLightmapsBox.IsChecked;
            UserSettings.Default.MotionBlurS = (bool)this.MotionBlurBox.IsChecked;
            UserSettings.Default.DepthOfFieldS = (bool)this.DepthOfFieldBox.IsChecked;
            UserSettings.Default.QualityBloomS = (bool)this.QualityBloomBox.IsChecked;
            UserSettings.Default.DropParticleDistortionS = (bool)this.DropParticleDistortionBox.IsChecked;
            UserSettings.Default.SpeedTreeLeavesS = (bool)this.SpeedTreeLeavesBox.IsChecked;
            UserSettings.Default.SpeedTreeFrondsS = (bool)this.SpeedTreeFrondsBox.IsChecked;
            UserSettings.Default.OnlyStreamInTexturesS = (bool)this.OnlyStreamInTexturesBox.IsChecked;
            UserSettings.Default.LensFlaresS = (bool)this.LensFlaresBox.IsChecked;
            UserSettings.Default.FogVolumesS = (bool)this.FogVolumesBox.IsChecked;
            UserSettings.Default.FloatingPointRenderS = (bool)this.FloatingPointRenderBox.IsChecked;
            UserSettings.Default.OneFrameThreadLagS = (bool)this.OneFrameThreadLagBox.IsChecked;
            UserSettings.Default.UpscaleScreenPercS = (bool)this.UpscaleScreenPercBox.IsChecked;
            UserSettings.Default.EnableHighPolyS = (bool)this.EnableHighPolyBox.IsChecked;
            UserSettings.Default.VSMShadowsS = (bool)this.VSMShadowsBox.IsChecked;
            UserSettings.Default.BranchingPCFS = (bool)this.BranchingPCFBox.IsChecked;
            UserSettings.Default.BetterModulatedShadowsS = (bool)this.BetterModulatedShadowsBox.IsChecked;
            UserSettings.Default.ForegroundShadowsS = (bool)this.ForegroundShadowsBox.IsChecked;
            UserSettings.Default.SimplifiedVehicleMaterialsS = (bool)this.SimplifiedVehicleMaterialsBox.IsChecked;
            UserSettings.Default.CompressLocalCharacterS = (bool)this.CompressLocalCharacterBox.IsChecked;
            UserSettings.Default.CompressLocalVehicleS = (bool)this.CompressLocalVehicleBox.IsChecked;
            UserSettings.Default.CompressOtherCharacterS = (bool)this.CompressOtherCharacterBox.IsChecked;
            UserSettings.Default.CompressOtherVehicleS = (bool)this.CompressOtherVehicleBox.IsChecked;
            UserSettings.Default.CompressNormalS = (bool)this.CompressNormalBox.IsChecked;



            // ============================================= APBCompat Options =============================================
            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "DynamicDecals", Conversions.ToString(this.DynamicDecalsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "LevelParticles", Conversions.ToString(this.LevelPariclesBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "DynamicLight", Conversions.ToString(this.DynamicLightsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "DepthOfField", Conversions.ToString(this.DepthOfFieldBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "CompositeDynamicLights", Conversions.ToString(this.CompositeDynamicLightsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "DirectionalLightmaps", Conversions.ToString(this.DirectionalLightmapsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "MotionBlur", Conversions.ToString(this.MotionBlurBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "DepthOfField", Conversions.ToString(this.DepthOfFieldBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "QualityBloom", Conversions.ToString(this.QualityBloomBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "DropParticleDistortion", Conversions.ToString(this.DropParticleDistortionBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "SpeedTreeLeaves", Conversions.ToString(this.SpeedTreeLeavesBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "SpeedTreeFronds", Conversions.ToString(this.SpeedTreeFrondsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "OnlyStreamInTextures", Conversions.ToString(this.OnlyStreamInTexturesBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "LensFlares", Conversions.ToString(this.LensFlaresBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "FogVolumes", Conversions.ToString(this.FogVolumesBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "FloatingPointRenderTargets", Conversions.ToString(this.FloatingPointRenderBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "OneFrameThreadLag", Conversions.ToString(this.OneFrameThreadLagBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "UpscaleScreenPercentage", Conversions.ToString(this.UpscaleScreenPercBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "EnableHighPolyChars", Conversions.ToString(this.EnableHighPolyBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "bEnableVSMShadows", Conversions.ToString(this.VSMShadowsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "bEnableBranchingPCFShadows", Conversions.ToString(this.BranchingPCFBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "bAllowBetterModulatedShadows", Conversions.ToString(this.BetterModulatedShadowsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "bEnableForegroundShadowsOnWorld", Conversions.ToString(this.ForegroundShadowsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppCompatBucket1", "bUseSimplifiedVehicleMaterials", Conversions.ToString(this.SimplifiedVehicleMaterialsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressDiffuseLocalPlayerCharacterTextures", Conversions.ToString(this.CompressLocalCharacterBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressDiffuseLocalPlayerVehicleTextures", Conversions.ToString(this.CompressLocalVehicleBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressDiffuseOtherPlayerCharacterTextures", Conversions.ToString(this.CompressOtherCharacterBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressDiffuseOtherPlayerVehicleTextures", Conversions.ToString(this.CompressOtherVehicleBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBCompat.ini");
            GameLauncher.SaveToINI("AppHWConstraintsBucket1", "bCompressNormalTextures", Conversions.ToString(this.CompressNormalBox.IsChecked));

            UserSettings.Default.Save();



        }
    }
}
