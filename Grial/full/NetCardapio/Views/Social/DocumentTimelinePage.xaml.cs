using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NetCardapio
{
	public partial class DocumentTimelinePage : ContentPage
	{
		public DocumentTimelinePage()
		{
			InitializeComponent ();
			BindingContext = new DocumentTimelineViewModel();
		}
	}
}

