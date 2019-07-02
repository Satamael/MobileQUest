using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobileQest
{
	public class mp : ContentPage
	{
		public mp ()
		{
			Content = new StackLayout {
				Children =
                {
					new Label { Text = "Я буду стрелять!" }
				}
			};
		}
	}
}