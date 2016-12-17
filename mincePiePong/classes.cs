using System;

namespace MincePiePongClasses{

  // The class for the ball (mince pie)
  class Ball{
    // POSITION IS DON AS A FLOAT ARRAY
    // VELOCITY IS AS INT ARRAY

    public int radius = 16;
    public float[] pos = {0,0};
    public int[] velocity = {0,0};
    //private sprite = (pie image);

    // instantiating the class, with the given parameters
    public Ball(int startX, int startY, int vX, int vY, string colour, int r){
      self.pos = {startX,startY};
      self.velocity = {vX,vY};
    }

    // dTime is the time since the last drawn frame
    public void move(float dTime){
      self.pos[0] += self.velocity[0] * dTime;
      self.pos[1] += self.velocity[1] * dTime;
    }

    // reflections go as follows:
    // {-1,1} is reflection in x
    // {1,-1} is reflection in y
    // nuberes can be changed to change velocity
    public void reflect(int[] reflection){
      self.velocity[0] = self.velocity[0] * reflection[0];
      self.velocity[1] = self.velocity[1] * reflection[1];
    }
  }

  // The class for both of the player or AI controlled paddles
  class Paddle{
    // motion is either 0, 1 or -1, and it determines in which direction the paddle moves
    public int motion = 0;
    // the speed of motion of the paddle in pixels per second
    private int speed;
    public float[] pos = {0,0};
    // dimensions of the rectangle in pixels
    public int[] dim = {19,60};

    public Paddle(int speed,float[] pos){
      self.speed = speed;
      self.pos = pos;
    }

    // dTime is the time since the last drawn frame
    public void move(float dTime){
      pos[1] = pos[1] + dTime*(speed*motion)
    }
  }
}
