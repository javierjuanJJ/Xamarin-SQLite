using System;
using SQLite;
using Xamarin_SQLite;

namespace Xamarin_SQLite.Model
{
    public class ContactModel
    {
        private string Name, Lastname, Email, Address;
        private int PhoneNumber, Id;

        public ContactModel(string name = null, string lastname = null, string email = null, string address = null,
            int phoneNumber = default, int id = default)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Lastname = lastname ?? throw new ArgumentNullException(nameof(lastname));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            PhoneNumber = phoneNumber;
            Id = id;
        }

        public ContactModel()
        {
            
        }


        [PrimaryKey, AutoIncrement]
        public int Id1
        {
            get => Id;
            set => Id = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public string Lastname1
        {
            get => Lastname;
            set => Lastname = value;
        }

        public string Email1
        {
            get => Email;
            set => Email = value;
        }

        public string Address1
        {
            get => Address;
            set => Address = value;
        }
        [MaxLength(10)]
        public int PhoneNumber1
        {
            get => PhoneNumber;
            set => PhoneNumber = value;
        }
    }
}