namespace DotNetConf2019.Features.CollectionSample
{
    using DotNetConf2019.Base;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;
    using System.Collections.Generic;
    using System.Threading;

    public class CollectionSampleViewModel : BaseViewModel
    {
        private ObservableCollection<string> items;
        private int index = 1;
        private bool loading = false;
        
        public CollectionSampleViewModel()
        {
            items = new ObservableCollection<string>();
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

        public bool Loading
        {
            get => loading;
            set
            {
                loading = value;
                OnPropertyChanged();
            }
        }

        private async void Refresh(object obj)
        {
            if (!loading)
            {
                Loading = true;
                foreach (string item in await AddItems(50))
                {
                    if (Items.Count % 2 == 0)
                        Items.Add($"{item} es impar");
                    else
                        Items.Add($"{item} es par");
                }


                //await foreach (string item in AddItemsAsync(50).ConfigureAwait(false))
                //{
                //    if (Items.Count % 2 == 0)
                //        Items.Add($"{item} es impar");
                //    else
                //        Items.Add($"{item} es par");
                //}

                Loading = false;
            }
        }

        private async Task<IEnumerable<string>> AddItems(int numberOfItems)
        {
            var newItems = new List<string>();
            index = 1;
            for (int i = 1; i <= numberOfItems; i++)
            {
                await Task.Delay(100);
                newItems.Add($"Item {index}");
                index++;
            }

            return newItems;
        }

        private async IAsyncEnumerable<string> AddItemsAsync(int numberOfItems)
        {
            index = Items.Count;
            for (int i = 1; i <= numberOfItems; i++)
            {
                await Task.Delay(100);
                index++;
                yield return $"Item {index}";
            }
        }
    }
}
