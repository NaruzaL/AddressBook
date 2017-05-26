using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

  namespace AddressBook
  {
    public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get["/"] = _ => {
          List<Contact> allContacts = Contact.GetAll();
          return View["index.cshtml"];
        };
        Get["/contact/add"] = _ =>  View["contact_form.cshtml"];

        Post["/contact/new"] = _ => {
          Contact newContact = new Contact(Request.Form["name"], Request.Form["photo"], Request.Form["phone"], Request.Form["address"]);
          List<Contact> addedContact = Contact.GetAll();
          return View["contact_new.cshtml"];
        };

        Post["/contact/clear"] = _ => {
          Contact.ClearAll();
          return View["contacts_cleared.cshtml"];
        };
      }
    }
  }
