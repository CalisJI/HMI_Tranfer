   M S B A M L   `   `   `  ����E  AHMITranfer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:HMITranfer.ViewHMITranfer.View  5      %    HMITranfer.View.MainScreen_View   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:HMITranfer.View     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
         
MainScreen  � DataContext#  [  5	      $	��700��5      $
��1366��6   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *Loaded+5        5   
   $ Unloaded��6   . 5         6$   �� *
Unloaded+5      .��5      � .+�5   
   �� $
��Fill=�5      $��/Image/premo.Png��5      �� 5   
   $
��Left=�5      $	��Top=�5      $��80��5      $��/Image/FWD.Png��5      �� 5   
   $��	0,200,0,0q�5      $��Center=�5      $	��Top=�5        �� Orientation$ 
Horizontal=�5!      .+�5"      �� 
��� � �+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5%      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 50��5&      $��Start��5'      $��28(�5(      $
��Left=�5)      $	��Top=�5*      $	��300��5+      $	��200��6   ��5#      �� *Start_Command+5+      �� 5,      $��50,0,0,0q�5.      
���  ��$ Depth3=�50      $ 50��51      $
��Stop��52      $��28(�53      $
��Left=�54      $	��Top=�55      $	��300��56      $	��200��6   ��5-      �� *Stop_Command+56      57      �� 58   
   $	��Top=�59      $��	0,500,0,0q�5:      $ 
Horizontal=�5;      $��Center=�6&   .+�5<      �� $	��100��5=      $	��200��5>      $
��Fill=�5?      $��/Image/flagvn.Png��5@      �� 5A      $��15,0,0,0q�5B      $	��100��5C      $	��200��5D      $
��Fill=�5E      $��/Image/flaguk.Png��5F      5G      �� 5H   
   $	��Top=�5I      $ 
Horizontal=�5J      $��Center=�6&   .+�5K      �� $	��300��5M      $��DemiBold"�5N      $��50(�5P       �� 
IsReadOnly 5L      �� *Visi+  InvertBooleanConverter	 �� 	Converter#	 [ ��5O      �� *PLC_IP+5P      �� 5Q      $��20,0,0,0q�5T      $	��150��5U      $��50��5V      ��5R      �� *Edit+��5S      �� 
 �� ElementName$
 btnname�� �� Path$
 Text���5W      �� 5X      -   5         ��Name$ btnname��5Y      $��Center=�5Z      $��Center=�5[      $��30(�5]      ��5\      �� *Btn_edtiname+5]      5_      �� 5`      $��20,0,0,0q�5c      $	��150��5d      $��50��5e      ��5a      �� *Save+y�5b      �� *Visi+   BooleanToVisibilityConverter#	 [ ��5f      �� 5g      $��Center=�5h      $��Center=�5i      $
��SAVE��5j      $��30(�6%   5l      5m      5o      5p      