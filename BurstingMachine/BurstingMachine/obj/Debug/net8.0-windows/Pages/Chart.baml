   M S B A M L   `   `   `  ����J  FBurstingMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BurstingMachine.PagesBurstingMachine.Pages  5      U QScottPlot.WPF, Version=5.0.55.0, Culture=neutral, PublicKeyToken=86698dc10387c39eD2clr-namespace:ScottPlot.WPF;assembly=ScottPlot.WPFScottPlot.WPF 5	      !    BurstingMachine.Pages.Chart   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:BurstingMachine.Pages     5      _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      B	ScottPlot2clr-namespace:ScottPlot.WPF;assembly=ScottPlot.WPF  5	        N� Title$  Chart��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   .+�5$   
     ScottPlot.WPF.WpfPlot  -   5          Name$ WpfPlot1��5$      $��8��60   $��9��5%      $��34,51,99,56q�6/   �� 5'   
   -   5         ��Name$ btnTest��5'      $��7��5(      $��Тест��6#   $
��Left=�5)      $��Center=�6.   $��88��5*      
���   ����	#DD000000$��	101,0,0,0q�5,   *   ��5+      Z� 5,   *   �� 5.   
   -   5         ��Name$ 	TBNewtons��5.      $	��400��5/       �� AcceptsReturn$
 True��50         MaterialDesignFilledTextBox#��[  52       �� TextAlignment$ Justify=�53      $��2��6*   $��4,0,6,24q�54      $
��Bold"�6$   $��15(�66   {�51      �� *	IsChecked+ �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox��54   6   �� 56   
   -   5        $ TBSpeed��56      $	��400��57      $
 True��58      #��[  5:      $ Justify=�5;      $��4��6%   $��98,0,111,24q�5<      $��2��6"   $
��Bold"�66   $��15(�6H   {�59      �� *	IsChecked+$0 *MaterialDesignFilledTextBoxEnabledComboBox��5<   H   �� 5>   
   -   5        $ btnIncrease��5>      	 � ToolTip$'	 !Приблизить график��5?      $
��Left=�5@      $	��Top=�6.   $��76��5A      
���   ����	#DD000000$��
113,24,0,0q�5C   *   $��60��5D      $��7��6   $��5��6-   $��2��5E   +   ��5B      Z� .��5F      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 MagnifyPlusOutline=�6&   $��42��6@   $��53��6L   5G      �� 5I   
   -   5        $ 	btnReduce��5I      $#	 Отдалить график��5J      $
��Left=�5K      $	��Top=�6.   $��76��5L      
���   ����	#DD000000$��
113,24,0,0q�5N   *   $��60��5O      $��7��6   $��7��6-   $��2��6R   ��5M      Z� .��5P        $
 MagnifyMinusOutline=�6&   $��42��6A   $��53��6M   5Q      �� 5S   
   -   5        $ btnNormalize��5S      $%	 Выровнять график��5T      $
��Left=�5U      $	��Top=�6.   $��76��5V      
���   ����	#DD000000$��
113,24,0,0q�5X   *   $��60��5Y      $��7��6   $��6��6-    � Cursor$
 Hand��6:   $��2��6c   ��5W      Z� .��5Z        $
 MagnifyScan=�6&   $��42��69   $��53��6E   5[      �� 5]   
   $��Сила(N)��6   $��15(�6#   $��Arial)�5^      $��	-12,2,0,0q�6'   $��4��6:   $	��Top=�6G   $
��Left=�5_       J� RenderTransformOrigin$ 0.5,0.5&�6/   z�5`      V� 5a      .~�5b      �� �� 5c      �� 5d       �� Angle$ -90.89Q�6&   T� 5e      5f      5h      �� 5i   
   $��Ход(ММ)��6   $��15(�6#   $��Arial)�5j      $��
135,0,0,32q�6'   $��8��6;   $��3��5k      $��Bottom=�6$   $
��Left=�5l      �� 5n   
   $��Сила(N)��6   $��15(�6#   $��Arial)�5o      $��	129,0,0,0q�6'   $��Center=�5p      $ 0.5,0.5&�6/   $��1��5q      $
��Left=�6$   $
��Bold"�6?   $��15��6Q   �� 5s   
   $��Ход(ММ)��6   $��15(�6#   $��Arial)�5t      $��22,0,0,0q�6'   $��4��5u      $��Center=�6$   $
��Left=�5v      $
��Bold"�6/   5x      5y      