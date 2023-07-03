using System;


    public abstract class Goals
    {
        private string _goalType;
        private string _goalName;
        private string _goalDescription;
        private int _points;

        public Goals(string type, string name, string description, int points)
        {
            _goalType = type;
            _goalName = name;
            _goalDescription = description;
            _points = points;
        }

        public new string GetType()
        {
            return _goalType;
        }
        public string GetGoalName()
        {
            return _goalName;
        }
        public string GetGoalDescription()
        {
            return _goalDescription;
        }
        public int GetPoints()
        {
            return _points;
        }

        public abstract void ListGoal(int i);
        public abstract string SaveGoal();
        public abstract string LoadGoal();
        public abstract void RecordGoalEvent(List<Goals> goals);
    }
