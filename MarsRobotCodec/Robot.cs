class Robot
{
    private int x;
    private int y;
    private Direction facing;
    private int gridX;
    private int gridY;

    public Robot(int gridX, int gridY)
        {
            this.x = 1;
            this.y = 1;
            this.facing = Direction.North;
            this.gridX = gridX;
            this.gridY = gridY;
        }

    public void Move(char command)
    {
        if (command.Equals('L'))
        {
            TurnLeft();
        }
        else if (command.Equals('R'))
        {
            TurnRight();
        }
        else if (command.Equals('F'))
        {
            GoForward();
        }
    }

    private void TurnLeft()
    {
        if (facing == Direction.North)
            facing = Direction.West;
        else
            facing = facing - 1;
    }

    private void TurnRight()
    {
        if (facing == Direction.West)
            facing = Direction.North;
        else
            facing = facing + 1;
    }

    private void GoForward()
    {
        switch (facing)
        {
            case Direction.North:
                if (y < gridY)
                    y++;
                break;
            case Direction.East:
                if (x < gridX)
                    x++;
                break;
            case Direction.South:
                if (y > 1)
                    y--;
                break;
            case Direction.West:
                if (x > 1)
                    x--;
                break;
        }
    }

    public override string ToString()
    {
        return x + "," + y + "," + facing;
    }
}
