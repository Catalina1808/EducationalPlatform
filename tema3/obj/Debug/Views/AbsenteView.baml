   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   	   3clr-namespace:tema3.Converterstema3.Converters  5   	       tema3.Views.AbsenteView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   	   9localConverterclr-namespace:tema3.Converters     5   	     � Title$  AbsenteView��5	   	   $	��450��6   $��848.882��6*    � DataContext 5         tema3.ViewModels.AbsentaVM  5   
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
 .  $��Visible=�5)      $��Segoe Script)�6h   ���	#FFFCC093���	#FF0877E4���	#FF390BB3 J� RenderTransformOrigin$ 0.5,0.5&�6�   $��11(�6�   ��6@   �� *AbsenteListProf+z�5*      V� 5+      .~�5,      �� �� 5-      �� 5.       �� Angle$ -0.057Q�6&   T� 5/      50         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$
 Data��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Data+  54      $ 	Nume elev��6%    68   �� *ElevN+  55      $ Prenume elev��6%    6;   �� *ElevP+  56      $ Materie��6%    66   �� *	Materie+  57      $ Motivata��6%    67   �� *
Motivata+  58      $ 
Motivabila��6%    69   �� *
Motivabila+  59      $ Semestru��6%    67   �� *
Semestru+5;      �� 5<   
   $��Center=�6   $��74,274,80.8,0q�61   $
��Wrap=�6H   $	��Top=�6\   $��36��6t   $	��694��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=��� 5?   
   $��Adauga absenta��6   $��250,310,426.8,66.2q�6*   $��Segoe Script)�6F   $��18(�6`   $
��Bold"�6n   ���	#FFE9F2F3��6�   �� *
AddCommand+��5@      `� 5A       `� 	Converter# [  6   .1�5B      �� $ 
txtMaterie��6    �� Path$
 Text�67   �� 5C      $ txtElevN��6   $
 Text�65   �� 5D      $ txtElevP��6   $
 Text�65   �� 5E      $ txtData��6   $
 Text�64   �� 5F      $ txtMotivata��6   $ 	IsChecked�68   �� 5G      $ txtMotivabila��6   $ 	IsChecked�6:   �� 5H      $ txtSemestru��6   $
 Text�68   5I       J� Effect 5K      3  -System.Windows.Media.Effects.DropShadowEffect  5L      ��5N      �� 5O       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5P      �  � Color$ 	#FFD3632D��6#    � Offset$ 0.511Q�65   � 5Q      $ 	#FF802E0C��6#   $ 1Q�65   � 5R      $ 	#FFF0AE9F��6#   5S      5U      �� 5V   
   $��Motiveaza absenta��6   $��Segoe Script)�6.   $��18(�6H   $
��Bold"�6V   ���	#FFF5F7F7$��462,310,182.8,66.2q�6   ��6�   �� *UpdateCommand+��5W      �� *SelectedItem+$ absenteGrid�� 5X        5Y      ��5[      �� 5\      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5]      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5^      $ 	#FF802E0C��6#   $ 1Q�65   � 5_      $ 	#FFF0AE9F��6#   5`      5b      �� 5c   
   -   5        $��Inapoi��5c      $
��Left=�6"   $��	15,0,0,26q�6=   $��Bottom=�6P   $	��110��6k   $��30��5d   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ 5e        5f      ��5h      �� 5i      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5j      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5k      $ 	#FF802E0C��6#   $ 1Q�65   � 5l      $ 	#FFF0AE9F��6#   5m      5o      �� 5p   
   $
��Left=�6   $��
38,206,0,0q�6/   $
��Wrap=�6C   $��Motivata��6W   $	��Top=�6g   $��31��6   $��82��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA$ 0.643,1.166&�6�   �� 5q   
   -   5         ��Name$ txtMotivata��5q      $	��142��6(   $
��Left=�64   $��125,207,0,182q�5r   y   $��16(�6�   $��Segoe Script)�6�    d� 	IsChecked 6   �� *SelectedItem.Motivata+$ absenteGrid��$ PropertyChanged=�6�   �� 5s   
   $
��Left=�6   $��
31,236,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��31��6o   $��94��6{   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA$ 0.643,1.166&�6�   �� 6�   $��14(�6   $�
Motivabila��6  6#  �� 5t   
   -   5        $ txtMotivabila��5t      $	��142��6*   $
��Left=�66   $��125,238,0,151q�5u   {   $��16(�6�   $��Segoe Script)�6�    6   �� *SelectedItem.Motivabila+$ absenteGrid��$ PropertyChanged=�6�   �� 5v   
   $
��Left=�6   $��	74,27,0,0q�6/   $
��Wrap=�6B   $
��Data��6V   $	��Top=�6b   $��31��6z   $��43��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5w   
   -	   5        $ txtData��5w      $	��142��6#   $
��Left=�6/   $��125,27,0,365.2q�5x   p   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Data+$ absenteGrid��$ PropertyChanged=�6�   5z      5{      