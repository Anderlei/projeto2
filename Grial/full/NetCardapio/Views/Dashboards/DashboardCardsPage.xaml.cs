using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace NetCardapio
{
	public partial class DashboardCardsPage : ContentPage
	{
		public DashboardCardsPage()
		{
			InitializeComponent();

			BindingContext = new DashboardCardsViewModel();
		}
	}
}

