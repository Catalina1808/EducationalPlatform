   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   
       tema3.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   
     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	      #  tema3.ViewModels.MainWindowVM  5
   
   .��5      � ��5   
   �� 5       �� ImageSource$( "/tema3;component/Images/fundal.jpg��6   6L   .+�5   
   �� $
��Left=�6   $��
338,33,0,0q�6/   $
��Wrap=�6C   $��Login��6W   $	��Top=�6d   $��53��6|   $	��125��6�   $��36(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAF8F8 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FF2E81B3��6#   5      �� 5   
   $
��Left=�6   $��213,110,0,0q�6/   $
��Wrap=�6D   $��Username��6X   $	��Top=�6h   $��36��6�   $	��125��6�   $��20(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFFAFAFA6�   �� 5   
   $
��Left=�6   $��213,169,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��36��6p   $	��125��6|   $��20(�6�   $��Segoe Script)�6�   $
��Bold"�6�   �� 6�   ���	#FFFCF6F6$�Password��6�   6�   �� 5   
   -   5         ��Name$ txtUsername��5      $	��200��6'   $
��Left=�63   $��338,115,0,274q�5   O   $��18(�6f   $��Segoe Script)�6t   ��6   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6t   �� 5   
   -   5        $ txtPassword��5      $	��200��6'   $
��Left=�63   $��338,169,0,220q�5   M   $��18(�6d   $*��$/tema3;component/Resources/#Password)�6s   ��6   �� *
Password+$ PropertyChanged=�6s   �� 5   
   $��Login as profesor��6   $
��Left=�6-   $��200,0,0,134q�6H   $��Bottom=�6]   $	��174��6x   $��1��5   7   $��34��6L   $��Segoe Script)�6X   $��18(�6r   $
��Bold"�6�   ���	#FF0E2E42��6   �� *OpenWindowCommand+ 5        5      ��5       �� 5!       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5"      � 	 � Color$	 	#FF254E7C��6#   
 � Offset$
 0Q�65   � 5#      $	 	#FF89E6EB��6#   $
 1Q�65   5$      5&      �� 5'   
   $��Login as admin��6   $
��Left=�6*   $��318,304,0,0q�6E   $	��Top=�6Z   $	��174��6r   $��3��5(   3   $��34��6H   $��Segoe Script)�6T   $��18(�6n   $
��Bold"�6|   ���	#FF0E2E42��6   �� *OpenWindowCommand+ 5)        5*      ��5,      �� 5-      $ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67   $ 0.5,0&�6[   .��5.      � $	 	#FF254E7C��6#   $
 1Q�65   � 5/      $	 	#FF89E6EB��6#   50      52      �� 53   
   $��Center=�6   $��162,210,175.6,0q�61   $
��Wrap=�6J   $	��Top=�6^   $��36��6v   $	��456��6�   $��18(�6�   $��Segoe Script)�6�   $
��Bold"�6�   ���	#FFEA0D0D �� TextAlignment$ Center=�6�   ��6�   �� *ErrorMessage+$ PropertyChanged=��� 54   
   $��Login as elev��6   $
��Left=�6)   $��419,0,0,134q�6D   $��Bottom=�6Y   $	��174��6t   $��2��55   3   $��34��6H   $��Segoe Script)�6T   $��18(�6n   $
��Bold"�6|   ���	#FF0E2E42 J� RenderTransformOrigin$ 0.617,0.518&�6�   ��6   �� *OpenWindowCommand+ 56        57      ��59      �� 5:      $ 0.5,1&�6&   $ 0.5,0&�67   .��5;      � $	 	#FF254E7C��6#   $
 0Q�65   � 5<      $	 	#FF89E6EB��6#   $
 1Q�65   5=      5?      �� 5@   
   $��	Diriginte��6T   $
��Left=�6h   $��200,301,0,0q�6�   $	��Top=�6�   $��Segoe Script)�6�   $��16(�6�   $
��Bold"�6�   ���	#FFFAF4F4 d� 	IsChecked 6   �� *Dirig+$ PropertyChanged=�6�   5C      5D      