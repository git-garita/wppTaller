   M S B A M L   `   `   `  ����E  Awpp_Taller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:wpp_Taller.UserControlwpp_Taller.UserControl  5      )    #wpp_Taller.UserControl.ucCarPending   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:wpp_Taller.UserControl     5      .��5	      � ���	#FFD0D0D0.+�5
   
   &   System.Windows.Controls.DataGrid  $��0,96,0,0q�6   
�������
���   �    Columns  5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Marca��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 64     5      $ Modelo��6%   $	 100 65     5      $ Detalles��6%   $
  120 67     5      $ Reparación��6%   $	 180 69     5      $ Fecha Ingreso��6%   $	 100 6<     5      $ Estado��6%     5      $ Cliente��6%   $	 100 66     5      $ Retirar��6%   $ 50 66   5      �� 5   
   $��Vehículos Pendientes��6   $
��Left=�6/   $��	10,20,0,0q�6J   $	��Top=�6]   $��60��6u   $	��400��6�   ���	#FFC50000$��35(�6�   ���	#00000000$
��Bold"�6�   �� 5   
   -   5         ��Name$ 	btnAddCar��5   b    � Cursor$
 Hand��6   $��	0,20,82,0q�6u   $��50��6�   $��50��6�   $	��Top=�6�   $��Right=�6�   ��6   Z� ��65   Z� ��6L   Z� ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value �	#FF17151563    �� Triggers 5      P� 5      	 P� Property	 �@J�IsMouseOver
 P� Value
 . . �5      ��  � �� �	#FF2924236;   5      5       ��5"      �� 5#       �� 
TargetType" ��6"   .R�5$      �� $��40��6   $��40��6(    �� CornerRadius$ 9��5%      #��z��5&      ._�5'      �� $��Center=�6+   $��Center=�5(      5)      5*      .��5,      �� $��/Images/add.png��6   $��40��6-   $��40��69   5-      5.      5/      