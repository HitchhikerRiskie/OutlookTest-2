   M S B A M L   `   `   `  ����S  OOutlookTest.Modules.Mail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:OutlookTest.Modules.Mail.Converters#OutlookTest.Modules.Mail.Converters  5      U/clr-namespace:OutlookTest.Modules.Mail.Controls!OutlookTest.Modules.Mail.Controls  5	      -    'OutlookTest.Modules.Mail.Views.MailList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      \ XInfragisticsWPF, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbj fInfragisticsWPF.DataPresenter, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbg cInfragisticsWPF.OutlookBar, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd	 `InfragisticsWPF.Editors, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbc
 _InfragisticsWPF.Ribbon, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb<igWpf(http://schemas.infragistics.com/xaml/wpf    	 
 5      w sInfragisticsWPF.Controls.Menus.XamDataTree, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cba ]InfragisticsWPF.Undo, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbw sInfragisticsWPF.Documents.RichTextDocument, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb {InfragisticsWPF.Controls.Editors.XamRichTextEditor, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb{ wInfragisticsWPF.Documents.RichTextDocument.Rtf, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbh dInfragisticsWPF.DataManager, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbs oInfragisticsWPF.Controls.Menus.XamMenu, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbe aInfragisticsWPF.DragDrop, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb=ig$http://schemas.infragistics.com/xaml	          5      BigPrim/http://schemas.infragistics.com/xaml/primitives     5      G	coverters1clr-namespace:OutlookTest.Modules.Mail.Converters     5      Dcontrols/clr-namespace:OutlookTest.Modules.Mail.Controls     5	      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5
       � 	Resources 5      ;  5Infragistics.Windows.DataPresenter.CellValuePresenter �� 
TargetType �� Property �� Value>   8OutlookTest.Modules.Mail.Converters.MailAddressConverter   MailAddressConverterQ  KInfragistics.Controls.Interactions.Primitives.NullableToVisibilityConverter ! NullableToVisibilityConverter��%�   '        &	  W     &	 j     �� 5   
   "  6   �5      �� 5       � ��$ 0,0,0,0q�64   5        5   
   6)     5   
   6/   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��370 �6   �� 5      $��* �6   .+�5   
   � 
�������$��5,0,0,0q�6"   .+�5      4  .Infragistics.Windows.DataPresenter.XamDataGrid  $��0,0,10,0q�6    :  4Infragistics.Windows.DataPresenter.DataPresenterBase   RecordSelectorExtent$ 0Q�6u      GroupByAreaLocation$
 None=�6�      
DataSource 62   �� *
Messages+	   ActiveDataItem	 6R   �� *	Message+
 J� InputBindings
 5      d� 5        d� MouseAction$ LeftDoubleClicke�6#    �� CommandParameter$
 Read��6d    �� Command 6A   �� *MessageCommand+6d   �� 5!      
 �� Key$ Delete��6J    6!   �� *DeleteMessageCommand+6J      FieldSettings 5#      6  0Infragistics.Windows.DataPresenter.FieldSettings  5$         	AllowEdit�  �Infragistics.Windows.Helpers.NullableConverter`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]$ False 6*      CellClickAction$ SelectRecord=�6<      FieldLayoutSettings 5&      <	  6Infragistics.Windows.DataPresenter.FieldLayoutSettings	  5'       	  LabelLocation$ Hidden=�60    	  AutoGenerateFields$ FalseY�6G    	  AutoArrangeCells$ Never=�6b    	  SelectionTypeCell$
 None=�6{    	  SelectionTypeRecord$ Single=�5(   -    	  AutoFitMode$ OnlyWithVisibleStarFields=�6J      FieldLayouts 5*      4
  .Infragistics.Windows.DataPresenter.FieldLayout
  5+       
  SortedFields 5,      =  7Infragistics.Windows.DataPresenter.FieldSortDescription  5-         	FieldName$ DateSent��69      	Direction$ 
Descending=�6N      	IsGroupBy . 6e    
  
FieldItems. 5/      2  ,Infragistics.Windows.DataPresenter.TextField  2  ,Infragistics.Windows.DataPresenter.FieldItem   Name$
 From��6*       Column$  1��66   
!   Row$! 0��6A   "   Width$" *X�6I     50      $ Subject��6*   $  1��69   $! 1��6D   $" *X�6L   6  0Infragistics.Windows.DataPresenter.DateTimeField  51      $ DateSent��6.   $  2��6>   $! 1��6I   #   
ColumnSpan$# 3��6Q   $" 85X�6`   .  (Infragistics.Windows.DataPresenter.Field$   GroupByMode$$ OutlookDate=�6k   52      54      55      =   7OutlookTest.Modules.Mail.Controls.MessageDisplayControl  57   
   $��1��6)   y�69   �� *	Message+% �� 	Converter#% [ �� 59   
   $��1��6   $��Stretch=�6'   $��10��6C   $
��Left=�6N   $	��100��6i   5:      5;      5<      