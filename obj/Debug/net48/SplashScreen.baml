   M S B A M L   `   `   `  ����H  DAPB CLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CLauncher2._0CLauncher2._0  5   	        CLauncher2._0.SplashScreen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CLauncher2._0     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   _ [MaterialDesignThemes.Wpf, Version=4.7.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6B   A	 =Wpf.Ui, Version=2.0.3.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml 	 6�   -   5          � Title$"  APB CLauncher - SplashScreen��5	   	   $	��280��6.   $	��585��6;    � 
ResizeMode$ NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]    � WindowStyle$
 None=�6�    J� Opacity$	 0.9Q�6�   ��6�   Z� .��5
      � ��5   
   �� 5       �� ImageSource$! /Resources/splashscreen.png��6    � ColumnDefinitions 5   
   �� 5      $
��401* �6   �� 5      $
��399* �6   .+�5   
   �� $��2��6   $
��Left=�6$   $	��165��6?   $��	67,43,0,0q�6L   $	��Top=�6_   $	��451��6w   $/��)Resources/clauncher_fontlogo_launcher.png��6�   $
��Fill=�6�   �� 5   
   -   5         ��Name$ splashscreen_status��5      $��Checking for updates��6-   $
��Left=�6L   $��
10,169,0,0q�6g   $	��Top=�6{      Purista#��[  6�   
�������$��2��6�   $	��565��6�   $��Center=�6�   $��Center=�6  $��Normal"�62  4  .System.Windows.Automation.AutomationProperties   	AccessKey$ false��6F  $��14(�6m  )  #MahApps.Metro.Controls.ProgressRing  5   
   $
��Left=�6   $��263,200,0,0q�66   $	��Top=�6K   $��2��6c   ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ 	#FF54AEF4��6#   � 5      $ 	#FF8EA9F7��6#    � Offset$ 1Q�65   5      5      5      5      