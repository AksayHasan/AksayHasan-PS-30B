   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseReport   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - View Expense��5   	   $	��450��6*   $	��800��67   .��5	      � ��5
   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��0��6    $��Right=�6-   $��	0,10,30,0q�6I   $��30(�6\   $
��Bold"�6j   
����  �.��6�   Expense Report For:6�   � 5   
   $��1��6   $��1��6   $��0,0,0,33q�6,   $��2��6>    5      �� 5      6%   �� 5      6%    5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5       $
��Auto �6    60   .+�5"      �� $��0��6   $��0��6$   $��20(�61   $
��Bold"�6?   .��6Q   Name:6X   �� 5#      $��1��6   $��0��6$   ��61   ��  �� Path$
 Name�6Q   �� 5$      $��0��6   $��1��6$   $��20(�61   $
��Bold"�6?   .��6Q   Department:6^   �� 5%      $��1��6   $��1��6$   ��61   �� $ 
Department�6W   �� 5&      $��0��6   $��2��6$   $��20(�61   $
��Bold"�6?   .��6Q   Expense Type:6`   &   System.Windows.Controls.DataGrid  5'      $��1��6   $��1��6'      AutoGenerateColumns$ False��6Z      RowHeaderWidth$ 0Q�6v   $��0,36,53,-71q�6�   $��2��6�    J� RenderTransformOrigin$ 0.208,1.358&�6�   ��64   �� $ Expenses�   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ExpenseType��6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6>   �� $ ExpenseType�  5*      $	 Amount��6)   
 69   �� $ ExpenseAmount�5,      5-      5.      5/      