namespace DotNetConf2019.Features.LabelSample
{
	using System;
	using DotNetConf2019.Base;
	using Xamarin.Forms;

	public class LabelSampleViewModel : BaseViewModel
	{
		private string text;

		public LabelSampleViewModel()
		{
			LoadMoreDataForVasileo = new Command(LoadMoreDataForVasileoExecute);
		}


		public Command LoadMoreDataForVasileo { get; }

		public string Text
		{
			get => text;
			set
			{
				text = value;
				OnPropertyChanged();
			}
		}


		private void LoadMoreDataForVasileoExecute(object obj)
		{
			Text = @"<p><b>Placerat a litora at scelerisque iaculis. Blandit habitasse vel feugiat id nostra ultricies fringilla mus nec dictum inceptos ultricies.Convallis feugiat inceptos consequat dolor sed lorem at placerat condimentum. Sociosqu torquent feugiat et.</b> <u>Lacus sociosqu pellentesque erat, aliquam turpis suspendisse volutpat placerat senectus penatibus. Lectus lectus in mollis feugiat dignissim litora.</u> <i>Faucibus ad gravida non? Gravida suscipit faucibus ac iaculis imperdiet natoque integer gravida non nostra! Viverra, curae; himenaeos!</i></p>
<p>Sociosqu fusce sollicitudin commodo, iaculis pellentesque ut taciti turpis tristique phasellus dictum cursus.Sit, blandit consectetur etiam.Feugiat erat, at natoque lacus curae;. Netus himenaeos nulla sociosqu luctus! Nisi nibh magnis natoque enim! Velit sociis id non mauris ipsum libero leo dignissim, cubilia eros mollis mattis. Aenean penatibus tristique ac magnis torquent egestas lacinia cras hac velit.Diam netus purus nascetur in sagittis.Accumsan sociis aliquam malesuada sagittis lobortis. Phasellus ligula magna tristique vulputate.Class condimentum eget metus convallis tristique iaculis faucibus commodo.Vulputate lectus laoreet sem magnis.Nunc sodales blandit a quisque massa adipiscing pharetra ut ?</p>";
		}
	}
}
