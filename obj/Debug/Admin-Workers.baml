   M S B A M L   `   `   `  ����H  DLoginPageTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LoginPageTestLoginPageTest  5   	   !    LoginPageTest.Admin_Workers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LoginPageTest     5   	     � Title$  Admin_Workers��5   	   $	��500��6   $	��800��6,    � 
ResizeMode$ NoResize=�68    � WindowStyle$
 None=�5	   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � .+�5   
   �  � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��2* �6#   .+�5      ��  �� CornerRadius$ 10��6   $��2��6(   ��5      �� 5      -   5        RegisterPage��.��5      �  � Color$ #F7971E��6'    � Offset$	 0.3Q�67   � 5      $ #FFD200��6'   $	 1.0Q�67   5      5      �� 5      $��0��6   $��Center=�6)   .+�5      �� -   5        	 ��Name$	 AddWorkerBtn��5      $��
Add Worker��5      $��	Helvetica)�6.   $��28(�5      $	��160��5      $��80��6%   $
��0,50q�61   ���#ff6a005   .   �� 5      -   5        $	 PayWorkersBtn��5      $	��160��5       $��80��6%   $��	helvetica)�5!      $��28(�5"      $��Pay Workers��5#      ���#ff6a005$      �� 5%      $��
Worker.png��6   $	��200��6,   $	��200��68   �� 5&      -   5        $	 BackBtn��5&      $
��Back��6*   $��20(�69   $��80��6G   $��40��5'      ���#ff6a00$��	0,-10,0,0q�5)      5*      5+      �� 5,      $��1��6   .+�5/      �� $��10q�6   .+�50      �� -   5        
 ��Name$
 cm��50       �� Text$
 text��6+   $��26��67    J� RenderTransformOrigin$ 
0.49,1.784&�6C   ��51      �� 52      .R�53   "   ��  �� Orientation$ 
Horizontal=�6-   .+�54   &   �� $��20��61   $��20��6<   $��0,2,5,2q�6H   �� 55   &    ��Name$ namebox��60   ��6A   �� *
UserName+56   #   57      59      � 5:      $��80,400,0,50q�6    $
��Left=�65   $	��400��6P   .+�5;      �� -   5        $	 btnPrevious��5;   !   $��Bottom=�66   $
��10,0q�6Q   $	��100��6y   $��PreviousPerson��6�   �� 5<      -   5        $	 btnNext��5<   !   $	��100��6I   $
��20,0q�6U   $��
NextPerson��6c   �� 5=      -   5        $
	 XBox��5=   !   $	��100��6E   $��Remove��6Q   5>      5?      5@      5A      5B      5C      