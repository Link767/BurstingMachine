   M S B A M L   `   `   `  ����J  FBurstingMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BurstingMachine.WinBurstingMachine.Win  5   	   "    BurstingMachine.Win.PushMail   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BurstingMachine.Win     5   	   _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5
   	    � Title$ PushMail��5   	   $	��144��6   $	��300��6'   .��5      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6   .+�5!   
   �� -   5         ��Name$ btnPush��5!      $��4��6#   $��Отправить��5"      $��3��6&   $
��Left=�5#      $��	23,16,0,0q�6-   $��4��5$      $	��Top=�6   
���   ����	#DD000000$	��107��5&   =   $��2��6I   $��26��6Z   ��5%   '   Z� 5&   Z   �� 5(   
   -   5        +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowAnimationDuration$ 0:0:0.5h�5)       "  MaterialDesignRaisedDarkButton#��[  5*      $��5��5+      $
��Left=�5,      $��Center=�6,    � Cursor$
 Hand��5-      $��40,0,0,0q�63   ���	#DD000000$��20��5.   >   $��53��5/      $��1��6   $��2��6)   ��5+   !   Z� ��5.   (   Z� .��50      �� $��36��6   $��20��6$   $��Center=�51      $
��Left=�6,   .+�52      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�6*   $��20��6=   $��22��6I   53      54      �� 55   
   -   5        	 ��Name$	 TBEmail��55      $��50��56      $	��Top=�57      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$%
 Почта получателя��58       �� AcceptsReturn$
 True��59       ! MaterialDesignOutlinedTextBox#��[ 5;       �� TextWrapping$
 Wrap=�5<      " �� VerticalScrollBarVisibility$
 Auto=�5=      $��9,5,4,0q�65   $��2��6F   $��3��5>      $��7��6#   {�5:      ��  �� Path$ 	IsChecked� �� ElementName$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5>   #   5?      5@      