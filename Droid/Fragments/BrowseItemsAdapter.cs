using Android.App;
using Android.Support.V7.Widget;
using Android.Views;
using FoodPrices.Droid.Helpers;

namespace FoodPrices.Droid.Fragments
{
	class BrowseItemsAdapter : BaseRecycleViewAdapter
	{
		ItemsViewModel viewModel;
		Activity activity;

		public BrowseItemsAdapter(Activity activity, ItemsViewModel viewModel)
		{
			this.viewModel = viewModel;
			this.activity = activity;

			this.viewModel.Items.CollectionChanged += (sender, args) =>
			{
				this.activity.RunOnUiThread(NotifyDataSetChanged);
			};
		}

		// Create new views (invoked by the layout manager)
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			//Setup your layout here
			View itemView = null;
			var id = Resource.Layout.item_browse;
			itemView = LayoutInflater.From(parent.Context).Inflate(id, parent, false);

			var vh = new MyViewHolder(itemView, OnClick, OnLongClick);
			return vh;
		}

		// Replace the contents of a view (invoked by the layout manager)
		public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			var item = viewModel.Items[position];

			// Replace the contents of the view with that element
			var myHolder = holder as MyViewHolder;
			myHolder.TextView.Text = item.Text;
			myHolder.DetailTextView.Text = item.Description;
		}

		public override int ItemCount => viewModel.Items.Count;
	}
}
