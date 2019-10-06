using InitBlaz.Client.Helpers;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitBlaz.Client.Services.Js
{
    /// <summary>
    /// Javasript service for alertify
    /// </summary>
    public class JsAlertifyService : IJsAlertifyService
    {
        private readonly IJSRuntime _jsRuntime;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="jSRuntime">Javascript runtime</param>
        public JsAlertifyService(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }

        public async Task Open(string message, TypeAlertify type)
        {
            switch (type)
            {
                case TypeAlertify.Success:
                    await _jsRuntime.InvokeAsync<bool>("Alertify", message, "success", 5);
                    break;
                case TypeAlertify.Warning:
                    await _jsRuntime.InvokeAsync<bool>("Alertify", message, "success", 5);
                    break;
                case TypeAlertify.Error:
                    await _jsRuntime.InvokeAsync<bool>("Alertify", message, "success", 5);
                    break;
                default:
                    await _jsRuntime.InvokeAsync<bool>("Alertify", message);
                    break;
            }
        }

    }
}
