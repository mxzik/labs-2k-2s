   M S B A M L   `   `   `  ����>  :7-8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_7_8_7_8  5   	       _7_8.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:_7_8     5   	     � Title$  My Calendar��5   	      WindowStyle#���   6   $��396.4��6C   $��528.2��6R   $	��600��6`   $
��1000��6p    � Cursor$	 Pen��6�    � Icon$ logo.jpg��6�    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$ local:WindowCommands.Exit��5
      6=    � 	Resources 5       �� 
TargetType  
btTemplate �� CornerRadius  ShowAll �� 
TargetType	 �� Triggers
 ]� 
Conditions �� Property �� Value �� Property �� Value  MyStyle��%k  &	       '�� �     &	 �    �� 5   
   " ��6   .R�5      �� $ 25��6   
���""��$��2q�6?   
�������._�5      �� $��5q�6!   $��Center=�6,   $��Center=�6I   #���  6d   5      5      �� 5   
   " ��6   	 5      ]� 5      
 5      �� 5       �@J�IsMouseOver . 6;   �� 5       � �� . 69   /�5      �� 5       � ��$ 14(�65   �� 5       � ��
 �  ��67   5      5       �� 5"   
   �5#      �� 5$       � ��$ 20q�63   �� 5%       � ��$ Stretch=�6@   �� 5&       � ��$ Stretch=�6>   5(      5*      .��5+      � -   5         �Name$ BigGrid��5+       � ColumnDefinitions 5,   
   �� 5-      $��1* �6   �� 5.      $��2* �6   .+�50   
   � -   5        $ LeftGrid��50       � RowDefinitions 51      �� 52      �� 53      .+�55      � -   5        $ BottomLeftGrid��55      $��1��6+    56      �� 57      �� 58      �� 59      .+�5;      �� -   5         ��Name$ ShowAll��5;      #��[ 6*   #��[ 6Q   #���  6r   6�   �� 5<      -   5        $ SaveAll��5<      #��[ 6*   $��1��6K     SaveAll#���  6Y   6~   �� 5=      -   5        $ LoadAll��5=      #��[ 6*   $��2��6K     LoadAll#���  6Y   6~   5>      &   System.Windows.Controls.Calendar  5@      -   5          Name$ Calendar��5@   �    J� RenderTransformOrigin$ 0.5,0.5&�6M   $��Center=�6m   $	��Top=�6�   $��-20,40,-20,-20q�6�      DisplayDateStart$ 
2020-04-14X�6�   z�5A      V� 5B      .~�5C      ��  �� ScaleX$	 1.4Q�6)    �� ScaleY$	 1.4Q�66   5D      5F      5H      o� 5I   
   $	��Top=�6   $��25��6'   .@�5J      m� $��
Выход��6    m� Command$ local:WindowCommands.Exit��6&   5K      � 5L   
   -	   5        $ 	RightGrid��5L      $��1��6"    5M      �� 5N      $��4* �6$   �� 5O      $��6* �6$   .+�5R      �  5S      �� 5T      $��3* �6,   �� 5U      $��2* �6,   .+�5W      � -
   5        $ TopButtonGrid��5W      $��0��66    5X      �� 5Y   "   �� 5Z   "   �� 5[   "   .+�5]      �� -   5        $ AdditionalFunc��5]   %   #��[ 6>     AdditionalFunc#���  6_   $��0��6�   6�   �� 5^      -   5        $ 
Doneundone��5^   %   #��[ 69     
Doneundone#���  6Z   $��1��6�   6�   � 5_      $��2��6#    5`   "   �� 5a   &   �� 5b   &   .+�5d   "   o� $��
10,40,10,0q�6'   $��Stretch=�6;   $��Stretch=�6Y   .@�5e   &   m� -   5         m�Name$ menuLanguage��5e   /     menuLanguage#���  6F   5f   #   �� 5g   "   -   5         ��Name$ styleBox��5g   +   $��1��6=   $��10,20q�6J   5h      5j      � 5k      -   5        $ ButtonsGrid��5k      $��1��64    5l      �� 5m   "   �� 5n   "   �� 5o   "   �� 5p      .+�5r      �� -   5        $ 	AddButton��5r   W   $��0��6%   #��[ 65    	 	AddButton#��� 	 6j   6�   �� 5s      -   5        $ 
EditButton��5s   W   $��1��6%   #��[ 65    
 
EditButton#��� 
 6k   6�   �� 5t      -   5        $ DeleteButton��5t   W   $��2��6%   #��[ 65     DeleteButton#���  6m   6�   � 5u      $��3��6    5v      �� 5w      �� 5x      .+�5z      �� -   5        $��20q�5z   4   $
��Undo��6@   �� 5{      -   5        $��1��5{   !   $��20q�6D   $
��Redo��6P   5|      5}      5~      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ DayDataGrid��5�      $��1��64   $��10q�6A      AutoGenerateColumns .     CanUserAddRows .     Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�        	startTime,  &System.Windows.Controls.DataGridColumn   Header# �  6U       Width5  /System.Windows.Controls.DataGridLengthConverter$  60 6z   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 61   �� " �� Path$" 	startTime�6z     5�        endTime# �  6S   $  60 6v   ! 61   �� $" endTime�6v     5�        name# �  6P   $	  200 6p   ! 61   �� $
" name�6p     5�        category# �  6T   $	  100 6x   ! 61   �� $" category�6x     5�       
 status# �  6R   $	  100 6t   ! 61   �� $" status�6t     5�        priority# �  6T   $	  100 6x   ! 61   �� $" priority�6x     5�        description# �  6W   $  * 6~   ! 61   �� $" description�6~   5�      5�      5�      5�      