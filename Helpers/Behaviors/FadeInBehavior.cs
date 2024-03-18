namespace BibliotekaGierMAUI.Helpers.Behaviors
{
    public class FadeInBehavior : Behavior<View>
    {
        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.BindingContextChanged += OnBindingContextChanged;
        }

        protected override void OnDetachingFrom(View bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.BindingContextChanged -= OnBindingContextChanged;
        }

        private async void OnBindingContextChanged(object sender, EventArgs e)
        {
            var view = (View)sender;
            view.Opacity = 0;
            await view.FadeTo(1, 1000); // Fade in over 1 second
        }
    }
}
