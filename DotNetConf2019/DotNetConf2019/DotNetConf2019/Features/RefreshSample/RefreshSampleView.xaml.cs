namespace DotNetConf2019.Features.RefreshSample
{

    public partial class RefreshSampleView 
    {
        public RefreshSampleView()
        {
            InitializeComponent();
            BindingContext = new RefreshSampleViewModel();
        }
    }
}