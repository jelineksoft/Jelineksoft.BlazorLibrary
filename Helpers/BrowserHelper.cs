using Microsoft.JSInterop;
using System.Threading.Tasks;
using Jelineksoft.Logging;
using Microsoft.AspNetCore.Components;

namespace Jelineksoft.BlazorLibrary.Helpers
{
    public class BrowserHelper
    {
        private readonly IJSRuntime xJs;
        private ILogFactory log;

        public BrowserHelper(IJSRuntime js, ILogFactory logger)
        {
            xJs = js;
            log = logger;
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            return await xJs.InvokeAsync<BrowserDimension>("getDimensions");
        }

        public void FocusElement(ElementReference element)
        {
            log?.Trace(this, "BrowserHelper", $"Call FocusElementByRef.");
            xJs.InvokeVoidAsync("focusElementByRef",element);
        }
        public void FocusElement(string id)
        {
            log?.Trace(this, "BrowserHelper", $"Call FocusElementById {id}.");
            xJs.InvokeVoidAsync("focusElementById",id);
        }

        public async void FocusElementClassOrNextInput(string className)
        {
            await xJs.InvokeVoidAsync("focusInputFromBlazor", new[] { className });
        }
  
    }

  
    public class BrowserDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
    
}