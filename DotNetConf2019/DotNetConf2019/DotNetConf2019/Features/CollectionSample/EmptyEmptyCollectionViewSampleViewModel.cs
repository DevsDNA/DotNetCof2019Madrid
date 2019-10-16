namespace DotNetConf2019.Features.CollectionSample
{
    using DotNetConf2019.Base;
    using System.Collections.ObjectModel;

    public class EmptyEmptyCollectionViewSampleViewModel : BaseViewModel
    {
        private ObservableCollection<string> items;

        public EmptyEmptyCollectionViewSampleViewModel()
        {
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
    }
}