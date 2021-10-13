using System;
using ActionRSP = RSP.Action;
using ActionRSPLS = RSPLS.Action;
using PlayerRockRSP = RSP.PlayerRock;
using PlayerPaperRSP = RSP.PlayerPaper;

using PlayerRockRSPLS = RSPLS.PlayerRock;
using PlayerSpockRSPLS = RSPLS.PlayerSpock;

namespace RSPGame
{
    class Program
    {
        static void Main()
        {
            PlayerRockRSPLS playerLizard = new("Lizard");
            PlayerSpockRSPLS playerSpock = new("Spock");
            Console.WriteLine(RSPBase.Game<ActionRSPLS>.Fight(playerLizard, playerSpock).ToString());


            PlayerRockRSP playerRock = new("Rock");
            PlayerPaperRSP playerPapper = new("Papper");
            Console.WriteLine(RSPBase.Game<ActionRSP>.Fight(playerRock, playerPapper).ToString());
        }
    }
}
