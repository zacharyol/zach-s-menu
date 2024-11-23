using System;
using Photon.Pun;  // Photon namespace

namespace StupidTemplate.Mods
{
    internal class Disconect
    {
        // Method to handle the disconnection process
        public static void DisconectNow()
        {
            try
            {
                // Check if the player is connected before attempting to disconnect
                if (PhotonNetwork.IsConnected)
                {
                    Console.WriteLine("Attempting to disconnect from Photon...");

                    // Call PhotonNetwork's disconnect function
                    PhotonNetwork.Disconnect();

                    Console.WriteLine("Player disconnected successfully from Photon.");
                }
                else
                {
                    Console.WriteLine("Player is not connected to Photon.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to disconnect: " + ex.Message);
            }
        }
    }
}
