   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=0.13.1.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    WeddingPlanner   WeddingPlanner.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Wedding Planner��5   	   $��428.947��6!   $��646.053��62   (   "MahApps.Metro.Controls.MetroWindow   ShowIconOnTitleBar .    SaveWindowPosition .  � WindowStartupLocation$ CenterScreen=�6v    � Icon$ Images/cake.ico��6�   $��1q�6�   ���	#FF5140FF   RightWindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� .��5	      ��  �� Orientation$ 
Horizontal=�6   .+�5
      �� $��30��6   $��30��6'   $��Images/rimi.png��63   $��UniformToFill=�6L   �� 5      $��4 0 0 0q�6    $��Center=�5      $��Ridma��5      5      5      �� 5      .��5      �� $ 
Horizontal=�6   .+�5      �� $��30��6   $��30��6'   $��Images/shehan.jpg��63   $��UniformToFill=�6N   �� 5      $��4 0 0 0q�6    $��Center=�5      $��Shehan��5      5      5      5      .��5      � -   5         �Name$ 
LayoutRoot��5      .+�5   
   �� $��10q�6   .@�5      �� $��	Dashboard��6   .��5      � 
�������5       5!      �� 5"      $��Expenses��6   .��5#      � 
�������.+�5$      �� $��Total Cost :��6   $��	0,0,188,0q�63   $��14(�6F   $
��Bold"�6T   $��31��6f   $��Bottom=�6r   $��Right=�6�   $��84��6�   &   System.Windows.Controls.DataGrid  5%         AutoGenerateColumns .  $��
10,0,10,36q�6;      AzureDataGrid#��[  6�   ��6O   �� 	 �� Path$	 ExpensesList�
 �� Mode$
 TwoWay=�   Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$
 Item��6~      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� $
	 Item�$
 TwoWay=�   ClipboardContentBinding 6[   Z� 6�   8   2MahApps.Metro.Controls.DataGridNumericUpDownColumn  5(      $ Amount��6o   $ * 6      Minimum$ 0Q�6�      StringFormat$ C��6�    6C   �� $	 Amount�$
 TwoWay=�6�     5)      $ Notes��6   $ * 6�    61   �� $	 Notes�$
 TwoWay=� 6\   Z� 6�   5+      �� 5,       �� 
IsReadOnly . $��23��60   $��0,0,3,2q�6<    �� TextWrapping$
 Wrap=�6M   $��Bottom=�6a   $��Right=�6|   $	��185��6�   5-      5.      �� 5/      $��Guests��6   .��50      � 
�������.+�51        $��10,46,10,36q�6    52        53      $ * 61   $
 Name��6q    6;   Z�  6N   Z� 6q     54      $ 70 61   $ Gender��6r    6<   Z�  6O   Z� 6r   4	  .System.Windows.Controls.DataGridCheckBoxColumn	  55      $ 80 65   $ Wedding��6v    6@   Z�  6S   Z� 6v   	  56      $ 80 65   $ HComing��6v    6@   Z�  6S   Z� 6v     57      $ 90 61   $ 	Telephone��6r    6<   Z�  6O   Z� 6r   59      �� 5:      $��Side :��6   $
��Left=�6-   $��	15,10,0,0q�6H   $	��Top=�6[   $��48��6s   �� 5;      $
��Left=�6S   $��	57,10,0,0q�6n   $	��Top=�6�   $	��229��6�   ��6   �� $	 	SidesList�$
 OneTime=�6�   5<      5=      �� 5>      $��Reports��6   .��5?      � 
�������5@      5A      5B      )
   #MahApps.Metro.Controls.ProgressRing
  5C   
    
  IsActive . 6    5D      5E      