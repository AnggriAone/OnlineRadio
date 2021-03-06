﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineRadio.Core
{
    public interface IPlugin
    {
        string Name
        {
            get;
        }

        void OnCurrentSongChanged(object sender, CurrentSongEventArgs args);

        void OnStreamUpdate(object sender, StreamUpdateEventArgs args);
    }

    public abstract class BasePlugin : IPlugin
    {
        string IPlugin.Name
        {
            get 
            { 
                return "BasePlugin";
            }
        }

        void IPlugin.OnCurrentSongChanged(object sender, CurrentSongEventArgs args)
        {}

        void IPlugin.OnStreamUpdate(object sender, StreamUpdateEventArgs args)
        { }
    }
}
