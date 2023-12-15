using mvvmDBpractice.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using mvvmDBpractice.Models;
using System.Linq;

namespace mvvmDBpractice.Services
{
    public class FormService
    {
        private readonly AppDbContext _context;

        public FormService() => _context = App.GetContext();


        public bool Create(Form item)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Form> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Form> Get()
        {
            return _context.People.ToList();
        }


        public List<Form> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return _context.People.ToList();


            return _context.People.Where(x => x.FirstName.Contains(text) || x.LastName.Contains(text)).ToList();
        }
    }
}
