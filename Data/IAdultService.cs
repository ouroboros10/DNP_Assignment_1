using System.Collections.Generic;
using Models;

namespace DNP_Assignment_1.Data
{
    public interface IAdultService
    {
        IList<Adult> getAdults();
        void addAdult(Adult adult);
        void removeAdult(Adult adult);

        void updateAdult(Adult adult, string firstName, string lastName, string hairColor, string eyeColor, int age,
            float weight, int Height, string sex);
        void updateFirstName(Adult adult, string firstName);
        void updateLastName(Adult adult, string lastName);
        void updateHairColor(Adult adult, string hairColor);
        void updateEyeColor(Adult adult, string eyeColor);
        void updateAge(Adult adult, int age);
        void updateWeight(Adult adult, float weight);
        void updateHeight(Adult adult, int Height);
        void updateSex(Adult adult, string sex);



    }
}