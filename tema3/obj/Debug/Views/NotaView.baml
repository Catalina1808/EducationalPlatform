   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   	   3clr-namespace:tema3.Converterstema3.Converters  5   	       tema3.Views.NotaView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   	   9localConverterclr-namespace:tema3.Converters     5   	     � Title$  NotaView��5	   	   $	��450��6   $	��800��6'    � DataContext 5        tema3.ViewModels.NotaVM  5   
   .��5      � $��0,0,-6.6,-3q�6   ��5   
   �� 5       �� ImageSource$1 +/tema3;component/Images/fundal_profesor.jpg��6   6U    � 	Resources 5   
   "  tema3.Converters.NotaConvert   notaConvert��%   &	          5      6)   5      .+�5   
   �� $
��Left=�6   $��	42,64,0,0q�6/   $
��Wrap=�6B   $��Materie��6V   $	��Top=�6e   $��31��6}   $��75��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5         ��Name$ 
txtMaterie��5      $	��142��6&   $
��Left=�62   $��125,64,0,330q�5   p   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Materie+ �� ElementName$ noteGrid�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
42,103,0,0q�6/   $
��Wrap=�6C   $��	Nume elev��6W   $	��Top=�6h   $��31��6�   $��83��6�   $��14(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ txtElevN��5      $	��142��6$   $
��Left=�60   $��125,98,0,294q�5   n   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.ElevN+$ noteGrid��$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
14,134,0,0q�6/   $
��Wrap=�6C   $��Prenume elev��6W   $	��Top=�6k   $��31��6�   $	��111��6�   $��14(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ txtElevP��5      $	��142��6$   $
��Left=�60   $��125,134,0,258q�5   n   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.ElevP+$ noteGrid��$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
36,170,0,0q�6/   $
��Wrap=�6C   $��Semestru��6W   $	��Top=�6g   $��31��6   $��89��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ txtSemestru��5      $	��142��6'   $
��Left=�63   $��125,170,0,222q�5    q   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Semestru+$ noteGrid��$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ noteGrid��5"      $��288,19,29.2,173q�6&      AutoGenerateColumns .  $��Visible=�5#      $��Segoe Script)�6e   ���	#FFFCC093���	#FF0877E4���	#FF390BB3	 J� RenderTransformOrigin$	 0.5,0.5&�6�   $��11(�6�   ��6@   �� *NoteListProf+z�5$      V� 5%      .~�5&      �� �� 5'      �� 5(      
 �� Angle$
 -0.057Q�6&   T� 5)      5*         Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nota��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Nota+  5.      $ 	Nume elev��6%    68   �� *ElevN+  5/      $ Prenume elev��6%    6;   �� *ElevP+  50      $ Materie��6%    66   �� *	Materie+  51      $ Semestru��6%    67   �� *
Semestru+  52      $
 Teza��6%    63   �� *Teza+54      �� 55   
   $��Center=�6   $��74,274,32.2,0q�61   $
��Wrap=�6H   $	��Top=�6\   $��36��6t   $	��694��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=��� 58   
   $��Adauga nota��6   $��250,310,378.2,66q�6'   $��Segoe Script)�6A   $��18(�6[   $
��Bold"�6i   ���	#FFE9F2F3��6�   �� *
AddCommand+��59      `� 5:       `� 	Converter# [  6   .1�5;      �� $ 
txtMaterie��6    �� Path$
 Text�67   �� 5<      $ txtElevN��6   $
 Text�65   �� 5=      $ txtElevP��6   $
 Text�65   �� 5>      $ txtNota��6   $
 Text�64   �� 5?      $ txtTeza��6   $ 	IsChecked�64   �� 5@      $ txtSemestru��6   $
 Text�68   5A       J� Effect 5C      3  -System.Windows.Media.Effects.DropShadowEffect  5D      ��5F      �� 5G       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5H      �  � Color$ 	#FFD3632D��6#    � Offset$ 0.511Q�65   � 5I      $ 	#FF802E0C��6#   $ 1Q�65   � 5J      $ 	#FFF0AE9F��6#   5K      5M      �� 5N   
   $��Anulare nota��6   $��Segoe Script)�6)   $��18(�6C   $
��Bold"�6Q   ���	#FFF5F7F7$��462,310,134.2,66q�6z   ��6�   �� *DeleteCommand+��5O      �� *SelectedItem+$ noteGrid�� 5P        5Q      ��5S      �� 5T      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5U      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5V      $ 	#FF802E0C��6#   $ 1Q�65   � 5W      $ 	#FFF0AE9F��6#   5X      5Z      �� 5[   
   -   5        $��Inapoi��5[      $
��Left=�6"   $��15,0,0,25.8q�6=   $��Bottom=�6R   $	��110��6m   $��30��5\   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ 5]        5^      ��5`      �� 5a      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5b      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5c      $ 	#FF802E0C��6#   $ 1Q�65   � 5d      $ 	#FFF0AE9F��6#   5e      5g      �� 5h   
   $
��Left=�6   $��
38,206,0,0q�6/   $
��Wrap=�6C   $
��Teza��6W   $	��Top=�6c   $��31��6{   $��82��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA$	 0.643,1.166&�6�   �� 5i   
   -   5         ��Name$ txtTeza��5i      $	��142��6$   $
��Left=�60   $��125,207,0,181.8q�5j   r   $��16(�6�   $��Segoe Script)�6�    d� 	IsChecked 6   �� *SelectedItem.Teza+$ noteGrid��$ PropertyChanged=�6�   �� 5k   
   $
��Left=�6   $��	74,27,0,0q�6/   $
��Wrap=�6B   $
��Nota��6V   $	��Top=�6b   $��31��6z   $��43��6�   $��16(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5l   
   -   5        $ txtNota��5l      $	��142��6#   $
��Left=�6/   $��125,27,0,365q�5m   m   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.Nota+$ noteGrid��$ PropertyChanged=�6�   5o      5p      