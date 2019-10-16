namespace DotNetConf2019.Features.CollectionSample
{
    public partial class EmptyCollectionViewSampleView
    {
        public EmptyCollectionViewSampleView()
        {
            InitializeComponent();
            BindingContext = new EmptyEmptyCollectionViewSampleViewModel();
        }
    }
}