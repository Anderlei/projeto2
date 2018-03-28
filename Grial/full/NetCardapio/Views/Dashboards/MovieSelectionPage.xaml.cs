﻿using System;
using Xamarin.Forms;
using NetCardapio.Resx;

namespace NetCardapio
{
	public partial class MovieSelectionPage : ContentPage
	{
		public MovieSelectionPage()
		{
			InitializeComponent();

			var defaultMovie = new DashboardMultipleScrollPageViewModel().Sections[3].Content[3];
			BindingContext = defaultMovie;
		}

		public async void OnMovieTapped(object sender, EventArgs args)
		{
			await DisplayAlert(
				AppResources.AlertTitleMovieTapped, 
				AppResources.AlertMessageMovieShouldPlayMovieNow, 
				AppResources.StringOK
			);
		}
	}
}

