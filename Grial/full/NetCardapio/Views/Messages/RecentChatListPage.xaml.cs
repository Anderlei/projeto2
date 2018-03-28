using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NetCardapio
{
	public partial class RecentChatListPage : ContentPage
	{
		public RecentChatListPage()
		{
			InitializeComponent();

			BindingContext = new ChatViewModel(useRecent: true);
		}
	}
}

