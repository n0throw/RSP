using System;
using System.Linq;

namespace RSPBase;

public static class Game<T>
{
    public static PlayerDefault<T> Fight(PlayerDefault<T> player1, PlayerDefault<T> player2)
    {
        if (player1 is null)
            throw new ArgumentNullException(nameof(player1));
        if (player2 is null)
            throw new ArgumentNullException(nameof(player2));

        if (player1.CompareTo(player2.GetAction()))
            return null;

        if (player1.GetAction() % Max() == player2.GetAction())
            return player1;
        else
            return player2;
    }

    private static int Max() => Enum.GetValues(typeof(T)).Cast<int>().Max();
}
