   M S B A M L   `   `   `  ����\  XMidterm - Cory_Bridgman_991199354, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Midterm___Cory_Bridgman_991199354!Midterm___Cory_Bridgman_991199354  5   	   3    -Midterm___Cory_Bridgman_991199354.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Midterm___Cory_Bridgman_991199354     5   	   -   5          �Name$  loginWindow��5   	    � Title$ LoginWindow��5   	   $	��225��6   $	��400��6*   ��5
      
� 5   
   .��5      �  � Color$ 	#FF678086��6    � Offset$ 1Q�6-   � 5      $ 	#FFCDE6ED��6   $ 0Q�6-   5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��106* �6   �� 5      $
��103* �6   .+�5   
   �� -   5         ��Name$ lblLogin��5      $��Please log in to continue��6"   $��100,0,100,70q�6F   $��Center=�5      $��2��64   $��26��6H   $��Bottom=�6T   $��Italic$�6o   �� 5   
   $��	Username:��6   $��	0,0,42,34q�6$   $��Right=�67   $��0��6Z   $��0��6g   $
��Bold"�6w   $��Right=�5      $��76��6,   $��25��67   $��Bottom=�6C   �� 5    
   -   5         ��Name$ userName��5       $��5,0,0,34q�6$   $��0��66   $��1��6C   $��Bottom=�6S   $
��Left=�6n      txtBoxStyle#��[  6�   �� 5"   
   $��	Password:��6   $��0,9,42,0q�6$   $��1��66   $��0��6C   $
��Bold"�6S   $��Right=�5#      $��25��63   $	��Top=�6?   $��Right=�6W   $��76��6s   G� 5%   
   -   5         G�Name$ userPw��5%      $
��Left=�6&   $��5,9,0,0q�6A   $	��Top=�6R   $	��150��6j   $��25��6v   $��1��6�   $��1��6�   ���	#1FFFFFFF
���   �$��0,0,0,2q�5&   A   �� 5)   
   -   5        	 ��Name$	 loginBtn��5)      $��Login��6#   $��0��63   $��Right=�6C   $��	0,52,42,0q�6_   $��1��6r   $	��Top=�6   $��25��6�   $��60��6�   
�������$
��Bold"�6�   
 � 	Resources
 5*       �� 
TargetType �� Property �� Value��%a   '��       �� 5+      " ��6   .�5,      ��  �@��CornerRadius$
 12.5��65   5-      5.      5/      �� 50   
   -   5        $	 closeBtn��50      $��Close��6#   $��1��63   $��	42,52,0,0q�6C   $��1��6V   $	��Top=�6c   $��25��6{   $
��Left=�6�   $��60��6�   
�������$
��Bold"�6�   
 51      ��%a   '��       �� 52      " ��6   .�53      ��  �@��CornerRadius$
 12.5��65   54      55      56      58      59      