using System;

namespace Estimate.Hubs
{
    class ConnectionInfo
    {
        public ConnectionInfo(Guid sessionId, Guid tfId)
        {
            this.SessionId = sessionId;
            this.TfId = tfId;
        }

        public Guid SessionId { get; private set; }

        public Guid TfId { get; private set; }
    }
}
