   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   	   3clr-namespace:tema3.Converterstema3.Converters  5   	       tema3.Views.EditareClasa   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   	   9localConverterclr-namespace:tema3.Converters     5   	     � Title$  EditareClasa��5	   	   $	��450��6   $	��800��6+    � DataContext 5
      %  tema3.ViewModels.EditareClasaVM  5   
   .��5      � ��5   
   �� 5       �� ImageSource$. (/tema3;component/Images/fundal_admin.jpg��6   6R    � 	Resources 5   
   #  tema3.Converters.ClasaConvert   clasaConvert��%   &	          5      6*   5      .+�5   
   �� $
��Left=�6   $��
103,72,0,0q�6/   $
��Wrap=�6C   $��Denumire��6W   $	��Top=�6g   $��31��6   $��89��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5         ��Name$ txtDenumire��5      $	��142��6'   $
��Left=�63   $��197,72,0,317q�5   v   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Denumire+ �� ElementName$ 	claseGrid�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
88,107,0,0q�6/   $
��Wrap=�6C   $��Specializare��6W   $	��Top=�6k   $��31��6�   $	��109��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ txtSpecializare��5      $	��142��6+   $
��Left=�67   $��197,107,0,282q�5   z   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Specializare+$ 	claseGrid��$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
57,146,0,0q�6/   $
��Wrap=�6C   $��Nume Diriginte��6W   $	��Top=�6m   $��31��6�   $	��140��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ 	txtDirigN��5      $	��142��6%   $
��Left=�61   $��197,144,0,245q�5   t   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.DirigN+$ 	claseGrid��$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
26,182,0,0q�6/   $
��Wrap=�6C   $��Prenume Diriginte��6W   $	��Top=�6p   $��31��6�   $	��166��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ 	txtDirigP��5      $	��142��6%   $
��Left=�61   $��197,182,0,207q�5    t   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.DirigP+$ 	claseGrid��$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ 	claseGrid��5"      $��386,42,53.6,182q�6'      AutoGenerateColumns .  $��Visible=�5#      $��Segoe Script)�6f   ���	#FF9DA2FF���	#FF0877E4���	#FF390BB3	 J� RenderTransformOrigin$	 0.5,0.5&�6�   ��6D   �� *	ClaseList+z�5$      V� 5%      .~�5&      �� �� 5'      �� 5(      
 �� Angle$
 -0.057Q�6&   T� 5)      5*         Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Denumire��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Denumire+  5.      $ Specializare��6%    6;   �� *Specializare+  5/      $ DirigN��6%    65   �� *DirigN+  50      $ DirigP��6%    65   �� *DirigP+52      �� 53   
   $��Center=�6   $��147,250,190.6,0q�61   $
��Wrap=�6J   $	��Top=�6^   $��36��6v   $	��456��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=��� 56   
   $��Adauga clasa��6   $��109,286,542.6,90q�6(   $��Segoe Script)�6B   $��18(�6\   $
��Bold"�6j   ���	#FF9FF5FD��6�   �� *
AddCommand+��57      `� 58       `� 	Converter# [  6   .1�59      �� $ txtDenumire��6    �� Path$
 Text�68   �� 5:      $ txtSpecializare��6   $
 Text�6<   �� 5;      $ 	txtDirigN��6   $
 Text�66   �� 5<      $ 	txtDirigP��6   $
 Text�66   5=       J� Effect 5?      3  -System.Windows.Media.Effects.DropShadowEffect  5@      ��5B      �� 5C       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5D      �  � Color$ 	#FF2C34C5��6#    � Offset$ 0.511Q�65   � 5E      $ 	#FF05223A��6#   $ 1Q�65   � 5F      $ 	#FF6124E7��6#   5G      5I      �� 5J   
   $��Modifica clasa��6   $��Segoe Script)�6+   $��18(�6E   $
��Bold"�6S   ���	#FF9FF5FD$��312,286,316.6,90q�6|   ��6�   �� *UpdateCommand+��5K      �� *SelectedItem+$ 	claseGrid�� 5L        5M      ��5O      �� 5P      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5Q      � $ 	#FF2C34C5��6#   $ 0.511Q�65   � 5R      $ 	#FF05223A��6#   $ 1Q�65   � 5S      $ 	#FF6124E7��6#   5T      5V      �� 5W   
   $��Sterge clasa��6   $��Segoe Script)�6(   $��18(�6B   $
��Bold"�6P   ���	#FF9FF5FD$��526,286,106.6,90q�6y   ��6�   �� *DeleteCommand+��5X      �� *SelectedItem+$ 	claseGrid�� 5Z        5[      ��5]      �� 5^      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5_      � $ 	#FF2C34C5��6#   $ 0.511Q�65   � 5`      $ 	#FF05223A��6#   $ 1Q�65   � 5a      $ 	#FF6124E7��6#   5b      5d      �� 5e   
   -   5        $��Inapoi��5e      $
��Left=�6"   $��	40,0,0,30q�6=   $��Bottom=�6P   $	��110��6k   $��30��5f   7   $��Segoe Script)�6C   $��16(�6]   $
��Bold"�6k   ���	#FF020006��6   �� *OpenWindowCommand+ 5g        5h      ��5j      �� 5k      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5l      � $ 	#FF260540��6#   $ 1Q�65   � 5m      $ 	#FF6124E7��6#   5n      5p      5t      5u      