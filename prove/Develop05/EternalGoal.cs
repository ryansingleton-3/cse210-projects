using System;

class EternalGoal : Goal
{
    // attributes ----------------------------
   


    // constructors ---------------------------
    public EternalGoal()
    {
        _isCompleted = false;
    }

    // methods ---------------------------------
    public override int calculatePoints()
    {
        return _goalPoints;
    }

    public override void setCompleted(bool isCompleted)
    {
        _isCompleted = false;
    }

}