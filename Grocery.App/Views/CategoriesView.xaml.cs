using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class CategoriesView : ContentPage
{
	public CategoriesView(CategoriesViewModel viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
}