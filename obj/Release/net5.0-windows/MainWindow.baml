   M S B A M L   `   `   `  ���� G  CCLauncher2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CLauncher2._0CLauncher2._0      CLauncher2._0.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:CLauncher2._0       � Title$  APB CLauncher��$	��615��$
��1200�� � WindowStyle$
 None=� � AllowsTransparency$
 True�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�$��Purista)���Z� .���  � RowDefinitions �� $	��91* ��� $
��524* � � ColumnDefinitions �� $	��53* ��� $
��347* �.+��� $��
137,27,0,0q�$��2��$��2�� J� Opacity$
 0.98Q� J� Effect -  'System.Windows.Media.Effects.BlurEffect  ���� 	 �� ImageSource$	 /Resources/BG_1_2.png�� � -   
  �Name$
 Site_Content��$��Frame��$��2��$��2��  � NavigationUIVisibility$ Hidden=�$��
125,46,0,0q�� -   $��2��$��	147,0,0,0q����� $	 /Resources/Panel-up.png�� j� Stretch$ Uniform=�� $��2��$��0,67,1040,0q�$��2������ $	 /Resources/Panel-left.png��.+��� �� -    ��Name$ LV��
������ 
������ $��Disabled=�$��
0,90,17,64q�����  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R���  ��Name$ Bd��$��50��#��z��#��z��#��z�� �� Padding# z�� J� SnapsToDevicePixels$
 True��._��� #��z��# z #��z�� �� Triggers ]�  ]� 
Conditions ��  �� Property �@J�IsMouseOver �� Value$
 True��./���  �� 
TargetName$ Bd�� � �� �#404D5B�� $ Bd�� � �� �#404D5B.@��� -    ��Name$ Home_Btn��$
��Left=�$��0,0,0,15q� � ToolTip _� -    _�Name$ tt_home��$
��Home��$��Purista)�.����  �� Orientation$ 
Horizontal=�$	��230��.+��� $%��Resources/icons8_Home_100px.png��$
��Fill=�$��5,0,0,0q�$��25��$��25���� $
��HOME��$��10,5,0,5q�$��Purista)�
�������$��SemiBold"�$��18(��� -   $ Settings_Btn��$
��Left=�$��0,0,0,15q� _� -   $ tt_contacts��$��Settings��$��Purista)�.���� $ 
Horizontal=�$	��129��.+��� $)��#Resources/icons8_Settings_100px.png��$
��Fill=�$��5,0,0,0q�$��25��$��25���� $��SETTINGS��$��10,5,0,5q�$��Purista)�
�������$��SemiBold"�$��18(�$��91���� -   $ News_Btn��$
��Left=�$��0,0,0,15q�$	 0.2Q�${�False�� _� -	   $ tt_messages��$
��News��$��Purista)�.���� $ 
Horizontal=�$	��230��.+��� $%��Resources/icons8_News_100px.png��$
��Fill=�$��5,0,0,0q�$��25��$��25���� $
��NEWS��$��10,5,0,5q�$��Purista)�
�������$��SemiBold"�$��18(��� -
   $ CET_Btn��$
��Left=�$��0,0,0,15q�${�False��$	 0.2Q� _� -   $ tt_maps��$	��CET��$��Purista)�.���� $ 
Horizontal=�$	��129��.+��� $$��Resources/icons8_cet_100px.png��$
��Fill=�$��5,0,0,-5q�$��35��$��35���� $	��CET��$��10,5,0,5q�$��Purista)�
�������$��SemiBold"�$��18(��� -   $ Discord_Btn��$
��Left=�$��0,0,0,15q� _� -   $ 
tt_signout��$��Discord��$��Purista)�.���� $ 
Horizontal=�$	��230��.+��� $(��"Resources/icons8_Discord_100px.png��$
��Fill=�$��5,0,0,0q�$��25��$��25���� $��DISCORD��$��10,5,0,5q�$��Purista)�
�������$��SemiBold"�$��18(��� -   $ Info_Btn��$��0,0,0,15q� _� -   $ tt_settings��$��Informations��$��Purista)�.���� $ 
Horizontal=�$	��230��.+��� $%��Resources/icons8_Info_104px.png��$
��Fill=�$��5,0,0,0q�$��25��$��25���� $
��INFO��$��10,5,0,5q�$��Purista)�
�������$��SemiBold"�$��18(�� ���� $	 /Resources/Panel-left.png��.+��� $��8,4,-39,-21q����� $.	 (/Resources/kisspng-vehicle-clauncher.png��