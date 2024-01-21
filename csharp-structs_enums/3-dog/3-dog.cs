// Override the '.ToString()' method to print the Dog object’s attributes to stdout.
using System;

enum Rating
{
    Good,
    Great,
    Excellent
}
struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    public override string ToString()
    {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
}
