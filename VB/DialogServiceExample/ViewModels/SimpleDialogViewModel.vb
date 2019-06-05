Imports DevExpress.Mvvm

Namespace DialogServiceExample.ViewModels
    Public Class SimpleDialogViewModel
        Inherits ViewModelBase

        Public Property DialogResult() As MessageResult
            Get
                Return GetProperty(Function() DialogResult)
            End Get
            Set(ByVal value As MessageResult)
                SetProperty(Function() DialogResult, value)
            End Set
        End Property
        Public Property CloseCommand() As ICommand
        Protected ReadOnly Property CurrentDialogService() As ICurrentDialogService
            Get
                Return GetService(Of ICurrentDialogService)()
            End Get
        End Property

        Public Sub New()
            CloseCommand = New DelegateCommand(Of MessageResult)(AddressOf Close)
        End Sub

        Public Sub Close(ByVal parameter As MessageResult)
            CurrentDialogService.Close(DialogResult)
        End Sub
    End Class
End Namespace