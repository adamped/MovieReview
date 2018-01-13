using Exrin.Framework;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MovieReview.Behaviors
{
    public class NotificationBehavior : Behavior<Label>
    {
        public bool IsSelected { get; set; }
        private Label _label { get; set; }
        protected override void OnAttachedTo(Label bindable)
        {
            base.OnAttachedTo(bindable);
            _label = bindable;
            _label.GestureRecognizers.Add(new TapGestureRecognizer() { Command = TapCommand });
        }

        public RelayCommand TapCommand => new RelayCommand(async (o) =>
        {
            IsSelected = !IsSelected;
            _label.TextColor = IsSelected ? Color.Red : Color.Gray;
            if (IsSelected)
                await Task.Run(async () =>
                {
                    while (IsSelected)
                    {
                        await _label.ScaleTo(1.2, 500, easing: Easing.SpringIn);
                        
                        await _label.ScaleTo(1, 500, easing: Easing.SpringOut);
                    }
                });
                
            else
                await _label.ScaleTo(1, 500, easing: Easing.SpringOut);
        });

        protected override void OnDetachingFrom(Label bindable)
        {
            base.OnDetachingFrom(bindable);
            _label = null;
        }
    }
}
