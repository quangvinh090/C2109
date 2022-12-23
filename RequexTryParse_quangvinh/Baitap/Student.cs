using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap;

internal class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }

    public string Gender { get; set; } 

    public DateOnly DateofBirth { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(FullName)}={FullName}, {nameof(Gender)}={Gender.ToString()}, {nameof(DateofBirth)}={DateofBirth.ToString()}}}";
    }
}
