﻿using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTVM2App
{
    [HubName("Chat")]
    public class ChatHub : Hub
    {
        [HubMethodName("announceToEverybody")]
        public void Announce(string message)
        {
            Clients.All.Announce(message);
        }
        public DateTime GetServerDateTime() {
            return DateTime.Now;
        }
    }
}