using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassSafe
{
    public class Subject
    {
        

        public string Login { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public string Notes { get; set; }

        public Subject(string Login, string Password, string URL, string Notes)
        {
            this.Login = Login;
            this.Password = Password;
            this.URL = URL;
            this.Notes = Notes;
        }

        public void Encrypt()
        {
            this.Login = "#Encrypted";
            this.Password = "#Encrypted";
            this.URL = "#Encrypted";
            this.Notes = "#Encrypted";
        }
        public void Decrypt()
        {
            this.Login = "#Decrypted";
            this.Password = "#Decrypted";
            this.URL = "#Decrypted";
            this.Notes = "#Decrypted";
        }
    }
}
