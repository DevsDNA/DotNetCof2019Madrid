using System;
using Xamarin.Forms;

namespace DotNetConf2019.Features.CollectionSample
{
    public class CustomTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RedTemplate { get; set; }
        public DataTemplate BlueTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            string[] splitString = ((string)item).Split(' ');
            var index = Convert.ToInt32(splitString[1]);
            return index % 2 == 0 ? RedTemplate : BlueTemplate;
        }
    }
}
