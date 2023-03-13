Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace DialogServiceExample.ViewModels

    Public Class SimpleDialogViewModel
        Inherits ViewModelBase

        Public Property DialogResult As MessageResult
            Get
                Return GetProperty(Function() Me.DialogResult)
            End Get

            Set(ByVal value As MessageResult)
                SetProperty(Function() DialogResult, value)
            End Set
        End Property

        Protected ReadOnly Property CurrentDialogService As ICurrentDialogService
            Get
                Return GetService(Of ICurrentDialogService)()
            End Get
        End Property

        <Command>
        Public Sub Close()
            CurrentDialogService.Close(DialogResult)
        End Sub
    End Class
End Namespace
