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

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            /*
            File.WriteAllLines(Application.StartupPath + "\\APBGame\\Config\\APBCompat.ini", contents);
            MySettingsProperty.Settings.ParticleLODBiasSetting = this.ParticleLODBiasSelector.Value;
            MySettingsProperty.Settings.ParticleLODBiasLabelSetting = this.ParticleLODBiasLabel.Text;
            MySettingsProperty.Settings.ShadowQualityBiasSetting = this.ShadowQualityBiasSelector.Value;
            MySettingsProperty.Settings.ShadowQualityBiasLabelSetting = this.ShadowQualityBiasLabel.Text;
            MySettingsProperty.Settings.SunRenderQualitySetting = this.SunRenderQualitySelector.Value;
            MySettingsProperty.Settings.SunRenderQualityLabelSetting = this.SunRenderQualityLabel.Text;
            MySettingsProperty.Settings.ParticleSpaceAreaSeting = this.ParticleSpaceAreaSelector.Value;
            MySettingsProperty.Settings.ParticleSpaceAreaLabelSeting = this.ParticleSpaceAreaLabel.Text;
            MySettingsProperty.Settings.FoliageDrawRadiusSetting = this.FoliageDrawRadiusSelector.Value;
            MySettingsProperty.Settings.FoliageDrawRadiusLabelSetting = this.FoliageDrawRadiusLabel.Text;
            MySettingsProperty.Settings.ShadowFilterRadiusSetting = this.ShadowFilterRadiusSelector.Value;
            MySettingsProperty.Settings.ShadowFilterRadiusSettingLabelSetting = this.ShadowFilterRadiusLabel.Text;
            MySettingsProperty.Settings.ShadowDepthBiasSetting = this.ShadowDepthBiasSelector.Value;
            MySettingsProperty.Settings.ShadowDepthBiasLabelSetting = this.ShadowDepthBiasLabel.Text;
            MySettingsProperty.Settings.MaxMemoryCacheEntrySetting = this.MaxMemoryCacheEntrySelector.Value;
            MySettingsProperty.Settings.MaxMemoryCacheEntryLabelSetting = this.MaxMemoryCacheEntryLabel.Text;
            MySettingsProperty.Settings.TextureStreamingMemorySetting = this.TextureStreamingMemorySelector.Value;
            MySettingsProperty.Settings.TextureStreamingMemoryLabelSetting = this.TextureStreamingMemoryLabel.Text;
            MySettingsProperty.Settings.TexturePoolMemorySetting = this.TexturePoolMemorySelector.Value;
            MySettingsProperty.Settings.TexturePoolMemoryLabelSetting = this.TexturePoolMemoryLabel.Text;
            MySettingsProperty.Settings.MeshStreamingMemorySetting = this.MeshStreamingMemorySelector.Value;
            MySettingsProperty.Settings.MeshStreamingMemoryLabelSetting = this.MeshStreamingMemoryLabel.Text;
            MySettingsProperty.Settings.TextureCreationPerFrameSetting = this.TextureCreationPerFrameBox.Text;
            MySettingsProperty.Settings.MaxDynamicShadowsSetting = this.DynamicShadowsBox.Text;
            MySettingsProperty.Settings.ShadowFadeDistanceSetting = this.ShadowFadeDistanceBox.Text;
            MySettingsProperty.Settings.CharacterLODDistance1Setting = this.CharacterLODDistance1Box.Text;
            MySettingsProperty.Settings.CharacterLODDistance2Setting = this.CharacterLODDistance2Box.Text;
            MySettingsProperty.Settings.VehicleLODDistanceSetting = this.VehicleLODDistanceBox.Text;
            MySettingsProperty.Settings.VehicleCullDistanceSetting = this.VehicleCullDistanceBox.Text;
            MySettingsProperty.Settings.PedestrianLODDistanceSetting = this.PedestrianLODDistanceBox.Text;
            MySettingsProperty.Settings.PedestrianCullDistanceSetting = this.PedestrianCullDistanceBox.Text;
            MySettingsProperty.Settings.DriverLODDistanceSetting = this.DriverLODDistanceBox.Text;
            MySettingsProperty.Settings.DriverCullDistanceSetting = this.DriverCullDistanceBox.Text;
            MySettingsProperty.Settings.LCVehicleLODDistanceSetting = this.LCVehicleLODDistanceBox.Text;
            MySettingsProperty.Settings.LCVehicleCullDistanceSetting = this.LCVehicleCullDistanceBox.Text;
            MySettingsProperty.Settings.QualityBarSetting = this.QualityBar.Value;
            MySettingsProperty.Settings.QualityLabelSetting = this.QualityLabel.Text;
            MySettingsProperty.Settings.MouseAccelSetting = this.MouseAccelSelector.Checked;
            MySettingsProperty.Settings.Save();
            */
        }
    }





}
