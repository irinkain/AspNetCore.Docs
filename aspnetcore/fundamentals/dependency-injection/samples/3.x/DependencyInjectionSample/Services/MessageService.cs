using DependencyInjectionSample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Services
{
    public class MessageService : IMessage
    {
        public string Message(string str)
        {
            return str;
        }
    }
}
