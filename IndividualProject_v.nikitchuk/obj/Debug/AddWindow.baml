   M S B A M L   `   `   `  ����X  TIndividualProject_v.nikitchuk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:IndividualProject_v.nikitchukIndividualProject_v.nikitchuk  5   	   -    'IndividualProject_v.nikitchuk.AddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:IndividualProject_v.nikitchuk     5   	     � Title$  Новый заказ��5   	   $	��377��6   $	��578��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L   .��5	      � ���	#FFF3F3F3.+�5
   
   �� -   5         ��Name$ 
SaveButton��5
      $��Сохранить��6%   $
��Left=�69   $��198,306,0,0q�6T   $	��Top=�6i   $	��162��6�   6�   �� 5   
   -   5         ��Name$ OrderTextBox��5      $
��Left=�6(   $��
10,171,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��537��6�   $��92��6�   
���   � �� 
IsReadOnly . 6�   �� 5   
   $��Заказ:��6   $
��Left=�6!   $��
10,144,0,0q�6<   $	��Top=�6P   $	��537��6h   $��Center=�6t   
���   �$��1,1,1,0q�6�   �� 5   
   -   5         ��Name$ ProductComboBox��5      $
��Left=�6,   $��	10,35,0,0q�6G   $	��Top=�6Z   $	��176��6r   6~   �� 5   
   $��Товар:��6   $
��Left=�6!   $��10,9,0,0q�6<   $	��Top=�6N   $	��176��6f   �� 5   
   $��Количество:��6   $
��Left=�6&   $��	218,9,0,0q�6A   $	��Top=�6T   $��80��6l   �� 5   
   $��Цена за штуку:��6   $
��Left=�6)   $��	320,9,0,0q�6D   $	��Top=�6W   $	��120��6o   �� 5   
   -   5        $ CountProductTextBox��5      $
��Left=�6/   $��
218,35,0,0q�6J   $
 Wrap=�6^   $��1��6r   $	��Top=�6{   $��69��6�   $��22��6�   6�   �� 5   
   -   5        $ OneCostTextBox��5      $
��Left=�6*   $��
320,35,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��22��6�    . 6�   �� 5   
   $��*��6   $
��Left=�6   $��
195,33,0,0q�67   $	��Top=�6K   $��16��6c   $��24��6n   �� 5   
   -   5        $ AddToOrderButton��5      $&�� Добавить к заказу��6+   $
��Left=�6G   $��
450,36,0,0q�6b   $	��Top=�6v   6�   �� 5   
   -   5        $ NameClientTextBox��5      $
��Left=�6-   $��	10,99,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $	��277��6�   $��18��6�   6�   �� 5   
   -   5        $ PhoneNumberTextBox��5      $
��Left=�6.   $��
320,99,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   6�   �� 5   
   $��ФИО:��6   $
��Left=�6   $��	10,73,0,0q�6:   $	��Top=�6M   $	��120��6e   �� 5   
   $"��Номер телефона:��6   $
��Left=�6*   $��
320,73,0,0q�6E   $	��Top=�6Y   $	��120��6q   �� 5   
   -	   5        $ ClearButton��5      $��Очистить��6&   $
��Left=�69   $��
10,262,0,0q�6T   $	��Top=�6h   $	��537��6�   6�   5      5      