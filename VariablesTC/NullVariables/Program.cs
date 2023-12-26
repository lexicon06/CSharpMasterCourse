

//null is a lack of variable

int? userAge = null;
string? userFirstName = "Pablo";
string? userLastName = null;
string defaultUser = "User";

if (userAge != null && userFirstName != null && userLastName != null)
{
    Console.WriteLine($"Welcome {userFirstName} {userLastName}, happy {userAge}th birthday!");
}
else
{
    Console.WriteLine($"Welcome {(userFirstName ?? defaultUser)}");

}
