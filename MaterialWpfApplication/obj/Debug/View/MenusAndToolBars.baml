   M S B A M L   `   `   `  ����Q  MMaterialWpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:MaterialWpfApplication.ViewMaterialWpfApplication.View  5      2    ,MaterialWpfApplication.View.MenusAndToolBars   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:MaterialWpfApplication.View     5      U QMaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      ]� .+�5   
   o�   o� 
IsMainMenu  . $	��Top=�6!   .@�5      m� $��_File��6   .@�5      m� $
��Save��6    m� Icon 5      '  !MaterialDesignThemes.Wpf.PackIcon  5      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.0.823, Culture=neutral, PublicKeyToken=null]]   Kind$ ContentSave=�62   5      m� 5      $��	Save As..��6   m� 5      $
��Exit��6    m� InputGestureText$ Ctrl+E��6)    5        5      $ 	ExitToApp=�62   5      �� 5      m� 5      $��	Excellent��6    m� IsCheckable .  m� 	IsChecked . 6A   m� 5      $��Rubbish��6    . 6,   m� 5      $��
Dig Deeper��6   $ Ctrl+D��6/   .@�5      m� $��Enlightenment?��6    . 67   m� 5      $��Disappointment��6    . 67   5      m� 5      $��Look Deeper��6   $ Ctrl+D��60   .@�5       m� $��Plain��6   m� 5!      $��	Ice Cream��6   5"      5#      m� 5$      $��_Edit��6   .@�5%      m� $
��_Cut��6    m� Command$	 Cut��6)    5&        5'      $ 
ContentCut=�62   5)      m� 5*      $��_Copy��6   $
 Copy��6*    5+        5,      $ ContentCopy=�62   5.      m� 5/      $��_Paste��6   $ Paste��6+    50        51      $ ContentPaste=�62   53      54      55      `� 57   
   $	��Top=�6   .�58      c�    MaterialDesignToolBar#���   6   .@�59      �� -   5         � ToolTip$ Follow me on Twitter��59      .��5:        $ 
TwitterBox=�6.   5;      �� 5<      $
 Save��6   .��5=        $ ContentSave=�6.   5>      �� 5?      �� 5@      $	��Cut��6   $	 Cut��6'    c� OverflowMode$ AsNeeded=�65   .��5A        $ 
ContentCut=�6.   5B      �� 5C      $
��Copy��6   $ Copy that stuff��6(   $ AsNeeded=�6B   .��5D        $ ContentCopy=�6.   5E      �� 5F      �� 5G      $��Paste��6   $ Paste some stuff��6)   $ AsNeeded=�6D   .��5H        $ ContentPaste=�6.   5I      �� 5J      �� 5K      $��
Font size:��6   $��Center=�6-   �� 5L      .@�5M      �� $��10��6#   �� 5N      	 �� 
IsSelected	 . $��12��65   �� 5O      $��14��6#   �� 5P      $��16��6#   5Q      �� 5R      .��6   Check5T      �� 5U      $ 
Take a nap��6   $ Always=�6.   .��5V        $ Hotel=�6.   5W      	� 5X      
 	� 	GroupName$	
 XXX��6   $��Radio��6.   	� 5Y      $	
 XXX��6   $��Ga Ga��6.   d� 5Z      .��6   Switch5\      o� 5]      .@�5^      m� .@�6   Embedded menu6.   5_      5`      5a      �� 5c   
   $��16q�6   $	��Top=�6   $
��Left=�66   .��6Q   With Default Context Menu5e      �� 5g   
   $��16q�6   $	��Top=�6   $
��Left=�66   .��6Q    � ContextMenu 5h      �� 5i      .@�5j      m� $��Hello World��6   m� 5k      $��Clickety Click��6   .@�5l      m� $��Clackety Clack��6#   5m      5n      .��5o   #   With Custom Context Menu5q      5s      5t      