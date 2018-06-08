using System;

namespace Grocer.Infrastructure {
    public class StoreUriProvider {
        private readonly string StoreUrl;

        public StoreUriProvider(string storeUrl) {
            StoreUrl = storeUrl;
        }

        public string GetGds => new Uri(new Uri(StoreUrl), "/api/v1/Data/gds").ToString();
    }
}
