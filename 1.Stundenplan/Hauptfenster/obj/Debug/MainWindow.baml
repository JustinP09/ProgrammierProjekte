   M S B A M L   `   `   `  ����G  CHauptfenster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HauptfensterHauptfenster  5   	       Hauptfenster.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Hauptfenster     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��500��6,    � SizeToContent$ WidthAndHeight=�6;    � DataContext 5	   	   ��  �� Self �� RelativeSource# Z .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   
���   �$��2q�62    �� CornerRadius$ 5��6F   $��130,20,260,5q�6W   ._�5      �� $��Nächster Termin:��6   $��1��6/   $
��Left=�6=   5      �� 5   
   $��2��6   
���   �$��2q�62   $ 5��6F   $��130,0,130,30q�6W   ._�5      �� -   5        ��5      �� 5      $��Center=�6"   $��Center=�6?   .+�5      �� $��Mathe3��6    $��35(�61   $
��Bold"�6?   $��Center=�6Q   �� 5      $��Scheer��6    $��20(�61   $��Center=�6?   �� 5      $��HQ.105��6    $��20(�61   $��Center=�6?   5      5      5      5      5       