   M S B A M L   `   `   `  ����E  AHMITranfer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:HMITranfer
HMITranfer  5   	       HMITranfer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:HMITranfer     5   	      
MainScreen  � DataContext#  [  5   	    � Title$ 
MainWindow��5	   	   $	��768��6   $
��1366��6)   .��5
      (� .��5   
   �  � RowDefinitions 5      �� 5      $
��338* �6    �� 5      $	��51* �6    .+�5      � .+�5      �� ��6!   �� *SelectedViewModel+5      � 5      $��1��6   .+�5      �� $��0,8,0,0q�5      $��Center=�5      $	��Top=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� $��DemiBold"�5      $��70��5      $	��150��5      
��� �����5      �� *Home_PageCommand+��5       �� 5!      $
��HOME��6(   $��28(�64   5#      �� 5$      $��DemiBold"�5%      $��10,0,0,0q�5&      $��70��5'      $	��150��5(      
���   ���5)      �� *AUTO_PageCommnad+��5+      �� 5,      $
��AUTO��6(   $��28(�64   5.      �� 5/      $��10,0,0,0q�51      $��70��52      $	��150��53      
���   ���50      �� *MANU_PageCommand+��56      �� 57      $��MANUAL��6(   $��28(�66   59      �� 5:      $��10,0,0,0q�5=      $��70��5>      $	��150��5?      
���   ���5;      �� *IO_LIST_PageCommand+��5<      ��  �� ElementName$ btnname�� �� Path$
 Text���5B      �� 5C      -   5         ��Name$ btnname��5C   (   $��28(�6R   ��69   �� *	BtnName+6R   5E      �� 5F      $��10,0,0,0q�5H      $��70��5I      $	��150��5J      
���   ���5G      �� *ALARM_PageCommand+��5M      �� 5N      $��ALARM��6(   $��28(�65   5P      5Q      5R      5S      5T      5U      