using httpswwwhemfridse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace httpswwwhemfridse.Repositories
{
    public class CleaningModelRepository
    {
        List<CleaningModel> authors = new List<CleaningModel>()
        {
            /*11.3.2022. I commit and check out with message: "Creating CleaningModelRepository.cs 11.3.2022."
            new CleaningModel
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
