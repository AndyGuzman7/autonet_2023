   M S B A M L   `   `   `  ����N  JUnivalle.AutoNetWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Univalle.AutoNetWPF.PartsAdminUnivalle.AutoNetWPF.PartsAdmin  5      -    'Univalle.AutoNetWPF.PartsAdmin.uscParts   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Univalle.AutoNetWPF.PartsAdmin     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5           MaterialDesignBody#���   5
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
Horizontal=�6)   .+�52   "   �� -   5         ��Name$ btnRepuestosL��52   c   
��� � �$	��100��6<   $
��Left=�6H   $��20,0,10,0.4q�6z   $��0q�6�   .��53   &   �� $��Center=�61   .+�54   *   �� $
��auto��65   $ 
Horizontal=�6C   .+�56   .   �� $��Center=�68   $��
+ Repuesto��6S   $��5q�6f   $
��auto��6q   58   +   5:   '   5=   #   �� 5?   &   $ 
Horizontal=�61   $��Center=�6J   .+�5A   *   (  "MaterialDesignThemes.Wpf.ColorZone  $	��500��6C      Mode$ Standard=�6O   $��8 4 8 4q�6_      CornerRadius$ 2��6q    K� ZIndex$ 1��6�   $��16 0 0 0q�6�   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�6�   .��5B   .   �  � ColumnDefinitions 5C   2   �� 5D   6   $
��Auto �6H   �� 5E   6   $��* �6H   �� 5F   6   $
��Auto �6G   .+�5H   2   � $��Center=�67   .+�5I   6   '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ Search=�6O    J� Opacity$	 .56Q�6]   5J   3   �� 5K   2   -   5         ��Name$ txtNombreBuscar��5K   :   $��1��6S   $��8 0 0 0q�6c   )
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ Buscar Repuestos��6u   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�6�   $��0q�6�   $	��200��6�   $��Center=�6  6"  5M   /   5N   +   �� 5O   *   -   5        $��	btnBuscar��5O   �    & "MaterialDesignToolForegroundButton#���  61   $��8 0 0 0q�6n   $ 0��6�   .��5P   .   	  $
 Send=�6G   5Q   +   5R   '   5T      5V      � 5W      -   5         �Name$ gridMainParts��5W      $��20 90 20 20q�66   .+�5[      �� $��Visible=�6+   .��5\   "   � -   5        $ 	gridParts��5\   '   $	��Top=�6;   .+�5]   &   � $��
20,0,20,20q�60   $��Center=�6D   .+�5^   *     -   5        $��dataGridProgram��5^   c      AutoGenerateColumns .  
�������   SelectionMode$ Single=�6z   $��15(�6�      
IsReadOnly . $
��auto��6�   $	��700��6�      CanUserAddRows .  ��.    Columns 5`   .   0  *System.Windows.Controls.DataGridTextColumn  5a   2   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6F      Header$ 
Id Cliente��6Q       
Visibility$  	Collapsed=�6�   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6f   �� " �� Path$" idSpare�6�     5c   2   -   5        dtdd��$ * 5c   S   $ Nombre Repuesto��6^   ! 6x   �� $" nameProduct�  5e   2   $ * 6E   $ Precio��6O   ! 6_   �� $" 	basePrice�  5f   2   $ * 6E   $ Stock��6O   ! 6_   �� $" currentBalance�4  .System.Windows.Controls.DataGridTemplateColumn  5g   2   $ Vista��6I   #   CellTemplate# 5h   6   �� 5i   :   .R�5j   >   �� $��btnVistaProducto��6E   -	   5        $��40��5j   ]   $��Detalles��6i   
��� � ���6�   Z� 5k   ;   5m   3   5s   +   5t   '   5u   #   5v      5w      5{      5�      5�      5�      5�      5�      