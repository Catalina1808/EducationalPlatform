   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   	   3clr-namespace:tema3.Converterstema3.Converters  5   	       tema3.Views.IerarhieView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   	   9localConverterclr-namespace:tema3.Converters     5   	     � Title$  IerarhieView��5	   	   $	��450��6   $��1360.703��6+    � DataContext 5
      !  tema3.ViewModels.IerarhieVM  5   
   .��5      � $��0,0,-6.6,-3q�6   ��5   
   �� 5       �� ImageSource$1 +/tema3;component/Images/fundal_profesor.jpg��6   6U    � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ premiantiGrid��5      $��42,53,1099.8,163.2q�6+      AutoGenerateColumns .  $��Visible=�5      $��Segoe Script)�6�   ���	#FFFCC093���	#FF0877E4���	#FF390BB3 J� RenderTransformOrigin$ 0.5,0.5&�6�   $��11(�6  ��6@   �� *	MediiList+ �� UpdateSourceTrigger$ PropertyChanged=�z�5      V� 5      .~�5      �� �� 5      �� 5      	 �� Angle$	 -0.057Q�6&   T� 5      5       
   Columns
 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Nume elev��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Item1+  5$      $ Medie��6%    64   �� *Item2+5&        5(   
   -   5        $ 	mediiGrid��5(      $��282,48,844.8,164.2q�6'    .  $��Visible=�5)      $��Segoe Script)�6�   ���	#FF0877E4���	#FF390BB3$ 0.5,0.5&�6�   $��11(�6�   ���	#FFFCC093��6@   �� *PremiantiList+$ PropertyChanged=�z�5*      V� 5+      .~�5,      �� �� 5-      �� 5.      $	 -0.057Q�6&   T� 5/      50      
 52        53      $ 	Nume elev��6%    68   �� *Item1+  54      $ Premiu��6%    65   �� *Item2+56      �� 57   
   -   5        $��Inapoi��57      $
��Left=�6"   $��15,0,0,26.2q�6=   $��Bottom=�6R   $	��110��6m   $��30��58   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ J� Effect 59      3  -System.Windows.Media.Effects.DropShadowEffect  5:      ��5<      �� 5=       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5>      �  � Color$ 	#FFD3632D��6#    � Offset$ 0.511Q�65   � 5?      $ 	#FF802E0C��6#   $ 1Q�65   � 5@      $ 	#FFF0AE9F��6#   5A      5C      �� 5D   
   $
��Left=�6   $��
331,10,0,0q�6/   $
��Wrap=�6C   $��	Premianti��6W   $	��Top=�6h   $��31��6�   $	��116��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5E        5F      5H      �� 5I   
   $��Center=�6   $��305,304,305.4,0q�61   $
��Wrap=�6J   $	��Top=�6^   $��48��6v   $	��496��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=� 5J        5K      5M      �� 5N   
   $
��Left=�6   $��	81,10,0,0q�6/   $
��Wrap=�6B   $��Ierarhie��6V   $	��Top=�6f   $��31��6~   $	��116��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5O        5P      5R        5S   
   -   5        $ corigentiGrid��5S      $��532,48,603.8,164.2q�6+    .  $��Visible=�5T      $��Segoe Script)�6�   ���	#FF0877E4���	#FF390BB3$ 0.5,0.5&�6�   $��11(�6�   ���	#FFFCC093��6@   �� *CorigentiList+$ PropertyChanged=�z�5U      V� 5V      .~�5W      �� �� 5X      �� 5Y      $	 -0.057Q�6&   T� 5Z      5[      
 5]        5^      $ 	Nume elev��6%    68   �� *Item1+  5_      $ Materie��6%    66   �� *Item2+5a      �� 5b   
   $
��Left=�6   $��
600,10,0,0q�6/   $
��Wrap=�6C   $��	Corigenti��6W   $	��Top=�6h   $��31��6�   $	��116��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5c        5d      5f        5g   
   -   5        $ repetentiGrid��5g      $��777,49,354.8,163.2q�6+    .  $��Visible=�5h      $��Segoe Script)�6�   ���	#FF0877E4���	#FF390BB3$ 0.5,0.5&�6�   $��11(�6�   ���	#FFFCC093��6@   �� *RepetentiList+$ PropertyChanged=�z�5i      V� 5j      .~�5k      �� �� 5l      �� 5m      $	 -0.057Q�6&   T� 5n      5o      
 5q        5r      $ 	Nume elev��6%    68   �� *Item1+  5s      $ Medie��6%    64   �� *Item2+5u      �� 5v   
   $
��Left=�6   $��
844,10,0,0q�6/   $
��Wrap=�6C   $��	Repetenti��6W   $	��Top=�6h   $��31��6�   $	��116��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5w        5x      5z        5{   
   -   5        $ exmatriculatiGrid��5{      $��1035,49,77.8,163.2q�6/    .  $��Visible=�5|      $��Segoe Script)�6�   ���	#FF0877E4���	#FF390BB3$ 0.5,0.5&�6�   $��11(�6�   ���	#FFFCC093��6@   �� *ExmatriculatiList+$ PropertyChanged=�z�5}      V� 5~      .~�5      �� �� 5�      �� 5�      $	 -0.057Q�6&   T� 5�      5�      
 5�        5�      $ 	Nume elev��6%    68   �� *Item1+  5�      $ Nr. absente��6%    6:   �� *Item2+5�      �� 5�   
   $
��Left=�6   $��1101,10,0,0q�6/   $
��Wrap=�6D   $��Exmatriculati��6X   $	��Top=�6m   $��31��6�   $	��156��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5�        5�      5�      5�      5�      