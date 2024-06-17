using System;
using Xamarin.Forms;
using DateNight.views;

namespace DateNight
{
    public class TabController : TabbedPage
    {
        public TabController()
        {
            Children.Add(new CoffeePage() { Title="Coffee", IconImageSource="coffeeTab" });
            Children.Add(new DinnerPage() { Title = "Dinner", IconImageSource="dinnerTab" });
            Children.Add(new MoviePage() { Title = "Movie", IconImageSource="movieTab" });
            Children.Add(new CostPage() { Title = "Cost", IconImageSource="costTab" });
        }
    }
}
