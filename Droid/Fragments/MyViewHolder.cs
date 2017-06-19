using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using FoodPrices.Droid.Helpers;

namespace FoodPrices.Droid.Fragments
{
	public class MyViewHolder : RecyclerView.ViewHolder
	{
		public TextView TextView { get; set; }
		public TextView DetailTextView { get; set; }

		public MyViewHolder(View itemView, Action<RecyclerClickEventArgs> clickListener,
							Action<RecyclerClickEventArgs> longClickListener) : base(itemView)
		{
			TextView = itemView.FindViewById<TextView>(Android.Resource.Id.Text1);
			DetailTextView = itemView.FindViewById<TextView>(Android.Resource.Id.Text2);
			itemView.Click += (sender, e) => clickListener(new RecyclerClickEventArgs { View = itemView, Position = AdapterPosition });
			itemView.LongClick += (sender, e) => longClickListener(new RecyclerClickEventArgs { View = itemView, Position = AdapterPosition });
		}
	}
}
