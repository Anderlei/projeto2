using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace NetCardapio
{
	public partial class NotificationsPage : ContentPage
	{
		public NotificationsPage()
		{
			InitializeComponent();

			BindingContext = new NotificationsViewModel();
		}
	}
}

