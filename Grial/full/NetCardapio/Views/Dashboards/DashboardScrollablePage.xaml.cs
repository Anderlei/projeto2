using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace NetCardapio
{
	public partial class DashboardScrollablePage : ContentPage
	{
		public DashboardScrollablePage()
		{
			InitializeComponent();

			BindingContext = new DashboardScrollableViewModel();
		}
	}

}
