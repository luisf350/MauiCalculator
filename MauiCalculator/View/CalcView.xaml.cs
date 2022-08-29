using MauiCalculator.ViewModel;

namespace MauiCalculator.View;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		BindingContext = new CalcViewModel();

    }
}