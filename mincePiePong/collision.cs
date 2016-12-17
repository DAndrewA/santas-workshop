// just functions - implement them how you see fit

namespace functions{
  class FunctionsInIt{
    // RECTANGLE AND BALL
    // CHANGES STATE OF BALL
    public void collision(Object rectangle, Object circle){
      if((circle.pos[1] > rectangle.pos[1]) && (circle.pos[1] < rectangle.pos[1] + rectangle.dimensions[1]) && (circle.pos[0] > rectangle.pos[0] - circle.radius) && (circle.pos[0] < rectangle.pos[0] + rectangle.dimensions[0] + circle.radius)){
        circle.reflect({-1,1});
      }
      else if((circle.pos[1] > rectangle.pos[1] - circle.radius) && (circle.pos[1] < rectangle.pos[1] + rectangle.dimensions[1] + circle.radius) && (circle.pos[0] > rectangle.pos[0]) && (circle.pos[0] < rectangle.pos[0] + rectangle.dimensions[0])){
        circle.reflect({1,-1});
      }
    }
  }
}
