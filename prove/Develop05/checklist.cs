public class Checklist : Goal{
    public int ammount;
    public Checklist(string goalName, string goalDescription, int pointWorth, int ammount, bool isChecked) {
        _pointWorth = pointWorth;
        _goalDescription = goalDescription;
        _goalName = goalName;
        this.ammount = ammount;
        this.isChecked = isChecked;
    }

    public override void listGoal()
    {
        if (isChecked) {
            Console.WriteLine($"[X]{_goalName} ({_goalDescription})");
        }
        else {
            Console.WriteLine($"[ ]{_goalName} ({_goalDescription})");
        }
    }

    public override int checkGoal()
    {
        isChecked = true;
        return _pointWorth;
    }
        public override void displayGoals()
    {
         Console.WriteLine("$[ ] {_goalName}{_goalType}:,{_goalDescription},{_pointWorth},{goal.isChecked}.");
    }

}
