﻿using ShoppingUIMaui.MVVM.Views;

namespace ShoppingUIMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
