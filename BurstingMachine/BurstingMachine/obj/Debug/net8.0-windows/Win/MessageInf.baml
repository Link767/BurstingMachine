   M S B A M L   `   `   `  ����J  FBurstingMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BurstingMachine.WinBurstingMachine.Win  5   	   $    BurstingMachine.Win.MessageInf   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BurstingMachine.Win     5   	   _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStyle$
  None=�5	   	    � AllowsTransparency$
 True��5
   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
MessageErr��5   	   $	��200��6   $	��300��6)   .��5      ��  �� CornerRadius$ 20��6   
�������$��1q�62   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0.191Q�6-   � 5      $ 	#FF265BDE��6   5      ._�5   
   � 	 � ColumnDefinitions	 5      �� 5      $��10 �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��10 �6#   
 � RowDefinitions
 5       �� 5!      $��10 �6    �� 5"      $��20 �6    �� 5#      $��* �6    �� 5$      $��* �6    �� 5%      $��* �6    �� 5&      $��* �6    �� 5'      $��10 �6    .+�5*      �� -   5         ��Name$
 TBOk��5*      $��5��6$   $
��ОК��5+      $��2��6   $
��Left=�5,      $��40,0,0,0q�6-   $��5��5-      $��Center=�6   
���   ����	#DD000000��5.   '   Z� 5/   &   �� 51      $��Информация��6   $��1��6*   $��1��52      $��14(�6%   $��3��63   $��	24,0,27,0q�53      $��Italic$�6+   �� 55      -   5        +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowAnimationDuration$ 0:0:0.5h�56       "  MaterialDesignRaisedDarkButton#��[  57      $��5��58      $
��Left=�59      $��Center=�6,    � Cursor$
 Hand��5:      $��40,0,0,0q�63   ���	#DD000000$��20��5;   >   $��53��5<      $��1��6   $��2��6)   ��58   !   Z� ��5;   (   Z� .��5=      �� $��36��6   $��20��6(   $��Center=�5>      $
��Left=�6,   .+�5?      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�6.   $��20��6A   $��22��6M   5@      5A      �� 5C      $��/Res/info.png��6   $��7,0,24,0q�5D      $��1��6&   $��2��63   �� 5F      -   5         ��Name$ 	TBlockInf��5F      $��1��6+   $��
10,13,10,6q�5G      $��2��6,   $��6��69   $��3��5H      $
��Wrap=�6)   5I      5J      5K      