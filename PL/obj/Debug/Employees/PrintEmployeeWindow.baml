   M S B A M L   `   `   `  ����  PL&     PL.Employees.PrintEmployeeWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  EmployeePrintWindow��5   	   $	��400��6%   $	��600��62    � WindowStyle$ SingleBorderWindow=�6>   .��5      � .+�5   
   ]� -   5        $
��dock��5      ��.  .+�5      �� $	��Top=�6    �� Orientation$ 
Horizontal=�6.   $	��Top=�6G    �� CanVerticallyScroll . $��RightToLeft=�6z   
�������.+�5      �� -   5        $��closeB��5      $��X��6'   $��Center=�63   $��Center=�6P   $��25��6k   
�������
����������	#FF1E99FF$
��Bold"�6�   6�   �� 5	      -   5        $��
maximaizeB��5	      $��Center=�6+   $��Center=�6H   $��25��6c   
�������
����������	#FF1E99FF$
��Bold"�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��22��6�   z�5
      V� 5      .~�5      ��  �� ScaleY$ 1Q�6-    �� ScaleX$ -1Q�68   �� 5       �� AngleY$ 0Q�6,    �� AngleX$ 0Q�67   �� 5      	 �� Angle$	 0Q�6.   T� 5      5      .��5      F� ������B ��`���[y@+|�����+|�������`�    `� �y<4`� �y<4!d�    !d��D���"!@    ��3    � ��    Q ����x��@� ��o���3o�Q�3��x��@�D���"!@��x��@	
 �� Stretch$
 Uniform=�5   )   ���	#FF1E99FF$��10��6L   $��0,0,0,0q�6W   6k   5      �� 5      -   5        $��
minimaizeB��5      $��_��6+   $��Center=�67   $��Center=�6T   $��25��6o   
�������
����������	#FF1E99FF$
��Bold"�6�   6�   5      &   System.Windows.Controls.DataGrid  5      -   5        $��dataGrid��5      $	��Top=�6'   
����������	#FF00B9FF$��1q�6h      HorizontalGridLinesBrush �	#FF00B9FF   VerticalGridLinesBrush �	#FF00B9FF$ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   $��Center=�6�   $��Center=�6  $��0,20,0,0q�6!  �� 5      $	��Top=�6   .+�5      �� -   5        $��refreshButton��5      $��26��6.   $	��100��6:   $��Refresh��6F   $��Center=�6X   $��0,20,0,0q�6u   6�   5      5      5      5      