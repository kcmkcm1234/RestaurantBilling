using Android.App;
using MvvmCross.Droid.Views;

namespace RestaurantBilling.UI.Droid.Views
{
    [Activity(Label = "Main Menu")]
    public class MainMenuView : MvxActivity
    {
        /// <summary>
        /// Use OnViewModelSet to inflate the view's ContentView from AXML.
        /// </summary>
        protected override void OnViewModelSet()
        {
            // This uses a resource identifier generated by Android to identify the view.
            SetContentView(Resource.Layout.View_MainMenu);
        }
    }
}