using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q2Sharp.Qcommon
{
    public class TestLoadGame
    {
        public static void Main(string[] args)
        {
            Qcommon.Init(args);
            System.Diagnostics.Debug.WriteLine("hello!");
            GameSave.InitGame();
            GameSave.ReadGame("test/data/savegames/game.ssv");
        }
    }
}