   M S B A M L   `   `   `  ����  PL(    "PL.EmployeesManager.SearchEmployee   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  SearchEmployee��5   	   $	��400��6    $	��600��6-   .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0.215Q�6-   � 5	      $ 	#FFC0D4FF��6   $ 1Q�61   5
      .+�5   
   ]� .+�5      �� $	��Top=�6    �� Orientation$ 
Horizontal=�6.   $	��Top=�6G    �� CanVerticallyScroll . $��RightToLeft=�6z   
�������.+�5      �� -   5        $��closeB��5      $��X��6'   $��Center=�63   $��Center=�6P   $��25��6k   
�������
����������	#FF1E99FF$
��Bold"�6�   6�   �� 5      -   5        $��
maximaizeB��5      $��Center=�6+   $��Center=�6H   $��25��6c   
�������
����������	#FF1E99FF$
��Bold"�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��22��6�   z�5      V� 5      .~�5      ��  �� ScaleY$ 1Q�6-   	 �� ScaleX$	 -1Q�68   �� 5      
 �� AngleY$
 0Q�6,    �� AngleX$ 0Q�67   �� 5       �� Angle$ 0Q�6.   T� 5      5      .��5      F� ������B ��`���[y@+|�����+|�������`�    `� �y<4`� �y<4!d�    !d��D���"!@    ��3    � ��    Q ����x��@� ��o���3o�Q�3��x��@�D���"!@��x��@	 �� Stretch$ Uniform=�5   )   ���	#FF1E99FF$��10��6L   $��0,0,0,0q�6W   6k   5      �� 5      -   5        $��
minimaizeB��5      $��_��6+   $��Center=�67   $��Center=�6T   $��25��6o   
�������
����������	#FF1E99FF$
��Bold"�6�   6�   5      �� 5      $��Center=�6   $��Center=�66   $	��517��6Q   $	��350��6]   .+�5      �� $��50��6   $ 
Horizontal=�6)   $��Center=�6B   .+�5       �� $
��Wrap=�6    $��Search Employee��64   $	��353��6K   $��0q�6W   $��Bottom=�6b   $��30(�6}    �� TextAlignment$ Center=�6�   $
��Bold"�6�   5"      � 5#      $	��291��6   .+�5$      �� -   5         ��Name$ 	searchtxt��5$      $
��Left=�61   $��25��6L    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��359��6�   $��	10,21,0,0q�6�   �� 5%      -   5        $��Search��5%      $��Center=�6.   $��Bottom=�6K   $	��124��6f   $��25��6r   $��374,0,19,245q�6~   6�   	� 5'      -   5        $��	byIDradio��5'   "   $��by ID��63    	� 	GroupName$ search��6C   $
��Left=�6W   $	��Top=�6r   $��
182,51,0,0q�6�   	� 5(      -   5        $��byLastNameradio��5(   "   $��By last name��69   $ search��6P   $
��Left=�6c   $	��Top=�6~   $��	86,51,0,0q�6�   	� 5)      -   5        $��byNameradio��5)   "   $��By name��65   $ search��6G    d� 	IsChecked$
 TrueY�6Z   $
��Left=�6k   $	��Top=�6�   $��	10,51,0,0q�6�   &   System.Windows.Controls.DataGrid  5*      -	   5        $��searchResult��5*      $��	0,94,0,10q�63      GridLinesVisibility$
 None=�6F   5-      5.      5/      51      52      