   M S B A M L   `   `   `  ����N  JUnivalle.AutoNetWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Univalle.AutoNetWPFUnivalle.AutoNetWPF  5   	   $    Univalle.AutoNetWPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Univalle.AutoNetWPF     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5      $��Montserrat Regular)�5      
���   � � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�6!    � 	Resources 5        cmButton��%�   &	       �� 5   
   .@�5      m� $��Menu item 1��6   m� 5      $��Menu item 2��6   �� 5      m� 5      $��Menu item 3��6   5      5      .��54      � ���#E6E6E8.+�56   
   � -   5         �Name$ gridNav��56      $	��100��6!   $	��Top=�6.   
�������.+�57      � $	��100��6    � RowDefinitions 58      �� 59      $��50 �6$   �� 5:      $��50 �6$   .+�5<      � $��1��6   ��5=      �� 5>       �� ImageSource$! /HomeAdmin/image/fondo3.jpg��6%   	 j� Stretch$	 UniformToFill=�6O   .+�5@      � .+�5A      � ���#1E2E3B
 J� Opacity$	
 0.7Q�64   5C      �� 5D      .+�5F      �� $�� 5 5 5 5q�6(   � 5G      $
��15 0q�6#   $��0��61   .+�5H   "   �� -   5         ��Name$ txbNamePage��5H   ,    $  MaterialDesignHeadline5TextBlock#��[ 6B   $�� ��6|   
�������5J   #   5K      5L      5M      5R      � 5U      $��0��6   $��50��6$   .+�5W      �� $
��Left=�6"    �� Orientation$ 
Horizontal=�6=   .+�5Y   "   �� -   5         ��Name$ 	gridFondo��5Y   @   
�������$ 
Horizontal=�6S   .+�5Z   &   �� $��5q�6-   $3��-/PrincipalAdmin/image/logo2Recurso 10logo.png��68   $
��auto��6o   $
��auto��6|   �� 5[   &   $8��2/PrincipalAdmin/image/logo2Recurso 11logoletra.png��6,   $	��100��6h   $��0 0 10 0q�6t   5\   #   � 5^      $��50��6   .+�5`      �� -   5         ��Name$ 
btnInicioL��5`   %   $��50��69   $��Center=�6G   $��0q�6�   $��0q�6�   ��6b   Z� ��6z   Z� .��5b   "   �� $ Vertical=�6-   $��10q�6D   .+�5c   &   �� $
��auto��61   $ 
Horizontal=�6?   .+�5d   *   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 home=�6B   $��0 5 15 5q�6N   
���   �6a   �� 5e   *   -   5        $ txbIncio��5e   4   $��Center=�6F   $��Incio��6a   
���   �$��5q�6�   $
��auto��6�   5f   '   � 5g   &   -   5        $ gridM1��5g   +   $��	10 0 10 5q�6;   ���	#FF6F8190$��2��6e   $y�	Collapsed=�6p   5h   #   5k      5l      � 5n      .+�5p      �� -   5        $ btnEmpleados��5p   %   $��50��6;   $��Bottom=�6I   $��0q�6�   ��6e   Z� ��6{   Z� .��5q   "   �� $��Center=�6-   $��10q�6H   .+�5r   &   �� $
��auto��61   $ 
Horizontal=�6?   .+�5s   *     $ AccountGroup=�6B   $
��auto��6V   
���   �$��	0 5 15 0 q�6w   �� 5t   *   -	   5        $ txbEmpleados��5t   4   $��Center=�6J   $��	Empleados��6e   
���   �$��5q�6�   $
��auto��6�   5u   '   � 5v   &   -
   5        $ gridM2��5v   +   $��	10 0 10 5q�6;   ���	#FF6F8190$��2��6e   $y�	Collapsed=�6p   5w   #   5z      5{      � 5~      .+�5      �� -   5        $ btnClientesL��5   %   $��50��6;   $��Center=�6I   $��0q�6�   $��0q�6�   ��6d   Z� ��6|   Z� .��5�   "   �� $ Vertical=�6-   $��10q�6D   .+�5�   &   �� $
��auto��61   $ 
Horizontal=�6?   .+�5�   *     $ AccountMultiple=�6B   $��0 5 15 5q�6Y   
���   �6k   �� 5�   *   -   5        $ txbClientes��5�   4   $��Center=�6I   $��Clientes��6d   $��5q�6u   $
��auto��6�   
���   �6�   5�   '   � 5�   &   -   5        $ gridM3��5�   +   $��	10 0 10 5q�6;   ���	#FF6F8190$��2��6e   $y�	Collapsed=�6p   5�   #   5�      5�      � 5�      .+�5�      �� -   5        $ btnRegistros��5�   %   $��50��6;   $��Center=�6H   $��0q�6�   $��0q�6�   ��6d   Z� ��6z   Z� .��5�   "   �� $��Center=�6-   $��10q�6H   .+�5�   &   �� $
��auto��61   $ 
Horizontal=�6?   .+�5�   *     $ Ballot=�6B   $��0 5 15 5q�6P   
���   �6b   �� 5�   *   -   5        $ 	txbVentas��5�   4   $��Center=�6G   $��Ventas��6b   $��5q�6q   $
��auto��6|   
���   �6�   5�   '   � 5�   &   -   5        $ gridM4��5�   +   $��	10 0 10 5q�6;   ���	#FF6F8190$��2��6e   $y�	Collapsed=�6p   5�   #   5�      5�      �� 5�      $ Vertical=�6%   $��Center=�6<   .+�5�      o� -   5         o�Name$ MenuRepuestos��5�   #   
�������$��Center=�6M   $��0q�6o   ��6|   Z� .@�5�   "   m� -   5        $��menuItemRepuesto��5�   +   $��Montserrat Regular)�6C   
�������
���   � �� TextAlignment$
 Left=�6�   $��	Repuestos��6�   $��50��6�   $��10q�6�   $��13(�6o   m� Icon 6�   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Abacus=�.@�5�   &   m� -   5        $��mITodoLosRepuestos��5�   /   
���   �$��Todos los repuestos��6]   6z   �� 5�   &   m� 5�   &   -   5        $��mITipoRepuesto��5�   /   
���   �$��Tipos de repuestos��6X   6t   �� 5�   &   m� 5�   &   $��Categoria de respuestos��6/   
���   �6Q   5�   #   5�      � 5�      -   5        $ gridM5��5�   #   $��	10 0 10 5q�63   ���	#FF6F8190$��2��6]   $y�	Collapsed=�6h   5�      � 5�      .+�5�      �� -   5        $ btnReportes��5�   %   $��50��6:   $��Center=�6G   $��0q�6�   $��0q�6�   ��6c   Z� ��6y   Z� .��5�   "   �� $��Center=�6-   $��10q�6H   .+�5�   &   �� $
��auto��61   $ 
Horizontal=�6?   .+�5�   *     $ Ballot=�6B   $��0 5 15 5q�6P   
���   �6b   �� 5�   *   -   5        $ txbReportes��5�   4   $��Center=�6I   $��Reportes��6d   $��5q�6u   $
��auto��6�   
���   �6�   5�   '   � 5�   &   -   5        $ gridM6��5�   +   $��	10 0 10 5q�6;   ���	#FF6F8190$��2��6e   $y�	Collapsed=�6p   5�   #   5�      5�      �� 5�      $ Vertical=�6%   $��Center=�6<   .+�5�      o� 
�������$��Center=�67   $��0q�6Y   ��6f   Z� .@�5�   "   m� $��Montserrat Regular)�6,   
�������
���   �$
 Left=�6�   $��Otros��6�   $��50��6�   $��10q�6�   $��13(�6�    6r     $ Abacus=�.@�5�   &   m� 
���   �$��Proveedores��6D   �� 5�   &   m� 5�   &   -   5        $��btnLayoutFabricaRepuestos��5�   /   
���   �$��Fabricas de Repuestos��6e   6�   �� 5�   &   m� 5�   &   
���   �$��Categoria de respuestos��6C   5�   #   5�      5�      5�      �� 5�      $ 
Horizontal=�6"   $��Right=�6;   .+�5�      o� -   5        
�������.@�5�      m� -   5        $��menuItemHeader��5�   '   
�������$��AndyG��6P   $��13(�6_   $��Montserrat Regular)�6m   
���   �$��50��6�   $
��auto��6�    6�     $ AccountCircleOutline=�.@�5�   "   m� $��Ayuda��6,    6;     $ HelpCircleOutline=�m� 5�   "   -   5        $��mtAdministrarCuenta��5�   +   $��Administrar tu cuenta��6F    6e     $ AccountEdit=�6�   m� 5�   "   $��Configuraición��6+    6C     $	 Nut=�m� 5�   "   -   5        $��
mtAcercaDe��5�   +   $��Acerca de...��6=    6S     $ InformationOutline=�6�   �� 5�   "   m� 5�   "   -   5        $��Salir��5�   +    6;     $ 	ExitToApp=�6k   5�      5�      5�      5�      5�      5�      � 5�   
   $
��auto��6   $
��auto��6   $��0, 102, 0, 0 q�6,   .+�5�      ��  �� CornerRadius$ 0��6   
�������$��0q�69   $��2��6D   ._�5�      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5�      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5�         Kind$ FadeIn=�6:     5�      $ SlideInFromBottom=�6:   .��5�      � -   5        $ gridMain��5�      5�      5�      5�      '  !MaterialDesignThemes.Wpf.Snackbar  5�      -    5          Name$ snackbarMessage��5�   9   $��	20 0 20 0q�6&      IsActive .  $��Stretch=�6c      Message. 5�      .  (MaterialDesignThemes.Wpf.SnackbarMessage  $��Hello 2��62      ActionContent$
 UNDO��6D   5�      5�      5     5
     