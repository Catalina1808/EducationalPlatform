   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   
   3clr-namespace:tema3.Converterstema3.Converters  5   	       tema3.Views.MedieElevView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   
   9localConverterclr-namespace:tema3.Converters     5   	     � Title$  MedieElevView��5	   	   $	��450��6   $	��800��6,    � DataContext 5
      "  tema3.ViewModels.MedieElevVM  5   
   .��5      � $��0,0,-6.6,-3q�6   ��5   
   �� 5       �� ImageSource$1 +/tema3;component/Images/fundal_profesor.jpg��6   6U    � 	Resources 5   
   '  !tema3.Converters.MedieElevConvert   medieConvert��%   &	          5      6.   5       � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� $
��Left=�6   $��	42,87,0,0q�6/   $
��Wrap=�6B   $��	Nume elev��6V   $	��Top=�6g   $��31��6   $��83��6�   $��14(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5         ��Name$ txtElevN��5      $	��142��6$   $
��Left=�60   $��125,82,0,310.2q�5   o   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.ElevN+ �� ElementName$ 	mediiGrid�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $
��Left=�6   $��
14,119,0,0q�6/   $
��Wrap=�6C   $��Prenume elev��6W   $	��Top=�6k   $��31��6�   $	��111��6�   $��14(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   -   5        $ txtElevP��5      $	��142��6$   $
��Left=�60   $��125,119,0,273.2q�5   o   $��16(�6�   $��Segoe Script)�6�   ��6   �� *SelectedItem.ElevP+$ 	mediiGrid��$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5!   
   -   5        	  Name$	 	mediiGrid��5!      $��300,19,60,173.2q�6'   
   AutoGenerateColumns
 .  $��Visible=�5"      $��Segoe Script)�6�   ���	#FFFCC093���	#FF0877E4���	#FF390BB3 J� RenderTransformOrigin$ 0.5,0.5&�6�   $��11(�6  ��6@   �� *	MediiList+$ PropertyChanged=�z�5#      V� 5$      .~�5%      �� �� 5&      �� 5'       �� Angle$ -0.057Q�6&   T� 5(      5)         Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Nume elev��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *ElevN+  5-      $ Prenume elev��6%    6;   �� *ElevP+  5.      $ Materie��6%    66   �� *	Materie+  5/      $ Medie��6%    64   �� *Medie+  50      $ Semestru��6%    67   �� *
Semestru+52      �� 56   
   $��
Vezi medii��6   $��Segoe Script)�6'   $��18(�6A   $
��Bold"�6O   ���	#FFF5F7F7$��325,309,288,72.2q�6x   $ 0.664,0.587&�57      ��56   �   �� *UpdateCommand+��58      `� 59       `� 	Converter# [  6   .1�5:      �� $ txtElevN��6    �� Path$
 Text�65   �� 5;      $ txtElevP��6   $
 Text�65   5<       J� Effect 5>      3  -System.Windows.Media.Effects.DropShadowEffect  5?      ��5A      �� 5B       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5C      �  � Color$ 	#FFD3632D��6#    � Offset$ 0.511Q�65   � 5D      $ 	#FF802E0C��6#   $ 1Q�65   � 5E      $ 	#FFF0AE9F��6#   5F      5H      �� 5I   
   -   5        $��Inapoi��5I      $
��Left=�6"   $��	15,0,0,26q�6=   $��Bottom=�6P   $	��110��6k   $��30��5J   3   $��Segoe Script)�6?   $��16(�6Y   $
��Bold"�6g   ���	#FF020006��6   �� *OpenWindowCommand+ 5K        5L      ��5N      �� 5O      $ 0.5,1&�6&   $ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5P      � $ 	#FFD3632D��6#   $ 0.511Q�65   � 5Q      $ 	#FF802E0C��6#   $ 1Q�65   � 5R      $ 	#FFF0AE9F��6#   5S      5U      �� 5V   
   $
��Left=�6   $��151,286,0,0q�6/   $
��Wrap=�6D   $��Medie generala��6X   $	��Top=�6n   $��31��6�   $	��169��6�   $��18(�6�   $��Segoe Script)�6�   ���	#FFF7EEEE$
��Bold"�6�    5W        5X      5Z      �� 5[   
   -   5        $ 	txtMedieG��5[      $��72��6%   $
��Left=�60   $��195,317,0,75.2q�5\   M   $��16(�6e   $��Segoe Script)�6s   ���	#FFF4BCA5$ 1.118,0.314&�6�   ��6   �� *MedieG+$ PropertyChanged=�6�   �� 5]   
   $��Center=�6   $��42,155,559,0q�61   $
��Wrap=�6G   $	��Top=�6[   $��96��6s   $	��199��6   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=�5_      5`      