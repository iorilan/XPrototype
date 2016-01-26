using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using XPrototype;
using Xunit;

namespace XMock.Test
{
    public class XPrototypeTest
    {
        [Fact]
        public async void MakeSure_GetShops_Result_Deserializable()
        {
            using (var httpClient = new HttpClient())
            {
                var url = "http://xmock.azurewebsites.net/XPrototype/GetShops";
                var str = await httpClient.GetStringAsync(url);

                var result = JsonConvert.DeserializeObject<IList<Shop>>(str);
                Assert.True(result.Count == 4);
            }
        }
    }
}
