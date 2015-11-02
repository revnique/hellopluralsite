using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloPluralsite
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

		public void OnClick( object o, EventArgs e) {
			message.Text = "goodbye pluralsite";
		}
	}
}
