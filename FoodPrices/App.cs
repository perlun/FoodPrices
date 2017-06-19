using System;
using System.Collections.Generic;

namespace FoodPrices
{
    public partial class App
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "http://localhost:5000";

        public static void Initialize()
        {
            if (UseMockDataStore)
                ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
            else
                ServiceLocator.Instance.Register<IDataStore<Item>, CloudDataStore>();

#if __IOS__
			ServiceLocator.Instance.Register<IMessageDialog, iOS.MessageDialog>();
#else
            ServiceLocator.Instance.Register<IMessageDialog, Droid.Helpers.MessageDialog>();
#endif
        }

        public static IDictionary<string, string> LoginParameters => null;
    }
}
