   M S B A M L   `   `   `  ����@  <Lab11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab11Lab11  5   	       Lab11.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab11     5   	   X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f47toolkit)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  CRUD Application��5	   	   $	��350��6"   $	��525��6/    � 	Resources 5
       �� 
TargetType �� Property �� Value��%�  '��       �� 5   
   " ��6   .�5      ��  � ��$ 35��6'   �� 5       � ��$ 60��6&   �� 5       � ��$ 5,5,5,5q�5      �� 5       � ��$	 0.2q�5      �� 5       � ��
 �����5      �� 5       � ��
 � � �5      �� 5       � ��
 �����5      �� 5       � ��$ UltraCondensed&�5      �� 5       � ��$ Center=�5      5      5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   �� 5+      $��* �6    � RowDefinitions 5-   
   �� 5.      $��* �6   6)   �� 5/      $
��0.1* �6   6,   .+�51   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridInstance��52         AutoGenerateColumns .  	   CanUserAddRows	 .  
   CanUserDeleteRows
 .  $��Visible=�57      
�������$	��0.1q�59      $��0��5:      $��1��5;      $��0��5<      $��12��5=      ��53      ��  �� Path$ Teachers�   Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ Teacher name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5@   %   �� $ TeacherName�  5A      $ Teacher age��6%    5B   %   �� $ 
TeacherAge�  5C      $ Work experience��6%    5D   %   �� $ WorkExperience�4  .System.Windows.Controls.DataGridTemplateColumn  5E      $ Photo��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToCells 68      
IsReadOnly .    CellTemplate 5F      �� 5G      .R�5H      �� ��6$   �� $ TeacherPhoto�6K   5I      5K      5M      �� 5N   
   -   5        $	��Add��5N      $��1��5P      $��0��5Q      �� 5R   
   -   5         ��Name$ RemoveButton��5R      $��Remove��5T      $��1��5U      $��4��5V      5X      5Y      