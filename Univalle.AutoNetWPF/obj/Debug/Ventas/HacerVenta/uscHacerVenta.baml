   M S B A M L   `   `   `  ����N  JUnivalle.AutoNetWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Univalle.AutoNetWPF.Ventas.HacerVenta%Univalle.AutoNetWPF.Ventas.HacerVenta  5      9    3Univalle.AutoNetWPF.Ventas.HacerVenta.uscHacerVenta   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:Univalle.AutoNetWPF.Ventas.HacerVenta     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         MaterialDesignBody#���   5
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
Horizontal=�6)   .+�52   "   �� -   5         ��Name$ btnAñadirRepuestoLista��52   X   
��� � �$
��Left=�6=   $��	20,0,10,0q�6x   $��0q�6�   .��53   &   �� $��Center=�61   .+�54   *   �� $
��auto��65   $��Center=�6C   $ 
Horizontal=�6^   .+�56   .   �� $��Center=�68   $��Buscar Respuesto��6S   $��5q�6l   $
��auto��6w   58   +   5:   '   5=   #   �� 5?   "   -   5        $ btnListaVentas��5?   X   
��� � �$
��Left=�6=   $��	20,0,10,0q�6p   $��0q�6�   .��5@   &   �� $��Center=�61   .+�5A   *   �� $
��auto��65   $��Center=�6C   $ 
Horizontal=�6^   .+�5C   .   �� $��Center=�68   $��Lista Ventas��6S   $��5q�6h   $
��auto��6s   5E   +   5G   '   5J   #   �� 5L   "   $ 
Horizontal=�6-   $��Center=�6F   5i   #   5k      5m      � 5n      -   5         �Name$ gridMainParts��5n      $��20 90 20 20q�66    � ColumnDefinitions 5r       � RowDefinitions 5u      �� 5v   "   $
��auto �60   �� 5w   "   $��* �60   .+�5y      � $��25 10 20 10q�6#   $��0��68   .+�5z   "   �� -   5         ��Name$ txbTotalVentaBs��5z   ,   $ ��Total de la Venta: Bs 0.00��6E   $
��Bold"�6g   $��20(�6y   $��Calibri)�6�   5{      �� 5|      $��1��6+   $��Visible=�68   .��5}   "   � -   5        $ 	gridParts��5}   '   $	��Top=�6;   .+�5~   &   � $��
20,0,20,20q�60   $��Center=�6D   .+�5   *     -   5        $��dataGridProgram��5   c      AutoGenerateColumns .  
�������   SelectionMode$ Single=�6z   $��15(�6�      
IsReadOnly . $
��auto��6�   $	��700��6�      CanUserAddRows .  ��.    Columns 5�   .   0  *System.Windows.Controls.DataGridTextColumn  5�   2   ,  &System.Windows.Controls.DataGridColumn   Width5	  /System.Windows.Controls.DataGridLengthConverter$ *	 6F      Header$ Id��6Q      
Visibility$ 	Collapsed=�6�   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6^   ��  �� Path$ IdSpare�6�     5�   2   -   5        dtdd��$ *	 5�   S   $ Nombre Repuesto��6^    6x   �� $ NameProduct�  5�   2   $ *	 6F   $ Codigo��6Q    6b   �� $ ProductCode�  5�   2   $ *	 6F   $ Cantidad��6Q    6d   �� $ Quantity�  5�   2   $ *	 6E   $ Precio��6O    6_   �� $ 	BasePrice�  5�   2   $ *	 6E   $ Total��6O    6_   �� $ Total�4  .System.Windows.Controls.DataGridTemplateColumn  5�   2   $ +��6I   $
 auto	 6T      CellTemplate 5�   6   �� 5�   :   .R�5�   >   �� $��btnAñadirMas��6�   -   5         & "MaterialDesignToolForegroundButton#���  5�   F   $��50��6�   $��50��6�    K� ZIndex$ 0��6�   
��� � �.��5�   B   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ CartPlus=�6[   5�   ?   5�   ;   5�   3     5�   2   $ -��6I   $
 auto	 6T    5�   6   �� 5�   :   .R�5�   >   �� $��btnAñadirMenos��6�   -	   5        #���  5�   F   $��50��6�   $��50��6�   $ 0��6�   ���	#FFFFAE00.��5�   B     $ 	CartMinus=�6[   5�   ?   5�   ;   5�   3     5�   2   $ Eliminar��6I   $
 auto	 6[    5�   6   �� 5�   :   .R�5�   >   �� $��btnEliminar��6�   -
   5        #���  5�   F   $��50��6�   $��50��6�   $ 0��6�   
���  ��.��5�   B     $ Delete=�6[   5�   ?   5�   ;   5�   3   5�   +   5�   '   5�   #   5�      5�      5�      5�      )  #MaterialDesignThemes.Wpf.DialogHost  5�      -   5        $��DialogoHost1��5�   ,   $y�Hidden=�6@     MaterialDesignDivider#���  6T      DialogContent 5�      � 5�      .+�5�      �� $ 15��6%   $	��600��67   $	��400��6C   $��Center=�6P   
�������._�5�   "   � $��10q�6(    5�   &   �� 5�   *   �� 5�   *    5�   &   �� 5�   *   $
��auto �68   �� 5�   *   $��* �68   �� 5�   *   $
��auto �68   .+�5�   &   �� $��2��60   $��Center=�6D   $��Center=�6_   $��Añadir Repuestos��6|   �� 5�   &   -   5        $  btnCancelarAñdirProdcutos��5�   -   $��2��6P   $��Cancelar��6]   $��10q�6p   ���	#FFCD2F17��6|   Z� 6�   �� 5�   &   -   5        $! btnConfirmarAñadirProducto��5�   -   $��2��6Q   $��Añadir��6^   $��10q�6o   $��1��6{   ���	#FF1E700B��6�   Z� 6�   � 5�   &   $��1��6+   $��2��68   $��	10 5 10 5q�6L   .+�5�   *   �� -   5          ��Name$  lstProductos��5�   2   $��1q�6H   5�   +   5�   '   5�   #   5�      5�      5�        5�      -   5        $��DialogoHost2��5�   ,   $y�Hidden=�6@   #���  6T    5�      � 5�      .+�5�      �� $ 15��6!   $	��600��63   $	��600��6?   $��Center=�6L   
�������._�5�      � $��10q�6#    5�   "   �� 5�   &   �� 5�   &    5�   "   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   �� 5�   &   $
��auto �64   .+�5�   "   �� $��1��6,   $��10q�6@   $��17(�6L   $��Center=�6Z   $
��Left=�6u   $��Hacer Venta��6�   #  MaterialDesignThemes.Wpf.Card  5�   "   $y�Visible=�66   $��1��6K   !   UniformCornerRadius$! 15Q�6n   $��5q�6�   ��6X   Z� .��5�   &   �� .+�5�   *   �� -   5        " ��Name$" txtVentaPagoCliente��5�   P   $��5q�62   
���   �)  #MaterialDesignThemes.Wpf.HintAssist#   Hint$# Pago del cliente��6m    ! MaterialDesignOutlinedTextBox#��[ 6�   ���#F7F7F7��6�   Z� 6  5�   '   5�   #     5�   "   $y�Visible=�66   $��1��6K   $��1��6[   $! 15Q�6~   $��5q�6�   ��6h   Z� .��5�   &   �� .+�5�   *   �� -   5        $" txtVentaFechaDeVenta��5�   =   $��5q�62   $# Fecha de la venta��6\   #��[ 6�   ���#F7F7F7
���   ���6�   Z� 5�   '   5�   #   �� 5�   "   $��2��6,   $��2��69   $��25 10 25 10q�6M   � 5�   "   -   5        $ gridDataClient��5�   '   $y�Hidden=�6?   $��3��6T   $��2��6a   $��10 10 10 10q�6u   ���	#FF255DBF 5�   &   �� 5   *   $
��auto �6;   �� 5  *   �� 5  *   $
��auto �6;   .+�5  &   � $��0��6+   $��Center=�6;   $��10q�6V   .+�5  *     
�������$��30��6U   $��30��6`   $ J� Opacity$	$ 0.5Q�6l   $ AlertCircle=�6z   5  '   �� 5  &   $��1��61   $
��0 25q�6A   .+�5  *   �� 
�������$��5q�6H   $��Cliente Seleccionado��6S   �� 5	  *   -   5        $ txbVentaNit��5	  4   
�������$��5q�6\   $��1��6g   $��Nit: 12345678��6t   �� 5
  *   -   5        $ txbVentaNombre��5
  4   
