using DevExpress.Mvvm;
using System.Windows.Input;

namespace DialogServiceExample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public MessageResult Result {
            get { return GetProperty(() => Result); }
            set { SetProperty(() => Result, value); }
        }
        public ICommand ShowDialogCommand { get; private set; }
        protected IDialogService DialogService { get { return GetService<IDialogService>(); } }

        public MainViewModel() {
            ShowDialogCommand = new DelegateCommand(ShowDialog);
        }

        public void ShowDialog() {
            if (DialogService != null)
                Result = DialogService.ShowDialog(dialogButtons: MessageButton.YesNoCancel, title: "Simple Dialog", new SimpleDialogViewModel());
        }
    }
}