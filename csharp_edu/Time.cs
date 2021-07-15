namespace csharp_edu
{
    public struct Time
    {
        //cannot create default constructor. it always exists
        //fields are set with default values on calling default constructor
        //value (non ref, non object) type. based in stack
        //all fields should be initialized in parametrized constructor
        //cannot init fields on declaration
        //struct var can be declared without constructor but should init all fields after
        //cannot be abstract or inherit
        //its fields cannot be volatile
        //cannot declare same type fields inside struct

        private int _hours, _minutes, _seconds;

        public Time(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }
    }
}