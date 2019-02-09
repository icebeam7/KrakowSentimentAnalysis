using System;

using KrakowSentimentAnalysis.Helpers;
using KrakowSentimentAnalysis.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KrakowSentimentAnalysis.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextAnalyticsPage : ContentPage
	{
        public TextAnalyticsPage()
        {
            InitializeComponent();
        }

        private async void AnalyzeButton_Clicked(object sender, EventArgs e)
        {
            Loading(true);

            var sentiment = await TextAnalyticsService.AnalyzeText(MessageEntry.Text);

            if (sentiment != null)
            {
                ScoreLabel.Text = sentiment.score.ToString("N4");
                ScoreLabel.TextColor = SentimentColor.Retrieve(sentiment.score);
            }

            Loading(false);
        }

        void Loading(bool mostrar)
        {
            indicator.IsEnabled = mostrar;
            indicator.IsRunning = mostrar;
        }
    }
}