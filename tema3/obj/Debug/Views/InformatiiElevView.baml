   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   	   3clr-namespace:tema3.Converterstema3.Converters  5   	   $    tema3.Views.InformatiiElevView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   	   5
Convertersclr-namespace:tema3.Converters     5   	     � Title$  InformatiiElevView��5	   	   $��503.195��6$   $��896.326��65    � 	Resources 5
      )  #tema3.Converters.MaterieElevConvert   materieElevConvert��%   &	          5   
   6(   5       � DataContext 5      '  !tema3.ViewModels.InformatiiElevVM  5   
   .��5      � ��5   
   �� 5       �� ImageSource$- '/tema3;component/Images/fundal_elev.jpg��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ noteGrid��5      $��44,125,610.6,143.6q�6&      AutoGenerateColumns .  $��Visible=�5      $��Segoe Script)�6�   ���	#FFFCC093���	#FF0877E4���	#FF390BB3 J� RenderTransformOrigin$ 0.464,0.311&�6�   $��11(�6
  ��6@   �� *
NoteList+ �� UpdateSourceTrigger$ PropertyChanged=�z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.02Q�6$   �� 5      	 �� Angle$	 -0.048Q�6&   T� 5      
 T� X$
 -0.031Q�6)    T� Y$
 0.01Q�64   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Materie��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Item1+  5       $
 Nota��6%    63   �� *Item2+  5!      $
 Teza��6%    63   �� *Item3+  5"      $ Semestru��6%    67   �� *Item4+5$        5&   
   -   5        $ absenteGrid��5&      $��311,126,322.6,135.6q�6)    .  $��Visible=�5'      $��Segoe Script)�6�   ���	#FF0877E4���	#FF390BB3$ 0.5,0.5&�6�   $��11(�6�   ���	#FFFCC093��6@   �� *AbsenteList+$ PropertyChanged=�z�5(      V� 5)      .~�5*      �� �� 5+      $ -0.02Q�6$   �� 5,      $	 -0.048Q�6&   T� 5-      5.       50        51      $ Materie��6%    66   �� *Item1+  52      $
 Data��6%    63   �� *Item2+54      �� 55   
   -   5        $��Inapoi��55      $
��Left=�6"   $��	15,0,0,23q�6=   $��Bottom=�6P   $��93��6k   $��30��56   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ J� Effect 57      3  -System.Windows.Media.Effects.DropShadowEffect  58      ��5:      �� 5;       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5<      �  � Color$ 	#FFD3632D��6#    � Offset$ 0.511Q�65   � 5=      $ 	#FF802E0C��6#   $ 1Q�65   � 5>      $ 	#FFF0AE9F��6#   5?      5A      �� 5B   
   $
��Left=�6   $��
389,85,0,0q�6/   $
��Wrap=�6C   $��Absente��6W   $	��Top=�6f   $��31��6~   $��98��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5C        5D      5F      �� 5G   
   $
��Left=�6   $��
110,85,0,0q�6/   $
��Wrap=�6C   $
��Note��6W   $	��Top=�6c   $��31��6{   $��65��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5H        5I      5K        5L   
   -   5        $ 	mediiGrid��5L      $��599,123,25.6,140.6q�6'    .  $��Visible=�5M      $��Segoe Script)�6�   ���	#FF0877E4���	#FF390BB3$ 0.5,0.5&�6�   $��11(�6�   ���	#FFFCC093��6@   �� *	MediiList+$ PropertyChanged=�z�5N      V� 5O      .~�5P      �� �� 5Q      $ -0.02Q�6$   �� 5R      $	 -0.029Q�6&   T� 5S      5T       5V        5W      $ Materie��6%    66   �� *Item1+  5X      $ Medie��6%    64   �� *Item2+  5Y      $ Semestru��6%    67   �� *Item3+5[      �� 5\   
   $
��Left=�6   $��
697,85,0,0q�6/   $
��Wrap=�6C   $��Medii��6W   $	��Top=�6d   $��31��6|   $��75��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5]        5^      5`      �� 5a   
   $
��Left=�6   $��649,346,0,0q�6/   $
��Wrap=�6D   $��Medie generala��6X   $	��Top=�6n   $��31��6�   $	��169��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5b        5c      5e      �� 5f   
   -   5         ��Name$ 	txtMedieG��5f      $��72��6%   $
��Left=�60   $��697,382,0,59.6q�5g   L   $��16(�6d   $��Segoe Script)�6r   ���	#FFF4BCA5$ 1.118,0.314&�6�   ��6   �� *MedieG+$ PropertyChanged=�6�   �� 5h   
   $
��Left=�6   $��	59,42,0,0q�6/   $
��Wrap=�6B   $��Materie��6V   $	��Top=�6e   $��31��6}   $��78��6�   $��14(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5i   
   -   5        $ 
txtMaterie��5i      $	��142��6&   $
��Left=�62   $��142,37,0,405.6q�5j   M   $��16(�6e   $��Segoe Script)�6s   ��6   �� *	Materie+$ PropertyChanged=�6s   �� 5l   
   $��Afiseaza��6   $��Segoe Script)�6%   $��16(�6?   $
��Bold"�6M   ���	#FFF5F7F7$��319,37,441.6,405.6q�6v   $ 0.664,0.587&�5m      ��5l   �   �� *UpdateCommand+��5n      `� 5o       `� 	Converter# [  6   .1�5p      ��  �� ElementName$ 
txtMaterie��6    �� Path$
 Text�67   5q       5s        5t      ��5v      �� 5w      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5x      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5y      $ 	#FF802E0C��6#   $ 1Q�65   � 5z      $ 	#FFF0AE9F��6#   5{      5}      �� 5~   
   $��Center=�6   $��492,37,71.6,0q�61   $
��Wrap=�6H   $	��Top=�6\   $��48��6t   $	��326��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=�5�      5�      