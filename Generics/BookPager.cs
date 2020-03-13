using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
  class BookPager
  {
    public int ItemsPerPage { get; set; }
    public int PageNumber { get; set; }

    public List<Book> AllItems { get; set; }

    public List<Book> GetPage()
    {
      return AllItems
        .Skip(ItemsPerPage * PageNumber)
        .Take(ItemsPerPage)
        .ToList();
    }
  }

}