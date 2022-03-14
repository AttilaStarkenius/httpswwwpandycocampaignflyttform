using httpswwwhemfridse.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace httpswwwhemfridse.Repositories
{
    public class CleaningModelRepository
    {
        List<CleaningModel> customers = new List<CleaningModel>()
        {
            /*11.3.2022. I commit and check out with message: "Creating CleaningModelRepository.cs 11.3.2022."*/

/*11.3.2022. Í change this: new CleaningModel
{
    Id = 1,
    FirstName = "Joydip",
    LastName = "Kanjilal"
},
new CleaningModel
{
    Id = 2,
    FirstName = "Steve",
    LastName = "Smith"
}
};
public Author GetAuthor(int id)
{
return authors.FirstOrDefault(a => a.Id == id);
}
public List<Author> GetAuthors(int pageNumber = 1)
{
int pageSize = 10;
int skip = pageSize * (pageNumber - 1);
if (authors.Count < pageSize)
    pageSize = authors.Count;
return authors
  .Skip(skip)
  .Take(pageSize).ToList();
}
public bool Save(Author author)
{
var result = authors.Where(a => a.Id == author.Id);
if (result != null)
{
    if (result.Count() == 0)
    {
        authors.Add(author);
        return true;
    }
}
return false;
}
}
}
to this:*/

new CleaningModel
{
    //facebookProfilePicture = https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-xpf1/v/t34.0-12/10555140_10201501435212873_1318258071_n.jpg?oh=97ebc03895b7acee9aebbde7d6b002bf&oe=53C9ABB0&__gda__=1405685729_110e04e71d9,
/*   11.3.2022. Obviously     facebookProfilePicture = https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-xpf1/v/t34.0-12/10555140_10201501435212873_1318258071_n.jpg?oh=97ebc03895b7acee9aebbde7d6b002bf&oe=53C9ABB0&__gda__=1405685729_110e04e71d9,
won't work becausefacebookProfilePicture is Image variable
so I change it to existing file: */
    facebookProfilePicture = Image.FromFile("C:/Users/symph/source/repos/httpswwwpandycocampaignflyttform/httpswwwhemfridse/facebookProfilePicture.jpg"),
    firstName = "Attila",
    zip = "16869",
    sqm = 44
} };
        /*11.3.2022. I commit and push with message: "Creating CleaningModel object 11.3.2022."*/
        //new CleaningModel
        //{
        //    Id = 2,
        //    FirstName = "Steve",
        //    LastName = "Smith"
        //}
        //};
        public CleaningModel GetCustomer(Image facebookProfilePicture)
        {
            return customers.FirstOrDefault(a => a.facebookProfilePicture == facebookProfilePicture);
        }
        public List<CleaningModel> GetCustomers(int pageNumber = 1)
        {
            int pageSize = 10;
            int skip = pageSize * (pageNumber - 1);
            if (customers.Count < pageSize)
                pageSize = customers.Count;
            return customers
              .Skip(skip)
              .Take(pageSize).ToList();
        }
        public bool Save(CleaningModel customer)
        {
            var result = customers.Where(a => a.facebookProfilePicture == customer.facebookProfilePicture);
            if (result != null)
            {
                if (result.Count() == 0)
                {
                    customers.Add(customer);
                    return true;
                }
            }
            return false;
        }
    }
}
/*12.3.2022. I adjust code from: new CleaningModel
{
    Id = 1,
    FirstName = "Joydip",
    LastName = "Kanjilal"
},
new CleaningModel
{
    Id = 2,
    FirstName = "Steve",
    LastName = "Smith"
}
};
public Author GetAuthor(int id)
{
return authors.FirstOrDefault(a => a.Id == id);
}
public List<Author> GetAuthors(int pageNumber = 1)
{
int pageSize = 10;
int skip = pageSize * (pageNumber - 1);
if (authors.Count < pageSize)
    pageSize = authors.Count;
return authors
  .Skip(skip)
  .Take(pageSize).ToList();
}
public bool Save(Author author)
{
var result = authors.Where(a => a.Id == author.Id);
if (result != null)
{
    if (result.Count() == 0)
    {
        authors.Add(author);
        return true;
    }
}
return false;
}
}
}
to: 
new CleaningModel
{
    //facebookProfilePicture = https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-xpf1/v/t34.0-12/10555140_10201501435212873_1318258071_n.jpg?oh=97ebc03895b7acee9aebbde7d6b002bf&oe=53C9ABB0&__gda__=1405685729_110e04e71d9,
/*   11.3.2022. Obviously     facebookProfilePicture = https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-xpf1/v/t34.0-12/10555140_10201501435212873_1318258071_n.jpg?oh=97ebc03895b7acee9aebbde7d6b002bf&oe=53C9ABB0&__gda__=1405685729_110e04e71d9,
won't work becausefacebookProfilePicture is Image variable
so I change it to existing file: 
facebookProfilePicture = Image.FromFile("C:/Users/symph/source/repos/httpswwwpandycocampaignflyttform/httpswwwhemfridse/facebookProfilePicture.jpg"),
    firstName = "Attila",
    zip = "16869",
    sqm = 44
} };
/*11.3.2022. I commit and push with message: "Creating CleaningModel object 11.3.2022."
//new CleaningModel
//{
//    Id = 2,
//    FirstName = "Steve",
//    LastName = "Smith"
//}
//};
public CleaningModel GetCustomer(Image facebookProfilePicture)
{
    return customers.FirstOrDefault(a => a.facebookProfilePicture == facebookProfilePicture);
}
public List<CleaningModel> GetCustomers(int pageNumber = 1)
{
    int pageSize = 10;
    int skip = pageSize * (pageNumber - 1);
    if (customers.Count < pageSize)
        pageSize = customers.Count;
    return customers
      .Skip(skip)
      .Take(pageSize).ToList();
}
public bool Save(CleaningModel customer)
{
    var result = customers.Where(a => a.facebookProfilePicture == customer.facebookProfilePicture);
    if (result != null)
    {
        if (result.Count() == 0)
        {
            customers.Add(customer);
            return true;
        }
    }
    return false;
}
    }
}

I commit and push with message: "Fixing CleaningModelRepository.cs 12.3.2022."
*/

/*13.3.2022. I continue working with https://attilastarkenius.com/flyttstadning/
by adding paragraph block: "Vi på Hemfrid hjälper dig med flyttstädningen! Fönsterputs ingår och vi tar med all utrustning och städmaterial. Självklart med kvalitetsgaranti. Din köpare kommer att mötas av ett skinande hem och du kan ägna tid åt annat.

Vi på Hemfrid erbjuder alltid fem arbetsdagars garanti på vår flyttstädning."
After that I add a custom form without a mall: Postnummer(måste anges)
kvm(måste anges)
Fyll i fälten för att se pris
I commit and push to git with message: "Fix https://attilastarkenius.com/flyttstadning/ 13.3.2022."*/


/*14.3.2022. I continue working with https://attilastarkenius.com/flyttstadning/ like this:
I add aligned to center and bold fonted "Läs mer" paragraph with line break and under that
"V" letter as a closest equivalent to down arrow that I 
can find in wordpress, and under that two columns with the left one being 70%, right one 30% wide
including header with header style H2 Så fungerar vår Flyttstädning:
Postnummer(måste anges)
kvm(måste anges)
Fyll i fälten för att se pris
Kontakta oss
Läs mer
V

Så fungerar vår Flyttstädning
I commit and push to git 
with message: "Add columns to https://attilastarkenius.com/flyttstadning/ 14.3.2022."*/