﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bai1.Startup))]
namespace Bai1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
