using Xamarin.Forms;

namespace NetCardapio
{
	public partial class ChatTimelinePage : ContentPage
	{
		public ChatTimelinePage()
		{
			InitializeComponent();
			BindingContext = new ChatViewModel(useRecent: false);
		}
	}
}
