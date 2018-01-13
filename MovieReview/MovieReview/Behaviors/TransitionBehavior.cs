using Exrin.Framework;
using Xamarin.Forms;

namespace MovieReview.Behaviors
{
    public class TransitionBehavior : Behavior<Label>
    {
        public bool IsSelected { get; set; }
        private Label _label { get; set; }
        protected override void OnAttachedTo(Label bindable)
        {
            base.OnAttachedTo(bindable);
            _label = bindable;
            _label.GestureRecognizers.Add(new TapGestureRecognizer() { Command = TapCommand });
        }

        public RelayCommand TapCommand => new RelayCommand((o) =>
        {
            IsSelected = !IsSelected;
            _label.TextColor = IsSelected ? Color.Blue : Color.Gray;
            if (IsSelected)
                _label.TranslateTo(50, 0, 1000, Easing.CubicInOut);
            else
                _label.TranslateTo(0, 0, 1000, Easing.CubicInOut);
        });

        protected override void OnDetachingFrom(Label bindable)
        {
            base.OnDetachingFrom(bindable);
            _label = null;
        }
    }
}
