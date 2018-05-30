using Xamarin.Forms;

namespace BindingFailureOutputSample
{
	public partial class MainPage : ContentPage
	{
		public string ExistingProperty
		{
			get;
			set;
		}

		public MainPage()
		{
			InitializeComponent();

			BindingContext = this;
		}
	}
}