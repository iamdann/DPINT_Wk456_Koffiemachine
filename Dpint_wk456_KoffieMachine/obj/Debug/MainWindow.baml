   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   f bGalaSoft.MvvmLight.Platform, Version=5.3.0.19032, Culture=neutral, PublicKeyToken=5f873c45e98af8a1lMclr-namespace:GalaSoft.MvvmLight.Command;assembly=GalaSoft.MvvmLight.PlatformGalaSoft.MvvmLight.Command 5   	   T PDpint_wk456_KoffieMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Dpint_wk456_KoffieMachine.Helpers!Dpint_wk456_KoffieMachine.Helpers 5	   	   *   $Dpint_wk456_KoffieMachine.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   .c&clr-namespace:System;assembly=mscorlib  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   WcmdMclr-namespace:GalaSoft.MvvmLight.Command;assembly=GalaSoft.MvvmLight.Platform  5   	   =helpers/clr-namespace:Dpint_wk456_KoffieMachine.Helpers  5	   	     � Title$  
MainWindow��5   	   $��746.118��6   $	��900��6-    � DataContext 5   	   �� *Main+   Locator �� Source# [   � 	Resources 5      > 8Dpint_wk456_KoffieMachine.Helpers.EnumToBooleanConverter  
EnumToBool 
 5cents  10cents  20cents  50cents 	 1euro 
 2euros �� 
TargetType  DrinkButton �� 	Resources �� Property �� Value��%�  &	       &	      &	 >     &	 j     &	 �     &	 �     &	 �     &	       5   
   6)   �� 5   
   $��Images/5cents.png��6   �� 5   
   $��Images/10cents.png��6    �� 5   
   $��Images/20cents.png��6    �� 5   
   $��Images/50cents.png��6    �� 5   
   $��Images/1euro.png��6   �� 5   
   $��Images/2euros.png��6   �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��TextAlignment$ Center=�66   �� 5       � ��$
 Wrap=�65   5      5      .�5      ��  � ��$ 5q�6'   �� 5       � ��$ 5q�6(   �� 5       � ��$ 80��6&   �� 5       � ��$ 50��6'   �� 5        � ��$	 Top=�62   5!      5"      .��5#      � -   5        $��	MainPanel��5#       � ColumnDefinitions 5$   
   �� 5%      $��2* �6   6,   �� 5&      $��3* �6   6,   �� 5'      $��1* �6   6,   .+�5)   
   �� $��1��6   $��1q�6!   $��0��65   
���   �6B   �� 5*   
   $��2��6   $��1q�6!   $��0��65   
���   �6B   �� 5+   
   $��0��6   
���   �
���/���$��5q�6n   9  3Dpint_wk456_KoffieMachine.Helpers.SelectorExtenders	   IsAutoscroll	 . ��6"   �� *	LogText+5,      �� 5-   
   -   5        $��SelectionPanel��5-   <   $��1��6   
 �� Orientation$
 Vertical=�6%   $��5q�6R   .+�5.      � -   5        $��StrengthsPanel��5.       5/      �� 50      �� 51      �� 52      .+�54      �� $��0��6   $
 Vertical=�6-   $��Center=�6D   .+�55      �� $
��Bold"�6   .��6.   
Strength68   	� 56       	� 	GroupName$ Strength��6"    d� 	IsChecked 67   ��  �� Path$ CoffeeStrength� �� 	Converter# [  �� ConverterParameter$
 Weak��.��6�   Weak6�   	� 57      $ Strength��6"    67   �� $ CoffeeStrength�# [ $ Normal��.��6�   Normal6�   	� 58      $ Strength��6"    67   �� $ CoffeeStrength�# [ $ Strong��.��6�   Strong6�   59      �� 5:      $��1��6   $
 Vertical=�6-   $��Center=�6D   .+�5;      �� $
��Bold"�6   .��6.   Sugar65   	� 5<      $ Sugar��6"    64   �� $ SugarAmount�# [ $	 Few��.��6�   Few6�   	� 5=      $ Sugar��6"    64   �� $ SugarAmount�# [ $ Normal��.��6�   Normal6�   	� 5>      $ Sugar��6"    64   �� $ SugarAmount�# [ $ Extra��.��6�   Extra6�   5?      �� 5@      $��2��6   $
 Vertical=�6-   $��Center=�6D   .+�5A      �� $
