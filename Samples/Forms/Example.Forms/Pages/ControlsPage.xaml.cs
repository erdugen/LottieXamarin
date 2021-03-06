﻿using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Example.Forms
{
    public partial class ControlsPage : ContentPage
    {
        public ControlsPage()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            //animationView.Progress = (float)e.NewValue;
        }

        private void Handle_OnFinish(object sender, System.EventArgs e)
        {
            DisplayAlert(string.Empty, $"{nameof(animationView.OnFinishedAnimation)} invoked!", "OK");
        }

        private void animationView_OnAnimationUpdate(object sender, float e)
        {
            progressSlider.Value = e;
        }
    }
}
