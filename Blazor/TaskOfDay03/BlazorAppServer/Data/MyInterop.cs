using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace MyApplication
{
    public static class MyInterop
    {
        public static ValueTask<string> GetCurrentDate(IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeAsync<string>("myScript.getCurrentDate");
        }
    }
}