<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/146886609/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830533)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainView.xaml](./CS/DialogServiceExample/Views/MainView.xaml) (VB: [MainView.xaml](./VB/DialogServiceExample/Views/MainView.xaml))**
* [SimpleDialogView.xaml](./CS/DialogServiceExample/Views/SimpleDialogView.xaml) (VB: [SimpleDialogView.xaml](./VB/DialogServiceExample/Views/SimpleDialogView.xaml))
* [MainViewModel.cs](./CS/DialogServiceExample/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DialogServiceExample/ViewModels/MainViewModel.vb))
* [SimpleDialogViewModel.cs](./CS/DialogServiceExample/ViewModels/SimpleDialogViewModel.cs) (VB: [SimpleDialogViewModel.vb](./VB/DialogServiceExample/ViewModels/SimpleDialogViewModel.vb))
<!-- default file list end -->
# DialogService - How to close an opened dialog and specify the dialog result


This example demonstrates how to work with the currently opened dialog directly from its view model. The <a href="https://docs.devexpress.com/WPF/401018/MVVM-Framework/Services/Predefined-Set/CurrentDialogService">CurrentDialogService</a> component is a handful tool in this case, which allows to close the dialog with one of the available results from within a command inside the view model.
