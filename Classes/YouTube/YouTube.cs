
namespace ChineseChess {
    using System;
    using System.Threading.Tasks;

    using Google.Apis.YouTube.v3.Data;
    using Google.Apis.YouTube.v3;
    using Google.Apis.Services;
    static class YouTube 
    {
        public static async Task<SearchListResponse> Search(string q)
        {
            YouTubeService service = new YouTubeService(new BaseClientService.Initializer
                {
                    ApplicationName = "Chinese Chess",
                    ApiKey="AIzaSyC9bfFOOYKMMRXK6oJnxKDco-2Y7-jKyn0",
                });

            SearchResource.ListRequest req = service.Search.List("id");
            req.Q = q;
            req.MaxResults = 1;
            SearchListResponse res = await req.ExecuteAsync();
            return res;
        }
    }
}