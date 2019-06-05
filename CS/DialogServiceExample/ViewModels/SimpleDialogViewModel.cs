using DevExpress.Mvvm;
using System.Windows.Input;

namespace DialogServiceExample.ViewModels {
    public class SimpleDialogViewModel : ViewModelBase {
        public MessageResult DialogResult {
            get { return GetProperty(() => DialogResult); }
            set { SetProperty(() => DialogResult, value); }
        }
        public ICommand CloseCommand { get; private set; }
        protected ICurrentDialogService CurrentDialogService { get { return GetService<ICurrentDialogService>(); } }

        public SimpleDialogViewModel() {
            CloseCommand = new DelegateCommand<MessageResult>(Close);
        }

        public void Close(MessageResult parameter) {
            CurrentDialogService.Close(DialogResult);
        }
    }
}