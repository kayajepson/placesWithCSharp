using System.Collections.Generic;

namespace Travel.Models
{
  public class Places
  {
    public string CityName {get; set;}
    public int Id {get; set;}
    public string Date {get; set;}
    public string Journal {get; set;}
    public string Companion {get; set;}
    private static List<Places> _instances = new List<Places> {};

    public Places (string cityName, string date, string journal, string companion)
    {
      CityName = cityName;
      Date = date;
      Journal = journal;
      Companion = companion;
      _instances.Add(this);
      Id = _instances.Count;
    }


    public int GetId()
    {
      return Id;
    }

    public static List<Places> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Places Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
