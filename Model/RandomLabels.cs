using System;

namespace Labels.Model
{
    public class RandomLabels
    {
        readonly string[] _allNames =
        {
            "Keshava", "Narayana", "Madhava", "Govinda", "Vishnu", "Madhusoodana", "Trivikrama", "Vaamana",
            "Sreedhara", "Hrusheekesha", "Padmanaabha", "Daamodara", "Narasimha",
            "Shiva", "Shankara", "Rudra", "Mahadeva", "Shambhu", "Vishvanaatha", "Nanjundeshwara",
            "Srikanta", "Maheshvara", "Ganesha", "Vighneshwara", "Ganapa", "Benaka", "Vinaayaka", "Subrahmanya",
            "Sadashiva", "Brahma", "Shanmukha", "Muruga",
            "Lakshmi", "Saraswati", "Paarvati", "Harini", "Hiranmayee", "Prakruti", "Vidyaa", "Durga", "Bharati",
            "Kali", "Maayaa", "Yogamaayaa", "Shakti", "Hemamaalini", "Shubhaa", "Rajeshwari",
            "Govindaraja", "Srinivasa", "Vaasudeva", "Sankarshana", "Aniruddha", "Pradyumna",
            "Surabhi", "Sudhaa", "Vibhaa", "Vasudhaa", "Harivallabhaa", "Haripriya", "Sripriya", 
            "Ramaa", "Padmapriyaa", "Indiraa", "Padmagandhinee", "Varalakshmi", "Vasupradaa", "Jayaa",
            "Aparnaa", "Bhavaani", "Bhavataarini", "Chaamundi", "Kaatyaayini", "Daakshaayini", "Maheshwari",
            "Shankari", "Shivani", "Umaa", "Vanadurgaa", "Tripurasundari", "Gayatri", "Padmaa", "Medhaa", 
            "Shaaradaa", "Vagdevi", "Vaani", "Srividyaa"
        };

        public RandomLabels()
        {

        }

        public string SelectName()
        {
            Random rand = new();
            int no = rand.Next(0, _allNames.Length);
            return _allNames[no];
        }
    }
}