using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR
{
    public class ChatHub : Hub
    {
    

        //public async Task JoinGroup (string GroupId)
        //{
        //    await Groups.AddToGroupAsync(Context.ConnectionId, GroupId);
        //}
        //public async Task SendMessageGroup (string user, string message,string GroupId)
        //{
            
        //    await Clients.Group(GroupId).SendAsync("ReceiveMessage", user, message);
        //}
        //public async Task SendMessage(string user, string message)
        //{

        //    await Clients.All.SendAsync("ReceiveMessage", user, message);
        //}
    }
}
