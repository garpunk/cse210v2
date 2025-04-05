// function that get's the lefthand coordinates of an object

//this will go in the GameObject class

using System.Runtime.CompilerServices;

public virtual GetLeftEdge()
{

 return _x;
}

public virtual GetRightEdge()
{
 return  _x + _width;
}

public virtual GetBottomEdge()
{
 return _y;
}

public virtual GetTopEdge()
{
  return _y + height;
}




if (GetLeftEdge() < 0)
{
    _x = 0;
}

if (GetRightEdge() > GameManager.SCREEN_WIDTH)
{
    _x = SCREEN_WIDTH - _width;
}

//constructor or method in Raylib?

//Raylib doesn't keep track of objects, it jusst draws them

private bool isCollision(GameObject first, GameObject second)
isTrue = false;

{
    if (first.GetLeftEdge() >= second.GetLeftEdge() && first.GetRightEdge() <= first.GetLeftEdge() 
    
    && first.GetBottomEdge() >= second.GetTopEdge()
    && first.GetTopEdge <= second.GetBottomEdge()
    )

    isHit = true;



}