using RSPBase;

namespace RSP;

public sealed class PlayerRock : PlayerDefault<Action>
{
    public PlayerRock(string name) : base(name) { }

    public override bool CompareTo(object obj) =>
        obj is PlayerDefault<Action> player &&
        GetAction() == player.GetAction();

    public override int GetAction() => (int)Action.Rock;
    public override string ToString() => "Rock";
}

public sealed class PlayerScissors : PlayerDefault<Action>
{
    public PlayerScissors(string name) : base(name) { }

    public override bool CompareTo(object obj) =>
        obj is PlayerDefault<Action> player &&
        GetAction() == player.GetAction();

    public override int GetAction() => (int)Action.Scissors;
    public override string ToString() => "Scissors";
}

public sealed class PlayerPaper : PlayerDefault<Action>
{
    public PlayerPaper(string name) : base(name) { }

    public override bool CompareTo(object obj) =>
        obj is PlayerDefault<Action> player &&
        GetAction() == player.GetAction();

    public override int GetAction() => (int)Action.Paper;
    public override string ToString() => "Paper";
}
