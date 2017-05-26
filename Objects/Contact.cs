using System.Collections.Generic;

namespace Contact.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;
    private string _photo;
    private int _id;
    private static List<Contact> _instances = new List<Contact>();

    public Contact (string name, string phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
      _photo = photo;
      _instances.Add(this);
      _id = instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string phone)
    {
      _phone = phone;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string address)
    {
      _address = address;
    }
    public string Getphoto()
    {
      return _photo;
    }
    public void SetPhoto(string photo)
    {
      _photo = photo;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void ClearAll()
   {
     _instances.Clear();
  }
}
