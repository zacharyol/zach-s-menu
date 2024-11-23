using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class speedboost
    {
        public static void SpeedBoostMod() 
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
        }

    }
}
