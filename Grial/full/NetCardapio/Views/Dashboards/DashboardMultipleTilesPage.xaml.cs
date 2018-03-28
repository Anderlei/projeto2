using Xamarin.Forms;

namespace NetCardapio
{
	public partial class DashboardMultipleTilesPage : ContentPage
	{
		public DashboardMultipleTilesPage ()
		{			
			InitializeComponent();

			BindingContext = new DashboardMutipleTilesViewModel();
		}
	}
}