   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   	   3clr-namespace:tema3.Converterstema3.Converters  5   	       tema3.Views.EditareElev   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   	   9localConverterclr-namespace:tema3.Converters     5   	     � Title$  EditareElev��5	   	   $	��450��6   $	��800��6*    � DataContext 5
      $  tema3.ViewModels.EditareElevVM  5   
   .��5      � ��5   
   �� 5       �� ImageSource$. (/tema3;component/Images/fundal_admin.jpg��6   6R    � 	Resources 5   
   "  tema3.Converters.ElevConvert   elevConvert��%   &	          5      6)   5      .+�5   
   �� $
��Left=�6   $��	45,54,0,0q�6/   $
��Wrap=�6B   $
��Nume��6V   $	��Top=�6b   $��31��6z   $��59��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5         ��Name$ txtNume��5      $	��142��6#   $
��Left=�6/   $��109,54,0,335q�5   s   $��16(�6�   $��Segoe Script)�6�   ��6   ��  �� ElementName$ 	eleviGrid�� �� Path$ SelectedItem.Nume� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��	15,90,0,0q�6/   $
��Wrap=�6B   $��Prenume��6V   $	��Top=�6e   $��31��6}   $��94��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ 
txtPrenume��5      $	��142��6&   $
��Left=�62   $��109,90,0,299q�5   v   $��16(�6�   $��Segoe Script)�6�   ��6   �� $ 	eleviGrid��$ SelectedItem.Prenume�$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
45,126,0,0q�6/   $
��Wrap=�6C   $��Clasa��6W   $	��Top=�6d   $��31��6|   $��59��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ txtClasa��5      $	��142��6$   $
��Left=�60   $��109,126,0,263q�5   t   $��16(�6�   $��Segoe Script)�6�   ��6   �� $ 	eleviGrid��$ SelectedItem.Clasa�$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
20,164,0,0q�6/   $
��Wrap=�6C   $��Username��6W   $	��Top=�6g   $��31��6   $��89��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ txtUsername��5      $	��142��6'   $
��Left=�63   $��109,164,0,225q�5   w   $��16(�6�   $��Segoe Script)�6�   ��6   �� $ 	eleviGrid��$ SelectedItem.Username�$ PropertyChanged=�6�   �� 5    
   $
��Left=�6   $��
46,200,0,0q�6/   $
��Wrap=�6C   $��Parola��6W   $	��Top=�6e   $��31��6}   $��63��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA J� RenderTransformOrigin$ 0.643,1.166&�6�   �� 5!   
   -   5        $ txtPassword��5!      $	��142��6'   $
��Left=�63   $��109,200,0,189q�5"   w   $��16(�6�   $��Segoe Script)�6�   ��6   �� $ 	eleviGrid��$ SelectedItem.Password�$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5$   
   -   5        $��	eleviGrid��5$      $��344,40,95.6,184q�6%   	   AutoGenerateColumns	 .  $��Visible=�5%      $��Segoe Script)�6h   ���	#FF9DA2FF���	#FF0877E4���	#FF390BB3$ 0.5,0.5&�6�   ��6F   �� *	EleviList+z�5&      V� 5'      .~�5(      �� �� 5)      �� 5*      
 �� Angle$
 -0.057Q�6&   T� 5+      5,         Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nume��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Nume+  50      $ Prenume��6%    66   �� *	Prenume+  51      $ Clasa��6%    64   �� *Clasa+  52      $ Username��6%    67   �� *
Username+  53      $ Parola��6%    65   �� *
Password+55      �� 56   
   $��Center=�6   $��147,250,190.6,0q�61   $
��Wrap=�6J   $	��Top=�6^   $��36��6v   $	��456��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=��� 59   
   $��Adauga elev��6   $��109,286,542.6,90q�6'   $��Segoe Script)�6A   $��18(�6[   $
��Bold"�6i   ���	#FF9FF5FD��6�   �� *
AddCommand+��5:      `� 5;       `� 	Converter# [  6#   .1�5<      �� $ txtNume��6"   $
 Text�68   �� 5=      $ 
txtPrenume��6"   $
 Text�6;   �� 5>      $ txtClasa��6"   $
 Text�69   �� 5?      $ txtUsername��6"   $
 Text�6<   �� 5@      $ txtPassword��6"   $
 Text�6<   5A       J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D      ��5F      �� 5G       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5H      �  � Color$ 	#FF2C34C5��6#    � Offset$ 0.511Q�65   � 5I      $ 	#FF05223A��6#   $ 1Q�65   � 5J      $ 	#FF6124E7��6#   5K      5M      �� 5N   
   $��Modifica elev��6   $��Segoe Script)�6*   $��18(�6D   $
��Bold"�6R   ���	#FF9FF5FD$��312,286,316.6,90q�6{   ��6�   �� *UpdateCommand+��5O      �� $ 	eleviGrid��$ SelectedItem� 5P        5Q      ��5S      �� 5T      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5U      � $ 	#FF2C34C5��6#   $ 0.511Q�65   � 5V      $ 	#FF05223A��6#   $ 1Q�65   � 5W      $ 	#FF6124E7��6#   5X      5Z      �� 5[   
   $��Sterge elev��6   $��Segoe Script)�6'   $��18(�6A   $
��Bold"�6O   ���	#FF9FF5FD$��526,286,106.6,90q�6x   ��6�   �� *DeleteCommand+��5\      �� $ 	eleviGrid��$ SelectedItem� 5^        5_      ��5a      �� 5b      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5c      � $ 	#FF2C34C5��6#   $ 0.511Q�65   � 5d      $ 	#FF05223A��6#   $ 1Q�65   � 5e      $ 	#FF6124E7��6#   5f      5h      �� 5i   
   -   5        $��Inapoi��5i      $
��Left=�6"   $��	40,0,0,30q�6=   $��Bottom=�6P   $	��110��6k   $��30��5j   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ 5k        5l      ��5n      �� 5o      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5p      � $ 	#FF260540��6#   $ 1Q�65   � 5q      $ 	#FF6124E7��6#   5r      5t      5x      5y      