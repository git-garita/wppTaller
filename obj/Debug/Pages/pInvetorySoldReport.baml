   M S B A M L   `   `   `  ����E  Awpp_Taller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:wpp_Taller.Pageswpp_Taller.Pages  5      *    $wpp_Taller.Pages.pInvetorySoldReport   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:wpp_Taller.Pages     5        N� Title$  pInvetorySoldReport��5	      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0.023Q�6-   � 5      $ Black��6   $
 0.21Q�6-   � 5      $ 	#FFE0DEDE��6   $ 0.136Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtgInventory��5      $��
6,156,14,6q�6)   
�������   AutoGenerateColumns . $   HorizontalScrollBarVisibility$ Hidden=�6k      CanUserAddRows .  
���   �$��16(�6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
  Repuesto��6H      Width5  /System.Windows.Controls.DataGridLengthConverter$	 170 6\      MinWidth$	 170Q�6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *nombreRepuesto+6h     5      $
   Fecha Venta��6F   $	 151 6]   $	 151Q�6i    6%   �� *fechaDeVenta+6i     5      $
   Marca Auto��6C   $	 140 6Y   $	 140Q�6e    6%   �� *	marcaAuto+6e     5      $
   Modelo Auto��6D   $	 140 6[   $	 140Q�6g    6%   �� *
modeloAuto+6g     5      $
   Otros��6?   $	 190 6P   $	 190Q�6\    6%   �� *otros+6\     5      $
   Precio Total��6G   $	 120 6_   $	 120Q�6k    6%   �� *precioColones+6k     5      $
 
  Unidades��6B   $ 90 6V   $ 90Q�6a    6%   �� *
unidades+6a      ColumnHeaderStyle 5      �� 5        �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5!      ��  �� Property � �� �� Value$ Center=�6A   �� 5"       � ��
 �  ��63   �� 5#       � ��
 �����63   �� 5$       � ��$ 40��6/   �� 5%       � ��$ 17(�61   5'       � 	Resources 5)      *  $System.Windows.Controls.DataGridCell��%+   '        �� 5*      "  6   5+      5,         	CellStyle 5-      �� 5.      "  6   .�5/      ��  � ��$ Center=�6A   50      52      �� 53   
   $��INVENTARIO VENDIDO��6   $��Center=�6-   $��0,19,0,0q�6J   $	��Top=�6\   $��Center=�6t   $��80��6�   $	��720��6�   
���   �$��55(�6�   ���	#00000000$
��Bold"�6�   $��
Lucida Fax)�6�   �� 54   
   $
��Left=�6   $	��612��6/   $��	5,156,0,0q�6<   
���   �$	��Top=�6^   $��9��6v   
���   �6�   56      57      