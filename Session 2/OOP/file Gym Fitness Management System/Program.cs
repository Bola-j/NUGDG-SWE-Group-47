// Group 47
// SOTIR USAMA 221000694 / Bola Ghaly 241000985

using System;
class Prgram{
    static void Main(){
        Gym gym = new Gym();
        RegularMember regularMember1 = new RegularMember(1, "John", 25, 20);
        PremiumMember premiumMember1 = new PremiumMember(2, "Doe", 30, 30, 40);
        gym.AddMember(regularMember1);
        gym.AddMember(premiumMember1);
        gym.DisplayAllMembers();
    }
}

    abstract class Member{
        public readonly int MemberID;
        public string Name { get; set; }
        public int Age { get; set; }
        public Member(int memberID, string name, int age){
            this.MemberID = memberID;  
            this.Name = name;
            this.Age = age;
        }
        public abstract double CalculateMonthlyFee();
        public abstract void DisplayDetails();
}
class RegularMember : Member{
    public double WorkoutPlanFee { get; set; }
    public RegularMember(int memberID, string name, int age, double workoutPlanFee) : base(memberID, name, age){
        this.WorkoutPlanFee = workoutPlanFee;
    }
    public override double CalculateMonthlyFee(){
        return 50 + WorkoutPlanFee;
    }
    public override void DisplayDetails(){
        Console.WriteLine("Normal Member\n______________");
        Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Monthly Fee: {CalculateMonthlyFee()}\n");
    }
}
class PremiumMember  : Member{
    public double PersonalTrainerFee  { get; set; }
    public double DietPlanFee   { get; set; }
    public PremiumMember (int memberID, string name, int age, double PersonalTrainerFee, double DietPlanFee) : base(memberID, name, age){
        this.PersonalTrainerFee = PersonalTrainerFee;
        this.DietPlanFee = DietPlanFee;
    }
    public override double CalculateMonthlyFee(){
        return 100 + DietPlanFee + PersonalTrainerFee;
    }
    public override void DisplayDetails(){
        Console.WriteLine("Premium Member\n______________");
        Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Monthly Fee: {CalculateMonthlyFee()}\n");
    }
}

interface IGymManagement{
    public void AddMember(Member member);
    public void DisplayAllMembers();
}
class Gym : IGymManagement{
    public List<Member> members { get; set; }
    public Gym(){
        members = new List<Member>();
    }
    public void AddMember(Member member){
        members.Add(member);
    }
    public void DisplayAllMembers(){
        foreach(Member member in members){
            member.DisplayDetails();
        }
    }
}