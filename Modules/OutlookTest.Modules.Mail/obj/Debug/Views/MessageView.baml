   M S B A M L   `   `   `  ����S  OOutlookTest.Modules.Mail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:OutlookTest.Modules.Mail.Converters#OutlookTest.Modules.Mail.Converters  5   5   0    *OutlookTest.Modules.Mail.Views.MessageView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      w sInfragisticsWPF.Controls.Menus.XamDataTree, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb\ XInfragisticsWPF, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cba ]InfragisticsWPF.Undo, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbw sInfragisticsWPF.Documents.RichTextDocument, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb	 {InfragisticsWPF.Controls.Editors.XamRichTextEditor, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb{
 wInfragisticsWPF.Documents.RichTextDocument.Rtf, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbh dInfragisticsWPF.DataManager, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbs oInfragisticsWPF.Controls.Menus.XamMenu, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbe aInfragisticsWPF.DragDrop, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb=ig$http://schemas.infragistics.com/xaml	     	 
    5      T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      A	coverters1clr-namespace:OutlookTest.Modules.Mail.Converters  65   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5       � 	Resources 5      >   8OutlookTest.Modules.Mail.Converters.MailAddressConverter   MailAddressConverter �� Color  	LineBrush  LightTextBrush  DarkTextBrush��%�   &	        &	      &	 9     &	 _       5	   
   6)   �� 5
   
   $ #D4D4D4��6   6*   �� 5   
   $ #666666��6   6*   �� 5   
   $ #444444��6   6*   5      .��5      � -   5         �Name$ 
LayoutRoot��5      
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � -   5        $ _grid��5      $��	0,0,10,10q�6    5      �� 5      $��2 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5       $��* �6#   .+�5#      �� $��3��6   $��1��6&   $��6,2,6,0q�63   $��55��6D   $��80��6O   ��6[   �� *SendMessageCommand+.��5$      ��  �� Orientation$ Vertical=�6   .+�5%      �� $��30��6   $?��9/PrismOutlook.Modules.Mail;component/Images/Forward32.png��6(   �� 5&      $
��Send��6    #��[ 6,   5'      5(      �� 5*      $��1��6   $��1��6%   $	��To:��65   $��2q�6@   $��Center=�6K   #��[ 6f   �� 5+      $��1��6   $��2��6p   $��2q�6�   $��Center=�6�   ��6#   �� *
Message.To+ �� 	Converter# [  6�   �� 5-      $��2��6   $��1��6%   $	��CC:��65   $��2q�6@   $��Center=�6K   #��[ 6f   �� 5.      $��2��6   $��2��6p   $��2q�6�   $��Center=�6�   ��6#   �� *
Message.CC+# [  6�   �� 50      $��3��6   $��1��6%   $��Subject��65   $��2q�6D   $��Center=�6O   #��[ 6j   �� 51      $��3��6   $��2��6#   $��Stretch=�6T   $	��2,4q�6p   ��63   �� *Message.Subject+6p   52      < 
 6Infragistics.Documents.RichText.Rtf.RtfDocumentAdapter  54   
   O  IInfragistics.Documents.RichText.Serialization.RichTextDocumentAdapterBase   Document 6    �� *
Document+	 �� ElementName$
	 _rte��
   Value
 6P   �� *Message.Body+5 	 /Infragistics.Controls.Editors.XamRichTextEditor  55   
   -   5          Name$
 _rte��55      !   AllowDocumentViewSplitting .  $��1��6P   $��5,0,5,10q�6]   &   ClipboardSerializationProviders 57      B 
 <Infragistics.Documents.RichText.Rtf.RtfSerializationProvider  59      5:      5;      