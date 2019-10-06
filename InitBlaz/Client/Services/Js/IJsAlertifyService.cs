using InitBlaz.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InitBlaz.Client.Services.Js
{
    /// <summary>
    /// Alertiify javasript service.
    /// </summary>
    public interface IJsAlertifyService
    {
        Task Open(string message, TypeAlertify type);
    }
}
