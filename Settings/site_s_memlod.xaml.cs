using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Launcher;
using Microsoft.DotNet.Cli.Utils.CommandParsing;

namespace CLauncher2._0.Settings
{
    /// <summary>
    /// Interaktionslogik für site_s_memlod.xaml
    /// </summary>
    public partial class site_s_memlod : Page
    {
        public site_s_memlod()
        {
            InitializeComponent();


            // Load Settings
            this.ParticleLODBiasSelector.Value = UserSettings.Default.ParticleLODBias_Value;
            this.ParticleSpaceAreaLabel.Content = UserSettings.Default.ParticleLODBias_Text;

            this.ShadowQualityBiasSelector.Value = UserSettings.Default.ShadowQualityBias_Value;
            this.ShadowQualityBiasLabel.Content = UserSettings.Default.ShadowQualityBias_Text;

            this.SunRenderQualitySelector.Value = UserSettings.Default.SunRenderQuality_Value;
            this.SunRenderQualityLabel.Content = UserSettings.Default.SunRenderQuality_Text;

            this.ParticleSpaceAreaSelector.Value = UserSettings.Default.ParticleSpaceArea_Value;
            this.ParticleSpaceAreaLabel.Content = UserSettings.Default.ParticleSpaceArea_Text;

            this.FoliageDrawRadiusSelector.Value = UserSettings.Default.FoliageDrawRadius_Value;
            this.FoliageDrawRadiusLabel.Content = UserSettings.Default.FoliageDrawRadius_Text;

            this.ShadowFilterRadiusSelector.Value = UserSettings.Default.ShadowFilterRadius_Value;
            this.ShadowFilterRadiusLabel.Content = UserSettings.Default.ShadowFilterRadius_Text;

            this.ShadowDepthBiasSelector.Value = UserSettings.Default.ShadowDepthBias_Value;
            this.ShadowDepthBiasLabel.Content = UserSettings.Default.ShadowDepthBias_Text;

            this.MaxMemoryCacheEntrySelector.Value = UserSettings.Default.MaxMemoryCacheEntry_Value;
            this.MaxMemoryCacheEntryLabel.Content = UserSettings.Default.MaxMemoryCacheEntry_Text;

            this.TextureStreamingMemorySelector.Value = UserSettings.Default.TextureStreamingMemory_Value;
            this.TextureStreamingMemoryLabel.Content = UserSettings.Default.TextureStreamingMemory_Text;

            this.TexturePoolMemorySelector.Value = UserSettings.Default.TexturePoolMemory_Value;
            this.TexturePoolMemoryLabel.Content = UserSettings.Default.TexturePoolMemory_Text;

            this.MeshStreamingMemorySelector.Value = UserSettings.Default.MeshStreamingMemory_Value;
            this.MeshStreamingMemoryLabel.Content = UserSettings.Default.MeshStreamingMemory_Text;

            this.SkeletalMeshLODSelector.Value = UserSettings.Default.SkeletalMeshLOD_Value;
            this.SkeletalMeshLODLabel.Content = UserSettings.Default.SkeletalMeshLOD_Text;

            //---------------------------------------------------------------------------------------------------

            this.TextureCreationPerFrameBox.Text = UserSettings.Default.TextureCreationPerFrame_Value;
            this.DynamicShadowsBox.Text = UserSettings.Default.MaxDynamicShadows_Value;
            this.ShadowFadeDistanceBox.Text = UserSettings.Default.ShadowFade_Value;
            this.CharacterLODDistance1Box.Text = UserSettings.Default.PlayerLOD1_Value;
            this.CharacterLODDistance2Box.Text = UserSettings.Default.PlayerLOD2_Value;
            this.VehicleLODDistanceBox.Text = UserSettings.Default.VehicleLOD_Value;
            this.VehicleCullDistanceBox.Text = UserSettings.Default.VehicleCull_Value;
            this.PedestrianLODDistanceBox.Text = UserSettings.Default.LCPedestrianLOD_Value;
            this.PedestrianCullDistanceBox.Text = UserSettings.Default.LCPedestrianCull_Value;
            this.DriverLODDistanceBox.Text = UserSettings.Default.LCDriverLOD_Value;
            this.DriverCullDistanceBox.Text = UserSettings.Default.LCDriverCull_Value;
            this.LCVehicleLODDistanceBox.Text = UserSettings.Default.LCVehicleLOD_Value;
            this.LCVehicleCullDistanceBox.Text = UserSettings.Default.LCVehicleCull_Value;


        }

