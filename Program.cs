using VCard.Models;
using VCard.Helpers;

Contact contact = new Contact
{
    FirstName = "Gulkhanim",
    LastName = "Akberova",
    Addresses = new System.Collections.Generic.List<Address>()
    {
        { new Address(){ Description="This is my Home Address..", Type="Home"} },
        { new Address(){ Description="This is my Work Address", Type="Work"} }
    },
    Phones = new System.Collections.Generic.List<Phone>()
    {
        { new Phone(){ Number="+994556667777", Type="Home"} },
        { new Phone(){ Number="994556667777", Type="Work"} }
    },
    Email = "gulukhanimakberova@examplemail.com",
    Organization = "Merkezibank",
    Photo = "https://www.c-sharpcorner.com/App_Themes/CSharp/Images/SiteLogo.png",
    Title = "Gulu"
};



string vcardcontents = FileHelper.CreateVCard(contact);
string SavePath = System.IO.Path.Combine(AppContext.BaseDirectory, "output.vcf");
System.IO.File.WriteAllText(SavePath, vcardcontents);
Console.WriteLine("File saved at " + SavePath.Trim());
