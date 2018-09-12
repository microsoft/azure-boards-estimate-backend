using System;

namespace Estimate.Hubs
{
    class ConnectionInfo
    {
        public ConnectionInfo(string sessionId, Guid tfId)
        {
            this.SessionId = sessionId;
            this.TfId = tfId;
        }

        public string SessionId { get; private set; }

        public Guid TfId { get; private set; }
    }
}
