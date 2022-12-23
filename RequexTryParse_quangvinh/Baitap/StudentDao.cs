using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap;

internal class StudentDao
{
    List<Student> stu = new();

    // tự động tăng id
    private int GenerateID()
    {
        int max = 1;
        if (stu != null && stu.Count > 0)
        {
            max = stu[0].Id;
            foreach (Student sv in stu)
            {
                if (max < sv.Id)
                {
                    max = sv.Id;
                }
            }
            max++;
        }
        return max;
    }

    //Nhập thoong tin sinh viên
    public void AddStudent(bool value)
    {
        Student  stud = new Student();
        stud.Id = GenerateID();

        Console.Write("Enter your fullname: ");
        stud.FullName = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter your gender: ");
        stud.Gender = Convert.ToString(Console.ReadLine());
        stu.Add(stud);

    }

    public bool DeleteById(int Id)
    {
        bool IsDeleted = false;
        // tìm kiếm sinh viên theo ID
        Student stud = FindByID(Id);
        if (stud != null)
        {
            IsDeleted = stu.Remove(stud);
        }
        return IsDeleted;
    }

    public List<Student> FindByName(String keyword)
    {
        List<Student> searchResult = new List<Student>();
        if (stu != null && stu.Count > 0)
        {
            foreach (Student stud in stu)
            {
                if (stud.FullName.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(stud);
                }
            }
        }
        return searchResult;
    }
    //tim kiem thong tin sv theo id
    public Student FindByID(int ID)
    {
        Student searchResult = null;
        if (stu != null && stu.Count > 0)
        {
            foreach (Student stud in stu)
            {
                if (stud.Id == ID)
                {
                    searchResult = stud;
                }
            }
        }
        return searchResult;
    }
    public void UpdateSinhVien(int ID)
    {
        
        Student stud = FindByID(ID);
        // Nếu sinh viên tồn tại thì cập nhập thông tin sinh viên
        if (stud != null)
        {
            Console.Write("Enter fullname: ");
            string name = Convert.ToString(Console.ReadLine());
            if (name != null && name.Length > 0)
            {
                stud.FullName = name;
            }

            Console.Write("Enter gender: ");
            string gender = Convert.ToString(Console.ReadLine());
            if (gender != null && gender.Length > 0)
            {
                stud.Gender = gender;
            }
        }
        else
        {
            Console.WriteLine("Student have Id = {0} don't exist.", ID);
        }
    }

}
