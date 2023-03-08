using Blazorise.Bootstrap;
using Blazorise;
using BlazorWebApp.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blazorise.Icons.FontAwesome;

namespace BlazorTestProject1
{
    public class CounterTests : TestContext
    {
        [Fact]
        public void CounterStartsAtZero()
        {
            // To make this test pass.
            //  1. Comment out the Services block
            //  2. Comment out the Blazorize Button in the Counter Component

            Services
                .AddBlazorise(options =>
                {
                    options.Immediate = true;
                })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();
            
            // Arrange
            var cut = RenderComponent<Counter>();

            // Assert that content of the paragraph shows counter at zero
           cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 0</p>");
        }
      

    }
}
