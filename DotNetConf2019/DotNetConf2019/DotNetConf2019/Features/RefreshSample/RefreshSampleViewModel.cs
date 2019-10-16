namespace DotNetConf2019.Features.RefreshSample
{
    using DotNetConf2019.Base;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class RefreshSampleViewModel : BaseViewModel
    {
        private bool isRefreshing;
        private ObservableCollection<string> items;
        private int index = 3;

        public RefreshSampleViewModel()
        {
            isRefreshing = false;
            items = new ObservableCollection<string>() { "Item 1", "Item 2" };
            RefreshCommand = new Command(Refresh);
        }

        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand { get; set; }

        private async void Refresh(object obj)
        {
            IsRefreshing = true;
            await Task.Delay(2000);

            Items.Add($"Item {index}");
            index++;
            Items.Add($"Item {index}");
            index++;
            IsRefreshing = false;
        }
    }
}
