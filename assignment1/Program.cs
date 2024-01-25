namespace assignemnt1;

class Person {
    public int personid {get;set;}
    public string firstName {get;set;}
    public string LastName {get;set;}
    public string favColor {get;set;}
    public int age {get;set;}
    public bool isWorking {get;set;}
    public List<Person> listOfPeople = new List<Person>();

    public Person(int id, string firstname, string lastname, string favouritecolor, int Age, bool working){
        this.personid = id;
        this.firstName = firstname;
        this.LastName = lastname;
        this.favColor = favouritecolor;
        this.age = Age;
        this.isWorking = working;
    }
    public string DisplayPersonInfo(int id, string firstname, string lastname, string favouritecolor, int age, bool working) {
        string name = $"{firstname} {lastname}";
        return $"{personid}: {name} favorite color is {favouritecolor}";
    }

    public string ChangeFavouriteColor() {
        favColor = "white";
        return favColor;
    }

    public int GetAgeInTenYears() {
        int ageInTen = age + 10;
        return ageInTen;
    }

    public override string ToString()
    {
        
        return $"PersonID: {personid}\n"+ $"FirstName: {firstName} \n" +
        $"LastName: {LastName}\n" + $"FavouriteColor: {favColor} \n" +
        $"Age: {age}\n" + $"IsWorking: {isWorking}\n";
    }


}

class Relation {

    public string relationship { get; set; }
    public Relation (string relations)
    {
        relationship = relations;
    }

    public string ShowRelationship(Person p1, Person p2) {
        

        return $"Relationship between {p1.firstName} and {p2.firstName} is: {relationship}\n";
    }
}

class Main1 {

    static void Main(string[] args) {


        Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
        Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
        Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

        
        Console.WriteLine(person2.DisplayPersonInfo(2, "Gina", "James", "Green", 18, false));
        Console.WriteLine(person3.ToString());
        Console.WriteLine("1: Ian Brooks favorite color is: " + person1.ChangeFavouriteColor());
        Console.WriteLine("Mary Beals's Age in 10 is: " + person4.GetAgeInTenYears());

        Relation relationship = new Relation("Sisterhood");
        Console.WriteLine(relationship.ShowRelationship(person2,person4));
        Relation relationship2 = new Relation("Brotherhood");
        Console.WriteLine(relationship2.ShowRelationship(person1,person3));

        person1.listOfPeople.Add(new Person(4, "Mary", "Beals", "Yellow", 28, true));
        person1.listOfPeople.Add(new Person(1, "Ian", "Brooks", "Red", 30, true));
        person1.listOfPeople.Add(new Person(3, "Mike", "Briscoe", "Blue", 45, true));
        person1.listOfPeople.Add(new Person(2, "Gina", "James", "Green", 18, false));
        double avg = 0.0;
        double count = 0.0;
        
        int youngestPerson = 0;
        int oldestPerson = 0;

        string letterM = "";
        string letterB = "";

        

        foreach (Person a in person1.listOfPeople) {
            avg += a.age;
            count++;
        }
        double averageAge = avg / count;

        Console.WriteLine($"Average age is: {averageAge}");

        foreach (Person a in person1.listOfPeople) {
            if (oldestPerson < a.age) {
                oldestPerson = a.age;
            } else if (oldestPerson > a.age) {
                youngestPerson = a.age;
            }
        }
        Console.WriteLine($"Oldest person is: {oldestPerson}");
        Console.WriteLine($"youngest person is: {youngestPerson}");

        foreach (Person a in person1.listOfPeople) {
            letterM = a.firstName;
            string firstLettter = letterM.Substring(0,1);
            if (firstLettter == "M") {
                Console.WriteLine(a.ToString());
            }
        }

        foreach (Person a in person1.listOfPeople) {
            letterB = a.favColor;
            string firstLettter = letterB.Substring(0,1);
            if (firstLettter == "B") {
                Console.WriteLine(a.ToString());
            }
        }   
    }

}

    
