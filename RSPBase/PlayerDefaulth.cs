namespace RSPBase;

public abstract class PlayerDefault<T>
{
    protected int score;
    protected string name;

    public int Score
    {
        get => score;
        protected internal set => score = value;
    }

    public string Name
    {
        get => name;
        protected internal set => name = value;
    }

    public PlayerDefault(string name)
    {
        Name = name;
        Score = 0;
    }

    public abstract bool CompareTo(object obj);
    public abstract int GetAction();

    public override bool Equals(object obj) =>
        obj is PlayerDefault<T> player &&
        score == player.score &&
        name == player.name;

    public override int GetHashCode() => name.GetHashCode() ^ score.GetHashCode();
}
