   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   	   3clr-namespace:tema3.Converterstema3.Converters  5   	   "    tema3.Views.MaterialElevView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   	   9localConverterclr-namespace:tema3.Converters     5   	     � Title$  MaterialElevView��5	   	   $	��450��6"   $	��800��6/    � DataContext 5
      %  tema3.ViewModels.MaterialElevVM  5   
   .��5      � $��0,0,-6.6,-3q�6   ��5   
   �� 5       �� ImageSource$1 +/tema3;component/Images/fundal_profesor.jpg��6   6U    � 	Resources 5   
   *  $tema3.Converters.MaterialElevConvert   materialelevConvert��%   &	          5      61   5      .+�5   
   �� $
��Left=�6   $��	46,46,0,0q�6/   $
��Wrap=�6B   $��Materie��6V   $	��Top=�6e   $��31��6}   $��75��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5         ��Name$ 
txtMaterie��5      $	��142��6&   $
��Left=�62   $��129,46,0,343q�5   u   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Materie+ �� ElementName$ materialeGrid�� �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ materialeGrid��5      $��288,19,29.4,172.8q�6+      AutoGenerateColumns .  $��Visible=�5      $��Segoe Script)�6e   ���	#FFFCC093���	#FF0877E4���	#FF390BB3	 J� RenderTransformOrigin$	 0.5,0.5&�6�   $��11(�6�   ��6@   �� *MaterialList+z�5      V� 5      .~�5      �� �� 5      �� 5      
 �� Angle$
 -0.057Q�6&   T� 5      5          Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Materie��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Materie+  5$      $ Clasa��6%    64   �� *Clasa+  5%      $
 Path��6%    63   �� *Path+5'      �� 5(   
   $��Center=�6   $��46,104,552.2,0q�61   $
��Wrap=�6I   $	��Top=�6]   $��71��6u   $	��202��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   $	 0.381,-1.632&�68  ��6�   �� *ErrorMessage+$ PropertyChanged=�68  �� 5+   
   $��Afisare materiale��6   $��46,180,548.2,200q�6-   $��Segoe Script)�6G   $��18(�6a   $
��Bold"�6o   ���	#FFE9F2F3��6�   �� *UpdateCommand+��5,      `� 5-       `� 	Converter# [  6   .1�5.      �� $ 
txtMaterie��6    �� Path$
 Text�67   5/       J� Effect 51      3  -System.Windows.Media.Effects.DropShadowEffect  52      ��54      �� 55       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��56      �  � Color$ 	#FFD3632D��6#    � Offset$ 0.511Q�65   � 57      $ 	#FF802E0C��6#   $ 1Q�65   � 58      $ 	#FFF0AE9F��6#   59      5;      �� 5<   
   -   5        $��Inapoi��5<      $
��Left=�6"   $��15,0,0,25.6q�6=   $��Bottom=�6R   $	��110��6m   $��30��5=   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ 5>        5?      ��5A      �� 5B      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5C      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5D      $ 	#FF802E0C��6#   $ 1Q�65   � 5E      $ 	#FFF0AE9F��6#   5F      5H      �� 5I   
   -   5        $��Deschide material��5I      $��503,321,89.2,67q�6-   $��Segoe Script)�6F   $��18(�6`   $
��Bold"�6n   ���	#FFE9F2F3$	 0.533,-0.359&�6�    5K        5L      ��5N      �� 5O      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5P      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5Q      $ 	#FF802E0C��6#   $ 1Q�65   � 5R      $ 	#FFF0AE9F��6#   5S      5U      �� 5V   
   $
��Left=�6   $��
68,282,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��31��6o   $��53��6{   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA$	 0.884,0.677&�6�   �� 6�   $
�Path��6   �� 6  �� 6  6!  �� 5W   
   -   5         ��Name$ txtPath��5W      $	��398��6%   $
��Left=�61   $��129,278,0,79q�5X   r   $��16(�6�   $��Segoe Script)�6�   ���	#FFFAFAFA$	 0.5,0.5&�6�   ��6   �� *SelectedItem.Path+$ materialeGrid��$ PropertyChanged=�5Z      5\      5]      