   M S B A M L   `   `   `  ����S  OOutlookTest.Modules.Mail, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:OutlookTest.Modules.Mail.MenusOutlookTest.Modules.Mail.Menus  5      /    )OutlookTest.Modules.Mail.Menus.MessageTab   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      >local,clr-namespace:OutlookTest.Modules.Mail.Menus     5      \ XInfragisticsWPF, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbj fInfragisticsWPF.DataPresenter, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbg cInfragisticsWPF.OutlookBar, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbd `InfragisticsWPF.Editors, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cbc	 _InfragisticsWPF.Ribbon, Version=21.1.20211.27, Culture=neutral, PublicKeyToken=7dd5c3163f2cd0cb9ig(http://schemas.infragistics.com/xaml/wpf     	 5      $��Message��5      / 	 )Infragistics.Windows.Ribbon.RibbonTabItem    RibbonGroups.  5      - 	 'Infragistics.Windows.Ribbon.RibbonGroup     Caption$ 	Clipboard��6   .@�5	   
   , 	 &Infragistics.Windows.Ribbon.ButtonTool     Caption$ Paste��6   $��ApplicationCommands.Paste��5
         
LargeImage$< 6/OutlookTest.Modules.Mail;component/Images/Paste32.png��5         MinimumSize$ ImageAndTextLarge=�5         MaximumSize$ ImageAndTextLarge=�6J     5   
   $	 Cut��6   $��ApplicationCommands.Cut��5         
SmallImage$: 4/OutlookTest.Modules.Mail;component/Images/Cut16.png��5      $ 	ImageOnly=�5        5   
   $
 Copy��6   $��ApplicationCommands.Copy��5      $; 5/OutlookTest.Modules.Mail;component/Images/Copy16.png��5      $ 	ImageOnly=�6^   5        5      $
 Font��6   .@�5   
   9 	 3Infragistics.Windows.Ribbon.ToolHorizontalWrapPanel  .+�5      - 	 'Infragistics.Windows.Ribbon.ButtonGroup  .+�5      1 	 +Infragistics.Windows.Ribbon.ComboEditorTool  -   5          Name$ 
_fontNames��5   %   1  +Infragistics.Windows.Editors.XamComboEditor   
IsEditable . 6m     5      -   5        $ 
_fontSizes��5   %   	   EditAreaWidth$	 45Q�6m    . 6�   5        5      .+�5      2 	 ,Infragistics.Windows.Ribbon.ToggleButtonTool  -   5        
  Name$
 _boldButton��5   &   $ ��EditingCommands.ToggleBold��6;      
SmallImage$; 5/OutlookTest.Modules.Mail;component/Images/Bold16.png��5   )     5      -   5        $
 _italicButton��5   &   $"��EditingCommands.ToggleItalic��6=   $= 7/OutlookTest.Modules.Mail;component/Images/Italic16.png��5    )     5!      -   5        $
 _underlineButton��5!   &   $%��EditingCommands.ToggleUnderline��6@   $@ :/OutlookTest.Modules.Mail;component/Images/Underline16.png��5"   )   5#      5$      5%        5&      $ 	Paragraph��6   .@�5'   
     .+�5(        .+�5)      1	 	 +Infragistics.Windows.Ribbon.RadioButtonTool	  -   5         	 Name$ 
_alignLeft��5)   %   $��EditingCommands.AlignLeft��69    	  
SmallImage$@ :/OutlookTest.Modules.Mail;component/Images/LeftAlign16.png��5*   (   	  5+      -   5        $ _alignCenter��5+   %   $!��EditingCommands.AlignCenter��6;   $B </OutlookTest.Modules.Mail;component/Images/CenterAlign16.png��5,   (   	  5-      -   5        $ _alignRight��5-   %   $ ��EditingCommands.AlignRight��6:   $A ;/OutlookTest.Modules.Mail;component/Images/RightAlign16.png��5.   (   	  5/      -	   5        $ _alignJustify��5/   %   $"��EditingCommands.AlignJustify��6<   $C =/OutlookTest.Modules.Mail;component/Images/JustifyAlign16.png��50   (   51        52      .+�53        -
   5        $
 _bulletsButton��53   &   
 � Tag$ Bullet��6Z   $> 8/OutlookTest.Modules.Mail;component/Images/Bullets16.png��6g     54      -   5        $
 _numbersButton��54   &   $ Decimal��6Z   $@ :/OutlookTest.Modules.Mail;component/Images/Numbering16.png��6h   55      56      57      58      