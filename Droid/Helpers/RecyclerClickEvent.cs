using System;
using Android.Views;

namespace FoodPrices.Droid.Helpers
{
    public class RecyclerClickEventArgs : EventArgs
    {
        public View View { get; set; }
        public int Position { get; set; }
    }
}
