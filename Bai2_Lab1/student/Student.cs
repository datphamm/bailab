using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Lab1
{
    internal class Student
    {
        private int ID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public Student() //Constructor mac dinh (default constructor)
        {
            ID = 1;
            TenSV = "Pham Xuan Dat";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student(Student stu) //Copy constructor
        {
            SID = stu.ID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        //Constructor with parameters
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        //Properties for each attribute of the class
        public int StudentID
        {
            get { return ID; } //Get data
            set { SID = value; } //Set data
        }

        public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }

        public String Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }

        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }

        public void Show()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Họ và tên: " + Name);
            Console.WriteLine("Khoa: " + Faculty);
            Console.WriteLine("Điểm trung bình: " + Mark);
        }

    }