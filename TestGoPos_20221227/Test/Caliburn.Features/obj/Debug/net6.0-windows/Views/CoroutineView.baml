   M S B A M L   `   `   `  ????L  HCaliburn.Features, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Caliburn.Features.ViewsCaliburn.Features.Views  5      +    %Caliburn.Features.Views.CoroutineView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Caliburn.Features.Views     5        N? Title$  Coroutine Sample View??5	      .??5      ?? .+?5   
   ? -   5         ?Name$ 
LoadingBar??5       ? Minimum$ 0Q?6*    ? Maximum$	 100Q?66    ? IsIndeterminate$
 True??6D   $??20??6[   $y?Hidden=?6g   ?? 5   
   -   5         ??Name$ Execute??5      $??Execute Coroutine??6"   $??40,20q?6>   5      '  !System.Windows.VisualStateManager   VisualStateGroups 5      %  System.Windows.VisualStateGroup  5   
   -   5        LoadingStateGroup??   States. 5         System.Windows.VisualState  -   5        Loading??   
Storyboard. 5      ?? .??5      T? 	 ?? 
TargetName$	 
LoadingBar??64   
 ?? TargetProperty$
 
Visibility?6W   ..?5      i?  R? KeyTime$ 0??61     System.Windows.Visibility   Visible R? Value# Z 6=   5      5      5        5      -   5        LoadingComplete??5      5      5       