�������$��5q�6_   $��2��6j   $��Nombre: Andy��6w   �� 5  *   -   5        $ txbVentaApellido��5  4   
�������$��5q�6a   $��2��6l   $��Apellido: Guzman��6y   5  '   �� 5  &   -   5        $��btnVentaEliminarCliente��5  �   $��2��6-   $	��Top=�6=   #���  6U   $��10q�6�   $ 0��6�   
��� � �.��5  *     $��30��6B   $��30��6M   $ Delete=�6Z   
�������6h   5  '   5  #   � 5  "   $��4��6'   $	��150��64   $��2��6A    5  &   �� 5  *   $
��auto �68   �� 5  *   $
��auto �68   .+�5  &   �� $ 
Horizontal=�61   $��Center=�6J   .+�5  .   � -   5        $ gridBuscador��5  3   .+�5  2   (  "MaterialDesignThemes.Wpf.ColorZone  $	��400��6K   %   Mode$% Standard=�6W   $��8 4 8 4q�6g   &   CornerRadius$& 2��6y   $ 1��6�   $��16 0 0 0q�6�   +  %MaterialDesignThemes.Wpf.ShadowAssist'   ShadowDepth$' Depth1=�6�   .��5  6   �  5  :   �� 5  >   $
��Auto �6P   �� 5  >   $��* �6P   �� 5   >   $
��Auto �6O   .+�5"  :   � $��Center=�6?   .+�5#  >     $ Search=�6W   $	$ .56Q�6e   5$  ;   �� 5%  :   -   5        $!" txtVentaNombreClienteBuscar��5%  B   $��1��6g   $��8 0 0 0q�6w   $# Buscar Ciente��6�   .  (MaterialDesignThemes.Wpf.TextFieldAssist(   DecorationVisibility$( Hidden=�6�   $��0q�6�   $	��200��6	  $��Center=�6  63  �� 5&  :   -   5        $��btnRegistrarCliente��5&  �   #���  6A   $��10 0 0 0q�6~   
����  �.��5'  >     $ 	PlusThick=�6W   5(  ;   5)  7   5*  3   5-  /   50  '   � 51  &   $��1��6+   .+�52  *   �� -   5        $  lstVentaListaClientes��52  >   $��25q�62   54  +   55  '   58  #   � 59  "   $��5��6'   $��2��64   $��25 10q�6H   .+�5:  &   �� $ Vertical=�61   $��Right=�6H   .+�5;  *   �� -   5        $ txbVentaTotal��5;  4   $��Total: Bs 0.00��6K   �� 5<  *   -   5        $ txbVentaPago��5<  4   $��Pago: Bs 0.00��6J   �� 5=  *   -   5        $ txbVentaCambio��5=  4   $��Cambio: Bs 0.00��6L   5>  '   5?  #   �� 5A  "   -   5        $ btnVentaCancelarVenta��5A  )   $��7��6H   $��Cancelar��6U   $��10q�6h   ���	#FFCD2F17��6t   Z� 6�   �� 5B  "   -   5        $ btnVentaTerminarVenta��5B  )   $��7��6H   $��Terminar Venta��6U   $��10q�6n   $��1��6z   ���	#FF1E700B��6�   Z� 6�   5C     5D     5F     5H     �� 5L      , (MaterialDesignFloatingActionAccentButton#���  6   $��Right=�6^   $��Bottom=�6z   $ 0��6�   $��
 0 0 50 50q�6�   ���	#FF221F9A���	#FF0D5C9D.��5M     '  !MaterialDesignThemes.Wpf.PopupBox  -    5        )   PlacementMode$) BottomAndAlignCentres=�5O     * ^� 	Placement$* Right=�5P     + � ToolTip$?+ 9PopupBox, Style MaterialDesignMultiFloatingActionPopupBox��5Q     ,   ToggleContent, 5T       5U     $ 	CheckBold=�66   
�������$��30��6Z   $��30��6e   -   PopupContent.- 5W     �� .+�5X     �� -!   5        $��btnAbrirPagVenta��5X  P   $&+  Hacer la venta con los Productos��6%   $��Hacer Venta��6h   6~   �� 5Y     -"   5        $��btnCancelarVenta��5Y  L   $	+ Two��6%   $��Cancelar Venta��63   6e   5[     5\     5]     5`     5a     '  !MaterialDesignThemes.Wpf.Snackbar  5b  
   -#   5        .  Name$. snackbarMessage��5b  L   ���	#FF175CC1$��	20 0 20 0q�69   /   IsActive/ .  $��Stretch=�6v   0   Message.0 5c     .  (MaterialDesignThemes.Wpf.SnackbarMessage  -$   5        $��
sBMMensaje��5c  -   
�������$&�� ¡Repuesto Modificado con exito!��6R   5d     5f     5g     