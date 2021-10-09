using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Game
{

    public class Game
    {
        public static GameResult Play(Throw p1Throw, Throw p2Throw)
        {
            if (p1Throw == p2Throw)
            {
                return GameResult.DRAW;
            }

            if (p1Throw == Throw.ROCK)
            {
                return p2Throw == Throw.SCISSORS ? GameResult.P1_WINS : GameResult.P2_WINS;
            }
            else if(p1Throw == Throw.SCISSORS)
            {
                return p2Throw == Throw.PAPER ? GameResult.P1_WINS : GameResult.P2_WINS;
            }
            else if (p1Throw == Throw.PAPER)
            {
                return p2Throw == Throw.ROCK ? GameResult.P1_WINS : GameResult.P2_WINS;
            }

            return GameResult.DRAW;
        }
    }

    public enum GameResult
    {
        P1_WINS,
        P2_WINS,
        DRAW
    }

    public enum Throw
    {
        ROCK,
        SCISSORS,
        PAPER
    }
}
