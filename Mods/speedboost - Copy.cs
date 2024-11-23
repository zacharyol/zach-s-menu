using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class speedboostslower
    {
        public static void SpeedBoostModslower() 
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 2f;
        }

    }
}
