namespace PhoneBook;

public class Person
{
    
        private String name;
        private String surName;
        private int number;

        public Person(){}
        public Person(string cesimEfe, string name, string surName)
        {
           this.name = name;    
           this.surName = surName;
           this.number = number;
        }

        public string Name
        {
         get=> name;
         set => name = value;
        }
        public string SurName
        {
            get => SurName;
            set => SurName = value;
        }
        public string Number
        {
            get => Number;
            set => Number = value;
        }
}