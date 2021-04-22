using System;
using System.Collections.Generic;
using System.Text;

namespace OOtask
{
    class FootBallTeam
    {
        public string _teamName;
        public string _coach;
        public int _tablePlace;

        public void Show()
        {
            Console.WriteLine($"laget er {_teamName},trener er {_coach}, de er på plass nr{_tablePlace}");
            
        }

        public FootBallTeam(string teamName, string coach, int tablePlace)
        {
            _teamName = teamName;
            _coach = coach;
            _tablePlace = tablePlace;

        }
    }
}
