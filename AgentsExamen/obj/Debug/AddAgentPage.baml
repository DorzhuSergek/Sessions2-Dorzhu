   M S B A M L   `   `   `  ����G  CAgentsExamen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AgentsExamenAgentsExamen  5          AgentsExamen.AddAgentPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:AgentsExamen     5        N� Title$  AddAgentPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6   �� 5      �� 5      $��2* �6   .+�5   
   �� $��Тип агента��6   $��Center=�6&   $��Center=�6A   $��Comic Sans MS)�6^   �� 5   
   -   5        $��	typeAgent��5      $��1��6$   $	��150��64   $��30��6@    �� DisplayMemberPath$ NameType��6s    �� SelectedItem 6L   ��  �� Path$ TypeAget�6�   �� 5   
   $��0��6   $��1��6$   $+��%Наименование агента��61   $��Center=�6L   $��Comic Sans MS)�6g   �� 5   
   $��1��6   $��1��6"   $	��160��6/   $��40��6;   ��6G   �� $* $НаименованиеАгента��� 5   
   $��0��6   $��2��6$   $'��!Электронная почта��61   $��Center=�6J   $��Comic Sans MS)�6e   �� 5   
   $��1��6   $��2��6"   $	��160��6/   $��40��6;   ��6G   �� $2 ,ЭлектроннаяПочтаАгента��� 5    
   $��0��6   $��3��6$   $��Телефон��61   $��Center=�6@   $��Comic Sans MS)�6[   �� 5!   
   $��1��6   $��3��6"   $	��160��6/   $��40��6;   ��6G   �� $  ТелефонАгента��� 5"   
   $��0��6   $��4��6$   $!��Логотип Агента��61   $��Center=�6G   $��Comic Sans MS)�6b   �� 5#   
   $��1��6   $��4��6"   $	��160��6/   $��40��6;   ��6G   �� $  ЛоготипАгента��� 5$   
   $��2��6   $��0��6$   $+��%Юридический аддресс��61   $��Center=�6L   $��Comic Sans MS)�6g   �� 5%   
   $��3��6   $��0��6"   $	��160��6/   $��40��6;   ��6G   �� $&  ЮридическийАдрес��� 5&   
   $��2��6   $��1��6$   $��Приоритет��61   $��Center=�6B   $��Comic Sans MS)�6]   �� 5'   
   $��3��6   $��1��6"   $	��160��6/   $��40��6;   ��6G   �� $ Приоритет��� 5(   
   $��2��6   $��2��6$   $��Директор��61   $��Center=�6A   $��Comic Sans MS)�6\   �� 5)   
   $��3��6   $��2��6"   $	��160��6/   $��40��6;   ��6G   �� $ Директор��� 5*   
   $��2��6   $��3��6$   $��ИНН��61   $��Center=�6<   $��Comic Sans MS)�6W   �� 5+   
   $��3��6   $��3��6"   $	��160��6/   $��40��6;   ��6G   �� $ ИНН��� 5,   
   $��2��6   $��4��6$   $��КПП��61   $��Center=�6<   $��Comic Sans MS)�6W   �� 5-   
   $��3��6   $��4��6"   $	��160��6/   $��40��6;   ��6G   �� $ КПП��� 5/   
   -   5        $��addAgent��5/      $��2��68   $��5��6L   $	��160��6Y   $��30��6e   $��Сохранить��6q   6�   �� 50   
   -   5        $��delAgent��50      $��2��68   $��3��6L   $��5��6\   $	��160��6i   $��30��6u   $��Удалить��6�   6�   51      52      