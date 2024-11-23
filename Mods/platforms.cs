using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Platforms
    {
        private static GameObject CreatePlatformOnHand(Transform handTransform)
        {
            GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)3);
            gameObject.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
            gameObject.transform.position = handTransform.position;
            gameObject.transform.rotation = handTransform.rotation;
            float num = (float)Time.frameCount / 180f % 1f;
            gameObject.GetComponent<Renderer>().material.color = Color.HSVToRGB(num, 1f, 1f);
            return gameObject;
        }

        public static void CreatePlatformOnHand()
        {
            bool flag = ControllerInputPoller.instance.leftGrab && Platforms.leftplat == null;
            if (flag)
            {
                Platforms.leftplat = Platforms.CreatePlatformOnHand(GorillaTagger.Instance.leftHandTransform);
            }
            bool flag2 = ControllerInputPoller.instance.rightGrab && Platforms.rightplat == null;
            if (flag2)
            {
                Platforms.rightplat = Platforms.CreatePlatformOnHand(GorillaTagger.Instance.rightHandTransform);
            }
            bool flag3 = ControllerInputPoller.instance.rightGrabRelease && Platforms.rightplat != null;
            if (flag3)
            {
                Utils.Disable(Platforms.rightplat);
                Platforms.rightplat = null;
            }
            bool flag4 = ControllerInputPoller.instance.leftGrabRelease && Platforms.leftplat != null;
            if (flag4)
            {
                Utils.Disable(Platforms.leftplat);
                Platforms.leftplat = null;
            }
        }

        private static GameObject leftplat;

        private static GameObject rightplat;
    }
}