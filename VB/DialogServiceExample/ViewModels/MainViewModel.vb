Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DialogServiceExample.ViewModels
    Public Class MainViewModel

        Private ReadOnly Property DialogService() As IDialogService
            Get
                Return Me.GetService(Of IDialogService)()
            End Get
        End Property
        Public Overridable Property Result() As MessageResult

        Protected Sub New()
        End Sub

        Public Shared Function Create() As MainViewModel
            Return ViewModelSource.Create(Function() New MainViewModel())
        End Function
        Public Sub ShowDialog()
            Result = DialogService.ShowDialog(dialogButtons:= MessageButton.YesNoCancel, title:= "Simple Dialog", viewModel:= SimpleDialogViewModel.Create())
        End Sub
    End Class
End Namespace
