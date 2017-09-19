using Exrin.Abstraction;
using Exrin.Framework;
using MovieReview.Feature.Main;
using MovieReview.Locator;
using MovieReview.Proxy;

namespace MovieReview.Stack
{
	public class MainStack : BaseStack
	{
		public MainStack(IViewService viewService)
            : base(new NavigationProxy(), viewService, Stacks.Main, nameof(MainViews.Main))
        {
			ShowNavigationBar = true;
		}

		protected override void Map()
		{
			base.NavigationMap<MainView, MainViewModel>(nameof(MainViews.Main));
		}
	}
}
