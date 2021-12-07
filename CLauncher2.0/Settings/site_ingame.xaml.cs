using System;
using Launcher;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic.CompilerServices;

namespace CLauncher2._0.Settings
{
    /// <summary>
    /// Interaktionslogik für site_ingame.xaml
    /// </summary>
    public partial class site_ingame : Page
    {


        public site_ingame()
        {
            InitializeComponent();


            // ========================================== Loading User-Settings ==========================================
            this.VsyncBox.IsChecked = UserSettings.Default.UseVsyncS;
            this.ResBox.SelectedIndex = UserSettings.Default.ResSelectedIndexS;
            this.DisplayBox.SelectedIndex = UserSettings.Default.DisplaySelectedIndexS;
            this.AnisBox.SelectedIndex = UserSettings.Default.AnisSelectedIndexS;
            this.SmoothFrameRateBox.IsChecked = UserSettings.Default.SmoothFrameS;
            this.StaticDecalsBox.IsChecked = UserSettings.Default.StaticDecalsS;
            this.DynamicShBox.IsChecked = UserSettings.Default.DynamicShS;
            this.LightEnviroBox.IsChecked = UserSettings.Default.LightEnviroS;
            this.BlobBox.IsChecked = UserSettings.Default.BlobS;
            this.AmbientBox.IsChecked = UserSettings.Default.AmbientS;
            this.BloomBox.IsChecked = UserSettings.Default.BloomS;
            this.DistortionBox.IsChecked = UserSettings.Default.DistortionS;
            this.TrilinearBox.IsChecked = UserSettings.Default.TrilinearS;
            this.hudBox.IsChecked = UserSettings.Default.hudS;
            this.RenderBox.IsChecked = UserSettings.Default.RenderS;

        }


        // ----------------------------------------------------- IN-GameOptions ----------------------------------------------------
        // ------------------------------------------------- Descriptions / Preview ------------------------------------------------

        private void VSync_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Resources/missing1.png", UriKind.Relative));//!!!!!!!
            Preview_Text.Text = "limits the GPU output to the refresh rate of the monitor, preventing the GPU from doing anything to the display memory until the monitor has concluded it's current refresh cycle.";
        }

