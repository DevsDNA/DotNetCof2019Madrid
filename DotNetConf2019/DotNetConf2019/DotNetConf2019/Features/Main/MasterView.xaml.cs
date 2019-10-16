using System;

namespace DotNetConf2019.Features.Main
{
	public partial class MasterView
	{
		public MasterView()
		{
			InitializeComponent();
			BindingContext = new MainViewModel();
		}

        public event EventHandler<int> ItemSelected;

        private void BtnCarousel_Clicked(object sender, System.EventArgs e)
        {
            ItemSelected?.Invoke(this, 1);
        }

        private void BtnCollection_Clicked(object sender, System.EventArgs e)
        {
            ItemSelected?.Invoke(this, 2);
        }

        private void BtnLabel_Clicked(object sender, System.EventArgs e)
        {
            ItemSelected?.Invoke(this, 3);
        }

        private void BtnCheckBox_Clicked(object sender, System.EventArgs e)
        {
            ItemSelected?.Invoke(this, 4);
        }

        private void BtnRefresh_Clicked(object sender, System.EventArgs e)
        {
            ItemSelected?.Invoke(this, 5);
        }

        private void BtnEmptyCollection_Clicked(object sender, System.EventArgs e)
        {
            ItemSelected?.Invoke(this, 6);
        }
    }
}