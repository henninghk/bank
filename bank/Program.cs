using System;

namespace OOtask

{
    class Program
    {
        static void Main(string[] args)
        {
            var team = new FootBallTeam("Liverpool", "klopp", 1);
            var team1 = new FootBallTeam("manchesterU", "solskjær", 20);
            team.Show();
            team1.Show();
            

        }
    }
}
