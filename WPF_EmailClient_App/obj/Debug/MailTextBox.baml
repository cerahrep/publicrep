   M S B A M L   `   `   `  ����X  TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4P:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.ToolkitXceed.Wpf.Toolkit  5       HCI_WPF_Email_App#   HCI_WPF_Email_App.MailTextBox   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      NwpfTool:clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit     5      -   5        $��MailRichTextBox��5        � 	Resources  5         
Underlined �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " d�6#   .�5      ��  � �� 5      �� 5      .R�5      �� $��	Underline{�6$   #��z��6@   5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      $��30 �6   6*   .+�5   
   �� $��0��6   $
��Auto=�6%   .��5      �� -   5        $��MailRichText��5      $��0q�6.   $��20q�6B   ��6�   �� *MailRichText+ �� ElementName$ 
ThisWindow��6�   5       9� 5!   
   -   5        $��TextFontExpander��5!       9� 
IsExpanded . $��1��6>   $	��5,0q�6K    9� ExpandDirection$ Right=�6X   $��24��6p   .��5"      ��  �� Orientation$ 
Horizontal=�6   $	��5,0q�62   .+�5#      �� -   5        $��FontCombobox��5#      $	��150��6/   $��5,0,5,0q�6;   	 �� SelectedItem	 5$      �� *MailRichText+$ 
ThisWindow����5%      ��    System.Windows.Media.Fonts
   SystemFontFamilies �� Source# Z
 �� 5&      -   5        $��FontSizeCombobox��5&      $��60��63   $��0,0,5,0q�6>   #   Xceed.Wpf.Toolkit.ColorPicker  5'      -   5        $��TextColorPicker��5'   &      SelectedColor$ BlackX�6=   $��80��6�   5)      d� 5*      -   5        $��
BoldTglBtn��5*      $��0q�61   $��16(�6{   $
��Bold"�6�   $��25��6�   $��5 0 0 0q�6�   $��B��6�   d� 5+      -   5        $��ItalicTglBtn��5+   +   $��0q�6   $��16(�6�   $��Italic$�6�   $��I��6�   $��25��6�   $��5,0,0,0q�6�   d� 5,      -	   5        $��UnderLineTglBtn��5,   +   $��0q�6   $��16(�6�   #��[  6�   $��U��6�   $��25��6�   $��5,0,0,0q�6�   �� 5-      -
   5        $��ClearAllTglBtn��5-      $��0q�6/   $��16(�6X   $��C��6f   $��25��6r   $��5,0,0,0q�6}   6�   5.      5/      50      51      