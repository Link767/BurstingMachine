   M S B A M L   `   `   `  ���� J  FBurstingMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BurstingMachine.WinBurstingMachine.Win  $    BurstingMachine.Win.MessageErr   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:BurstingMachine.Win     _ [MaterialDesignThemes.Wpf, Version=5.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � WindowStyle$
  None=� � AllowsTransparency$
 True��
������  � WindowStartupLocation$ CenterScreen=� � Title$ 
MessageErr��$	��200��$	��300��.����  �� CornerRadius$ 20��
�������$��1q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ White�� � Offset$ 0.191Q�� $ 	#FFDE2626��._�� 	 � ColumnDefinitions	 �� $��10 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��10 �
 � RowDefinitions
 �� $��10 ��� $��20 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��10 �.+��� -    ��Name$
 TBOk��$��5��$
��ОК��$��2��$
��Left=�$��40,0,0,0q�$��5��$��Center=�
���   ����	#DD000000��Z� �� $��Ошибка��$��1��$��1��$��14(�$��2��$��	24,0,11,0q�$��Italic$��� -   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowAnimationDuration$ 0:0:0.5h� "  MaterialDesignRaisedDarkButton#��[  $��5��$
��Left=�$��Center=� � Cursor$
 Hand��$��40,0,0,0q����	#DD000000$��20��$��53��$��1��$��2����Z� ��Z� .���� $��36��$��20��$��Center=�$
��Left=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�$��20��$��22���� $��/Res/error.png��$��7,0,24,0q�$��1��$��2���� -    ��Name$ TBlockError��$��1��$��
10,13,10,6q�$��2��$��6��$��3��$
��Wrap=