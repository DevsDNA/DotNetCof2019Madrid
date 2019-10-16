namespace DotNetConf2019.Features.CollectionSample
{
    using DotNetConf2019.Base;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class CollectionSampleViewModel : BaseViewModel
    {
        private ObservableCollection<string> items;
        private int index = 1;
        
        public CollectionSampleViewModel()
        {
            items = new ObservableCollection<string>();
            AddItems(100);
            RefreshCommand = new Command(Refresh);
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
            await Task.Delay(1000);
            AddItems(100);
        }

        private void AddItems(int numberOfItems)
        {
            if (index >= 300)
                return;

            for (int i = 0; i < numberOfItems; i++)
            {
                Items.Add($"Item {index}");
                index++;
            }
        }
    }
}
