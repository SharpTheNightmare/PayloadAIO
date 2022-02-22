using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayloadAIO.Updates
{
    internal class UpdateChecker
    {
        public const string ApiUrl = "https://api.github.com/repos/SharpTheNightmare/PayloadAIO/releases";

        public static async Task<List<UpdateInfo>> GetReleases()
        {
            using GHWebClient wc = new();
            return JsonConvert.DeserializeObject<List<UpdateInfo>>(await wc.DownloadStringTaskAsync(ApiUrl));
        }
    }
}
