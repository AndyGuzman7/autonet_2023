   M S B A M L   `   `   `  ����N  JUnivalle.AutoNetWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Univalle.AutoNetWPF.Ventas.ListaVentas&Univalle.AutoNetWPF.Ventas.ListaVentas  5      ;    5Univalle.AutoNetWPF.Ventas.ListaVentas.uscListaVentas   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:Univalle.AutoNetWPF.Ventas.ListaVentas     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5           MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      $��Montserrat Regular)�5       � 	Resources 5        DataGridStyle1 �� 
TargetType&   System.Windows.Controls.DataGrid �� Property  ColumnHeaderStyle1 �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Triggers P� Property P� Value��%�  &	       &	 X     �� 5   
   "  6'   .�5      ��  �@ ColumnHeaderStyle# �  62   5      �� 5   
   	sssss��"  6:   .�5      ��  � ��$ 30��6'   �� 5       � ��
 ��ح�6+   �� 5       � ��
 ��  �6+   �� 5       � ��$ 18(�6)    5      P� 5       �@J�IsMouseOver . . �5      ��  �@�ToolTip$ Click to sort.��60   5      5!      5"      .��5#      � .+�5%   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase	   OpeningEffects	 5&      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5'      
   Kind$
 FadeIn=�62     5(      $
 SlideInFromBottom=�62   .��5*      � $
��auto��6   $
��auto��6!   .+�5+      ��  �� CornerRadius$ 15��6   
�������._�5,      � .+�50      � $��	0  10 0 0q�6    $��60��63   $	��top=�6?   ���#F7F7F7.+�51      ��  �� Orientation$ 
Horizontal=�6)   .+�52   "   �� -   5         ��Name$ btnHacerVenta��52   t   
��� � �$
��Left=�6=   $��20,0,10,0.4q�6�   $
��10 0q�6�   .��53   &   �� $��Center=�61   .+�54   *   �� $
��auto��65   $ 
Horizontal=�6C   .+�56   .   �� $��Center=�68   $��Hacer venta��6S   $��5q�6g   $
��auto��6r   58   +   5:   '   5=   #   �� 5?   "   $ 
Horizontal=�6-   $��Center=�6F   .+�5A   &   (  "MaterialDesignThemes.Wpf.ColorZone  $	��500��6?      Mode$ Standard=�6K   $��8 4 8 4q�6[      CornerRadius$ 2��6m    K� ZIndex$ 1��6~   $��16 0 0 0q�6�   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6�   .��5B   *   �  � ColumnDefinitions 5C   .   �� 5D   2   $
��Auto �6D   �� 5E   2   $��* �6D   �� 5F   2   $
��Auto �6C   .+�5H   .   � $��Center=�63   .+�5I   2   '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ Search=�6K    J� Opacity$	 .56Q�6Y   5J   /   �� 5K   .   -   5         ��Name$ txtNombreBuscar��5K   6   $��1��6O   $��8 0 0 0q�6_   )
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ Buscar Repuestos��6q   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�6�   $��0q�6�   $	��200��6�   $��Center=�6  6  5M   +   5N   '   �� 5O   &   -   5        $��	btnBuscar��5O   �    & "MaterialDesignToolForegroundButton#���  6-   $��8 0 0 0q�6j   $ 0��6|   .��5P   *   	  $
 Send=�6C   5Q   '   5R   #   5T      5V      � 5W      -   5         �Name$ gridMainParts��5W      $��20 90 20 20q�66   .+�5[      �� $��Hidden=�6+   .��5\   "   � -   5        $ 	gridParts��5\   '   $	��Top=�6;   .+�5]   &   � $��
20,0,20,20q�60   $��Center=�6D   .+�5^   *     -   5        $��dataGridProgram��5^   c      AutoGenerateColumns .  
�������   SelectionMode$ Single=�6z   $��15(�6�      
IsReadOnly . $
��auto��6�   $��0 0 0 50q�6�   $	��700��6�      CanUserAddRows .  ��.    Columns 5`   .   0  *System.Windows.Controls.DataGridTextColumn  5a   2   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6F      Header$ 
Id Cliente��6Q       
Visibility$  	Collapsed=�6�   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6f   �� " �� Path$" idSpare�6�     5c   2   -   5        dtdd��$ * 5c   S   $ 
Fecha/Hora��6^   ! 6s   �� $" DateSale�  5e   2   $ * 6E   $ Cliente��6O   ! 6`   �� $" 
NameClient�  5f   2   $ * 6E   $ Vendedor��6O   ! 6b   �� $" NameEmployee�  5g   2   $ * 6E   $ Total Venta��6O   ! 6e   �� $" Total�4  .System.Windows.Controls.DataGridTemplateColumn  5h   2   $ Eliminar��6I   #   CellTemplate# 5i   6   �� 5j   :   .R�5k   >   �� $��btnVistaProducto��6E   $��40��6]   $��Eliminar��6i   
���  ����6�   Z� 5l   ;   5n   3     5o   2   $ Editar��6I   # 5p   6   �� 5q   :   .R�5r   >   �� $��btnVistaProducto��6E   $��40��6]   $��Editar��6i   
����Zj���6�   Z� 5s   ;   5u   3     5x   2   $ Recibo��6I   # 5y   6   �� 5z   :   .R�5{   >   �� $��btnGenerarRecibo��6E   -	   5        $��40��5{   ]   $��Recibo��6i   
��� � ���6�   Z� 6�   5|   ;   5~   3   5�   +   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      