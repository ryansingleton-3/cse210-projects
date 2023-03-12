using System;

class ChecklistGoal : Goal
{
    // attributes ----------------------------
   
    

    // constructors ---------------------------
    public ChecklistGoal()
    {
        
    }

    // methods ---------------------------------
    public override int calculatePoints()
    {
        if (_numCompletions == _neededCompletions)
        {
            return _goalPoints + _bonusPoints;
        }
        return _goalPoints;
    }

    
    



    

}