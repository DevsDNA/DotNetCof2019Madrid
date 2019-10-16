namespace DotNetConf2019.Features.LabelSample
{
	public partial class LabelSampleView
	{
		public LabelSampleView()
		{
			InitializeComponent();
			BindingContext = new LabelSampleViewModel();
		}
	}
}