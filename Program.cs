



using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1=new FulltimeEmployee()
{
    ID=2;
    IdCard=456
    Name="Name 2"
    Birthday=new DateTime(1920,34,35),
}

 ID=3;
IdCard = 123
    Name = "Name 3"
    Birthday = new DateTime(1920, 34, 35),
}

     ID = 4;
IdCard = 789
    Name = "Name 4"
    Birthday = new DateTime(1920, 34, 35),
}
    employees.Add(pe1);

ID = 5;
IdCard = 512
    Name = "Name 2"
    Birthday = new DateTime(1920, 34, 35),
WorkingHour=3
};
    employees.Add(pe2);
Console.OutputEncoding=Encodin
2)
    Console.WriteLine("xuat toan bo nhan su");
//c1:

employees.ForEach(e=>Console.WriteLine(e));

// cau 3 R Loc ra cac nhan su chinh thuc
// cachs 1:

List<FulltimeEmployee> fe_list=employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("cau 3: R--> Loc ra cac nhan su chinh thuc:");
foreach(FulltimeEmployee fulltimeEmployee in fe_list)
    Console.WriteLine(fe);


//Cau 4: tong luong nhan cgunh thuc

    double fe_sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("cau 4: tong luong chinh thuc:");
Console.WriteLine(fe_sum_salary);

// cau5 tong luong nv thoi vu

double pe_sum_salary = employees.OfType(ParttimeEmployee > ().Sum(employees => e.calSalary());
Console.WriteLine("cau 5: tong luong thoi vu:");
Console.WriteLine(pe_sum_salary);
