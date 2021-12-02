namespace TestRunner.Helpers;

public class SubmarineWithAim : Submarine
{
    private int _aim;

    public SubmarineWithAim() : base()
    {
        _aim = 0;
    }

    protected override void MoveUp(int amount)
    {
        _aim -= amount;
    }

    protected override void MoveDown(int amount)
    {
        _aim += amount;
    }

    protected override void MoveForward(int amount)
    {
        base.MoveDown(amount * _aim);
        base.MoveForward(amount);
    }
}