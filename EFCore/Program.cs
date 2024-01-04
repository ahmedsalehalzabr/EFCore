// See https://aka.ms/new-console-template for more information
using EFCore;

var _context = new ApplicationDbContext();
var employee = new Eemployeee
{
    Name = "Employee 1"
};
_context.Employees.Add(employee);
_context.SaveChanges();