// See https://aka.ms/new-console-template for more information
Customer customer = new Customer()
{
    Email = "haman.shareghi@gmail.com",
    CustomerName = "Haman Shareghi",
    CustomerAgeGroup = AgeGroup.Group35to45,
    CustomerGender = Gender.Male,
};

Console.WriteLine($"Customer name : {customer.CustomerName} with Email : {customer.Email} in age Group : {customer.CustomerAgeGroup} in Sex : {customer.CustomerGender}");

var ageGroupList = Enum.GetNames(typeof(AgeGroup))
    .Select(a => new
    {
        ageGroupId = (int)Enum.Parse(typeof(AgeGroup), a),
        ageGroupText = a,
    }).ToList();

foreach (var item in ageGroupList)
{
    Console.WriteLine($"{item.ageGroupId} \t| {item.ageGroupText}");
}
Console.ReadLine();


public class Customer
{
    public string CustomerName { get; set; }
    public string Email { get; set; }
    public Gender CustomerGender { get; set; }
    public AgeGroup CustomerAgeGroup { get; set; }
}   
public enum Gender
{
    Male = 5,
    Female = 10,
}

public enum AgeGroup
{
    Group25to35 = 5,
    Group35to45 = 8,
    Group45to55 = 9,
    Group55to65 = 12,

}
