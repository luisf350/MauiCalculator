using MauiCalculator.View;

namespace MauiCalculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalcView();
	}
}
