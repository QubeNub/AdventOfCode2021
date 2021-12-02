namespace TestRunner.Helpers;

public class Submarine
{
    private int _horizontalPosition;
    private int _depth;

    public Submarine()
    {
        _horizontalPosition = 0;
        _depth = 0;
    }

    public void ExecuteCommand((string, int) command)
    {
        ExecuteCommand(command.Item1, command.Item2);
    }

    private void ExecuteCommand(string command, int amount)
    {
        switch (command.TrimEnd())
        {
            case "up":
                MoveUp(amount);
                break;
            case "down":
                MoveDown(amount);
                break;
            case "forward":
                MoveForward(amount);
                break;
        }
    }

    public int GetFinalLocation()
    {
        return _depth * _horizontalPosition;
    }

    protected virtual void MoveUp(int amount)
    {
        _depth -= amount;
    }

    protected virtual void MoveDown(int amount)
    {
        _depth += amount;
    }

    protected virtual void MoveForward(int amount)
    {
        _horizontalPosition += amount;
    }
}