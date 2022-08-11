using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace UserFormInWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            UserClass userClass= new UserClass();
            userClass.Name = txtusername.Text;
            userClass.Password = txtpassword.Text;
            userClass.Address = txtAddress.Text;
            userClass.Country = txtcountry.Text;
            if(telCheckBox.IsChecked==true)
            {
                userClass.PhoneNo = txttel.Text;
            }
            else
            {
                userClass.PhoneNo = txtmob.Text;
            }
            if (maleRadio.IsChecked == true)
            {
                userClass.gender = "Male";
            }
            else
            {
                userClass.gender = "Female";
            }
            if (marrirdRadio.IsChecked==true)
            {
                userClass.MarritalStatus = "married";
            }
            else
            {
                userClass.MarritalStatus = "unmarried";
            }
            userClass.Qualification = txtqua.Text;
            string path = @"C:\\TrainingFiles\\" + userClass.Name + ".txt";
            if (!File.Exists(path))
            {                
                 TextWriter txt = new StreamWriter("C:\\TrainingFiles\\" +userClass.Name + ".txt");
                txt.WriteLine("UserName : "+userClass.Name);
                txt.WriteLine("Password : "+userClass.Password);
                txt.WriteLine("Address : "+userClass.Address);
                txt.WriteLine("Country : "+userClass.Country);
               txt.WriteLine("Phone no  : "+userClass.PhoneNo);
                txt.WriteLine("Gender : "+userClass.gender);
                txt.WriteLine("Marrital status : "+userClass.MarritalStatus);
                txt.WriteLine("Qualification : "+userClass.Qualification);
                List<String> Configurations = new List<string>();
                string[] fileEntries = Directory.GetFiles(path);
                foreach (string fileName in fileEntries)
                {
                    Configurations.Add(fileName);
                   
                }
                 while(Configurations!=null)
                {
                 
                }
                txt.Close();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            txtusername.Clear();
            txtAddress.Clear();
            txtpassword.Clear();
            if(mobCheckBox.IsChecked==true)
            {
                mobCheckBox.IsChecked = false;
            }
            else
            {
                telCheckBox.IsChecked = false;
            }
            if(maleRadio.IsChecked==true)
            {
               maleRadio.IsChecked = false;
            }
            else
            {
                femaleRadio.IsChecked = false;
            }
            if (marrirdRadio.IsChecked == true)
            {
                marrirdRadio.IsChecked = false;
            }
            else
            {
                unmarriedRadio.IsChecked = false;
            }
           
            txtmob.Clear();
            txttel.Clear();
        }
       // private void unmarriedRadio_Checked(object sender, RoutedEventArgs e)
       
    }
}
