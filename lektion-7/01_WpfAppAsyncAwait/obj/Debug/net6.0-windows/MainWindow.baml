   M S B A M L   `   `   `  ����N  J01_WpfAppAsyncAwait, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_01_WpfAppAsyncAwait_01_WpfAppAsyncAwait  5   	   %    _01_WpfAppAsyncAwait.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:_01_WpfAppAsyncAwait     5   	     � Title$3  -Blocking (Sync) vs. Non-Blocking Code (Async)��5   	   $	��350��5	   	   $	��400��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ btnSync��5      $��0��6"   $��
10 10 10 5q�6/   $��10q�6C   $��Blocking Code (Sync)��6P   6o   �� 5   
   -   5        $ btnAsync��5      $��1��6#   $��
10 5 10 10q�60   $��10q�6D   $��Non-Blocking Code (ASync)��6Q   6u   �� 5   
   -   5         ��Name$ tblockResult��5      $��2��6*   $��10q�67   �� 5   
   -   5        $ tblockClear��5      $��3��5      $��10q�5      $��Clear Output��5      $��9(�5       
����+��5"      5%      5&      