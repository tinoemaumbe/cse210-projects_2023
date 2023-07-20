// NAME: ASHTON MUPEREKI
//COURSE: CSE210-C#
//PROJECT NAME: STUDENT MANAGEMENT SYSTEM
using System;
namespace Ashton
{
    public abstract class Person
    {
        protected string _name;
        private string _address;
        private string _email;
        protected int _id;

        public Person(string name, string address, string email, int id)
        {
            _name = name;
            _address = address;
            _email = email;
            _id = id;
        }

        

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public abstract string SaveName();
        public abstract void SaveId();
    }
}