
using Domain.Models;
using Infrastructure.Services;

var stdServices = new StudentService();
var uniServices = new UniversityService();
var teacherServices = new TeacherService();


var std1 = new Student()
{
    id = 1,
    FirstName = "Salohuddun",
    LastName = "Ikromov",
    Age = 19,
    Unversity = univer1,
    Email = "salohudun@gmail.com"

};

var std2 = new Student()
{
    id = 2,
    FirstName = "Salohuddun",
    LastName = "Ikromov",
    Age = 19,
    Unversity = univer2,
    Email = "salohudun@gmail.com"

};

var std3 = new Student()
{
    id = 3,
    FirstName = "Salohuddun",
    LastName = "Ikromov",
    Age = 19,
    Unversity = univer1,
    Email = "salohudun@gmail.com"

};

var teacher1 = new Teacher()
{
    FirstName = "Qurbonali",
    LastName = "Nazarov",
    Experience = 2,
    Students = std1
};

var univer1 = new University()
{
    name = "Standford",
    subject = "OOP",
    contract = 15000,
    Teachers = teacher1,
    Students = std1

};
    stdServices.AddStudent(std1);
    stdServices.AddStudent(std2);
    stdServices.AddStudent(std3);



