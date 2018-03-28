using Xamarin.Forms;

namespace NetCardapio
{
	public partial class DashboardMultipleScrollPage : ContentPage
	{
		public DashboardMultipleScrollPage ()
		{
			InitializeComponent ();

			BindingContext = new DashboardMultipleScrollPageViewModel();
		}
	}
}
