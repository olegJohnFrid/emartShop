   M S B A M L   `   `   `  ����  PL!    PL.Employees.SearchEmployee   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  SearchEmployee��5   	   $��459.702��6    $��626.866��61    � WindowStartupLocation$ CenterScreen=�6A   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0.215Q�6-   � 5	      $ 	#FFC0D4FF��6   $ 1Q�61   5
      .+�5   
   ]� .+�5      �� $��Center=�6   $��Center=�66   $	��517��6Q   $	��350��6]   .+�5      �� $��50��6    �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5      �� $
��Wrap=�6    $��Search Employee��64   $	��353��6K   $��0q�6W   $��Bottom=�6b   $��30(�6}    �� TextAlignment$ Center=�6�   $
��Bold"�6�   5      � 5      $	��315��6   .+�5      �� -   5         ��Name$ 	searchtxt��5      $
��Left=�61   $��25��6L   	 �� TextWrapping$
	 Wrap=�6Y   $	��Top=�6m   $	��359��6�   $��	10,21,0,0q�6�   �� 5      -   5        $��Search��5      $��Center=�6.   $��Bottom=�6K   $	��124��6f   $��25��6r   $��374,0,19,245q�6~   6�   	� 5      -   5        $��	byIDradio��5   "   $��by ID��63   
 	� 	GroupName$
 search��6C   $
��Left=�6W   $	��Top=�6r   $��
182,51,0,0q�6�   	� 5      -   5        $��byLastNameradio��5   "   $��By last name��69   $
 search��6P   $
��Left=�6c   $	��Top=�6~   $��	86,51,0,0q�6�   	� 5      -   5        $��byNameradio��5   "   $��By name��65   $
 search��6G    d� 	IsChecked$
 TrueY�6Z   $
��Left=�6k   $	��Top=�6�   $��	10,51,0,0q�6�   &   System.Windows.Controls.DataGrid  5      -   5        $��searchResult��5      $��
0,120,0,10q�63      GridLinesVisibility$
 None=�6G   �� 5      -   5        $��Show All��5      $
��Left=�60   $��22��6K   $��0,93,0,0q�6W   $	��Top=�6i   $	��130��6�   6�   �� 5      -   5        $
��Edit��5      $
��Left=�6,   $��22��6G   $��
387,93,0,0q�6S   $	��Top=�6g   $	��130��6   6�   5       5!      5"      5$      5%      