   M S B A M L   `   `   `  ����H  DAPB CLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CLauncher2._0CLauncher2._0  5   	        CLauncher2._0.ConfigWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CLauncher2._0     5   	     � Title$  APB CLauncher��5   	   $	��615��6   $
��1200��6,    � WindowStyle$
 None=�69    � AllowsTransparency$
 True��6L    � 
ResizeMode$ NoResize=�6f    � WindowStartupLocation$ CenterScreen=�6|   $��Purista)�6�   ��6�   Z� .��5	      � ��5
   
   �� 5       �� ImageSource$ /BG_1_2.png��6   .+�5   
   � -   5        $��
3,0,872,10q�5      ��5      �� 5      $ /Panel-left-config.png��6   .+�5      �� �� 5      -   5         ��Name$ LV��5      
������ 
������ $��Disabled=�5      $��0,0,-9,0q�6G   $��Center=�6Y   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � ��	 �� Value	 5      �� 5!   "   
 �� 
TargetType"
 ��62   .R�5#   &   ��  ��Name$ Bd��6-   $��50��5$   )   #��z��5%   )   #��z��5&   )   #��z��5'   )    �� Padding# z��5(   )    J� SnapsToDevicePixels$
 True��5)   )   ._�5+   *   �� #��z��6;   # z 5,   -   #��z��5-   -   5/   '    �� Triggers 51   &   ]� 53   *    ]� 
Conditions 55   .   �� 57   2    �� Property �@J�IsMouseOver �� Value$
 True��6S   ./�5;   .   ��  �� 
TargetName$ Bd��5<   1    � ��	 �#404D5B5=   1   �� 5?   .   $ Bd��5@   1    � ��	 �#404D5B5A   1   5C   +   5G   #   5K      5M      .@�5S      �� -   5         ��Name$ Mission_Btn��5S      $��0,0,0,15q�5T      $	��135��6'   $
��Left=�63   ���	#CC353333 � ToolTip 5Y      _� 5[      -   5         _�Name$ 	tt_ingame��5[   "   $��MISSION��5\      $��Purista)�5]      .��5a      ��  �� Orientation$ 
Horizontal=�6!   $	��110��5b      $��Center=�6%   $��Center=�6B   .+�5d      �� $��MISSION��6$   $��10,5,0,5q�5e      $��Purista)�5f      
�������$��SemiBold"�6E   $��18(�6[   $��Center=�6i   $��Center=�6�   5h      5j      �� 5n      -   5        $ Description_Btn��5n      $
��Left=�68   $��0,0,0,15q�5o      ���	#CC353333 5t      _� 5v      -   5        $ 
tt_setting��5v   "   $��DESCRIPTION��5w      $��Purista)�5x      .��5|      �� $ 
Horizontal=�6!   $	��129��5}      .+�5      �� $��DESCRIPTION��6$   $��10,5,0,5q�5�      $��Purista)�5�      
�������$��SemiBold"�6E   $��18(�6[   $	��118��6i   5�      5�      �� 5�      -   5        $ Killfeed_Btn��5�      $��0,0,0,15q�5�      $	��111��6'   $
��Left=�63   ���	#CC353333 5�      _� 5�      -   5        $ tt_textures��5�   "   $��KILLFEED��5�      $��Purista)�5�      .��5�      �� $ 
Horizontal=�6!   $	��230��5�      .+�5�      �� $��KILLFEED��6$   $��10,5,0,5q�5�      $��Purista)�5�      
�������$��SemiBold"�6E   $��18(�6[   5�      5�      �� 5�      -	   5        $ 	other_Btn��5�      $
��Left=�62   $��0,0,0,15q�5�      ���	#CC353333 5�      _� 5�      -
   5        $ other_other��5�   "   $��OTHER��5�      $��Purista)�5�      .��5�      �� $ 
Horizontal=�6!   $	��129��5�      .+�5�      �� $��OTHER��6$   $��10,5,0,5q�5�      $��Purista)�5�      
�������$��SemiBold"�6E   $��18(�6[   5�      5�      �� 5�      -   5        $ pre_Btn��5�      $
��Left=�60   $��0,0,0,15q�5�      ���	#CC353333 5�      _� 5�      -   5        $ tt_other��5�   "   $��
PRE-CONFIG��5�      $��Purista)�5�      .��5�      �� $ 
Horizontal=�6!   $	��129��5�      .+�5�      �� $��
PRE-CONFIG��6$   $��10,5,0,5q�5�      $��Purista)�5�      
�������$��SemiBold"�6E   $��18(�6[   5�      5�      5�      5�       � 5�   
   -   5          �Name$ site_configs��5�      $��Frame��6&   $��
146,0,0,10q�66     � NavigationUIVisibility$ Hidden=�6J   5�      5�      