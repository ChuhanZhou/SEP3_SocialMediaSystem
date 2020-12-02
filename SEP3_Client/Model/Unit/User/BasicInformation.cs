using System;

namespace SEP3_Client.Model.Unit.User
{
    public abstract class BasicInformation : User
    {
        public string UserName { get; set; }
        public Birthday Birthday { get; set; }
        public char Gender { get; set; }
        public string Hometown { get; set; }
        public long PhoneNumber { get; set; }

        public BasicInformation(string id,string userName) : base(id)
        {
            UserName = userName;
            Birthday = new Birthday();
            Gender = ' ';
            Hometown = "";
            PhoneNumber = 0;
        }

        public BasicInformation(string id,string userName, Birthday birthday, char gender, string homeTown, long phoneNumber) :
            base(id)
        {
            UserName = userName;
            Birthday = birthday;
            Gender = gender;
            Hometown = homeTown;
            PhoneNumber = phoneNumber;
        }

        public BasicInformation()
        {
            
        }
        
        public string GetUserName() 
        {
            return UserName;
        }

        public void SetUserName(string userName) 
        {
            UserName = userName;
        }

        public Birthday GetBirthday() 
        {
            return Birthday;
        }

        public void SetBirthday(Birthday birthday) 
        {
            Birthday = birthday;
        }
        
        public char GetGender() 
        {
            return Gender;
        }

        public void SetGender(char gender) 
        {
            Gender = gender;
        }
        
        public string GetHomeTown() 
        {
            return Hometown;
        }

        public void SetHomeTown(string homeTown) 
        {
            Hometown = homeTown;
        }

        public long GetPhoneNumber() 
        {
            return PhoneNumber;
        }

        public void SetPhoneNumber(long phoneNumber) 
        {
            PhoneNumber = phoneNumber;
        }

        public void Update(string userName,Birthday birthday,char gender,string homeTown,long phoneNumber) 
        {
            UserName = userName;
            Birthday = birthday;
            Gender = gender;
            Hometown = homeTown;
            PhoneNumber = phoneNumber;
        }
        
        public void Update(BasicInformation basicInformation) {
            UserName = basicInformation.UserName;
            Birthday = basicInformation.Birthday;
            Gender = basicInformation.Gender;
            Hometown = basicInformation.Hometown;
            PhoneNumber = basicInformation.PhoneNumber;
        }
    }
}