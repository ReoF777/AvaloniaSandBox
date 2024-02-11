using System.Collections.Generic;

namespace AvaSandBox.Models;

public interface IUser : IBirthData, IFood
{
    public List<IBirthData>? Birth { get; }
    public List<IFood>? Food { get; }
}

public interface IBirthData
{
    public int Year { get; }
    public int Month { get; }
    public int Day { get; }
    public string Place { get; }
}

public interface IFood
{
    public string First { get; }
    public string Second { get; }
    public string Third { get; }
}

public class UserData : IBirthData, IFood
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public UserData(int year, int month, int day, string place, string first, 
        string second, string third)
    {
        Year = year;
        Month = month;
        Day = day;
        Place = place;
        First = first;
        Second = second;
        Third = third;
    }
    
    public int Year { get; }
    public int Month { get; }
    public int Day { get; }
    public string Place { get; }
    public string First { get; }
    public string Second { get; }
    public string Third { get; }
    // public List<IBirthData>? Birth { get; set; }
    // public List<IFood>? Food { get; set; }
}