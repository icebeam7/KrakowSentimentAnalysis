﻿using Xamarin.Forms;

namespace KrakowSentimentAnalysis.Helpers
{
    public static class SentimentColor
    {
        public static Color Retrieve(float sentiment)
            => sentiment < 0.5 ? Color.Red
            : sentiment > 0.5 ? Color.Green
            : Color.Black;
    }
}
