using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIOS9.Fly.Services;
using Cysharp.Threading.Tasks;
using OpenMod.Core.Commands;
using OpenMod.Unturned.Commands;
using OpenMod.Unturned.Users;

namespace BIOS9.Fly.Commands
{
    [Command("fly")]
    [CommandDescription("Gives you wings!")]
    [CommandActor(typeof(UnturnedUser))]
    internal class FlyCommand : UnturnedCommand
    {
        private FlyService _flyService;

        public FlyCommand(FlyService flyService, IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _flyService = flyService;
        }

        protected override UniTask OnExecuteAsync()
        {
            var user = (UnturnedUser)Context.Actor;
            _flyService.toggleFly(user);
            return UniTask.CompletedTask;
        }
    }
}
