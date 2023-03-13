using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace DialogServiceExample.ViewModels {
    public class SimpleDialogViewModel : ViewModelBase {
        public MessageResult DialogResult {
            get { return GetProperty(() => DialogResult); }
            set { SetProperty(() => DialogResult, value); }
        }
        protected ICurrentDialogService CurrentDialogService { get { return GetService<ICurrentDialogService>(); } }

        [Command]
        public void Close() {
            CurrentDialogService.Close(DialogResult);
        }
    }
}