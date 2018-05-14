namespace Library
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class ExerciseAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class TaskAttribute : Attribute
    {
        public TaskAttribute(int number)
        {
            this.Number = number;
        }

        public int Number { get; }
    }
}