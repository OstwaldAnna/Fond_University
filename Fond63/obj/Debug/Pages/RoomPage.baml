   M S B A M L   `   `   `  ����A  =Fond63, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Fond63.PagesFond63.Pages  5          Fond63.Pages.RoomPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Fond63.Pages     5        N� Title$  RoomPage��5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��32* �6    � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��33* �6   �� 5      $��7* �6   .+�5   
   �� $��Center=�6   $��Center=�62   .+�5      �� $��Университет:��6   �� 6-   -   5         �Name$ RnUniversity��5   1   6H   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Center=�6K   $��2��6f   .+�5      �� $��Комнаты��6   $��20(�6'   $
��Bold"�65   5      �� 5   
   $��Center=�6   $��2��62   $��1��6F   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��DgRooms��5         AutoGenerateColumns .     CanUserAddRows .  $	��330��5   .      RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      -   5        5       	   Columns	 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Факультет��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *Faculty.Name+  5$      $
 Комната��6)   $ * 6:    6D   �� *	Room.Name+  5%      $!
 Ширина комнаты��6)   $ * 6A    6K   �� *Room.Height+  5&      $!
 Высота комнаты��6)   $ * 6A    6K   �� *
Room.Width+  5'      $
 Длина комнаты��6)   $ * 6@    6J   �� *Room.Lenght+  5(      $#
 Площадь комнаты��6)   $ * 6B    6L   �� *	Room.Area+  5)      $
 Объем комнаты��6)   $ * 6@    6J   �� *Room.Volume+5+      5,      �� 5-   
   $ 
Horizontal=�6   $��Right=�6.   $��Center=�5.      $��2��60   $��2��6=   .+�5/      �� -   5        $��
BtnAddEdit��5/   =   $	��150��6   $'��!Добавить/Изменить��6!   6O   �� 50      -   5        $��BtnDeleteRoom��50   '   $��Удалить��6   6<   51      �� 52   
   $��2��6   $��0��53      $��Center=�54      $��Center=�55      .+�56      �� $3��-Количество факультетов: ��6   �� 57      -   5        $ RnCount��57      58      59      5:      5;      