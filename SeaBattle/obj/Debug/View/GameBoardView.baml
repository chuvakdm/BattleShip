   M S B A M L   `   `   `  ����D  @SeaBattle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SeaBattle.ViewSeaBattle.View  5   	   "    SeaBattle.View.GameBoardView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SeaBattle.View     5   	     � Title$  GameBoardView��5   	   $	��450��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ GridBot��5      $��
5,14,20,10q�6I   $��0��6]   $��2��6j   ��6(   �� *
CellsBot+��5      �� 5      .R�5      A�  A� Columns$ 10��6"   5      ��5      �� 5      .R�5      �� 
���   �$��1q�61   ._�5      �� ��6!   �� *DataContext.ClickCellCommand+ �� RelativeSource ��  �� AncestorType$ ItemsControlL���6�   �� ��6�   �� *ButtonContent+5      5      5      �� 5   
   -   5        $ GridUser��5      $��
10,19,15,5q�6K   ��6)   �� *	CellsUser+��5       �� 5!      .R�5"      A� $ 10��6"   5#      ��5%      �� 5&      .R�5'      �� 
���   �$��1q�61   ._�5(      �� ��6"   �� *ButtonContent+5)      5*      5,      5-      52      