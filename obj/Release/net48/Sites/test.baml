   M S B A M L   `   `   `  ���� H  DAPB CLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CLauncher2._0.WindowCLauncher2._0.Window      CLauncher2._0.Window.test   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     4local"clr-namespace:CLauncher2._0.Window     S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  _ [MaterialDesignThemes.Wpf, Version=4.7.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  T	 PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls 	 A
 =Wpf.Ui, Version=2.0.3.0, Culture=neutral, PublicKeyToken=null/ui&http://schemas.lepo.co/wpfui/2022/xaml 
 -     � Title$  APB CLauncher��$	��788��$
��1492�� � WindowStyle$
 None=� � AllowsTransparency$
 True�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�   Purista#��[  
������ .��� -    �Name$ MainGrid��$	��788��.+��� -    ��Name$
 mask�� �� CornerRadius$ 20�����	#D8191919$	��788���� $	��788�� J� OpacityMask !� 	 !� Visual	 �� 
 �� ElementName$

 mask��.+�� $	��791��.+��� -    ��Name$ 
LauncherBG��$&�� /Resources/Backgrounds/BG_11.png��$	��788��$
��1492��$
��Fill=�� $	��788��$��
0,2,1306,1q����	#4C000000.+��� $��Center=�$��76��$��0,19,0,0q�$	��Top=�$	��130��$.��(/Resources/kisspng-vehicle-clauncher.png��$
��Fill=��� -    ��Name$ Home_Btn�� �� Orientation$ 
Horizontal=�$��0,214,0,524q�����  �� 
TargetType" �� �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 true��. ���  �� Property � �� �� Value �� .���  � Color$ 	#000C368A�� � Offset$ 0.995Q�� $ 	#19FFFFFF��$ 0.221Q�.+��� $&�� /Resources/icons8_Home_100px.png��$
��Fill=�$��25,0,0,0q�$��25��$��25���� $
��Home��$��10,5,0,5q�  PuristaSemiBold#��[ 
�������$��Normal"�$��18(�$��Center=�$��Center=�$��69�� � -     �Name$ Site_Content��$��Frame��  � NavigationUIVisibility$ Hidden=�$��186,74,-1306,0q�$	��714���� $��Center=�$��	0,258,0,0q�$	��Top=�$��13��$	��186�� J� Opacity$
 0.15Q��� -   $ Settings_Btn��$ 
Horizontal=�$��0,266,0,468q�$��54������ " �� P�  �@J�IsMouseOver$
 true��. ���  � �� �� .��� $ 	#000C368A��$ 0.995Q�� $ 	#19FFFFFF��$ 0.221Q�.+��� $*��$/Resources/icons8_Settings_100px.png��$
��Fill=�$��25,0,0,0q�$��25��$��25���� $��Settings��$��10,5,0,5q�#��[ 
�������$��Normal"�$��18(�$��Center=�$��Center=�$��79���� $��Center=�$��	0,314,0,0q�$	��Top=�$��13��$	��186��$
 0.15Q��� -   $ Configs_Btn��$ 
Horizontal=�$��0,321,0,413q�$��54������ " �� P�  �@J�IsMouseOver$
 true��. ���  � �� �� .��� $ 	#000C368A��$ 0.995Q�� $ 	#19FFFFFF��$ 0.221Q�.+��� $*��$/Resources/icons8_Settings_100px.png��$
��Fill=�$��25,0,0,0q�$��25��$��25���� $��Configs��$��10,5,0,5q�#��[ 
�������$��Normal"�$��18(�$��Center=�$��Center=�$��73���� $��Center=�$��	0,369,0,0q�$	��Top=�$��13��$	��186��$
 0.15Q��� $ 
Horizontal=�$��0,376,0,358q�$��54��${�False��$
 0.25Q����� " �� P�  �@J�IsMouseOver$
 true��. ���  � �� �� .��� $ 	#000C368A��$ 0.995Q�� $ 	#19FFFFFF��$ 0.221Q�.+��� $&�� /Resources/icons8_News_100px.png��$
��Fill=�$��25,0,0,0q�$��25��$��25���� $
��News��$��10,5,0,5q�#��[ 
�������$��Normal"�$��18(�$��Center=�$��Center=�$��72���� $��Center=�$��	0,424,0,0q�$	��Top=�$��13��$	��186��$
 0.15Q��� $ 
Horizontal=�$��0,431,0,303q�$��54��$
 0.25Q�${�False������ " �� P�  �@J�IsMouseOver$
 true��. ���  � �� �� .��� $ 	#000C368A��$ 0.995Q�� $ 	#19FFFFFF��$ 0.221Q�.+��� $%��/Resources/icons8_cet_100px.png��$
��Fill=�$��25,0,0,0q�$��30��$��30���� $	��CET��$��10,5,0,5q�#��[ 
�������$��Normal"�$��18(�$��Center=�$��Center=�$��60���� $��Center=�$��	0,479,0,0q�$	��Top=�$��14��$	��186��$
 0.15Q��� -	   $ discord_btn��$ 
Horizontal=�$��0,487,0,247q�$��54��${�False��$ 0.228Q����� " �� P�  �@J�IsMouseOver$
 true��. ���  � �� �� .��� $ 	#000C368A��$ 0.995Q�� $ 	#19FFFFFF��$ 0.221Q�.+��� $)��#/Resources/icons8_Discord_100px.png��$
��Fill=�$��25,0,0,0q�$��25��$��25���� $��Discord��$��10,5,0,5q�#��[ 
�������$��Normal"�$��18(�$��Center=�$��Center=�$��78���� -
   $ Info_Btn��$ 
Horizontal=�$��	0,733,0,0q�$��40��$��Center=�$	��Top=�$��66��.+��� $&�� /Resources/icons8_Info_104px.png��$
��Fill=�$-��'0                                ,0,0,0q�$��25��$��25���� $
��INFO��$��0,5,0,5q�#��[ 
�������$��Normal"�$��14(�$��Center=�$��Center=�$��40������ " �� P�  �@J�IsMouseOver$
 True��. ���  �@J�Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q�   Color$ White��   Opacity$ 1Q�   
BlurRadius$ 20Q� 
 Wpf.Ui.Controls.Card  $�� ��$
��Left=�$��1346,29,0,0q�$	��Top=�$��2��$��24�����	#25FFFFFF����  �� EndPoint$	 0,3&� � MappingMode$ Absolute=�.��� $ 	#18FFFFFF��$
 0.33Q�� $ 	#26FFFFFF��$ 1Q�� $��1118,0,0,712q�.+��� -    ��Name$ updateStatus��$#��Launcher is on latest version��$
��Left=�$��	34,32,0,0q�$	��Top=�
�������$
 0.65Q�  J� RenderTransformOrigin$  0.5,0.5&�$	��172��$��Right=�#��[  z�V� .~��� ! �� ScaleX$! 1Q��� �� T� �� -   $ Exit_Btn��$
��Left=�$��25��$��
319,28,0,0q�$	��Top=�$��25��$"��/Resources/on-off-button.png��$
 0.65Q�$  0.667,0.613&����� " �� P�  �@J�IsMouseOver$
 True��. ���  �@J�Effect   $ 0Q�$ White��$ 1Q�$ 20Q��� -   $ Launcher_Settings_Btn��$
��Left=�$��257,27,0,21q�$��28��$*��$/Resources/icons8_Settings_100px.png��$
 0.35Q�${�False������ " �� P�  �@J�IsMouseOver$
 True��. ���  �@J�Effect   $ 0Q�$ White��$ 1Q�$ 20Q