        private void ParticleLODBiasSelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.ParticleLODBiasSelector.Value == 0)
                this.ParticleLODBiasLabel.Content = "Low";
            else
                this.ParticleLODBiasLabel.Content = "High";
        }

        private void ShadowQualityBiasSelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.ShadowQualityBiasSelector.Value == 0)
                this.ShadowQualityBiasLabel.Content = "Low";
            else
                this.ShadowQualityBiasLabel.Content = "High";
        }

        private void SunRenderQualitySelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.SunRenderQualitySelector.Value == 0)
                this.SunRenderQualityLabel.Content = "Low";
            else if (this.SunRenderQualitySelector.Value == 1)
                this.SunRenderQualityLabel.Content = "Medium";
            else
                this.SunRenderQualityLabel.Content = "High";
        }

        private void ParticleSpaceAreaSelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.ParticleSpaceAreaSelector.Value == 0)
                this.ParticleSpaceAreaLabel.Content = "None";
            else if (this.ParticleSpaceAreaSelector.Value == 1)
                this.ParticleSpaceAreaLabel.Content = "5";
            else if (this.ParticleSpaceAreaSelector.Value == 2)
                this.ParticleSpaceAreaLabel.Content = "50";
            else if (this.ParticleSpaceAreaSelector.Value == 3)
                this.ParticleSpaceAreaLabel.Content = "500";
            else if (this.ParticleSpaceAreaSelector.Value == 4)
                this.ParticleSpaceAreaLabel.Content = "1250";
            else if (this.ParticleSpaceAreaSelector.Value == 5)
                this.ParticleSpaceAreaLabel.Content = "2500";
            else if (this.ParticleSpaceAreaSelector.Value == 6)
                this.ParticleSpaceAreaLabel.Content = "5000";
            else if (this.ParticleSpaceAreaSelector.Value == 7)
                this.ParticleSpaceAreaLabel.Content = "7812.5";
            else if (this.ParticleSpaceAreaSelector.Value == 8)
                this.ParticleSpaceAreaLabel.Content = "12500";
            else if (this.ParticleSpaceAreaSelector.Value == 9)
                this.ParticleSpaceAreaLabel.Content = "25000 (Default)";
            else if (this.ParticleSpaceAreaSelector.Value == 10)
                this.ParticleSpaceAreaLabel.Content = "50000";
            else if (this.ParticleSpaceAreaSelector.Value == 11)
                this.ParticleSpaceAreaLabel.Content = "125000";
            else if (this.ParticleSpaceAreaSelector.Value == 12)
                this.ParticleSpaceAreaLabel.Content = "250000";
            else if (this.ParticleSpaceAreaSelector.Value == 13)
                this.ParticleSpaceAreaLabel.Content = "500000";
            else
                this.ParticleSpaceAreaLabel.Content = "Infinite";
        }

        private void FoliageDrawRadiusSelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.FoliageDrawRadiusSelector.Value == 0)
                this.FoliageDrawRadiusLabel.Content = "Low";
            else
                this.FoliageDrawRadiusLabel.Content = "High";
        }

        private void ShadowFilterRadiusSelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.ShadowFilterRadiusSelector.Value == 0)
                this.ShadowFilterRadiusLabel.Content = "Low";
            else if (this.ShadowFilterRadiusSelector.Value == 1)
                this.ShadowFilterRadiusLabel.Content = "High";
            else
                this.ShadowFilterRadiusLabel.Content = "Ultra";
        }

        private void ShadowDepthBiasSelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.ShadowDepthBiasSelector.Value == 0)
                this.ShadowDepthBiasLabel.Content = "Low";
            else if (this.ShadowDepthBiasSelector.Value == 1)
                this.ShadowDepthBiasLabel.Content = "Medium";
            else if (this.ShadowDepthBiasSelector.Value == 2)
                this.ShadowDepthBiasLabel.Content = "High";
            else
                this.ShadowDepthBiasLabel.Content = "Ultra";
        }

        private void MaxMemoryCacheEntrySelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.MaxMemoryCacheEntrySelector.Value == 0)
                this.MaxMemoryCacheEntryLabel.Content = "Low";
            else if (this.MaxMemoryCacheEntrySelector.Value == 1)
                this.MaxMemoryCacheEntryLabel.Content = "Medium";
            else
                this.MaxMemoryCacheEntryLabel.Content = "High";
        }

        private void TextureStreamingMemorySelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.TextureStreamingMemorySelector.Value == 0)
                this.TextureStreamingMemoryLabel.Content = "Minimal";
            else if (this.TextureStreamingMemorySelector.Value == 1)
                this.TextureStreamingMemoryLabel.Content = "Low";
            else if (this.TextureStreamingMemorySelector.Value == 2)
                this.TextureStreamingMemoryLabel.Content = "Medium";
            else if (this.TextureStreamingMemorySelector.Value == 3)
                this.TextureStreamingMemoryLabel.Content = "High";
            else if (this.TextureStreamingMemorySelector.Value == 4)
                this.TextureStreamingMemoryLabel.Content = "Maximum";
            else
                this.TextureStreamingMemoryLabel.Content = "Ultra";
        }

        private void TexturePoolMemorySelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.TexturePoolMemorySelector.Value == 0)
                this.TexturePoolMemoryLabel.Content = "Low";
            else if (this.TexturePoolMemorySelector.Value == 1)
                this.TexturePoolMemoryLabel.Content = "High";
            else
                this.TexturePoolMemoryLabel.Content = "Ultra";
        }

        private void MeshStreamingMemorySelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.MeshStreamingMemorySelector.Value == 0)
                this.MeshStreamingMemoryLabel.Content = "Minimal";
            else if (this.MeshStreamingMemorySelector.Value == 1)
                this.MeshStreamingMemoryLabel.Content = "Low";
            else if (this.MeshStreamingMemorySelector.Value == 2)
                this.MeshStreamingMemoryLabel.Content = "Medium";
            else if (this.MeshStreamingMemorySelector.Value == 3)
                this.MeshStreamingMemoryLabel.Content = "High";
            else if (this.MeshStreamingMemorySelector.Value == 4)
                this.MeshStreamingMemoryLabel.Content = "Maximum";
            else
                this.MeshStreamingMemoryLabel.Content = "Ultra";
        }

        private void SkeletalMeshLODSelector_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.SkeletalMeshLODSelector.Value == 0)
                this.SkeletalMeshLODLabel.Content = "Minimal";
            else if (this.SkeletalMeshLODSelector.Value == 1)
                this.SkeletalMeshLODLabel.Content = "Low";
            else if (this.SkeletalMeshLODSelector.Value == 2)
                this.SkeletalMeshLODLabel.Content = "Medium";
            else if (this.SkeletalMeshLODSelector.Value == 3)
                this.SkeletalMeshLODLabel.Content = "High";
            else 
                this.SkeletalMeshLODLabel.Content = "Maximum";
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            GameLauncher.GetINI(Environment.CurrentDirectory + "\\APBGame\\Config\\APBMachineOptions.ini");

            //ParticleLODBias
            if (this.ParticleLODBiasSelector.Value == 0)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleLODBias", "1");
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleLODBias", "0");

            //ShadowQualityBias
            if (this.ShadowQualityBiasSelector.Value == 0)
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterQualityBias", "0");
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterQualityBias", "1");

            //SunRenderQuality
            if (this.SunRenderQualitySelector.Value == 0)
                GameLauncher.SaveToINI("AppCompatBucket1", "SunRenderQuality", "0");
            else if (this.SunRenderQualitySelector.Value == 1)
                GameLauncher.SaveToINI("AppCompatBucket1", "SunRenderQuality", "1");
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "SunRenderQuality", "2");

            //ParticleSpaceArea
            if (this.ParticleSpaceAreaSelector.Value == 0)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "0.1");
            else if (this.ParticleSpaceAreaSelector.Value == 1)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "5.0");
            else if (this.ParticleSpaceAreaSelector.Value == 2)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "50.0");
            else if (this.ParticleSpaceAreaSelector.Value == 3)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "500.0");
            else if (this.ParticleSpaceAreaSelector.Value == 4)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "1250.0");
            else if (this.ParticleSpaceAreaSelector.Value == 5)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "2500.0");
            else if (this.ParticleSpaceAreaSelector.Value == 6)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "5000.0");
            else if (this.ParticleSpaceAreaSelector.Value == 7)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "7812.5");
            else if (this.ParticleSpaceAreaSelector.Value == 8)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "12500.0");
            else if (this.ParticleSpaceAreaSelector.Value == 9)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "25000.0");
            else if (this.ParticleSpaceAreaSelector.Value == 10)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "50000.0");
            else if (this.ParticleSpaceAreaSelector.Value == 11)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "125000.0");
            else if (this.ParticleSpaceAreaSelector.Value == 12)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "250000.0");
            else if (this.ParticleSpaceAreaSelector.Value == 13)
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "500000.0");
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "ParticleMaxWorldSpaceArea", "0.0");

            //FoliageDrawRadius
            if (this.FoliageDrawRadiusSelector.Value == 0)
                GameLauncher.SaveToINI("AppCompatBucket1", "FoliageDrawRadiusMultiplier", "0.000000");
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "FoliageDrawRadiusMultiplier", "1.000000");

            //ShadowFilterRadius
            if (this.ShadowFilterRadiusSelector.Value == 0)
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterRadius", "1");
            else if (this.ShadowFilterRadiusSelector.Value == 1)
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterRadius", "2");
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFilterRadius", "3");

            //ShadowDepthBias
            if (this.ShadowDepthBiasSelector.Value == 0)
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowDepthBias", ".008");
            else if (this.ShadowDepthBiasSelector.Value == 1)
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowDepthBias", ".01");
            else if (this.ShadowDepthBiasSelector.Value == 2)
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowDepthBias", ".012");
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowDepthBias", ".015");

            //SkeletalMeshLOD
            if (this.SkeletalMeshLODSelector.Value == 0)
                GameLauncher.SaveToINI("AppCompatBucket1", "SkeletalMeshLODBias", "4");
            else if (this.SkeletalMeshLODSelector.Value == 1)
                GameLauncher.SaveToINI("AppCompatBucket1", "SkeletalMeshLODBias", "3");
            else if (this.SkeletalMeshLODSelector.Value == 2)
                GameLauncher.SaveToINI("AppCompatBucket1", "SkeletalMeshLODBias", "2");
            else if (this.SkeletalMeshLODSelector.Value == 3)
                GameLauncher.SaveToINI("AppCompatBucket1", "SkeletalMeshLODBias", "1");
            else GameLauncher.SaveToINI("AppCompatBucket1", "SkeletalMeshLODBias", "0");

            //MaxMemoryCacheEntry
            if (this.MaxMemoryCacheEntrySelector.Value == 0)
            {
                GameLauncher.SaveToINI("AppCompatBucket1", "nMaxMemoryCacheEntryCount", "100");
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nMaxMemoryCacheEntryCount", "100");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nMaxMemoryCacheEntryCount", "100");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "nMaxMemoryCacheEntryCount", "100");
            }
            else if (this.MaxMemoryCacheEntrySelector.Value == 1)
            {
                GameLauncher.SaveToINI("AppCompatBucket1", "nMaxMemoryCacheEntryCount", "120");
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nMaxMemoryCacheEntryCount", "120");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nMaxMemoryCacheEntryCount", "120");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "nMaxMemoryCacheEntryCount", "120");
            }
            else
            {
                GameLauncher.SaveToINI("AppCompatBucket1", "nMaxMemoryCacheEntryCount", "250");
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "nMaxMemoryCacheEntryCount", "250");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "nMaxMemoryCacheEntryCount", "250");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "nMaxMemoryCacheEntryCount", "250");
            }

            //TextureStreamingMemory
            if (this.TextureStreamingMemorySelector.Value == 0)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "52428800");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "52428800");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "52428800");
            }
            else if (this.TextureStreamingMemorySelector.Value == 1)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "104857600");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "104857600");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "104857600");
            }
            else if (this.TextureStreamingMemorySelector.Value == 2)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "125829120");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "125829120");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "125829120");
            }
            else if (this.TextureStreamingMemorySelector.Value == 3)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "157286400");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "157286400");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "157286400");
            }
            else if (this.TextureStreamingMemorySelector.Value == 4)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "314572800");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "314572800");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "314572800");
            }
            else
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTextureStreaming", "524288000");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTextureStreaming", "524288000");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTextureStreaming", "524288000");
            }

            //TexturePoolMemory
            if (this.TexturePoolMemorySelector.Value == 0)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTexturePool", "100000000");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTexturePool", "100000000");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTexturePool", "100000000");
            }
            else if (this.TexturePoolMemorySelector.Value == 1)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTexturePool", "150000000");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTexturePool", "150000000");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTexturePool", "150000000");
            }
            else
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByTexturePool", "200000000");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByTexturePool", "200000000");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByTexturePool", "200000000");
            }

            //MeshStreamingMemory
            if (this.MeshStreamingMemorySelector.Value == 0)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "26214400");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "26214400");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "26214400");
            }
            else if (this.MeshStreamingMemorySelector.Value == 1)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "31457280");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "31457280");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "31457280");
            }
            else if (this.MeshStreamingMemorySelector.Value == 2)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "57671680");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "57671680");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "57671680");
            }
            else if (this.MeshStreamingMemorySelector.Value == 3)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "89128960");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "89128960");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "89128960");
            }
            else if (this.MeshStreamingMemorySelector.Value == 4)
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "104857600");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "104857600");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "104857600");
            }
            else
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "MaxMemoryUsedByMeshStreaming", "157286400");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "MaxMemoryUsedByMeshStreaming", "157286400");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "MaxMemoryUsedByMeshStreaming", "157286400");
            }



            
            double TextureCreation = Convert.ToDouble(this.TextureCreationPerFrameBox.Text);


            if (!Versioned.IsNumeric((object)this.TextureCreationPerFrameBox.Text))
            {
                this.TextureCreationPerFrameBox.Text = Convert.ToString(10);
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "NumberOfTextureCreationPerFrame", "10");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "NumberOfTextureCreationPerFrame", "10");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "NumberOfTextureCreationPerFrame", "10");
            }
            else if (Convert.ToDouble(this.TextureCreationPerFrameBox.Text) <= 1.0)
            {
                this.TextureCreationPerFrameBox.Text = Convert.ToString(2);
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "NumberOfTextureCreationPerFrame", "2");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "NumberOfTextureCreationPerFrame", "2");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "NumberOfTextureCreationPerFrame", "2");
            }
            else if (Convert.ToDouble(this.TextureCreationPerFrameBox.Text) >= 11.0)
            {
                this.TextureCreationPerFrameBox.Text = Convert.ToString(10);
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "NumberOfTextureCreationPerFrame", "10");
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "NumberOfTextureCreationPerFrame", "10");
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "NumberOfTextureCreationPerFrame", "10");
            }
            else
            {
                GameLauncher.SaveToINI("AppHWConstraintsBucket1", "NumberOfTextureCreationPerFrame", this.TextureCreationPerFrameBox.Text);
                GameLauncher.SaveToINI("AppHWConstraintsBucket2", "NumberOfTextureCreationPerFrame", this.TextureCreationPerFrameBox.Text);
                GameLauncher.SaveToINI("AppHWConstraintsBucket3", "NumberOfTextureCreationPerFrame", this.TextureCreationPerFrameBox.Text);
            }

            GameLauncher.SaveToINI("AppCompatBucket1", "ShadowDepthBias", ".015");
            if (!Versioned.IsNumeric((object)this.DynamicShadowsBox.Text))
            {
                this.DynamicShadowsBox.Text = Convert.ToString(10);
                GameLauncher.SaveToINI("AppCompatBucket1", "MaxDynamicShadows", "10");
            }
            else if (Convert.ToDouble(this.DynamicShadowsBox.Text) >= 35.0)
            {
                this.DynamicShadowsBox.Text = Convert.ToString(35);
                GameLauncher.SaveToINI("AppCompatBucket1", "MaxDynamicShadows", "35");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "MaxDynamicShadows", this.DynamicShadowsBox.Text);
            if (!Versioned.IsNumeric((object)this.ShadowFadeDistanceBox.Text))
            {
                this.ShadowFadeDistanceBox.Text = Convert.ToString(65);
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFadeEndDistance", "6500");
            }
            else if (Convert.ToDouble(this.ShadowFadeDistanceBox.Text) <= 24.0)
            {
                this.ShadowFadeDistanceBox.Text = Convert.ToString(25);
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFadeEndDistance", "2500");
            }
            else if (Convert.ToDouble(this.ShadowFadeDistanceBox.Text) >= 101.0)
            {
                this.ShadowFadeDistanceBox.Text = Convert.ToString(100);
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFadeEndDistance", "10000");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "ShadowFadeEndDistance", Convert.ToString(Convert.ToInt64(this.ShadowFadeDistanceBox.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.CharacterLODDistance1Box.Text))
            {
                this.CharacterLODDistance1Box.Text = Convert.ToString(5);
                GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance1", "500");
            }
            else if (Convert.ToDouble(this.CharacterLODDistance1Box.Text) <= 0.0)
            {
                this.CharacterLODDistance1Box.Text = Convert.ToString(1);
                GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance1", "100");
            }
            else if (Convert.ToDouble(this.CharacterLODDistance1Box.Text) >= 100.0)
            {
                this.CharacterLODDistance1Box.Text = Convert.ToString(99);
                GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance1", "9900");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance1", Convert.ToString(Convert.ToInt64(this.CharacterLODDistance1Box.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.CharacterLODDistance2Box.Text))
            {
                this.CharacterLODDistance2Box.Text = Convert.ToString(15);
                GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance2", "1500");
            }
            else if (Convert.ToDouble(this.CharacterLODDistance2Box.Text) <= 1.0)
            {
                this.CharacterLODDistance2Box.Text = Convert.ToString(2);
                GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance2", "200");
            }
            else if (Convert.ToDouble(this.CharacterLODDistance2Box.Text) >= 101.0)
            {
                this.CharacterLODDistance2Box.Text = Convert.ToString(100);
                GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance2", "10000");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "fCharacterLODDistance2", Convert.ToString(Convert.ToInt64(this.CharacterLODDistance2Box.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.VehicleLODDistanceBox.Text))
            {
                this.VehicleLODDistanceBox.Text = Convert.ToString(25);
                GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleLODDistance", "2500");
            }
            else if (Convert.ToDouble(this.VehicleLODDistanceBox.Text) <= 0.0)
            {
                this.VehicleLODDistanceBox.Text = Convert.ToString(1);
                GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleLODDistance", "100");
            }
            else if (Convert.ToDouble(this.VehicleLODDistanceBox.Text) >= 100.0)
            {
                this.VehicleLODDistanceBox.Text = Convert.ToString(99);
                GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleLODDistance", "9900");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleLODDistance", Convert.ToString(Convert.ToInt64(this.VehicleLODDistanceBox.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.VehicleCullDistanceBox.Text))
            {
                this.VehicleCullDistanceBox.Text = Convert.ToString(100);
                GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleCullDistance", "10000");
            }
            else if (Convert.ToDouble(this.VehicleCullDistanceBox.Text) <= 1.0)
            {
                this.VehicleCullDistanceBox.Text = Convert.ToString(2);
                GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleCullDistance", "200");
            }
            else if (Convert.ToDouble(this.VehicleCullDistanceBox.Text) >= 101.0)
            {
                this.VehicleCullDistanceBox.Text = Convert.ToString(100);
                GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleCullDistance", "10000");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "fVehicleCullDistance", Convert.ToString(Convert.ToInt64(this.VehicleCullDistanceBox.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.PedestrianLODDistanceBox.Text))
            {
                this.PedestrianLODDistanceBox.Text = Convert.ToString(3);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianLODDistance", "300");
            }
            else if (Convert.ToDouble(this.PedestrianLODDistanceBox.Text) <= 0.0)
            {
                this.PedestrianLODDistanceBox.Text = Convert.ToString(1);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianLODDistance", "100");
            }
            else if (Convert.ToDouble(this.PedestrianLODDistanceBox.Text) >= 100.0)
            {
                this.PedestrianLODDistanceBox.Text = Convert.ToString(99);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianLODDistance", "9900");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianLODDistance", Convert.ToString(Convert.ToInt64(this.PedestrianLODDistanceBox.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.PedestrianCullDistanceBox.Text))
            {
                this.PedestrianCullDistanceBox.Text = Convert.ToString(50);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianCullDistance", "5000");
            }
            else if (Convert.ToDouble(this.PedestrianCullDistanceBox.Text) <= 1.0)
            {
                this.PedestrianCullDistanceBox.Text = Convert.ToString(2);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianCullDistance", "200");
            }
            else if (Convert.ToDouble(this.PedestrianCullDistanceBox.Text) >= 101.0)
            {
                this.PedestrianCullDistanceBox.Text = Convert.ToString(100);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianCullDistance", "10000");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCPedestrianCullDistance", Convert.ToString(Convert.ToInt64(this.PedestrianCullDistanceBox.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.DriverLODDistanceBox.Text))
            {
                this.DriverLODDistanceBox.Text = Convert.ToString(3);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverLODDistance", "300");
            }
            else if (Convert.ToDouble(this.DriverLODDistanceBox.Text) <= 0.0)
            {
                this.DriverLODDistanceBox.Text = Convert.ToString(1);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverLODDistance", "100");
            }
            else if (Convert.ToDouble(this.DriverLODDistanceBox.Text) >= 100.0)
            {
                this.DriverLODDistanceBox.Text = Convert.ToString(99);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverLODDistance", "9900");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverLODDistance", Convert.ToString(Convert.ToInt64(this.DriverLODDistanceBox.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.DriverCullDistanceBox.Text))
            {
                this.DriverCullDistanceBox.Text = Convert.ToString(70);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverCullDistance", "7000");
            }
            else if (Convert.ToDouble(this.DriverCullDistanceBox.Text) <= 1.0)
            {
                this.DriverCullDistanceBox.Text = Convert.ToString(2);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverCullDistance", "200");
            }
            else if (Convert.ToDouble(this.DriverCullDistanceBox.Text) >= 101.0)
            {
                this.DriverCullDistanceBox.Text = Convert.ToString(100);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverCullDistance", "10000");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCDriverCullDistance", Convert.ToString(Convert.ToInt64(this.DriverCullDistanceBox.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.LCVehicleLODDistanceBox.Text))
            {
                this.LCVehicleLODDistanceBox.Text = Convert.ToString(10);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleLODDistance", "1000");
            }
            else if (Convert.ToDouble(this.LCVehicleLODDistanceBox.Text) <= 0.0)
            {
                this.LCVehicleLODDistanceBox.Text = Convert.ToString(1);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleLODDistance", "100");
            }
            else if (Convert.ToDouble(this.LCVehicleLODDistanceBox.Text) >= 100.0)
            {
                this.LCVehicleLODDistanceBox.Text = Convert.ToString(99);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleLODDistance", "9900");
            }
            else
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleLODDistance", Convert.ToString(Convert.ToInt64(this.LCVehicleLODDistanceBox.Text) * Convert.ToInt64((object)100)));
            if (!Versioned.IsNumeric((object)this.LCVehicleCullDistanceBox.Text))
            {
                this.LCVehicleCullDistanceBox.Text = Convert.ToString(70);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleCullDistance", "7000");
            }
            else if (Convert.ToDouble(this.LCVehicleCullDistanceBox.Text) <= 1.0)
            {
                this.LCVehicleCullDistanceBox.Text = Convert.ToString(2);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleCullDistance", "200");
            }
            else if (Convert.ToDouble(this.LCVehicleCullDistanceBox.Text) >= 101.0)
            {
                this.LCVehicleCullDistanceBox.Text = Convert.ToString(100);
                GameLauncher.SaveToINI("AppCompatBucket1", "fLCVehicleCullDistance", "10000");
            }




            // ========================================== Saving User-Settings ==========================================
            UserSettings.Default.ParticleLODBias_Value = (int)this.ParticleLODBiasSelector.Value;
            UserSettings.Default.ParticleLODBias_Text = (string)this.ParticleSpaceAreaLabel.Content;

            UserSettings.Default.ShadowQualityBias_Value = (int)this.ShadowQualityBiasSelector.Value;
            UserSettings.Default.ShadowQualityBias_Text = (string)this.ShadowQualityBiasLabel.Content;

            UserSettings.Default.SunRenderQuality_Value = (int)this.SunRenderQualitySelector.Value;
            UserSettings.Default.SunRenderQuality_Text = (string)this.SunRenderQualityLabel.Content;

            UserSettings.Default.ParticleSpaceArea_Value = (int)this.ParticleSpaceAreaSelector.Value;
            UserSettings.Default.ParticleSpaceArea_Text = (string)this.ParticleSpaceAreaLabel.Content;
             
            UserSettings.Default.FoliageDrawRadius_Value = (int)this.FoliageDrawRadiusSelector.Value;
            UserSettings.Default.FoliageDrawRadius_Text = (string)this.FoliageDrawRadiusLabel.Content;

            UserSettings.Default.ShadowFilterRadius_Value = (int)this.ShadowFilterRadiusSelector.Value;
            UserSettings.Default.ShadowFilterRadius_Text = (string)this.ShadowFilterRadiusLabel.Content;

            UserSettings.Default.ShadowDepthBias_Value = (int)this.ShadowDepthBiasSelector.Value;
            UserSettings.Default.ShadowDepthBias_Text = (string)this.ShadowDepthBiasLabel.Content;

            UserSettings.Default.MaxMemoryCacheEntry_Value = (int)this.MaxMemoryCacheEntrySelector.Value;
            UserSettings.Default.MaxMemoryCacheEntry_Text = (string)this.MaxMemoryCacheEntryLabel.Content;

            UserSettings.Default.TextureStreamingMemory_Value = (int)this.TextureStreamingMemorySelector.Value;
            UserSettings.Default.TextureStreamingMemory_Text = (string)this.TextureStreamingMemoryLabel.Content;

            UserSettings.Default.TexturePoolMemory_Value = (int)this.TexturePoolMemorySelector.Value;
            UserSettings.Default.TexturePoolMemory_Text = (string)this.TexturePoolMemoryLabel.Content;

            UserSettings.Default.MeshStreamingMemory_Value = (int)this.MeshStreamingMemorySelector.Value;
            UserSettings.Default.MeshStreamingMemory_Text = (string)this.MeshStreamingMemoryLabel.Content;

            UserSettings.Default.SkeletalMeshLOD_Text = (string)this.SkeletalMeshLODLabel.Content;
            UserSettings.Default.SkeletalMeshLOD_Value = (int)this.SkeletalMeshLODSelector.Value;

            //-----------------------------------------------------------------------------------------------------------


            UserSettings.Default.TextureCreationPerFrame_Value = this.TextureCreationPerFrameBox.Text;
            UserSettings.Default.MaxDynamicShadows_Value = this.DynamicShadowsBox.Text;
            UserSettings.Default.ShadowFade_Value = this.ShadowFadeDistanceBox.Text;
            UserSettings.Default.PlayerLOD1_Value = this.CharacterLODDistance1Box.Text;
            UserSettings.Default.PlayerLOD2_Value = this.CharacterLODDistance2Box.Text;
            UserSettings.Default.VehicleLOD_Value = this.VehicleLODDistanceBox.Text;
            UserSettings.Default.VehicleCull_Value = this.VehicleCullDistanceBox.Text;
            UserSettings.Default.LCPedestrianLOD_Value = this.PedestrianLODDistanceBox.Text;
            UserSettings.Default.LCPedestrianCull_Value = this.PedestrianCullDistanceBox.Text;
            UserSettings.Default.LCDriverLOD_Value = this.DriverLODDistanceBox.Text;
            UserSettings.Default.LCDriverCull_Value = this.DriverCullDistanceBox.Text;
            UserSettings.Default.LCVehicleLOD_Value = this.LCVehicleLODDistanceBox.Text;
            UserSettings.Default.LCVehicleCull_Value = this.LCVehicleCullDistanceBox.Text;


            UserSettings.Default.Save();

        }

        private void Foliage_Draw_Radius_Field_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Preview_Text.Text = "0.0 turns off foliage. 1.0 is default on high setting. Can see changes in Financial park.";
        }

        private void Foliage_Draw_Radius_Field_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void Particle_Space_Area_Field_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Preview_Text.Text = "particle space area is the flares and smokes behind objectives";
        }

        private void Particle_Space_Area_Field_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        private void Sun_Render_Quality_Field_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Preview_Text.Text = "Doesn't seem like it does anything.";
        }

        private void Sun_Render_Quality_Field_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Preview_Text.Text = "Hover over the settings to see what it does!";
        }

        internal void SaveBtn_Click()
        {
            throw new NotImplementedException();
        }
    }





}
