   M S B A M L   `   `   `  ����Q  MZbW.Testing.Dms.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:ZbW.Testing.Dms.Client.ViewModels!ZbW.Testing.Dms.Client.ViewModels  5      5    /ZbW.Testing.Dms.Client.Views.DocumentDetailView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      F
viewModels/clr-namespace:ZbW.Testing.Dms.Client.ViewModels     5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��150 �6   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   $��Dokument��5      �� 5   
   $��0��6   $��1��6   $��Durchsuchen��5       $��26��5!   4   $��5,0,5,2q�6@   $��Bottom=�6Q   ��6   �� *CmdDurchsuchen+6Q   �� 5#   
   $��1��6   $��0��6!   $��Bezeichnung��5$      �� 5%   
   $��1��6   $��1��6   ��5&      �� *Bezeichnung+ �� UpdateSourceTrigger$ PropertyChanged=��� 5(   
   $��2��6   $��0��6!   $��Valuta Datum��5)      (  "System.Windows.Controls.DatePicker  5*   
   $��2��6   $��1��6"      SelectedDate 5+      �� *ValutaDatum+�� 5-   
   $��3��6   $��0��6!   $	��Typ��5.      �� 5/   
   $��3��6   $��1��6    ��50      �� *
TypItems+ �� SelectedItem 51      �� *SelectedTypItem+�� 53   
   $��4��6   $��0��6!   $��Stichwörter��54      �� 55   
   $��4��6   $��1��6   ��56      �� *Stichwoerter+�� 58   
   $��5��6   $��0��6!   $��Erfassungsdatum��59      �� 5:   
   $��5��6   $��1��6   {�.  ��5<      �� *Erfassungsdatum+ �� StringFormat$ dd.MM.yyyy HH:mm:ss���� 5>   
   $��6��6   $��0��6!   $��Benutzer��5?      �� 5@   
   $��6��6   $��1��6   {�.  ��5B      �� *
Benutzer+�� 5D   
   $��7��6   $��0��6!   $"��Datei anschliessend löschen��5E      $
��Wrap=�5F      �� 5G   
   $��7��6   $��1��6     d� 	IsChecked 5H      �� *IsRemoveFileEnabled+�� 5J   
   $��8��6   $��1��6   $��	Speichern��5K      ��5L      �� *CmdSpeichern+5N      5O      