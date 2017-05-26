using Nancy;
using Organizer.Objects;
using System.Collections.Generic;

  namespace Contact
  {
    public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml"];
      };

      }
    }
  }
