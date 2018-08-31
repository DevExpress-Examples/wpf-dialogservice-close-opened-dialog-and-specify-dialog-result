Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DialogServiceExample.ViewModels
    Public Class SimpleDialogViewModel
        Inherits ViewModelBase

        Public ReadOnly Property CurrentDialogService() As ICurrentDialogService
            Get
                Return GetService(Of ICurrentDialogService)()
            End Get
        End Property

        Public Property DialogResult() As MessageResult

        Protected Sub New()
        End Sub

        Public Sub Close(ByVal parameter As MessageResult)
            CurrentDialogService.Close(DialogResult)
        End Sub
        Public Shared Function Create() As SimpleDialogViewModel
            Return ViewModelSource.Create(Function() New SimpleDialogViewModel())
        End Function
    End Class
End Namespace
