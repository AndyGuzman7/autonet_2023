   M S B A M L   `   `   `  ����N  JUnivalle.AutoNetWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Univalle.AutoNetWPF.PartsAdminUnivalle.AutoNetWPF.PartsAdmin  5   	   3    -Univalle.AutoNetWPF.PartsAdmin.ViewsPartsType   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Univalle.AutoNetWPF.PartsAdmin     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5        MaterialDesignFont#���  5       � WindowStyle$
 None=�6@   $	��600��6j   $
��1000��6w    � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�    � AllowsTransparency . ��5   	   Z� .��5      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 20Q�6   $	��400��63   $	��900��6@   .��5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffects 5      ;  5MaterialDesignThemes.Wpf.Transitions.TransitionEffect  5      	   Kind$	 FadeIn=�62     5      $	 SlideInFromBottom=�62   .��5      � $	��400��6   $	��900��6"   ��6/   Z� .+�5      �� 
 �� CornerRadius$
 15��6   $��10q�6+   
�������._�5      � $��20q�6    � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $
��1.3* �6/    � RowDefinitions 5      �� 5       $��30 �6,   �� 5!      $��* �6,   .+�5#      � $��2��6    .+�5$      ��  �� Orientation$ 
Horizontal=�6*   $��Right=�6D   $��
0,0,10,0.4q�6`   $	��820��6t   .+�5%   "   �� -   5         ��Name$ 	btnEditar��5%   )   
���   �$��60��6Q   $
��auto��6\   
���   �$��Right=�6�   ��6}   Z� .��5&   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Edit=�6>   5'   #   �� 5(   "   -   5        $ btnEliminar��5(   )   $��	10 0 10 0q�6>   $��Right=�6Q   
���   �$��60��6�   $
��auto��6�   
���   ���6�   Z� .��5)   &     $ delete=�6>   5*   #   5-      �� 5.      -   5        $ btnSalir��5.   %   $��10,0,10,0.4q�67   $��Right=�6L   
���   �$��60��6|   $
��auto��6�   
���   ���6�   Z� .��5/   "     $ Close=�6:   50      52      �� 53      $��1��6%   $��1��65   $��10q�6C   .+�54      �� -   5         ��Name$ 	txbnombre��54   ;   $��	10 0 0 50q�6(    $  MaterialDesignHeadline4TextBlock#��[ 6N   $��Titulo��6�   �� 55      $��
 10 0 10 0q�6(   �� 57      $��5q�6)   $ 
Horizontal=�64   .+�58   "   ��  $  MaterialDesignSubtitle1TextBlock#��[ 6,   $��10 10  30 10q�6f   $��Fecha de Creacion:��6|   �� 59   "   -   5        $ txbFechaCreacion��59   ,   #��[ 6F   $��10q�6�   $��0��6�   5;      �� 5<      $��
 10 0 10 0q�6(   �� 5=      $��5q�6)   $ 
Horizontal=�64   .+�5>   "   �� #��[ 6,   $��10 10  30 10q�6f   $��Fecha de Modificacion��6|   �� 5?   "   -   5        $ txbFechaModificacion��5?   ,   #��[ 6J   $��10q�6�   $��0��6�   5A      �� 5B      $��
 10 0 10 0q�6(   �� 5D      $��5q�6)   $ 
Horizontal=�64   .+�5E   "   �� #��[ 6,   $��10 10  30 10q�6f   $��Empleado que modifico:��6|   �� 5F   "   -   5        $ txbEmpleado��5F   ,   #��[ 6A   $��10q�6{   $��0��6�   5G      �� 5H      $��
 10 0 10 0q�6(   �� 5I      $��5q�6)   $ 
Horizontal=�64   .+�5J   "   �� #��[ 6,   $��10 10  30 10q�6f   $��	Categoria��6|   �� 5K   "   -	   5        $ txbCategoria��5K   ,   #��[ 6B   $��10q�6|   $��0��6�   5L      5M      �� 5N      $��10q�6%   $��1��61   $��0��6>   ���#F7F7F7.+�5P      �� $��10,10,9.6,10q�6$   $5��//PartsAdmin/image/logo2Recurso 12logoBalnco.png��6;   $	��255��6t   5Q      5W      5Z      5\      5]      5^      5_      