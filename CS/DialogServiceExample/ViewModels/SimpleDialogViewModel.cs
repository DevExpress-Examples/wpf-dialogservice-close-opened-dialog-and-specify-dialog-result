using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DialogServiceExample.ViewModels {
    public class SimpleDialogViewModel : ViewModelBase {
        public ICurrentDialogService CurrentDialogService {
            get {
                return GetService<ICurrentDialogService>();
            }
        }

        public MessageResult DialogResult { get; set; }

        protected SimpleDialogViewModel() { }

        public void Close(MessageResult parameter) {
            CurrentDialogService.Close(DialogResult);
        }
        public static SimpleDialogViewModel Create() {
            return ViewModelSource.Create(() => new SimpleDialogViewModel());
        }
    }
}
