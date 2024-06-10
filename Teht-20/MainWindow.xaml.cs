using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Teht_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<DataCollect.Student> Studentlist = new List<DataCollect.Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtSaveFile_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter Sw = new StreamWriter("Students.txt"))
            {
                foreach (DataCollect.Student student in Studentlist)
                {
                    Sw.WriteLine($"" +
                        $"{student.FirstName};" +
                        $"{student.LastName};" +
                        $"{student.Id};" +
                        $"{student.Email};" +
                        $"{student.PhoneNumber}");
                }
            }
        }

        private void BtLoadFile_Click(object sender, RoutedEventArgs e)
        {
            Studentlist.Clear();
            string[] lines = File.ReadAllLines("Students.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                DataCollect.Student student = new
                    DataCollect.Student(parts[0],
                    parts[1], int.Parse(parts[2]),
                    parts[3], int.Parse(parts[4]));
                Studentlist.Add(student);
            }
            RefreshList();

        }

        private void RefreshList()
        {
            lbStudentList.Items.Clear();
            foreach (DataCollect.Student student in Studentlist)
            {
                lbStudentList.Items.Add($"{student.FirstName} {student.LastName} ({student.Id})");
            }
        }

        private void BtAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string firstName = TbFirstName.Text;
            string lastName = TbLastName.Text;
            int id = int.Parse(TbId.Text);
            string email = TbEmail.Text;
            int phoneNumber = int.Parse(TbPhoneNumber.Text);


            DataCollect.Student student = new DataCollect.Student(firstName, lastName, id, email, phoneNumber);
            Studentlist.Add(student);
            RefreshList();
            TbFirstName.Text = "";
            TbLastName.Text = "";
            TbId.Text = "";
            TbEmail.Text = "";
            TbPhoneNumber.Text = "";

        }

    }
}
