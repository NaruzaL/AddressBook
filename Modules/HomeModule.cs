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
          return View["index.cshtml", allContacts];
        };

        Get["/contact/add"] = _ =>  View["contact_form.cshtml"];

        Post["/contact/new"] = _ => {
          Contact newContact = new Contact(Request.Form["name"], Request.Form["phone"], Request.Form["address"], Request.Form["photo"]);
          List<Contact> addedContact = Contact.GetAll();
          return View["contact_new.cshtml", newContact];
        };

        Get["/contact/{id}"] = parameters => {
          Contact selectedContact = Contact.Find(parameters.id);
          return View["contact_new.cshtml", selectedContact];
        };

        Post["/contact/clear"] = _ => {
          Contact.ClearAll();
          return View["contacts_cleared.cshtml"];
        };

        Post["/contact/{id}/deleted"] = parameters => {
          Contact selectedContact = Contact.Find(parameters.id);
          selectedContact.Remove();
          List<Contact> allContacts = Contact.GetAll();
          return View["contact_deleted.cshtml"];
        };

      }
    }
  }
