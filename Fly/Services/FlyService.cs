using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using OpenMod.API.Commands;
using OpenMod.API.Plugins;
using OpenMod.Unturned.Users;
using SDG.Unturned;

namespace BIOS9.Fly.Services
{
    [PluginServiceImplementation(Lifetime = ServiceLifetime.Singleton)]
    public class FlyService : IDisposable
    {
        private IOpenModPlugin _plugin;
        private IConfiguration _configuration;
        private IStringLocalizer _localizer;
        private ILogger<FlyService> _logger;

        private List<UnturnedUser> _flying = new List<UnturnedUser>();
        private List<UnturnedUser> _toStopFlying = new List<UnturnedUser>();

        public FlyService(
            IOpenModPlugin plugin,
            IConfiguration configuration,
            IStringLocalizer localizer,
            ILogger<FlyService> logger)
        {
            _plugin = plugin;
            _configuration = configuration;
            _localizer = localizer;
            _logger = logger;
        }

        /// <summary>
        /// Toggles the flight state of a user.
        /// </summary>
        /// <param name="user">The user who should start/stop flying.</param>
        /// <returns>The new flying state. True if flying is now enabled, false if flying is now disabled.</returns>
        public bool toggleFly(UnturnedUser user)
        {
            
        }

        /// <summary>
        /// Sets the flight state of the user
        /// </summary>
        /// <param name="user">The user who should start/stop flying.</param>
        /// <param name="flying">True to enable flight, false to disable flight.</param>
        public void setFly(UnturnedUser user, bool flying)
        {

        }

        private async UniTask FlyTask()
        {
            await UniTask.SwitchToMainThread(); // ensure this runs on main thread first.
            while (_plugin.IsComponentAlive) // ensure this task runs only as long as the plugin is loaded 
            {
                await UniTask.DelayFrame(1, PlayerLoopTiming.Update);
                
                

                //if (player.input.keys[JumpKey] || player.input.keys[LeanLeftKey])
                //{
                //    player.movement.sendPluginGravityMultiplier(-1f);
                //}
                //else if (player.input.keys[CrouchKey] || player.input.keys[LeanRightKey])
                //{
                //    player.movement.sendPluginGravityMultiplier(1f);
                //}
                //else
                //{
                //    player.movement.sendPluginGravityMultiplier(0f);
                //}
            }
        }

        public void Dispose()
        {

        }
    }
}