        private void VSync_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void SmoothFrameRate_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Resources/missing1.png", UriKind.Relative));//!!!!!!!
            Preview_Text.Text = "Uses the SmoothFramerate cap of 62 by default(can be increased in files) and is essentially only a purpose for a in-game framerate limiter.";
        }

        private void SmoothFrameRate_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void StaticDecals_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview/StaticDecals.png", UriKind.Relative));
            Preview_Text.Text = "Pretty random but decals on the walls like sprays, graffiti on some signs.";
        }

        private void StaticDecals_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void DynamicShadows_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Resources/missing1.png", UriKind.Relative));//!!!!!!!
            Preview_Text.Text = "Shadows underneath your and other player characters/cars.";
        }

        private void DynamicShadows_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void LightEnvironmentShadows_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Resources/missing1.png", UriKind.Relative));//!!!!!!!
            Preview_Text.Text = "?";
        }

        private void LightEnvironmentShadows_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void BlobShadows_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Resources/missing1.png", UriKind.Relative)); //!!!!!!!
            Preview_Text.Text = "Supposed to be fake shadows but this setting seem to be incorporated with Dynamic Shadows already as it requires it as well. Appears to be a different setting in the files but doesn't do much ingame. {always on unless changed in file}";
        }

        private void BlobShadows_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void AmbientOcclusion_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview/AmbientOcclusion.png", UriKind.Relative));
            Preview_Text.Text = "AO is a technique where it adds shadow to little surfaces like railing or steps, on and around objects (like car wheels)";
        }

        private void AmbientOcclusion_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void Bloom_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview/Bloom.png", UriKind.Relative));
            Preview_Text.Text = "This setting will add a lot of brightness to the scene, as well as adding blur to objects and depth of field.";
        }

        private void Bloom_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void Distortion_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Resources/missing1.png", UriKind.Relative));//!!!!!!!
            Preview_Text.Text = "This effect is the same as bloom but for around explosive's (like a heatwave)";
        }

        private void Distortion_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void Trillinear_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Resources/missing1.png", UriKind.Relative));//!!!!!!!
            Preview_Text.Text = "This technique is to smooth out the texture over distance. Off is bilinear. Smooths the 2D ground textures over distance.";
        }

        private void Trillinear_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void LowQualityHealthHUD_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview/LowQualityHealthHUD.png", UriKind.Relative));
            Preview_Text.Text = "Turning this on will render blood spats, a vignette darkening effect around the entire scene making it appear more real. Off is high quality HUD. also becomes more harder to tell if you're full HP or not. (vignette is completely gone with full hp)";
        }

        private void LowQualityHealthHUD_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void RenderEye_Lashes_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Resources/missing1.png", UriKind.Relative));//!!!!!!!
            Preview_Text.Text = "Does as it says, renders the eye-lashs on your character.";
        }

        private void RenderEye_Lashes_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void Anisotropy_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Resources/missing1.png", UriKind.Relative));//!!!!!!!
            Preview_Text.Text = "Same as Trilinear, intend to smooth out the textures over distance but does the 3D space as well. where as trilinear/bilinear mostly smooths the ground textures. (2D)";
        }

        private void Anisotropy_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Preview.Source = new BitmapImage(new Uri("/Settings/Preview_Placeholder.png", UriKind.Relative));
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        // ================================================= SAVE BUTTON =================================================
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // ========================================== Saving User-Settings ==========================================
            UserSettings.Default.UseVsyncS = (bool)this.VsyncBox.IsChecked;
            UserSettings.Default.ResSelectedIndexS = this.ResBox.SelectedIndex;
            UserSettings.Default.DisplaySelectedIndexS = this.DisplayBox.SelectedIndex;
            UserSettings.Default.AnisSelectedIndexS = this.AnisBox.SelectedIndex;
            UserSettings.Default.SmoothFrameS = (bool)this.SmoothFrameRateBox.IsChecked;
            UserSettings.Default.StaticDecalsS = (bool)this.StaticDecalsBox.IsChecked;
            UserSettings.Default.DynamicShS = (bool)this.DynamicShBox.IsChecked;
            UserSettings.Default.LightEnviroS = (bool)this.LightEnviroBox.IsChecked;
            UserSettings.Default.BlobS = (bool)this.BlobBox.IsChecked;
            UserSettings.Default.AmbientS = (bool)this.AmbientBox.IsChecked;
            UserSettings.Default.BloomS = (bool)this.BloomBox.IsChecked;
            UserSettings.Default.DistortionS = (bool)this.DistortionBox.IsChecked;
            UserSettings.Default.TrilinearS = (bool)this.TrilinearBox.IsChecked;
            UserSettings.Default.hudS = (bool)this.hudBox.IsChecked;
            UserSettings.Default.RenderS = (bool)this.RenderBox.IsChecked;


            UserSettings.Default.Save();

            

            // ============================================= IN-GameOptions =============================================
            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "VideoQuality", "1");
            if (this.ResBox.SelectedIndex == 0)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1024");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "768");
            }
            else if (this.ResBox.SelectedIndex == 1)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "720");
            }
            else if (this.ResBox.SelectedIndex == 2)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "768");
            }
            else if (this.ResBox.SelectedIndex == 3)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "800");
            }
            else if (this.ResBox.SelectedIndex == 4)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "960");
            }
            else if (this.ResBox.SelectedIndex == 5)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1280");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1024");
            }
            else if (this.ResBox.SelectedIndex == 6)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1360");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "768");
            }
            else if (this.ResBox.SelectedIndex == 7)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1360");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1024");
            }
            else if (this.ResBox.SelectedIndex == 8)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1366");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "768");
            }
            else if (this.ResBox.SelectedIndex == 9)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1400");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1050");
            }
            else if (this.ResBox.SelectedIndex == 10)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1440");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "900");
            }
            else if (this.ResBox.SelectedIndex == 11)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1600");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "900");
            }
            else if (this.ResBox.SelectedIndex == 12)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1600");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1200");
            }
            else if (this.ResBox.SelectedIndex == 13)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1680");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1050");
            }
            else if (this.ResBox.SelectedIndex == 14)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1776");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1000");
            }
            else if (this.ResBox.SelectedIndex == 15)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1920");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1080");
            }
            else if (this.ResBox.SelectedIndex == 16)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1920");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1200");
            }
            else if (this.ResBox.SelectedIndex == 17)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "1920");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1280");
            }
            else if (this.ResBox.SelectedIndex == 18)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "2560");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1440");
            }
            else if (this.ResBox.SelectedIndex == 19)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "2560");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1600");
            }
            else if (this.ResBox.SelectedIndex == 20)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "5760");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1080");
            }
            else if (this.ResBox.SelectedIndex == 21)
            {
                GameLauncher.SaveToINI("SystemSettings", "Resx", "5884");
                GameLauncher.SaveToINI("SystemSettings", "Resy", "1080");
            }

            if (this.DisplayBox.SelectedIndex == 0)
                GameLauncher.SaveToINI("SystemSettings", "Fullscreen", "0");
            else if (this.DisplayBox.SelectedIndex == 1)
                GameLauncher.SaveToINI("SystemSettings", "Fullscreen", "1");
            else if (this.DisplayBox.SelectedIndex == 2)
                GameLauncher.SaveToINI("SystemSettings", "Fullscreen", "2");


            if (this.AnisBox.SelectedIndex == 0)
                GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "0");
            else if (this.AnisBox.SelectedIndex == 1)
                GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "4");
            else if (this.AnisBox.SelectedIndex == 2)
                GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "4");
            else if (this.AnisBox.SelectedIndex == 3)
                GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "8");
            else if (this.AnisBox.SelectedIndex == 4)
                GameLauncher.SaveToINI("SystemSettings", "AnisotropyAmount", "16");


            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "UseVsync", Conversions.ToString(this.VsyncBox.IsChecked));
            GameLauncher.ReadFromINI("SystemSettings", "UseVsync", Conversions.ToString(this.VsyncBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "SmoothFrameRate", Conversions.ToString(this.SmoothFrameRateBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "bAllowStaticDecals", Conversions.ToString(this.StaticDecalsBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "DynamicShadows", Conversions.ToString(this.DynamicShBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "LightEnvironmentShadows", Conversions.ToString(this.LightEnviroBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "bAllowBlobShadows", Conversions.ToString(this.BlobBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "AmbientOcclusion", Conversions.ToString(this.AmbientBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "Bloom", Conversions.ToString(this.BloomBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "Distortion", Conversions.ToString(this.DistortionBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "bTrilinearFiltering", Conversions.ToString(this.TrilinearBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "bLowQualityHealthHUD", Conversions.ToString(this.hudBox.IsChecked));

            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");
            GameLauncher.SaveToINI("SystemSettings", "m_bGameRenderEyelashes", Conversions.ToString(this.RenderBox.IsChecked));


        }
    }





}
