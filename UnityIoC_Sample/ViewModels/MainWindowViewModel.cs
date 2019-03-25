using Prism.Mvvm;

namespace UnityIoC_Sample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(DemoData demoData)
        {
            // DemoData will be generated automatically.
        }
    }
}