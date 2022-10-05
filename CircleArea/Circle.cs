namespace CircleArea
{
    public class Circle
    {    //fields
        public float _pi = 3.141f; // assigning variable since it's the same value in both objects
        public int _radius;  // this variable gets assigned when it's used in a new object 

        //constructor
        public Circle(int radius)
        {
            _radius = radius;  // variable radius only exist in the constructor, it's local. 
        }

        //method
        public float GetArea() 
        {                         
            float area = _radius * _radius * _pi;
            return area;
        }
    }   
} 





