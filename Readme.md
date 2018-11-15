<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/LocalizationDescriptor/MainPage.xaml) (VB: [MainPage.xaml](./VB/LocalizationDescriptor/MainPage.xaml))
* [MainPage.xaml.cs](./CS/LocalizationDescriptor/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/LocalizationDescriptor/MainPage.xaml))
<!-- default file list end -->
# How to Localize Individual Runtime Resource Strings


<p>This example shows how to change the default string displayed within the Group Panel and the Column Chooser's caption, at runtime. To translate individual resource strings at runtime, create a RuntimeStringIdInfo object with the specified Id and Value properties, and add it to the View's RuntimeLocalizationStrings collection. The Id property identifies the required resource string. The Value property specifies a new value for it.</p>

<br/>


