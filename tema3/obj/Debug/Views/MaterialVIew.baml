   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5      3clr-namespace:tema3.Converterstema3.Converters  5   	       tema3.Views.MaterialView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5      9localConverterclr-namespace:tema3.Converters     5   	     � Title$  MaterialView��5	   	   $	��450��6   $	��800��6+    � DataContext 5      !  tema3.ViewModels.MaterialVM  5   
   .��5      � $��0,0,-6.6,-3q�6   ��5   
   �� 5       �� ImageSource$1 +/tema3;component/Images/fundal_profesor.jpg��6   6U    � 	Resources 5   
   &   tema3.Converters.MaterialConvert   materialConvert��%   &	          5      6-   5      .+�5   
   �� $
��Left=�6   $��	39,58,0,0q�6/   $
��Wrap=�6B   $��Materie��6V   $	��Top=�6e   $��31��6}   $��75��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5         ��Name$ 
txtMaterie��5      $	��142��6&   $
��Left=�62   $��122,58,0,333q�5   u   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Materie+ �� ElementName$ materialeGrid�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
58,108,0,0q�6/   $
��Wrap=�6C   $��Clasa��6W   $	��Top=�6d   $��31��6|   $��53��6�   $��14(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA J� RenderTransformOrigin$ 0.884,0.677&�6�   �� 5   
   -   5        $ txtClasa��5      $	��142��6$   $
��Left=�60   $��119,105,0,284q�5   s   $��16(�6�   $��Segoe Script)�6�   $ 0.5,0.5&�6�   ��6   �� *SelectedItem.Clasa+$ materialeGrid��$ PropertyChanged=�.��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.328Q�6&   T� 5       5!      .��5"   '   5#      &   System.Windows.Controls.DataGrid  5%   
   -   5        	  Name$	 materialeGrid��5%      $��288,19,29.4,172.8q�6+   
   AutoGenerateColumns
 .  $��Visible=�5&      $��Segoe Script)�6e   ���	#FFFCC093���	#FF0877E4���	#FF390BB3$ 0.5,0.5&�6�   $��11(�6�   ��6@   �� *MaterialList+z�5'      V� 5(      .~�5)      �� �� 5*      �� 5+      $ -0.057Q�6&   T� 5,      5-         Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Materie��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Materie+  51      $ Clasa��6%    64   �� *Clasa+  52      $
 Path��6%    63   �� *Path+54      �� 55   
   $��Center=�6   $��73.9,274,32.3,0q�61   $
��Wrap=�6J   $	��Top=�6^   $��36��6v   $	��694��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=��� 58   
   $��Adauga material��6   $��339,310,276.2,66q�6+   $��Segoe Script)�6E   $��18(�6_   $
��Bold"�6m   ���	#FFE9F2F3��6�   �� *
AddCommand+��59      `� 5:       `� 	Converter# [  6   .1�5;      �� $ 
txtMaterie��6    �� Path$
 Text�67   �� 5<      $ txtClasa��6   $
 Text�65   �� 5=      $ txtPath��6   $
 Text�64   5>       J� Effect 5@      3  -System.Windows.Media.Effects.DropShadowEffect  5A      ��5C      �� 5D       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5E      �  � Color$ 	#FFD3632D��6#    � Offset$ 0.511Q�65   � 5F      $ 	#FF802E0C��6#   $ 1Q�65   � 5G      $ 	#FFF0AE9F��6#   5H      5J      �� 5K   
   -   5        $��Inapoi��5K      $
��Left=�6"   $��15,0,0,25.6q�6=   $��Bottom=�6R   $	��110��6m   $��30��5L   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ 5M        5N      ��5P      �� 5Q      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5R      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5S      $ 	#FF802E0C��6#   $ 1Q�65   � 5T      $ 	#FFF0AE9F��6#   5U      5W      �� 5X   
   $
��Left=�6   $��
58,156,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��31��6o   $��53��6{   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA$ 0.884,0.677&�6�   �� 6�   $
�Path��6   �� 6  �� 6  6!  �� 5Y   
   -   5        $ txtPath��5Y      $	��142��6#   $
��Left=�6/   $��119,152,0,235q�5Z   r   $��16(�6�   $��Segoe Script)�6�   $ 0.5,0.5&�6�   ��6   �� *SelectedItem.Path+$ materialeGrid��$ PropertyChanged=�.��6�   z�5[      V� 5\      .~�5]      �� �� 5^      �� 5_      $ -0.328Q�6&   T� 5`      5a      .��5b   '   5c      �� 5d   
   -   5        $��Cauta��5d      $��161,200,536.2,189q�6!   $��Segoe Script)�6<   $��18(�6V   $
��Bold"�6d   ���	#FFE9F2F3$ 	0.502,0.5&�6�    5f        5g      ��5i      �� 5j      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5k      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5l      $ 	#FF802E0C��6#   $ 1Q�65   � 5m      $ 	#FFF0AE9F��6#   5n      5p      5r      5s      