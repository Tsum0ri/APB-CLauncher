﻿#pragma checksum "..\..\..\..\Settings\site_s-other.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BDC862FB657C197BA3916ACEEFBEE6C7575970DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using CLauncher2._0.Settings;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CLauncher2._0.Settings {
    
    
    /// <summary>
    /// site_s_other
    /// </summary>
    public partial class site_s_other : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\..\..\Settings\site_s-other.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AlwaysSprint;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Settings\site_s-other.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HoldCrouch;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Settings\site_s-other.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HoldLean;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/APB CLauncher;V1.0.0.0;component/settings/site_s-other.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Settings\site_s-other.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AlwaysSprint = ((System.Windows.Controls.CheckBox)(target));
            
            #line 64 "..\..\..\..\Settings\site_s-other.xaml"
            this.AlwaysSprint.Checked += new System.Windows.RoutedEventHandler(this.AlwaysSprint_Checked);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\..\Settings\site_s-other.xaml"
            this.AlwaysSprint.Unchecked += new System.Windows.RoutedEventHandler(this.AlwaysSprint_Unchecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.HoldCrouch = ((System.Windows.Controls.CheckBox)(target));
            
            #line 65 "..\..\..\..\Settings\site_s-other.xaml"
            this.HoldCrouch.Checked += new System.Windows.RoutedEventHandler(this.HoldCrouch_Checked);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\..\Settings\site_s-other.xaml"
            this.HoldCrouch.Unchecked += new System.Windows.RoutedEventHandler(this.HoldCrouch_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HoldLean = ((System.Windows.Controls.CheckBox)(target));
            
            #line 66 "..\..\..\..\Settings\site_s-other.xaml"
            this.HoldLean.Checked += new System.Windows.RoutedEventHandler(this.HoldLean_Checked);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\..\Settings\site_s-other.xaml"
            this.HoldLean.Unchecked += new System.Windows.RoutedEventHandler(this.HoldLean_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

