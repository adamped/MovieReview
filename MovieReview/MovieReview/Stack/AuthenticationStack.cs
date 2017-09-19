using Exrin.Abstraction;
using Exrin.Framework;
using MovieReview.Feature.Authentication;
using MovieReview.Locator;
using MovieReview.Proxy;

namespace MovieReview.Stack
{
	public class AuthenticationStack : BaseStack
	{
		public AuthenticationStack(IViewService viewService)
            : base(new NavigationProxy(), viewService, Stacks.Authentication, nameof(AuthenticationViews.Login))
        {
			ShowNavigationBar = false;
		}

		protected override void Map()
		{
			base.NavigationMap<LoginView, LoginViewModel>(nameof(AuthenticationViews.Login));
		}
	}
}
