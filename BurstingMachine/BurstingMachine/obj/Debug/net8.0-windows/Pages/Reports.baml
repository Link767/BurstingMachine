   M S B A M L   `   `   `  ����J  FBurstingMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BurstingMachine.PagesBurstingMachine.Pages  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	      #    BurstingMachine.Pages.Reports   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:BurstingMachine.Pages     5      _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      0sys&clr-namespace:System;assembly=mscorlib  5	        N� Title$  Reports��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��* �6   .+�5(   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ DPData��5(       "  MaterialDesignFilledDatePicker#��[  5)      $��2��6M   $��10,10,10,10q�5*      
 �� Now   SelectedDate# Z 6*   $��20(�5+      $��4��6#   )  #MaterialDesignThemes.Wpf.TimePicker  5-   
   -   5          Name$ 	TimePicer��5-   $      	Is24Hours$
 True��5.   $    $  MaterialDesignOutlinedTimePicker#��[ 5/   $   $��2��6^      SelectedTime# Z 50   $   $��
10,10,10,7q�51   $   $��5��68   $��15(�6E   �� 52   
   -   5        	 ��Name$	 
TBNameTest��52      $��Center=�53      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$*
 $Название испытания*��54        MaterialDesignFilledTextBox#��[ 55       �� TextWrapping$
 Wrap=�56      $��2��6&   $��	10,0,10,0q�57      $��50��6%   $��1��61   �� 59   
   -   5        $	 TBNameStaff��59      $��Center=�5:      $
 Испытатель��5;      #��[ 5<      $
 Wrap=�5=      $��2��6&   $��	10,0,10,0q�5>      $��50��6%   $��15(�61   �� 5@   
   -   5        $	 	TBNewtons��5@      $��Center=�5A      $!
 Верхнее усилие��5B      #��[ 5C      $
 Wrap=�5D      $��2��6&   $��	10,0,10,0q�5E      $��50��6%   $��2��61   �� 5G   
   -   5        $	 TBSpeed��5G      $��Center=�5H      $)
 #Скорость измерения��5I      #��[ 5J      $
 Wrap=�5K      $��2��6&   $��10,0,8,0q�5L      $��50��6$   $��3��60   �� 5N   
   -   5         ��Name$ btnSaveReport��5N      $��1��5O      $��Сохранить��6#   $
��Left=�5P      $��Center=�6.   $	��112��5Q      
���   ����	#DD000000$��6��5S   *   $��17,0,0,0q�5T      ��5R      Z� 5T      �� 5V   
   -   5        $ btnPushMail��5V       � ToolTip$3 -Отправьте отчет по почте��5W      $��Отправить��64   $��Center=�5X      $��Center=�60   $	��112��5Y      
���   ����	#DD000000$��6��5[   *   ��5Z      Z� 5[   7   �� 5]   
   $��10��6   $��1,9,1,26q�6%   $��7��67   $&�� C:\Users\win-112\GitHub\Plot.png��5^      $��2��6:   5_      5`      