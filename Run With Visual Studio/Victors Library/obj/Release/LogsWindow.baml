   M S B A M L   `   `   `  ���� J  FVictors Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Victors_LibraryVictors_Library       Victors_Library.LogsWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:Victors_Library       � Title$   Victor's Library - Reports��$	��720��$
��1280��.���� -   $��CANVAS��|�. ���	#FFCC1752.+��� -    ��Name$ Librarian_Image��$
��None=�$	��500�� �� Left$ 0��
 �� Top$ 0��$	��500��$��Center=�$��Bottom=�� #��Z��$
��1076��$	��Top=�$��Center=�$ 62�� � ColumnDefinitions �� $
��239* ��� $
��106* ��� $
��615* �.+�&   System.Windows.Controls.DataGrid  -     Name$ BookDataGrid��#��Z��$	��600��   
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�$   HorizontalScrollBarVisibility$ Visible=����	#FFCC1752���	#FF9C164D���	#FF31646D$��30(�$
��Left=�$	��Top=�$��	0,228,0,0q�$��3��	 �� SelectedItem	 �� *SelectedBook+
 �� Mode$
 TwoWay=��� -    ��Name$ BookSearch_Button��$��10q�$��Back To Library��$	��200��$	��400�����	#FF31646D���	#FFFDE975$��50(�$��Right=�$	��Top=�$��2������  �� Color$ 	#FF9A134E�� �� Opacity$
 0.85Q��� -   $ BoughtBooks_Button��$��10q�$��Bought Books��$	��150��$	��300�����	#FF31646D���	#FFFDE975$��40(�$
��Left=�$	��Top=�$��20,0,0,0q����� $ 	#FFD5B14C��$
 0.85Q��� -   $ RemovedtBooks_Button��$��10q�$��Removed Books��$	��150��$	��300�����	#FF31646D���	#FFFDE975$��40(�$
��Left=�$	��Top=�$��86,0,0,0q�$��2������ $ 	#FFD5B14C��$
 0.85Q��� -   $ AddedBooks_Button��$��10q�$��Added Books��$	��150��$	��300�����	#FF31646D���	#FFFDE975$��40(�$
��Left=�$	��Top=�$��3��$��	394,0,0,0q����� $ 	#FFD5B14C��$
 0.85Q��� -   $ Exceptions_Button��$��10q�$��
Exceptions��$	��150��$	��300�����	#FF31646D���	#FFFDE975$��40(�$��Center=�$	��Top=�$��2������ $ 	#FFD5B14C��$
 0.85Q