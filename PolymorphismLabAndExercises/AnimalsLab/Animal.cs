using System;
using System.Collections.Generic;
using System.Text;

public class Animal
{
    private string name;
    private string favouriteFood;

    protected Animal(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favoriteFood;
    }
    public string FavouriteFood
    {
        get { return favouriteFood; }
        protected set { favouriteFood = value; }
    }

    public string Name
    {
        get { return name; }
        protected set { name = value; }
    }
    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my favorite food is {this.FavouriteFood}";
    }
}