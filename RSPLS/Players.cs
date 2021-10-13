using RSPBase;

namespace RSPLS
{
    public sealed class PlayerRock : PlayerDefault<Action>
    {
        public PlayerRock(string name) : base(name) { }

        public override bool CompareTo(object obj) =>
            obj is PlayerDefault<Action> player &&
            GetAction() == player.GetAction();

        public override Action GetAction() => Action.Rock;
        public override string ToString() => "Rock";
    }

    public sealed class PlayerScissors : PlayerDefault<Action>
    {
        public PlayerScissors(string name) : base(name) { }

        public override bool CompareTo(object obj) =>
            obj is PlayerDefault<Action> player &&
            GetAction() == player.GetAction();

        public override Action GetAction() => Action.Scissors;
        public override string ToString() => "Scissors";
    }

    public sealed class PlayerPaper : PlayerDefault<Action>
    {
        public PlayerPaper(string name) : base(name) { }

        public override bool CompareTo(object obj) =>
            obj is PlayerDefault<Action> player &&
            GetAction() == player.GetAction();

        public override Action GetAction() => Action.Paper;
        public override string ToString() => "Paper";
    }

    public sealed class PlayerLizard : PlayerDefault<Action>
    {
        public PlayerLizard(string name) : base(name) { }

        public override bool CompareTo(object obj) =>
            obj is PlayerDefault<Action> player &&
            GetAction() == player.GetAction();

        public override Action GetAction() => Action.Paper;
        public override string ToString() => "Lizard";
    }

    public sealed class PlayerSpock : PlayerDefault<Action>
    {
        public PlayerSpock(string name) : base(name) { }

        public override bool CompareTo(object obj) =>
            obj is PlayerDefault<Action> player &&
            GetAction() == player.GetAction();

        public override Action GetAction() => Action.Paper;
        public override string ToString() => "Spock";
    }
}
