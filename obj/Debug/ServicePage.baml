   M S B A M L   `   `   `  ����J  FEvdokimovGlazki, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EvdokimovGlazkiEvdokimovGlazki  5      !    EvdokimovGlazki.ServicePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:EvdokimovGlazki     5      -   5          N� Title$  ServicePage��5	       N� 
FontFamily$ Century Gothic)�6   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $��2��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5      �� -   5        $��LeftDirButton��5      $��<��6*   $��20��69   $��20��6D   6n   �� 5      -   5        $��PageListBox��5   $   $��20(�6   ��5      �� 5      .R�5      �  � Orientation$ 
Horizontal=�6$   5      5      �� 5      -   5        $��RightDirButton��5      $��>��6+   $��20��6:   $��20��6E   6p   5       � 5#   
   $��0��6   $ 
Horizontal=�6!   $
��Left=�6:   .+�5$      �� $��5q�6   $ 
Horizontal=�6$   .+�5%      �� -   5        $��
TBoxSearch��5%      $
��Left=�6Q   $��Center=�6s   $	��300��6�   $��35��6�   $��15(�6�   6�   �� 5'      $��     ��6   6+   �� 5)      -   5        $��ComboSortSearch��5)      $��15(�6f   $	��270��6t   $
��Left=�6�   $��Center=�6�   .@�5*      �� 64наименование по возрастанию6=   �� 5+      0.наименование по убыванию6:   �� 5,      *(скидка по возрастанию67   �� 5-      $"скидка по убыванию64   �� 5.      0.приоритет по возрастанию6:   �� 5/      *(приоритет по убыванию67   50      �� 52      $��     ��6   6+   �� 54      -   5        $��ComboTypeSearch��54      $��15(�6f   $	��150��6t   $
��Left=�6�   $��Center=�6�   .@�55      �� Все типы6*   �� 56      ЗАО6%   �� 57      МКК6%   �� 58      МФО6%   �� 59      ОАО6%   �� 5:      ООО6%   �� 5;      ПАО6%   5<      5>      �� 5@      -   5        $��	AddButton��5@   /   $#��Добавить агента��6   $��Right=�6@   $��Center=�6\   $��34��6w   6�   �� 5A      -	   5        $��chngpriority��5A   9   $2��,Изменить приоритет на ...��6   $	��270��6M   $��Right=�6Y   $��Center=�6u   $��34��6�   $y�Hidden=�6�   6�   5D      �� 5E   
   $ 
Horizontal=�6   $��Right=�6.   $	��400��6J   $��5q�6V   5G      �� 5J   
   -
   5        $��ServiceListView��5J      $��1��6*   ��5K      �� 5L      .R�5M      � ��6   �� *
Fonstyle+ � ColumnDefinitions 5N      �� 5O      61   �� 5P      $	��650 �6/   6=    5R      �� 5S      $��50 �6,   �� 5T      $��* �6,   �� 5U      $��* �6,   �� 5V      $��* �6,   �� 5W      $��* �6,   .+�5Z      �� $	��100��6    $��0��6,   $��2��6<   $��UniformToFill=�6M   $��Center=�6e   ��5[      �� 5\   "    �� Path$
 Logo�6*    �� TargetNullValue 5]   &   ��5^   *   agents/picture.png��5`   +   5b   #   5d      �� 5e      $ 
Horizontal=�6'   $��1��6@   $��0��6P   .+�5f      �� $��1��6I   $��0��6Y   $
��left=�6f   $��20(�6�   ��6(   �� *AgentTypeString+6�   �� 5g      $	�� | ��6(   $��1��63   $��0��6C   $��Center=�6P   $��20(�6m   6~   �� 5h      $��1��6?   $��0��6O   $��Right=�6\   $��20(�6x   ��6(   �� *Title+6�   5i      �� 5k      $ 
Horizontal=�6%   $��1��6>   $��1��6N   .+�5l      �� $��1��6?   $��1��6O   $
��Left=�6\   $��15(�6w   $
��Wrap=�6�   ��6(   �� *Sales+6�   �� 5m      $�� продаж за год��6(   $��1��6>   $��1��6N   $
��Left=�6[   $��15(�6v   $
��Wrap=�6�   6�   5n      �� 5p      $��1��6;   $��2��6K   $
��Left=�6X   $��20(�6s   ��6$   �� *Phone+6�   �� 5q      $��1��6&   $��3��66   .+�5r      �� $��1��6d   $��2��6t   $
��Left=�6�   $��16(�6�   ��6(   �� *
Priority+ �� StringFormat$' !Приоритетность: {0}��6�   �� 5s      $��1��6a   $��2��6q   $��Right=�6~   $��16(�6�   ��6(   �� *SaleProduct+$ Скидка: {0}%��6�   5u      �� 5y      $��1��6%   $��4��65   $ 
Horizontal=�6B   .+�5z      �� $��
EditButton��6=   -   5        $ ��Редактировать��5z   %   $��2q�6h   6u   5{      5}      5~      5�      5�      5�      