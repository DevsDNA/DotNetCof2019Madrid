namespace DotNetConf2019.Features.CarouselSample
{
    using DotNetConf2019.Base;
    using System.Collections.ObjectModel;

    public class CarouselSampleViewModel : BaseViewModel
    {
        private ObservableCollection<string> items;

        public CarouselSampleViewModel()
        {
            LoadItems();
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

        private void LoadItems()
        {
            Items = new ObservableCollection<string>();
            for (int i = 1; i <= 3; i++)
                Items.Add($"Item {i}");
        }
    }
}
