   M S B A M L   `   `   `  ����>  :7-8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_7_8_7_8  5   	   )clr-namespace:_7_8.entity_7_8.entity  5   	       _7_8.AddWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:_7_8     5   	   ,entityclr-namespace:_7_8.entity     5   	      Title_AddWindow  � Title#  �   5	   	   $	��350��63   $	��485��6C   $	��350��6R   $	��485��6_    � 	Resources 5
       �� 
TargetType �� Property �� Value �� Triggers ]� 
Conditions �� Property �� Value	 :� RoutedEvent
 g� Duration �� TargetProperty	 W� To �� Binding �� ElementName �� Path �� Value��%�  '	�       '�� x    �� 5   
   " 	�6   �5      �� 5       � ��
 �   �6?    5      ]� 5       5      �� 5       �@d�	IsChecked$
 trueY�69   �� 5       �@J�IsMouseOver . 6;   /�5      �� 5       � ��
 �  ��6E   5      :� 5      $	 Checked��6   [�5      �� 5      .��5      �� .��5   "   W� $
 	0:0:0.300D�62   $ FontSize�6G   $ 14X�6l   5       5!      5#      :� 5$      $	 	Unchecked��6   [�5%      �� 5&      .��5'      �� .��5(   "   W� $
 	0:0:0.300D�62   $ FontSize�6G   $ 12X�6l   5)      5*      5,      5/      �� 50   
   " ��6    51      �� 52       6   �� $ AboutTextBox��$
 Text�  6V   .a�53      ��  � {� .  62   54      �� 55       6   �� $ NameTextBox��$
 Text�  6U   .a�56      ��  � {� .  62   57      5:      5;      .��5<      � $��0q�6    � ColumnDefinitions 5=   
   �� 5>      �� 5?      �� 5@       � RowDefinitions 5B   
   �� 5C      �� 5D      �� 5E      .+�5G   
   �� -   5         ��Name$ GBName��5G       
 GBName#���  6#   $��Stretch=�6E   $
��auto��6c   $��10q�6q   $��Stretch=�6}   $
��auto��6�   .��5H      �� -   5         ��Name$ NameTextBox��5H   C    �� 	IsEnabled .  � Language$ ru-ru�62   $��Stretch=�6X   $��60��6v   $	��100��6�   $
��auto��6�   $��0q�6�    �� TextWrapping$
 Wrap=�6�   $��Stretch=�6�   $
��auto��6�   5I      �� 5J   
   -   5        $ GBStartDate��5J        GBStartDate#���  6(   $��Stretch=�6O   $
��auto��6m   $��10q�6{   $��1��6�   $��Stretch=�6�   $
��auto��6�   .��5K      (  "System.Windows.Controls.DatePicker  -   5          Name$ StartCalendar��5K         SelectedDateFormat$ Short=�60      IsDropDownOpen .  $��Stretch=�6�   $��10,9,10,10.8q�6�   $��Stretch=�6�   $
��auto��6�   $
��auto��6�   5L      �� 5M   
   -   5        $ 	GBEndDate��5M        	GBEndDate#���  6&   $��Stretch=�6K   $
��auto��6i   $��10q�6w   $��2��6�   $��Stretch=�6�   $
��auto��6�   .��5N        -   5        $ EndCalendar��5N      $ Short=�6.    .  $��Stretch=�6�   $��10q�6�   $��Stretch=�6�   $
��auto��6�   $
��auto��6�   5O      �� 5P   
   -   5        $ GBPeriod��5P        GBPeriod#���  6%   $��Stretch=�6I   $
��auto��6g   $��10q�6u   $��0��6�   $��1��6�   $��Stretch=�6�   $
��auto��6�   .��5Q      �� -   5        .+�5R      	� -	   5         	�Name$ Single��5R   /    d� 	IsChecked$
 TrueY�6    
 Single#���  6?   	� 5S      -
   5        $ 	EveryWeek��5S        	EveryWeek#���  61   	� 5T      -   5        $ 
EveryMonth��5T        
EveryMonth#���  62   	� 5U      -   5        $ 	EveryYear��5U        	EveryYear#���  61   5V      5W      �� 5X   
   -   5        $ GBStatus��5X       	 GBStatus#��� 	 6%   $��Stretch=�6I   $
��auto��6g   $��10q�6u   $��1��6�   $��1��6�   $��Stretch=�6�   $
��auto��6�   .��5Y      �� -   5        .+�5Z      	� -   5        $	 Low��5Z       
 Low#��� 
 6+   	� 5[      -   5        $ Middle��5[   /   $
 TrueY�6    
 Middle#���  6?   	� 5\      -   5        $
 High��5\        High#���  6,   5]      5^      �� 5_   
   -   5        $ GBAbout��5_        GBAbout#���  6$   $��Stretch=�6G   $��1��6e   $��2��6u   $
��auto��6�   $��10q�6�   $��Stretch=�6�   $
��auto��6�   .��5`      �� -   5        $ AboutTextBox��5`   C    . $ ru-ru�62   $��Stretch=�6Y   $��60��6w   $	��100��6�   $
��auto��6�   $��0q�6�   $
 Wrap=�6�   $��Stretch=�6�   $
��auto��6�   5a      �� 5b   
   -   5        $ 
GBCategory��5b        
GBCategory#���  6'   $��Stretch=�6M   $��2��6k   $��0��6{   $��2��6�   $
��auto��6�   $��10q�6�   $��Stretch=�6�   $
��auto��6�   .��5c      �� -   5        .+�5d      	� -   5        $
 Home��5d   /   $
 TrueY�6   $��20��6=     Home#���  6L   	� 5e      -   5        $
 Work��5e      $��20��6,     Work#���  6;   	� 5f      -   5        $ Study��5f      $��20��6-    	 Study#���  6<   	� 5g      -   5        $ Cources��5g      $��20��6/     Cources#���  6>   	� 5h      -   5        $ Family��5h      $��20��6.    
 Family#���  6=   	� 5i      -   5        $
 Rest��5i      $��20��6,     Rest#���  6;   5j      5k      �� 5l   
   -   5         ��Name$ 	AddButton��5l        	AddButton#���  6$   $��2��6J   $��20q�6Z   $��2��6f   $
��auto��6s   6�   5m      5n      