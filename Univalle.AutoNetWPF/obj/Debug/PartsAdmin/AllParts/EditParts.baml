   M S B A M L   `   `   `  ����N  JUnivalle.AutoNetWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Univalle.AutoNetWPF.PartsAdminUnivalle.AutoNetWPF.PartsAdmin  5   	   .    (Univalle.AutoNetWPF.PartsAdmin.EditParts   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Univalle.AutoNetWPF.PartsAdmin     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � WindowState$ 	Maximized=�6W   $
��auto��6o   $
��auto��6}    � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�    � AllowsTransparency .  � WindowStyle$
 None=�6�   ��5      Z� .��5      � ��6   Z� .+�5   
   �  J� Opacity$	 0.5Q�6   
���   �5      #  MaterialDesignThemes.Wpf.Card  5   
   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�6   $	��750��6O   $	��780��6\   	   UniformCornerRadius$	 15Q�6h   .��5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase
   OpeningEffect
 62   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *
ExpandIn+.��5      � $
��auto��6   $
��auto��6%   .+�5      ��  �� CornerRadius$ 15��6   ._�5      �  � ColumnDefinitions 5      �� 5   "   $��* �63   �� 5    "   $��* �63   .+�5#      ��  �� Padding$ 15q�6&   $ Depth3=�63   $��0 80 0 0q�6d   $��2��6v   $ 
 0 15 15 0��6�   ���#F7F7F7._�5%   "   �� .+�5&   &     
�������$	 15Q�6M   $��10q�6f   $��5q�6s   .��5'   *   �� .+�5(   .   � $��5q�63   ���#F7F7F7.+�5)   2   �� $��10q�68   $��70��6D   $5��//PartsAdmin/image/logo2Recurso 12logoBalnco.png��6O   5+   3   5,   /   �� 5/   .   $��5q�65   ���	#FF175CC1$��Añadir Imagen��6r   
�������$��Normal"�6�   ��6@   Z� 6�   50   +   51   '     55   &   
�������$	 15Q�6M   $��10q�6f   $��5q�6s   .��56   *   �� .+�57   .   �� -   5        $��txtNombreProducto��57   6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre Producto��6O    ! MaterialDesignOutlinedTextBox#��[ 6�   ���#F7F7F7��6�   Z� 58   +   59   '     5;   &   
�������$	 15Q�6M   $��10q�6f   $��5q�6s   .��5<   *   �� .+�5=   .   �� -   5         ��Name$ txtDescripcion��5>   -   ���#F7F7F7#��[ 5@   1   $	��Top=�5A   1   $	��100��5B   1    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5D   1   " �� VerticalScrollBarVisibility$
 Auto=�5E   1   $ Descripcion��5F   1   ��5?   F   Z� {�5G   1   ��  �� Path$ 	IsChecked� �� ElementName$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5I   +   5K   '     5O   &   
�������$	 15Q�6M   $��10q�6f   $��5q�6s   .��5P   *   �  5Q   .   �� 5R   2   $��* �6C   �� 5S   2   $��* �6C   �� 5T   2   $��* �6C   .+�5W   .   �� -   5        $ txtSaldoActual��5W   6   $��0��6O   $ SaldoActual��6`   #��[ 6�   ���#F7F7F7$
��auto��6�   ��6�   Z� �� 5X   .   -   5        $ txtPrecioBase��5X   6   $��1��6M   $ Precio Base��6]   #��[ 6�   ���#F7F7F7$
��auto��6�   ��6�   Z� �� 5Y   .   -   5        $ txtPeso��5Y   6   $��2��6G   $
 Peso��6W   #��[ 6}   ���#F7F7F7$
��auto��6�   ��6�   Z� 5[   +   5]   '     5^   &   
�������$	 15Q�6M   $��10q�6f   $��5q�6s   .��5_   *   �� .+�5b   .   �� -   5        $ txtCodigoProducto��5b   6   $ Codigo de Producto��6Q   #��[ 6�   ���#F7F7F7��6�   Z� 5d   +   5f   '     5g   &   
�������$	 15Q�6M   $��10q�6f   $��5q�6s   .��5h   *   �  5i   .   �� 5j   2   $��* �6C   �� 5k   2   $��* �6C   .+�5p   .   �� -   5        $ 
txtFabrica��5p   6   $ Fabrica o Marca��6J   #��[ 6{   ���#F7F7F7��6�   Z� �� 5q   .   -	   5        $ txtTipoRepuesto��5q   6   $��1��6O   $ Tipo de Repuesto��6_   #��[ 6�   ���#F7F7F7��6�   Z� 5r   +   5u   '   5y   #   5z      �� 5|      $ 15q�6%   $��2��62   $ 	15 0 0 15��6F   5�      �� 5�      $��3��6&   $ 	15  0 0 0��6:   ���	#FF175CC1$	��Top=�6k   $��70��6�   ._�5�   "   � .+�5�   &   ��  $  MaterialDesignHeadline5TextBlock#��[ 61   $��Center=�6k    �� Padding$ 23q�6�   
�������$��Area de Edicion��6�   �� 5�   &    �� Orientation$ 
Horizontal=�61   $��2��6J   $��Right=�6^   $��0 0 10 0q�6z   .+�5�   *   �� -
   5         ��Name$ 	btnGuadar��5�   1   
���   �$��60��6Z   $��40��6e   
���   �
�������$��Right=�6�   $��0,15,0,0q�6�   $	��Top=�6�   .��5�   .   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ContentSave=�6F   5�   +   �� 5�   *   -   5        $ btnSalir��5�   1   $��
10 0 10 0 q�6C   
���   �$��60��6k   $��40��6v   
���   �
�������.��5�   .     $ Close=�6F   5�   +   5�   '   5�   #   5�      5�      5�      '	  !MaterialDesignThemes.Wpf.Snackbar	  5�      -   5         	 Name$ snackbarMessage��5�   X   ���	#FF175CC1$��	20 0 20 0q�6E    	  IsActive .  $��Stretch=�6�    	  Message. 5�      .
  (MaterialDesignThemes.Wpf.SnackbarMessage
  
�������$&�� ¡Repuesto Modificado con exito!��6L   5�      5�      5�      5�      5�      5�      