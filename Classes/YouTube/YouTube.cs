
namespace ChineseChess {
    using System;
    using System.Threading.Tasks;

    using Google.Apis.YouTube.v3.Data;
    using Google.Apis.YouTube.v3;
    using Google.Apis.Services;
    using Google.Apis.Requests;
    using Google;
    static class YouTube 
    {
        private static readonly string[] ApiKeys = {
            "AIzaSyC9bfFOOYKMMRXK6oJnxKDco-2Y7-jKyn0",
            "AIzaSyBReUZ-1lvauRN130H0BnJhgWGsovWloM0"
        };
        private static int activeKey = 0;
        public static async Task<SearchListResponse> Search(string q)
        {
            try {
                YouTubeService service = new YouTubeService(new BaseClientService.Initializer
                    {
                        ApplicationName = "Chinese Chess",
                        ApiKey = YouTube.ApiKeys[YouTube.activeKey],
                    });

                SearchResource.ListRequest req = service.Search.List("id");
                req.Q = q;
                req.MaxResults = 1;
                SearchListResponse res = await req.ExecuteAsync();
                return res;
            } catch(Google.GoogleApiException ex) {
                if(ex.Error.Code == 403) {
                    activeKey = (++activeKey) % YouTube.ApiKeys.Length;
                }
                return await YouTube.Search(q);
            } catch(Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return new SearchListResponse();
        }
    }
}