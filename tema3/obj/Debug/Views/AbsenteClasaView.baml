   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   
   3clr-namespace:tema3.Converterstema3.Converters  5   	   "    tema3.Views.AbsenteClasaView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   
   9localConverterclr-namespace:tema3.Converters     5   	     � Title$  AbsenteClasaView��5	   	   $	��450��6"   $��828.754��6/    � DataContext 5      %  tema3.ViewModels.AbsentaDirigVM  5   
   .��5      � $��0,0,-6.6,-3q�6   ��5   
   �� 5       �� ImageSource$1 +/tema3;component/Images/fundal_profesor.jpg��6   6U    � 	Resources 5   
   %  tema3.Converters.AbsentaConvert   absentaConvert��%   &	          5      6,   5       � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6   $��	42,64,0,0q�6/   $
��Wrap=�6B   $��Materie��6V   $	��Top=�6e   $��31��6}   $��75��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5         ��Name$ 
txtMaterie��5      $	��142��6&   $
��Left=�62   $��125,64,0,330.2q�5   s   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Materie+ �� ElementName$ absenteGrid�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
42,103,0,0q�6/   $
��Wrap=�6C   $��	Nume elev��6W   $	��Top=�6h   $��31��6�   $��83��6�   $��14(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ txtElevN��5      $	��142��6$   $
��Left=�60   $��125,98,0,294.2q�5    q   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.ElevN+$ absenteGrid��$ PropertyChanged=�6�   �� 5!   
   $
��Left=�6   $��
14,134,0,0q�6/   $
��Wrap=�6C   $��Prenume elev��6W   $	��Top=�6k   $��31��6�   $	��111��6�   $��14(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5"   
   -   5        $ txtElevP��5"      $	��142��6$   $
��Left=�60   $��125,134,0,258.2q�5#   q   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.ElevP+$ absenteGrid��$ PropertyChanged=�6�   �� 5$   
   $
��Left=�6   $��
36,170,0,0q�6/   $
��Wrap=�6C   $��Semestru��6W   $	��Top=�6g   $��31��6   $��89��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5%   
   -   5        $ txtSemestru��5%      $	��142��6'   $
��Left=�63   $��125,170,0,222.2q�5&   t   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Semestru+$ absenteGrid��$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5(   
   -   5        	  Name$	 absenteGrid��5(      $��288,19,9.8,173.2q�6)   
   AutoGenerateColumns
 .  $��Visible=�5)      $��Segoe Script)�6�   ���	#FFFCC093���	#FF0877E4���	#FF390BB3 J� RenderTransformOrigin$ 0.5,0.5&�6�   $��11(�6  ��6@   �� *AbsenteListDirig+$ PropertyChanged=�z�5*      V� 5+      .~�5,      �� �� 5-      �� 5.       �� Angle$ -0.057Q�6&   T� 5/      50         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$
 Data��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Data+  54      $ 	Nume elev��6%    68   �� *ElevN+  55      $ Prenume elev��6%    6;   �� *ElevP+  56      $ Materie��6%    66   �� *	Materie+  57      $ Motivata��6%    67   �� *
Motivata+  58      $ 
Motivabila��6%    69   �� *
Motivabila+  59      $ Semestru��6%    67   �� *
Semestru+5;      �� 5<   
   $��Center=�6   $��74,274,80.8,0q�61   $
��Wrap=�6H   $	��Top=�6\   $��36��6t   $	��694��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=��� 5@   
   $��Motiveaza absenta��6   $��Segoe Script)�6.   $��18(�6H   $
��Bold"�6V   ���	#FFF5F7F7$��348,309,276.8,72.2q�6   $ 0.664,0.587&�5A   P   ��5@   �   �� *UpdateCommand+��5A      �� *SelectedItem+$ absenteGrid�� J� Effect 5B      3  -System.Windows.Media.Effects.DropShadowEffect  5C      ��5E      �� 5F       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5G      �  � Color$ 	#FFD3632D��6#    � Offset$ 0.511Q�65   � 5H      $ 	#FF802E0C��6#   $ 1Q�65   � 5I      $ 	#FFF0AE9F��6#   5J      5L      �� 5M   
   -   5        $��Inapoi��5M      $
��Left=�6"   $��	15,0,0,26q�6=   $��Bottom=�6P   $	��110��6k   $��30��5N   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ 5O        5P      ��5R      �� 5S      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5T      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5U      $ 	#FF802E0C��6#   $ 1Q�65   � 5V      $ 	#FFF0AE9F��6#   5W      5Y      �� 5Z   
   $
��Left=�6   $��
38,206,0,0q�6/   $
��Wrap=�6C   $��Motivata��6W   $	��Top=�6g   $��31��6   $��82��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA$ 0.643,1.166&�6�   �� 5[   
   -   5         ��Name$ txtMotivata��5[      $	��142��6(   $
��Left=�64   $��125,207,0,182q�5\   y   $��16(�6�   $��Segoe Script)�6�    d� 	IsChecked 6   �� *SelectedItem.Motivata+$ absenteGrid��$ PropertyChanged=�6�   �� 5]   
   $
��Left=�6   $��
31,236,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��31��6o   $��94��6{   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA$ 0.643,1.166&�6�   �� 6�   $��14(�6   $�
Motivabila��6  6#  �� 5^   
   -   5        $ txtMotivabila��5^      $	��142��6*   $
��Left=�66   $��125,238,0,151q�5_   {   $��16(�6�   $��Segoe Script)�6�    6   �� *SelectedItem.Motivabila+$ absenteGrid��$ PropertyChanged=�6�   �� 5`   
   $
��Left=�6   $��	74,27,0,0q�6/   $
��Wrap=�6B   $
��Data��6V   $	��Top=�6b   $��31��6z   $��43��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5a   
   -	   5        $ txtData��5a      $	��142��6#   $
��Left=�6/   $��125,27,0,365.2q�5b   p   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Data+$ absenteGrid��$ PropertyChanged=�6�   �� 5c   
   $
��Left=�6   $��150,320,0,0q�6/   $
��Wrap=�6D   $��Nr. total absente��6X   $	��Top=�6q   $��31��6�   $	��169��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5d        5e      5g      �� 5h   
   -
   5        $ txtNrT��5h      $��72��6"   $
��Left=�6-   $��195,351,0,41.2q�5i   J   $��16(�6b   $��Segoe Script)�6p   ���	#FFF4BCA5��6   �� *NrT+$ PropertyChanged=�6�   �� 5j   
   $
��Left=�6   $��583,320,0,0q�6/   $
��Wrap=�6D   $��Nr. absente nemotivate��6X   $	��Top=�6v   $��26��6�   $	��225��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5k        5l      5n      �� 5o   
   -   5        $ txtNrN��5o      $��72��6"   $
��Left=�6-   $��653,351,0,41.2q�5p   I   $��16(�6a   $��Segoe Script)�6o   ���	#FFF4BCA5��6   �� *NrN+$ PropertyChanged=�6�   5r      5s      