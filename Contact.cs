
namespace TryCatch
{
    public class Contact
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Address;

        public string FullName
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }
    }
}