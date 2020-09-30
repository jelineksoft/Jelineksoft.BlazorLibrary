using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Jelineksoft.BlazorLibrary.Helpers
{
    public class BrowserHelper
    {
        private readonly IJSRuntime xJs;

        public BrowserHelper(IJSRuntime js)
        {
            xJs = js;
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            return await xJs.InvokeAsync<BrowserDimension>("getDimensions");
        }
        
  
    }

  
    public class BrowserDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    
}