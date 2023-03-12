using System;

class Points
{
    // attributes ----------------------------
    private int _totalPoints = 0;


    // constructors ---------------------------
    public Points()
    {

    }

    // methods ---------------------------------
    public int getPoints()
    {
        return _totalPoints;
    }

    public void setPoints(int points)
    {
        _totalPoints = _totalPoints + points;
    }

}