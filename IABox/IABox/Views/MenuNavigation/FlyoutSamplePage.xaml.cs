using Api.Entity;
using IABox.Models.DTO;
using IABox.Views.Pages;
using Configs = IABox.Views.Pages.Configs;

namespace IABox.Views.MenuNavigation;

public partial class FlyoutSamplePage : FlyoutPage
{
    #region properties..
    #endregion
    public FlyoutSamplePage()
	{
		InitializeComponent();
        flyoutPage.collectionViewFlyout.SelectionChanged += CollectionViewFlyout_SelectionChanged;
    }

   

    private void CollectionViewFlyout_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;

        if (item != null)
        {

            if (!((IFlyoutPageController)this).ShouldShowSplitMode)
                IsPresented = false;

            switch (item.Title)
            {
                case "Inicio":
                    break;

                case "Alarmas":
                    Detail = new NavigationPage(new Alarms());
                    break;

                case "Configuraciones":
                    Detail = new NavigationPage(new Configs());
                    break;
            }
        }
    }
}