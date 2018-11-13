using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;

namespace RaceManager.UI
{
    public class SoundHelper
    {
        public static void PlaySound(string filePath, SystemSound altSound = null)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var player = new SoundPlayer();
                    player.SoundLocation = filePath;
                    player.Play();
                }
                else
                {
                    altSound?.Play();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message + e.StackTrace);
            }
        }
    }
}
