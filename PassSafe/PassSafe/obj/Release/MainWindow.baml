   M S B A M L   `   `   `  ���� C  ?PassSafe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PassSafePassSafe      PassSafe.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:PassSafe       � Title$  PassSafe��$	��320��$	��525��.���  � ColumnDefinitions �� $��2* ��� $��5* �.+��� $��0��$��5q�.+��� -   $��	AddButton��$	��Add��$��0,40,0,0q�� -   $��AddDialogue��$��Mouse=�.���  �� $��2* ��� $��3* � � RowDefinitions �� $��3* ��� $��1* �.+��� $��0��$��0��
�������.+��� $��Login��$��25���� $��Password��$��25���� $	��URL��$��25���� $��Notes��$��25���� $��1��$��0��
�������.+��� -   $��LoginTextBox��$	��100��$��25���� -   $��PasswordTextBox��$	��100��$��25���� -   $��
URLTextBox��$	��100��$��25���� -    ��Name$ NotesTextBox��$	��100��$��25���� $��1��$��1��$��0q�
�������.+��� -   $��PopupAddButton��$	��Add��$��
10,10,10,0q��� $��0��$��1��$��0q�
�������.+��� -   $��PopupCancelButton��$��Cancel��$��0,10,0,0q��� -	   $��DeleteButton��$��Delete���� -
   $��
SaveButton��$
��Save���� -   $��
LoadButton��$
��Load���� -   $��EncryptButton��$��Encrypt���� -   $��DecryptButton��$��Decrypt���� -   $��	ListView1��$��5q�$��1������ *PasswordsList+ �� View �� .P��� $��Login�� �� DisplayMemberBinding �� *Login+�� $��Password�� �� *
Password+�� $	��URL�� �� *URL+�� $��Notes�� �� *Notes+