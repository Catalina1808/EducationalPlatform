   M S B A M L   `   `   `  ����@  <tema3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema3.ViewModelstema3.ViewModels  5   	       tema3.Views.ProfesorView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema3.ViewModels     5   	     � Title$  ProfesorView��5   	   $	��450��6   $	��800��6+    � DataContext 5	      !  tema3.ViewModels.ProfesorVM  5
   
   .��5      � ��5   
   �� 5       �� ImageSource$1 +/tema3;component/Images/fundal_profesor.jpg��6   6U   .+�5   
   �� $��Editare absente��6   $
��Left=�6+   $��299,0,0,328q�6F   $��Bottom=�6[   $	��174��6v   $��1��5   3   $��34��6H   $��Segoe Script)�6T   $��18(�6n   $
��Bold"�6|   ���	#FFF7F7F1��6   �� *OpenWindowCommand+ J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF992416��6#    � Offset$ 0Q�65   � 5      $ 	#FFE29D60��6#   $ 1Q�65   5      5      �� 5   
   $��Editare note��6   $
��Left=�6(   $��299,0,0,270q�6C   $��Bottom=�6X   $	��174��6s   $��2��5   3   $��34��6H   $��Segoe Script)�6T   $��18(�6n   $
��Bold"�6|   ���	#FFF7F7F1��6   �� *OpenWindowCommand+ 5        5      ��5!      �� 5"      $ 0.5,1&�6&   $ 0.5,0&�67   .��5#      � $ 	#FF992416��6#   $ 0Q�65   � 5$      $ 	#FFE29D60��6#   $ 1Q�65   5%      5'      �� 5(   
   $��Adaugare material��6   $
��Left=�6-   $��269,0,0,208q�6H   $��Bottom=�6]   $	��228��6x   $��3��5)   3   $��34��6H   $��Segoe Script)�6T   $��18(�6n   $
��Bold"�6|   ���	#FFF7F7F1��6   �� *OpenWindowCommand+ 5*        5+      ��5-      �� 5.      $ 0.5,1&�6&   $ 0.5,0&�67   .��5/      � $ 	#FF992416��6#   $ 0Q�65   � 50      $ 	#FFE29D60��6#   $ 1Q�65   51      53      �� 54   
   $��Calcul medii��6   $
��Left=�6(   $��299,0,0,144q�6C   $��Bottom=�6X   $	��174��6s   $��4��55   3   $��34��6H   $��Segoe Script)�6T   $��18(�6n   $
��Bold"�6|   ���	#FFF7F7F1��6   �� *OpenWindowCommand+ 56        57      ��59      �� 5:      $ 0.5,1&�6&   $ 0.5,0&�67   .��5;      � $ 	#FF992416��6#   $ 0Q�65   � 5<      $ 	#FFE29D60��6#   $ 1Q�65   5=      5?      �� 5@   
   $��Inapoi��6   $
��Left=�6"   $��	47,0,0,28q�6=   $��Bottom=�6P   $	��111��6k   $��5��5A   3   $��28��6H   $��Segoe Script)�6T   $��16(�6n   $
��Bold"�6|   ���	#FF0F0400��6   �� *OpenWindowCommand+ 5B        5C      ��5E      �� 5F      $ 0.5,1&�6&   $ 0.5,0&�67   .��5G      � $ 	#FF992416��6#   $ 0Q�65   � 5H      $ 	#FFE29D60��6#   $ 1Q�65   5I      5K      5M      5N      