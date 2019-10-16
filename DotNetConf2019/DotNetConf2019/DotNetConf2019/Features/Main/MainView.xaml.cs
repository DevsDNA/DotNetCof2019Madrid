using DotNetConf2019.Features.CarouselSample;
using DotNetConf2019.Features.CheckBoxSample;
using DotNetConf2019.Features.CollectionSample;
using DotNetConf2019.Features.LabelSample;
using DotNetConf2019.Features.RefreshSample;
using Xamarin.Forms;

namespace DotNetConf2019.Features.Main
{
    public partial class MainView
	{
		public MainView()
		{
			InitializeComponent();
			BindingContext = new MainViewModel();

            MasterPage.ItemSelected += MasterPage_ItemSelected;

        }

        private void MasterPage_ItemSelected(object sender, int e)
        {
            switch (e)
            {
                case 1:
                    Detail = new NavigationPage(new CarouselSampleView());
                    break;
                case 2:
                    Detail = new NavigationPage(new CollectionSampleView());
                    break;
                case 3:
                    Detail = new NavigationPage(new LabelSampleView());
                    break;
                case 4:
                    Detail = new NavigationPage(new CheckBoxSampleView());
                    break;
                case 5:
                    Detail = new NavigationPage(new RefreshSampleView());
                    break;
                case 6:
                    Detail = new NavigationPage(new EmptyCollectionViewSampleView());
                    break;
            }

            IsPresented = false;
        }
    }
}