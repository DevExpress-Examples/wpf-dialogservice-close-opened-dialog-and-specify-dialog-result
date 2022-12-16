Imports DevExpress.Mvvm
Imports System.Windows.Input

Namespace DialogServiceExample.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Private _ShowDialogCommand As ICommand

        Public Property Result As MessageResult
            Get
                Return GetProperty(Function() Me.Result)
            End Get

            Set(ByVal value As MessageResult)
                SetProperty(Function() Result, value)
            End Set
        End Property

        Public Property ShowDialogCommand As ICommand
            Get
                Return _ShowDialogCommand
            End Get

            Private Set(ByVal value As ICommand)
                _ShowDialogCommand = value
            End Set
        End Property

        Protected ReadOnly Property DialogService As IDialogService
            Get
                Return GetService(Of IDialogService)()
            End Get
        End Property

        Public Sub New()
            ShowDialogCommand = New DelegateCommand(AddressOf ShowDialog)
        End Sub

        Public Sub ShowDialog()
            Result = DialogService.ShowDialog(dialogButtons:=MessageButton.YesNoCancel, title:="Simple Dialog", viewModel:=New SimpleDialogViewModel())
        End Sub
    End Class
End Namespace
