   M S B A M L   `   `   `  ����E  Awpp_Taller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:wpp_Taller.Pageswpp_Taller.Pages  5      #    wpp_Taller.Pages.pViewReports   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:wpp_Taller.Pages     5        N� Title$  pViewReports��5	      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0.023Q�6-   � 5      $ Black��6   $
 0.21Q�6-   � 5      $ 	#FFE0DEDE��6   $ 0.136Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtgCarsRepared��5      $��
3,157,7,10q�6+   
�������$   HorizontalScrollBarVisibility$ Hidden=�6R   
���   �$��14(�6�      AutoGenerateColumns .    CanUserAddRows .  $
��1013��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
  Marca��6?      Width5  /System.Windows.Controls.DataGridLengthConverter$ 95 6O      MinWidth$ 95Q�6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *marca+6Z     5      $
   Modelo��6@   $ 95 6R   $ 95Q�6]    6%   �� *modelo+6]     5      $
   Reparaciones��6Q   $	 229 6i   $	 229Q�6u    6%   �� *reparacionesRealizadas1+6u     5      $
   Fecha Ingreso��6H   $	 181 6a   $	 176Q�6m    6%   �� *fechaDeIngreso+6m     5      $
   Fecha Salida��6G   $	 181 6_   $	 175Q�6k    6%   �� *fechaDeRetiro+6k     5      $
 	  Cliente��6A   $	 140 6T   $	 150Q�6`    6%   �� *	Cliente+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 
  Detalles��6)   $ 80 6=   $ 80Q�6H      CellTemplate 5      �� 5      .R�5      ��  ��Name$ 
btnDetails��6�   -   5         � Cursor$
 Hand��5   %   $��Bottom=�6I   $��35��6�   $��35��6�   ��63   Z� ��6d   Z� ��6{   Z� ��5    "   �� 5!   &    �� 
TargetType" ��6,   .�5"   *   ��  �� Property � �� �� Value �	#FF1715156G    �� Triggers 5#   *   P� 5$   .    P� Property �@J�IsMouseOver P� Value . . �5%   2   ��  � �� �	#FF2924236O   5&   /   5(   '   ��5*   "   �� 5+   &    �� 
TargetType" ��66   .R�5,   *   �� $��25��61   $��25��6<   #��z��5-   -   ._�5.   .   �� $��Center=�6?   $��Center=�5/   1   50   +   51   '   .��53   "   �� $��/Images/add.png��6(   $��25��6A   $��25��6L   54      55      57         ColumnHeaderStyle 59      �� 5:      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5;      ��  � ��$ Center=�6A   �� 5<       � ��
 �  ��63   �� 5=       � ��
 �����63   �� 5>       � ��$ 40��6/   �� 5?       � ��$ 17(�61   5A      5C      �� 5D   
   $��VEHÍCULOS REPARADOS��6   $��Center=�6.   $��0,19,0,0q�6K   $	��Top=�6]   $��Center=�6u   $��80��6�   $	��852��6�   
���   �$��55(�6�   ���	#00000000$
��Bold"�6�   $��
Lucida Fax)�6�   �� 5E   
   $
��Left=�6   $	��611��6/   $��
-1,157,0,0q�6<   
���   �$	��Top=�6_   $	��7.3��6w   
���   �6�   �� 5F   
   $
��Left=�6   $	��606��6/   $��	4,155,0,0q�6<   
���   �$	��Top=�6^   $��8��6v   
���   �6�   5H      5I      