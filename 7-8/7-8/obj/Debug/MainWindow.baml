   M S B A M L   `   `   `  ����>  :7-8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_7_8_7_8  5   	   F Busercontrol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null>.clr-namespace:usercontrol;assembly=usercontrolusercontrol 5   	       _7_8.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:_7_8     5   	   Fusercontrol.clr-namespace:usercontrol;assembly=usercontrol     5   	     � Title$  My Calendar��5	   	      WindowStyle#���   6   $��396.4��6C   $��528.2��6R   $	��600��6`   $
��1000��6p    � Cursor$	 Pen��6�    � Icon$ logo.jpg��6�    � 	Resources 5       �� 
TargetType  
btTemplate �� CornerRadius  ShowAll �� 
TargetType �� Triggers ]� 
Conditions	 �� Property
 �� Value �� Property �� Value  MyStyle��%k  &	       '�� �     &	 �    �� 5   
   " ��6   .R�5      �� $ 25��6   
���""��$��2q�6?   
�������._�5      �� $��5q�6!   $��Center=�6,   $��Center=�6I   #���  6d   5      5      �� 5   
   " ��6    5      ]� 5       5      �� 5      	 �@J�IsMouseOver
 . 6;   �� 5      	 � ��
 . 69   /�5      �� 5       � ��$ 14(�65   �� 5       � ��
 �  ��67   5      5      �� 5    
   �5!      �� 5"       � ��$ 20q�63   �� 5#       � ��$ Stretch=�6@   �� 5$       � ��$ Stretch=�6>   5&      5(      .��5)      � -   5         �Name$ BigGrid��5)       � ColumnDefinitions 5*   
   �� 5+      $
��331* �6   �� 5,      $
��500* �6   �� 5-      $
��161* �6   .+�5/   
   � -   5        $ LeftGrid��5/       � RowDefinitions 50      �� 51      �� 52      .+�54      � -   5        $ BottomLeftGrid��54      $��1��6+    55      �� 56      �� 57      �� 58      .+�5:      �� -   5         ��Name$ ShowAll��5:      #��[ 6*   #��[ 6Q   #���  6r   6�   �� 5;      -   5        $ SaveAll��5;      #��[ 6*   $��1��6K     SaveAll#���  6Y   6~   �� 5<      -   5        $ LoadAll��5<      #��[ 6*   $��2��6K     LoadAll#���  6Y   6~   5=      &   System.Windows.Controls.Calendar  5?      -   5          Name$ Calendar��5?   �    J� RenderTransformOrigin$ 0.5,0.5&�6M   $��Center=�6m   $	��Top=�6�   $��-20,40,-20,-20q�6�      DisplayDateStart$ 
2020-04-14X�6�   z�5@      V� 5A      .~�5B      ��  �� ScaleX$	 1.4Q�6)    �� ScaleY$	 1.4Q�66   5C      5E      5G      � 5I   
   .+�5J        usercontrol.UserControl1  $��94,242,76,271q�6'   $ 0.5,0.5&�6>   6`   5K      � 5M   
   -   5        $ 	RightGrid��5M      $��1��6"   $��2��62    5N      �� 5O      $��4* �6    �� 5P      $��6* �6    .+�5S      �  5T      �� 5U      $��3* �6$   �� 5V      $��2* �6$   .+�5X      � -	   5        $ TopButtonGrid��5X      $��0��6.    5Y      �� 5Z      �� 5[      �� 5\      .+�5^      �� -
   5        $ AdditionalFunc��5^      #��[ 66     AdditionalFunc#���  6W   $��0��6�   6�   �� 5_      -   5        $ 
Doneundone��5_      #��[ 61     
Doneundone#���  6R   $��1��6y   6�   � 5`      $��2��6    5a      �� 5b      �� 5c      .+�5e      o� $��10,20q�6   $��Stretch=�6.   $��Stretch=�6L   .@�5f      m� -   5         m�Name$ menuLanguage��5f   '     menuLanguage#���  6>   5g      �� 5h      -   5         ��Name$ styleBox��5h   #   $��1��65   $��10,20q�6B   5i      5k      � 5l      -   5        $ ButtonsGrid��5l      $��1��6,    5m      �� 5n      �� 5o      �� 5p      �� 5q      .+�5s      �� -   5        $ 	AddButton��5s   O   $��0��6   #��[ 6-    	 	AddButton#��� 	 6b   6�   �� 5t      -   5        $ 
EditButton��5t   O   $��1��6   #��[ 6-    
 
EditButton#��� 
 6c   6�   �� 5u      -   5        $ DeleteButton��5u   O   $��2��6   #��[ 6-     DeleteButton#���  6e   6�   � 5v      $��3��6    5w      �� 5x      �� 5y      .+�5{      �� -   5        $��20q�5{   4   $
��Undo��6@   �� 5|      -   5        $��1��5|   !   $��20q�6D   $
��Redo��6P   5}      5~      5      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ DayDataGrid��5�      $��1��6,   $��10q�69      AutoGenerateColumns .     CanUserAddRows .     Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�        	startTime,  &System.Windows.Controls.DataGridColumn   Header# �  6M      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6r   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ��  �� Path$ 	startTime�6r     5�        endTime# �  6K   $ 60 6n    6)   �� $ endTime�6n     5�        name# �  6H   $	 200 6h    6)   �� $
 name�6h     5�        category# �  6L   $	 100 6p    6)   �� $ category�6p     5�       
 status# �  6J   $	 100 6l    6)   �� $ status�6l     5�        priority# �  6L   $	 100 6p    6)   �� $ priority�6p     5�        description# �  6O   $ * 6v    6)   �� $ description�6v   5�      5�      5�      5�      