��Bold"�6   .��6.   Milk64   	� 5B      $
 Milk��6"    63   �� $ 
MilkAmount�# [ $	 Few��.��6�   Few6�   	� 5C      $
 Milk��6"    63   �� $ 
MilkAmount�# [ $ Normal��.��6�   Normal6�   	� 5D      $
 Milk��6"    63   �� $ 
MilkAmount�# [ $ Extra��.��6�   Extra6�   5E      5F      �� 5G      �� 5H      $��Coffee��6   $
��Bold"�6%   �� 5I      -   5        $��CoffeePanel��5I   2   $
 
Horizontal=�6   $��Center=�6E   $��5q�6b   .+�5J      �� $��Coffee��6:   #��[ 6T   ��6   �� *DrinkCommand+.��5K      �� Coffee6(   5L      �� 5M      $��Coffee��6C   #��[ 6]   ��6   �� *DrinkWithSugarCommand+.��5N      �� Coffee + sugar60   5O      �� 5P      $��Coffee��6B   #��[ 6\   ��6   �� *DrinkWithMilkCommand+.��5Q      �� Coffee + milk6/   5R      �� 5S      $��Coffee��6J   #��[ 6d   ��6   �� *DrinkWithSugarAndMilkCommand+.��5T      �� Coffee + sugar + milk67   5U      5V      �� 5W      �� 5X      $��Espresso��6   $
��Bold"�6'   �� 5Y      -   5        $��EsspressoPanel��5Y   2   $
 
Horizontal=�6   $��Center=�6H   $��5q�6e   .+�5Z      �� $��Espresso��6:   #��[ 6V   ��6   �� *DrinkCommand+.��5[      �� 
Espresso6*   5\      �� 5]      $��Espresso��6C   #��[ 6_   ��6   �� *DrinkWithSugarCommand+.��5^      �� Espresso + sugar62   5_      �� 5`      $��Espresso��6B   #��[ 6^   ��6   �� *DrinkWithMilkCommand+.��5a      �� Espresso + milk61   5b      �� 5c      $��Espresso��6J   #��[ 6f   ��6   �� *DrinkWithSugarAndMilkCommand+.��5d      �� Espresso + sugar + milk69   5e      5f      �� 5g      �� 5h      $��Specialties��6   $
��Bold"�6*   �� 5i      -   5        $��SpecialtiesPanel��5i   2   $
 
Horizontal=�6   $��Center=�6J   $��5q�6g   .+�5j      �� $��	Capuccino��6:   #��[ 6W   ��6   �� *DrinkCommand+.��5k      �� 	Capuccino6+   5l      �� 5m      $��	Capuccino��6C   #��[ 6`   ��6   �� *DrinkWithSugarCommand+.��5n      �� Capuccino + sugar63   5o      �� 5p      $��Wiener Melange��6:   #��[ 6\   ��6   �� *DrinkCommand+.��5q      �� Wiener Melange60   5r      �� 5s      $��Café au Lait��6:   #��[ 6Z   ��6   �� *DrinkCommand+.��5t      �� Café au Lait6.   5u      5v      �� 5w      �� 5x      $��	Chocolate��6   $
��Bold"�6(   �� 5y      -   5        $��ChocolatePanel��5y   2   $
 
Horizontal=�6   $��Center=�6H   $
��38,5q�6e   $	��360��6s   .+�5z      �� $��	Chocolate��6:   #��[ 6W   ��6   �� *DrinkCommand+.��5{      �� �� 6!   $�	Chocolate��6%   69   5|      �� 5}      $��Chocolate Deluxe��6:   #��[ 6^   ��6   �� *DrinkCommand+.��5~      �� �� 6!   $�Chocolate Deluxe��6%   6@   5      �� 5�      $��
CoffeeChoc��6:   #��[ 6X   ��6   �� *DrinkCommand+.��5�      �� $��
CoffeeChoc��6    5�      5�      �� 5�      �� 5�      $	��Tea��6   $
��Bold"�6"   �� 5�      -   5         ��Name$ TeaPanel��5�   2   $
 
Horizontal=�6   $��Center=�6D   $��	38,5,80,5q�6a   $��82��6t   $	��318��6�   .+�5�      �� $	��Tea��6:   #��[ 6Q   ��6   �� *DrinkCommand+.��5�      �� �� 6!   $	�Tea��6%   63   5�      �� 5�      $	��Tea��6C   #��[ 6Z   ��6   �� *DrinkWithSugarCommand+.��5�      �� �� 6!   $�Tea + sugar��6%   6;   5�      �� 5�      $��0��6   $
 Vertical=�6-   $��Center=�6D   .+�5�      �� $
