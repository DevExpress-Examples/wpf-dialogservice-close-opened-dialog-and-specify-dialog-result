Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace DialogServiceExample.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Result As MessageResult
            Get
                Return GetProperty(Function() Me.Result)
            End Get

            Set(ByVal value As MessageResult)
                SetProperty(Function() Result, value)
            End Set
        End Property

        Protected ReadOnly Property DialogService As IDialogService
            Get
                Return GetService(Of IDialogService)()
            End Get
        End Property

        <Command>
        Public Sub ShowDialog()
            Result = DialogService.ShowDialog(dialogButtons:=MessageButton.YesNoCancel, title:="Simple Dialog", viewModel:=New SimpleDialogViewModel())
        End Sub
    End Class
End Namespace
