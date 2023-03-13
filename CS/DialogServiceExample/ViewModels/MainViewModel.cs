using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace DialogServiceExample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public MessageResult Result {
            get { return GetProperty(() => Result); }
            set { SetProperty(() => Result, value); }
        }
        protected IDialogService DialogService { get { return GetService<IDialogService>(); } }

        [Command]
        public void ShowDialog() {
            Result = DialogService.ShowDialog(dialogButtons: MessageButton.YesNoCancel, title: "Simple Dialog", viewModel: new SimpleDialogViewModel());
        }
    }
}