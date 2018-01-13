using Exrin.Framework;
using Xamarin.Forms;

namespace MovieReview.Behaviors
{
    public class PopBehavior : Behavior<Label>
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
            _label.TextColor = IsSelected ? Color.Orange : Color.Gray;
            if (IsSelected)
                _label.ScaleTo(2, 500, easing: Easing.SpringIn);
            else
                _label.ScaleTo(1, 500, easing: Easing.SpringOut);
        });

        protected override void OnDetachingFrom(Label bindable)
        {
            base.OnDetachingFrom(bindable);
            _label = null;
        }
    }
}
