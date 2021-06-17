using MyRealmSample.Model;
using Realms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyRealmSample
{
    public partial class MainPage : ContentPage
    {
        Realm realmDB;
        public MainPage()
        {
            InitializeComponent();
            realmDB = Realm.GetInstance();
            List<Student> students = realmDB.All<Student>().ToList();
            studentList.ItemsSource = students;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var oldStudents = realmDB.All<Student>();
            var maxStudentId = oldStudents.Count()>0 ? oldStudents.Last().StudentId:0;

            Student student = new Student() { StudentId = maxStudentId + 1, Name = studentName.Text, Surname = studentSurname.Text };

            realmDB.Write(() =>
                {
                    realmDB.Add(student);
                }
            );
            studentName.Text = string.Empty;
            studentSurname.Text = string.Empty;
            List<Student> updatedStudents = realmDB.All<Student>().ToList();
            studentList.ItemsSource = updatedStudents;
        }
    }
}
