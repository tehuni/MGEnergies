   M S B A M L   `   `   `  ?????  ;MGEN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MGEN.Views
MGEN.Views  5   	   1clr-namespace:MGEN.ViewModelsMGEN.ViewModels  5   	       MGEN.Views.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MGEN.Views     5   	   3	viewModelclr-namespace:MGEN.ViewModels     5   	   X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     ? Title$  MainWindowView??5
   	   $	??700??6    $
??1300??6-    ? WindowStartupLocation$ CenterScreen=?5   	    ? WindowStyle$
 None=?5   	   
??????  ? AllowsTransparency$
 True??5   	    ? DataContext 5      #   MGEN.ViewModels.MainViewModel  5   
    ? 	Resources 5       ?? DataType#   MGEN.ViewModels.HomeViewModel   MGEN.Views.HomeView'   !MGEN.ViewModels.CustomerViewModel   MGEN.Views.CustomerView(  "MGEN.ViewModels.BiomassesViewModel   MGEN.Views.BiomassesView(   "MGEN.ViewModels.DashboardViewModel	   MGEN.Views.DashboardView&
    MGEN.ViewModels.DiagramViewModel   MGEN.Views.DiagramView&    MGEN.ViewModels.SettingViewModel   MGEN.Views.SettingView(   "MGEN.ViewModels.ContactUsViewModel   MGEN.Views.ContactUsView??%  (??       5      *, +)(?? 2     5      *, +)(?? d     5      *, +)(?? ?     5"      *, +)(?? ?     5%      *,
 +)(?? ?     5(      *, +)(?? ,    5+      *, +)?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5       ?? 5"   
   "  6   .R?5#      	  5$      ?? 5%   
   " 
 6   .R?5&        5'      ?? 5(   
   "  6   .R?5)        5*      ?? 5+   
   "  6   .R?5,        5-      5.      .??5/      ??  ?? CornerRadius$ 10??6   $??1q?50      ??51   
   ?? 52       ?? 
StartPoint$	 0,0&?6"   	 ?? EndPoint$		 1,1&?63   .??53      ?    winBorderColor1
 ? Color#
 [  6    ? Offset$ 0Q?6H   ? 54        winBorderColor2#
 [ 6   $	 0.5Q?6H   ? 55        winBorderColor3#
 [ 6   $ 1Q?6H   56      ._?58   
   ?  ? ColumnDefinitions 59      ?? 5;      $	??250 ?6#   ?? 5=      $??* ?6#   .+?5@      ?? $ 	10,0,0,10??6   $??0??5A      ??5B      ?? 5C      $	 0,0&?6*   $	 1,0.7&?6;   .??5D      ?   secondaryBackColor1#
 [ 6'   $ 0Q?6T   ? 5E        secondaryBackColor2#
 [ 6'   $ 1Q?6T   5F      ._?5H      ?? .+?5K      ??  ?? Orientation$ 
Horizontal=?6!   $??35??5L   !   $??
15,25,0,40q?5M   !   .+?5O      ?? $??/Images/Logo.png??6    $??30??6:   ?? 5P      $??
AIENERGIES??6$     titleColor2#??[ 5Q   $   $??20(?5R   $   $??
Montserrat)?5S   $   $??Medium"?5T   $   $??Center=?5U   $   $??10,0,0,0q?5V   $   5W      	? 5Z        
menuButton#??[ 6"    
 color1
 ? Tag# [ 5[   "    d? 	IsChecked$
 TrueY?5\   "   ??5]   "   ?? *ShowDashboardViewCommand+.??5^      ?? $ 
Horizontal=?6%   .+?5_      !  FontAwesome.Sharp.IconImage  ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=?6+     menuButtonIcon#??[ 67   ?? 5`      $??	Dashboard??6(    	 menuButtonText#??[	 69   5a      5b      	? 5d      #??[ 6"    

 color2# [
 5e   "   $
 TrueY?5f   "   ??5g   "   ?? *ShowDiagramViewCommand+.??5h      ?? $ 
Horizontal=?6%   .+?5i        $ 	ChartLine=?6+   #??[ 6<   ?? 5j      $??Diagrams??6(   #??[	 68   5k      5l      	? 5n      #??[ 6"    
 color9# [ 5o   "   $ FalseY?5p   "   ??5q   "   ?? *ShowBiomassesViewCommand+.??5r      ?? $ 
Horizontal=?6%   .+?5s        $ Seedling=?6+   #??[ 6;   ?? 5t      $??	Biomasses??6(   #??[	 69   5u      5v      	? 5x      #??[ 6"    
 color3# [ 5y   "   $ FalseY?5z   "   ??5{   "   ?? *ShowCustomerViewCommand+.??5|      ?? $ 
Horizontal=?6%   .+?5}        $ Industry=?6+   #??[ 6;   ?? 5~      $??	Companies??6(   #??[	 69   5      5?      	? 5?      #??[ 6"    
 color5# [ 5?   "   $ FalseY?5?   "   ??5?   "   ?? *ShowSettingViewCommand+.??5?      ?? $ 
