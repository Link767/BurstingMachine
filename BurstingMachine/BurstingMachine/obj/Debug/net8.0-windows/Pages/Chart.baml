   M S B A M L   `   `   `  ����J  FBurstingMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BurstingMachine.PagesBurstingMachine.Pages  5      U QScottPlot.WPF, Version=5.0.55.0, Culture=neutral, PublicKeyToken=86698dc10387c39eD2clr-namespace:ScottPlot.WPF;assembly=ScottPlot.WPFScottPlot.WPF 5	      !    BurstingMachine.Pages.Chart   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:BurstingMachine.Pages     5      _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      B	ScottPlot2clr-namespace:ScottPlot.WPF;assembly=ScottPlot.WPF  5	        N� Title$  Chart��5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   .+�5$   
     ScottPlot.WPF.WpfPlot  -   5          Name$ WpfPlot1��5$      $��1��5%      $��8��6+   $��8��5&      $��10,10,160,26q�6/   �� 5(   
   -   5         ��Name$ btnTest��5(      $��7��5)      $��Тест��6#   $
��Left=�5*      $	��Top=�6.   $��88��5+      
���   ����	#DD000000$��	74,28,0,0q�5-   *   $��6��6?   ��5,      Z� 5-   ?   �� 5/   
   -   5        $ btnSaveChart��5/      $��7��50      $��Сохранить��6#   $
��Left=�51      $	��Top=�6.   $	��112��52      
���   ����	#DD000000$��62,8,0,0q�54   *   $��7��6>   ��53      Z� 54   >   �� 56   
   -   5        $ btnClearChart��56      $��7��57      $��Очистить��6#   $
��Left=�58      $	��Top=�6.   $	��112��59      
���   ����	#DD000000$��	62,48,0,0q�5;   *   $��7��5<      $��2��6   ��5:      Z� 5<      �� 5>   
   -   5         ��Name$ 	TBNewtons��5>      $	��400��5?      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ СИЛА��5@       �� AcceptsReturn$
 True��5A         MaterialDesignFilledTextBox#��[  5C      $��41��5D       �� TextAlignment$ Justify=�6   $��2��61   $��33,19,33,10q�5E      {�5B      �� *	IsChecked+	 �� ElementName$0	 *MaterialDesignFilledTextBoxEnabledComboBox��5E      �� 5G   
   -   5        $ TBSpeed��5G      $	��400��5H      $ ХОД��5I      $
 True��5J      #��[  5L      $��41��5M      $ Justify=�6   $��4��61   $��34,18,33,10q�5N      {�5K      �� *	IsChecked+$0	 *MaterialDesignFilledTextBoxEnabledComboBox��5N      �� 5P   
   -   5        
 ��Name$
 CBNotClearChart��5P       d� 	IsChecked$
 TrueY�5Q       - )MaterialDesignFilterChipSecondaryCheckBox#��[ 5R      $��
10,23,0,15q�6P   .��6d   " Не очищать график5T      5U      5V      