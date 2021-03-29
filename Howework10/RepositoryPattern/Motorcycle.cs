using System;

namespace RepositoryPattern
{
    class Motorcycle
    {
        string _name, _model;
        int _id, _year, _odometer;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        public int Odometer { get { return _odometer; } set { _odometer = value; } }

        public Motorcycle() { }
        public Motorcycle(int id, string name, string model, int year, int odometer)
        {
            _id = id;
            _name = name;
            _model = model;
            _year = year;
            _odometer = odometer;
        }

        internal void DisplayStats()
        {
            Console.WriteLine($"ID: {_id}, Name: {_name}, Year: {_year}, Odometer: {_odometer}");
        }
    }
}