Horizontal=?6%   .+?5?        $
 Gear=?6+   #??[ 67   ?? 5?      $??Setting??6(   #??[	 67   5?      5?      	? 5?      #??[ 6"    
 color4# [ 5?   "   $ FalseY?5?   "   ??5?   "   ?? *ShowContactUsViewCommand+.??5?      ?? $ 
Horizontal=?6%   .+?5?        $ 	UserGroup=?6+   #??[ 6<   ?? 5?      $??
Contact Us??6(   #??[	 6:   5?      5?      5?      5?      ?? 5?      $ 	0,10,10,0??6   $??1??5?      ??5?      ?? 5?      $	 1,1&?6*   $		 0,0&?6;   .??5?      ?   primaryBackColor1#
 [ 6'   $ 0Q?6R   ? 5?        primaryBackColor2#
 [ 6'   $ 1Q?6R   5?      ._?5?      ?  ? RowDefinitions 5?      ?? 5?      $??25 ?6(   ?? 5?      $??35 ?6(   ?? 5?      $??* ?6(   .+?5?      ?? -   5         ??Name$ pnlControlBar??5?   !   $??0??5?   !   $ 
Horizontal=?5?   !   $??RightToLeft=?5?   !   
?????? $??0,0,5,0q?5?   !   .+?5?      ?? -   5         ??Name$ btnClose??5?   !     controlButton#??[ 5?   !   # [ 5?   !   .??5?        $ Xmark=?6+     controlButtonIcon#??[ 68   5?      ?? 5?      -   5        $ btnMaximize??5?   !   #??[ 5?   !    
 color6# [ 5?   !   .??5?        $ Square=?6+   #??[ 69   5?      ?? 5?      -   5        $ btnMinimize??5?   !   #??[ 5?   !    
 color8# [ 5?   !   .??5?        $ WindowMinimize=?6+   $??12??6A   #??[ 6L   5?      5?      ? 5?      $??1??6    5?      ?? 5?      ?? 5?      .+?5?      ?? $??0??6%   $ 
Horizontal=?5?   %   $??Center=?5?   %   .+?5?        $??20??5?   +   $??20??5?   +      
Foreground# [ 5?   +   $??	35,0,10,0q?5?   +    5?   +   ?? *Icon+5?   +   ?? 5?      #??[ 5?   (   $??16(?5?   (   $??
Montserrat)?5?   (   $??Medium"?5?   (   $??Center=?5?   (   ??5?   (   ?? *	Caption+5?   (   5?      ?? 5?      $??1??6%   $ 
Horizontal=?5?   %   $??RightToLeft=?5?   %   $??Center=?5?   %   $??0,0,10,0q?5?   %   .+?5?      ??   
iconButton#??[ 6%   # [ 5?   %   .??5?   "     $ 	AngleDown=?6/   $??12??5?   /   $??12??6;     iconButtonIcon#??[ 5?   /   5?      ?? 5?        titleColor3#??[ 5?   (   $??
Montserrat)?5?   (   $??12(?5?   (   $??Center=?5?   (   ??5?   (   ?? * CurrentUserAccount.DisplayName+5?   (   A? 5?      $??35??6&   $??35??62   #??[
 5?   &   $??2??5?   &   $??	10,0,10,0q?5?   &   5?      ?? 5?      #??[ 6%   # [ 5?   %   .??5?   "     $ Clock=?6/   #??[ 6<   5?      ?? 5?      #??[ 6%   # [ 5?   %   .??5   "     $ Envelope=?6/   #??[ 6?   5     ?? 5     #??[ 6%   # [ 5  %   .??5  "     $
 Bell=?6/   #??[ 6;   5     5     5     ?? 5
     $??2??5  %   $??25q?5  %   ??5
  %   ?? *CurrentChildView+5  %   5     5     5     5     5     