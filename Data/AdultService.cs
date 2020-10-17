using System.Collections.Generic;
using FileData;
using DNP_Assignment_1.Models;
using Models;

namespace DNP_Assignment_1.Data
{
    public class AdultService : IAdultService
    {
        private FileContext _fileContext = new FileContext();
        
        
        public IList<Adult> getAdults()
        {
            return _fileContext.Adults;
        }

        public IList<User> getUsers()
        {
            return _fileContext.Users;
        }

        public void addAdult(Adult adult)
        {
            int id = addId();
            adult.Id = id;
            _fileContext.Adults.Insert(id,adult);
            _fileContext.SaveChanges();
        }

        public void removeAdult(Adult adult)
        {
            _fileContext.Adults.Remove(adult);
            _fileContext.SaveChanges();
        }
        

        public int addId()
        {
            int j = 0;
            for (int i = 0; i < _fileContext.Adults.Count; i++)
            {
                if (_fileContext.Adults[i].Id != i)
                {
                    return i;
                }
            }

            return _fileContext.Adults.Count;
        }

        public void updateFirstName(Adult adult, string firstName)
        {
            adult.FirstName = firstName;
            _fileContext.SaveChanges();
        }

        public void updateLastName(Adult adult, string lastName)
        {
            adult.LastName = lastName;
            _fileContext.SaveChanges();        
        }

        public void updateHairColor(Adult adult, string hairColor)
        {
            adult.HairColor = hairColor;
            _fileContext.SaveChanges();
            
        }

        public void updateEyeColor(Adult adult, string eyeColor)
        {
            adult.EyeColor = eyeColor;
            _fileContext.SaveChanges(); 
        }

        public void updateAge(Adult adult, int age)
        {
            adult.Age = age;
            _fileContext.SaveChanges();
        }

        public void updateWeight(Adult adult, float weight)
        {
            adult.Weight = weight;
            _fileContext.SaveChanges();        
        }

        public void updateHeight(Adult adult, int Height)
        {
            adult.Height = Height;
            _fileContext.SaveChanges();            
        }

        public void updateSex(Adult adult, string sex)
        {
            adult.Sex = sex;
            _fileContext.SaveChanges();            
        }
        
        public void updateAdult(Adult adult, string firstName, string lastName, string hairColor, string eyeColor, int age,
            float weight, int Height, string sex)
        {
            adult.FirstName = firstName;
            adult.LastName = lastName;
            adult.HairColor = hairColor;
            adult.EyeColor = eyeColor;
            adult.Age = age;
            adult.Weight = weight;
            adult.Height = Height;
            adult.Sex = sex;
            _fileContext.SaveChanges();            

        }
    }
}