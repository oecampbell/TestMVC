using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestMVC.Models;

namespace TestMVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}