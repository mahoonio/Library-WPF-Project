   M S B A M L   `   `   `  ����H  DLoginPageTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LoginPageTestLoginPageTest  5   	   $    LoginPageTest.UserLibraryBooks   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LoginPageTest     5   	     � Title$  UserLibraryBooks��5   	   $	��500��6"   $	��800��6/    � 
ResizeMode$ NoResize=�6;    � WindowStyle$
 None=�5	   	    � AllowsTransparency . 
���   �.��5
      ]� $��10q�6   .+�5   
   �� $��Right=�6   $
��10,0q�6,    � 	Resources 5       �� 
TargetType �� Property �� Value��%W   '��       �� 5      " ��6   .�5      ��  � ��$ 0,0,0,5q�6/   5      5      .+�5      �� -   5        $��searchbutton��5      .��6E   search6M   �� 5      -   5         ��Name$ 	amanatbox��5      $��amanat��6(   69   �� 5      -   5        	 ��Name$	 BookName��5      $��BookName��6)   
�������6=   �� 5      -   5        $	 
AuthorName��5      $��
AuthorName��6+   
�������6@   �� 5      -   5        
 ��Name$
 
searchBlok��5      $��search here:��6,   
�������6@   �� 5      -   5         ��Name$ 	searchbox��5      5      �� 5   
   -   5        $��bookList��5      $��Stretch=�6"    �� SelectionMode$ Extended=�6G   ��5      �� 5      .R�5      � $	��0,2q�6    � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $	��100 �6/   .+�5!      �� $��0��6$   ��64   �� *Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5"      $��1��6$   ��64   �� *Author+$ TwoWay=�$ PropertyChanged=�5#      5$      5&      5'      5(      