��Bold"�6   $��Blend��6.   	� 5�      $ Strength��6"   $��	Green Tea��6�    67   �� *
TeaBlend+$ GreenTea��# [ 6�   	� 5�      $ Strength��6"   $��	Lemon Tea��6�    67   �� *
TeaBlend+$ LemonTea��# [ 6�   	� 5�      $ Strength��6"   $��Fruity Iced Tea��6�    67   �� *
TeaBlend+$ FruityIcedTea��# [ 6�   5�      5�      �� 5�      �� 5�      $��	Alcoholic��6   $
��Bold"�6(   $��Right=�6:   $	��436��6V   �� 5�      -	   5        $ TeaPanel_Copy��5�   2   $
 
Horizontal=�6   $��Center=�6I   $��	38,5,80,5q�6f   $��65��6y   $	��318��6�   .+�5�      �� $��IrishCoffee��6:   #��[ 6Y   ��6   �� *DrinkCommand+.��5�      ��  J� RenderTransformOrigin$ 0.5,0.5&�6    $��57��6@   $��Irish Coffee��6K   5�      �� 5�      $��SpanishCoffee��6C   #��[ 6d   ��6   �� *DrinkWithSugarCommand+.��5�      �� �� 6!   $�Spanish Coffee��6%   6>   5�      �� 5�      $��0��6   $
 Vertical=�6-   $��Center=�6D   �� 5�      $��ItalianCoffee��6C   #��[ 6d   $��5,5,5,0q�6�   ��6   �� *DrinkWithSugarCommand+.��5�      �� �� 6!   $�Italian Coffee��6%   6>   5�      5�      5�      �� 5�   
   -
   5        $��Payment��5�   G   $��2��6   $
 Vertical=�6%   $��5q�6<   .+�5�      �� $��Center=�6   $��14(�61   .��6?   Payment by card6P   �� 5�      $��Center=�6   $��WrapWithOverflow=�65   " Enter the username on your card:6w   �� 5�      ��6   �� *PaymentCardUsernames+ �� SelectedValue 6D   �� *SelectedPaymentCardUsername+�� 5�      $��8(�6   $��Center=�6%   $
��Wrap=�6B   ��6V   �� $  PaymentCardRemainingAmount� �� StringFormat$* $Remaining amount on card €{0:0.00}���� 5�      $��5q�6<   ��6   �� *PayByCardCommand+.��6G   Pay6L   �� 5�      �� 5�      $��Center=�6   $��14(�61   .��6?   Payment by coins6Q   � 5�       5�      �� 5�      $��* �6'   �� 5�      $��* �6'    � RowDefinitions 5�      �� 5�      $��60 �6$   �� 5�      $��60 �6$   �� 5�      $��60 �6$   .+�5�      �� $��0��6   $��0��6&   $��60��6[   $��60��6f   #��[ 5�      
������ $��0q�6T   ��5�   6   �� *PayByCoinCommand+��5�      X�5�      0.05Q�6)   5�      �� 5�      $��0��6   $��1��6&   $��60��6[   $��60��6f   #��[ 5�      
������ $��0q�6U   ��5�   6   �� *PayByCoinCommand+��5�      X�5�      0.1Q�6(   5�      �� 5�      $��1��6   $��0��6&   $��60��6[   $��60��6f   #��[ 5�      
������ $��0q�6U   ��5�   6   �� *PayByCoinCommand+��5�      X�5�      0.2Q�6(   5�      �� 5�      $��1��6   $��1��6&   $��60��6[   $��60��6f   #��[ 5�      
������ $��0q�6U   ��5�   6   �� *PayByCoinCommand+��5�      X�5�      0.5Q�6(   5�      �� 5�      $��2��6   $��0��6&   $��60��6[   $��60��6f   #��[ 5�      
������ $��0q�6S   ��5�   6   �� *PayByCoinCommand+��5�      X�5�      1Q�6&   5�      �� 5�      $��2��6   $��1��6&   $��60��6[   $��60��6f   #��[ 5�      
������ $��0q�6T   ��5�   6   �� *PayByCoinCommand+��5�      X�5�      2Q�6&   5�      5�      5�      5�      5�      