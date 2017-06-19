using Android.Content;
using Android.Support.V4.App;
using FoodPrices.Droid.Fragments;
using Java.Lang;

namespace FoodPrices.Droid.Activities
{
    class TabsAdapter : FragmentStatePagerAdapter
	{
		string[] titles;

		public override int Count => titles.Length;

		public TabsAdapter(Context context, FragmentManager fm) : base(fm)
		{
			titles = context.Resources.GetTextArray(Resource.Array.sections);
		}

		public override ICharSequence GetPageTitleFormatted(int position) =>
							new Java.Lang.String(titles[position]);

		public override Fragment GetItem(int position)
		{
			switch (position)
			{
				case 0: return BrowseFragment.NewInstance();
				case 1: return AboutFragment.NewInstance();
			}
			return null;
		}

		public override int GetItemPosition(Java.Lang.Object frag) => PositionNone;
	}
}
