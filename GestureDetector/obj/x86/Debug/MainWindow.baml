   M S B A M L   `   `   `  ����^  ZMicrosoft.Samples.Kinect.WpfViewers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null�^clr-namespace:Microsoft.Samples.Kinect.WpfViewers;assembly=Microsoft.Samples.Kinect.WpfViewers#Microsoft.Samples.Kinect.WpfViewers  5   ;    GestureDetector    GestureDetector.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   mmy^clr-namespace:Microsoft.Samples.Kinect.WpfViewers;assembly=Microsoft.Samples.Kinect.WpfViewers     5   ;     � Title$  Gesture Detector��6	   $	��647��6"   $	��713��6/   .��5      � $	��602��6   $	��652��6    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6    � ColumnDefinitions 5
   
   �� 5      $
��356* �6   6.   �� 5      $
��296* �6   6.   .+�5   
   �� $��2��6   ���#F7F7F7 �� Orientation$ 
Horizontal=�6>    �� Left$ 0��6W   
 �� Top$ -9��6g   .+�5      �� $9��3/GestureDetector;component/Images/signLogo_edit.png��6   $��51��6Q   $��40��6\   $��Center=�6h   $��5q�6�   �� 5      ���#007ACC$��30(�6)   $��Segoe UI SemiBold)�67   $�� Kiiki ��6V   $
��Left=�6h   $��1��6�   $��0��6�   $��2��6�   $	��Top=�6�   $	��5,0q�6�   $	��456��6�   5      �� 5   
   $��1��6   $��Skeleton Feed��6    $��
16,0,0,163q�67   ���#007ACC6b   �� 5   
   -   5        $��textBox1��5   Y   $��1��6   $��87��6   $
��Left=�6+   $��	5,453,0,0q�6F   $	��Top=�6i   $	��630��6�   $��2��6�   $��56(�6�   $
��Bold"�6�   $�� ��6�   ���#007ACC
���   �6�   �� 5   
   -   5        $��myCanvas��5      $��16,31,14,187q�6!   $��1��67   
���   �6Y   �� 5   
   -   5        $��label1��5   r   $��Recognized Word��6   $��1��6*   $��52��67   $
��Left=�6C   $��
16,395,0,0q�6^   $	��Top=�6�   $	��252��6�   $��24(�6�   $
��Bold"�6�   ���#007ACC6�   �� 5   
   -   5        $��	groupBox1��5      $��1��6   $��1��6#   $��Color Stream��60   $	��365��6F   $
��Left=�6S   $��6,0,0,0q�6n   $	��Top=�6�   $	��290��6�   ���#007ACC.��5      ;   5Microsoft.Samples.Kinect.WpfViewers.KinectColorViewer  -   5        $��ColorViewer��5   #   5   /Microsoft.Samples.Kinect.WpfViewers.ImageViewer   Kinect 66   ��  �� ElementName$ ColorViewer�� �� Path$ Kinect�5      5      5      