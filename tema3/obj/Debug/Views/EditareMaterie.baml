   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   	   3clr-namespace:tema3.Converterstema3.Converters  5   	        tema3.Views.EditareMaterie   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   	   9localConverterclr-namespace:tema3.Converters     5   	     � Title$  EditareMaterie��5	   	   $	��450��6    $	��800��6-    � 	Resources 5
      #  tema3.Converters.ClasaConvert   clasaConvert��%   &	          5   
   6&   5       � DataContext 5      '  !tema3.ViewModels.EditareMaterieVM  5   
   .��5      � ��5   
   �� 5       �� ImageSource$. (/tema3;component/Images/fundal_admin.jpg��6   6R    5   
   %  tema3.Converters.MaterieConvert  materieConvert��%   &	         5      6,   5      .+�5   
   �� $
��Left=�6   $��	49,88,0,0q�6/   $
��Wrap=�6B   $��Denumire��6V   $	��Top=�6f   $��31��6~   $	��103��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5         ��Name$ txtDenumire��5      $	��164��6'   $
��Left=�63   $��158,88,0,301q�5   t   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Denumire+ �� ElementName$ materiiGrid�� �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ materiiGrid��5      $��391,34,95.6,190q�6)      AutoGenerateColumns .  $��Visible=�5      $��Segoe Script)�6d   ���	#FF9DA2FF���	#FF0877E4���	#FF390BB3	 J� RenderTransformOrigin$	 0.5,0.5&�6�   ��6@   �� *MateriiList+z�5      V� 5      .~�5      �� �� 5       �� 5!      
 �� Angle$
 -0.057Q�6&   T� 5"      5#         Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ Denumire��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Denumire+5(      �� 5)   
   $��Center=�6   $��21,146,471.6,0q�61   $
��Wrap=�6I   $	��Top=�6]   $��76��6u   $	��301��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=��� 5,   
   $��Adauga Materie��6   $��64,261,547.6,120q�6*   $��Segoe Script)�6D   $��18(�6^   $
��Bold"�6l   ���	#FF9FF5FD��6�   �� *
AddCommand+��5-      `� 5.       `� 	Converter# [ 6   .1�5/      �� $ txtDenumire��6    �� Path$
 Text�68   50       J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53      ��55      �� 56       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��57      �  � Color$ 	#FF2C34C5��6#    � Offset$ 0.511Q�65   � 58      $ 	#FF05223A��6#   $ 1Q�65   � 59      $ 	#FF6124E7��6#   5:      5<      �� 5=   
   $��Modifica materie��6   $��Segoe Script)�6-   $��18(�6G   $
��Bold"�6U   ���	#FF9FF5FD$��285,261,314.6,120q�6~   ��6�   �� *UpdateCommand+��5>      �� *SelectedItem+$ materiiGrid�� 5?        5@      ��5B      �� 5C      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5D      � $ 	#FF2C34C5��6#   $ 0.511Q�65   � 5E      $ 	#FF05223A��6#   $ 1Q�65   � 5F      $ 	#FF6124E7��6#   5G      5I      �� 5J   
   $��Sterge materie��6   $��Segoe Script)�6*   $��18(�6D   $
��Bold"�6R   ���	#FF9FF5FD$��522,261,93.6,120q�6{   ��6�   �� *DeleteCommand+��5K      �� *SelectedItem+$ materiiGrid�� 5M        5N      ��5P      �� 5Q      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5R      � $ 	#FF2C34C5��6#   $ 0.511Q�65   � 5S      $ 	#FF05223A��6#   $ 1Q�65   � 5T      $ 	#FF6124E7��6#   5U      5W      �� 5X   
   -   5        $��Inapoi��5X      $
��Left=�6"   $��	40,0,0,30q�6=   $��Bottom=�6P   $	��110��6k   $��30��5Y   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ 5Z        5[      ��5]      �� 5^      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5_      � $ 	#FF260540��6#   $ 1Q�65   � 5`      $ 	#FF6124E7��6#   5a      5c      5f      5g      