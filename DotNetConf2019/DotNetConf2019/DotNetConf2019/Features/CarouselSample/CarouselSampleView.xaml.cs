namespace DotNetConf2019.Features.CarouselSample
{
    public partial class CarouselSampleView
    {
        public CarouselSampleView()
        {
            InitializeComponent();
            BindingContext = new CarouselSampleViewModel();
        }
    }
}