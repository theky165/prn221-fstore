   M S B A M L   `   `   `  ????F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.WindowMembers   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	   -   5          ? Title$  WindowOrders??5   	   $	??720??6   $	??800??6+    ? WindowStartupLocation$ CenterScreen=?67    ? 	Resources 5	       ?? 
TargetType ?? Property ?? Value??%?   '??       '?? H     ?? 5
   
   " ??6   .?5      ??  ? ??$ 16(?6)   5      ?? 5   
   " ??6   .?5      ??  ? ??$ 16(?6)   ?? 5       ? ??$ 25??6'   5      5      .??5      ?? .??5   
   ? $??0,0,0,0q?6   $	??700??6     ? RowDefinitions 5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    .+?5      o? $
??Left=?6   
???? ??$??0 0 0 0q?6B   $	??Top=?6S   $	??800??6m   $??1??6{   $??3??6?   .@?5      m? -   5        $
??Bold"?5      $??Member??6-   $
??Left=?6=   6s   m? 5      -   5        $
??Bold"?5      $??Order??6-   $
??Left=?6<   6t   m? 5      -   5        $
??Bold"?5      $??Product??6-   $
??Left=?6>   6v   5      ?? 5        ?? Orientation$ Vertical=?6   
????ح?$
??Left=?6G   $	??797??6b   $??0,50,0,5q?6n   $??2??6?   $??3??6?   .+?5!      ?? $??Member Management??6   $??Center=?64   
???? ??$
??Bold"?6e   $??18(?6w   ?? 5"      $??	Member Id??6   ?? 5#      -   5        $??txtMemId??5#      ${?False??5$       ? DataContext 5%      ?? 	 ?? ElementName$	 lvMember??
 ?? Path$
 SelectedItem???5&      ?? $
 id? ?? Mode$ OneWay=??? 5'      $??Email??6   ?? 5(      -   5        $??txtEmail??5(       5)      ?? $	 lvMember??$
 SelectedItem???5*      ?? $
 email?$ OneWay=??? 5+      $??Company Name??6   ?? 5,      -   5        $??txtCompanyName??5,       5-      ?? $	 lvMember??$
 SelectedItem???5.      ?? $
 companyName?$ OneWay=??? 5/      $
??City??6   ?? 50      -   5        $??txtCity??50       51      ?? $	 lvMember??$
 SelectedItem???52      ?? $

 city?$ OneWay=??? 53      $??Country??6   ?? 54      -	   5        $??
txtCountry??54       55      ?? $	 lvMember??$
 SelectedItem???56      ?? $
 country?$ OneWay=??? 57      $??Password??6   ?? 58      -
   5        $??txtPassword??58       59      ?? $	 lvMember??$
 SelectedItem???5:      ?? $
 password?$ OneWay=?5;      ?? 5<      $??Center=?6   $ 
Horizontal=?66   $??2??6O   $??0 0 0 0q?6\   .+?5=      ?? -   5        $??
btnRefresh??5=      $??Refresh??6+   $??10q?6=   $??80??6I   6T   ?? 5>      -   5        $??btnAdd??5>      $	??Add??6'   $??10q?65   $??80??6A   6L   ?? 5?      -   5        $??btnEdit??5?      $
??Edit??6(   $??10q?67   $??80??6C   6N   ?? 5@      -   5        $??	btnDelete??5@      $??Delete??6*   $??10q?6;   $??80??6G   6R   5A      ?? 5B      -   5        $??lvMember??5B   $   $??3??6   $	??800??64    ?? View 5C      ?? 5D      .P?5E      ?? $??	Member ID??6)    ?? DisplayMemberBinding 6<   ?? $
 id??? 5F      $??Email??6)    68   ?? $
 email??? 5G      $??Company Name??6)    6?   ?? $
 companyName??? 5H      $
??City??6)    67   ?? $

 city??? 5I      $??Country??6)    6:   ?? $
 country?5J      5L      5M      5N      5O      