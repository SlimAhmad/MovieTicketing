using MonkeyCache;
using MovieTicketing.Core;

namespace MovieTicketing;

public class YoutubeService : RestServiceBase, IApiService
{
	public YoutubeService(IConnectivity connectivity, IBarrel cacheBarrel) : base(connectivity, cacheBarrel)
	{
        SetBaseURL(Constants.ApiServiceURL);
	}

  

}

