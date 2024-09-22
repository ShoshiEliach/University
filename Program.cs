using System;
using verysoft_test;

class Program
{

    static void Main(string[] args)
    {
        // Define the persons data
        List<Person> personList = new List<Person>();

        // Student data: IDs, names, addresses, and ages
        string[] idsStudents = { "214984593", "335876553", "332985613", "039947916", "043234889", "216165548", "222314361", "123456789", "255666987", "111222333", "853624071", "065389421", "269408571", "243560198", "381259670", "069731258", "869045173", "739624805", "165498370", "293508647", "504129678", "058673921", "396405218", "763482590", "692451803", "093856471", "597216038", "209387561", "693158740", "965873421" };
        string[] namesStudent = { "shoshi Eliach", "Rivki Klein", "Ayala Iluz", "Rut Oster", "Yael Hadad", "Laiki Yoffee", "Tamar Zaks", "Michal Hain", "Chaya Krener", "Sary Friedman", "Aldo Macdonald", "Concepcion Combs", "Simon Pearson", "Keith Hanna", "Vicky Eaton", "Jordon Arnold", "Cornelia Gillespie", "Craig Potter", "Shaun Stark", "Nathan Cunningham", "Nicole Bowman", "Ronnie Holden", "Joyce Hays", "Stevie Whitehead", "Donald Chaney", "Carroll Carey", "Carolyn Lowe", "Nathanael Burton", "Misty Underwood", "Fletcher Ho" };
        string[] addressStudent = { "Hanarkisim 32, Rekhasim", "Hilel, Lod", "Dafna 35, Jerusalem", "Harakevet 78, Yafo", "Yael Hadad", "Hankin 14, Haifa", "Tamar Zaks", "Hagiborim 100, Ramat-gan", "hashlosha 22, Bney-Brak", "Hamanoul 45, Netanya", "31 East Jennings St. Warner Robins, GA 31088", "9606 W. Willow Rd. Richardson, TX 75080", "82 Bank Rd. Randallstown, MD 21133", "30 Evergreen St. Brainerd, MN 56401", "309 Thompson Road Banning, CA 92220", "43 Summerhouse Dr. Twin Falls, ID 83301", "91 Roberts Lane Bettendorf, IA 52722", "968 North 8th Ave. Kings Mountain, NC 28086", "8215 W. Saxon St. Carol Stream, IL 60188", "776 South Arcadia Lane Lacey, WA 98503", "971 South Country Club Ave. Richmond Hill, NY 11418", "12 Pineknoll Court Woonsocket, RI 02895", "38 Pineknoll Street Orlando, FL 32806", "9337 Depot Street Algonquin, IL 60102", "806 N. Center Street Rosedale, NY 11422", "883 Walt Whitman St. Enfield, CT 06082", "914 Canal Lane Pickerington, OH 43147", "52 Pacific Lane Buffalo Grove, IL 60089", "19 10th Dr. Southampton, PA 18966", "145 Sleepy Hollow Lane West Fargo, ND 58078", "62 Foster St. Whitestone, NY 11357" };
        int[] agesStudent = { 14, 19, 20, 18, 19, 21, 16, 22, 17, 20, 15, 16, 17, 18, 19, 20, 16, 17, 18, 14, 20, 21, 15, 18, 19, 17, 18, 20, 15, 19 };
        string[] namesProffesor = { "Bernardo Lind", "Rocco Stephens", "Thaddeus Solorion", "Zaire Martell", "Rico Kaplan", "Freddie Driver", "Zain Knox", "Francesco Osullivan", "Pranav Poole", "Mikel Street", "Wyatt Lugo", "Curtis Malley" };
        string[] addressProffesor = { "816 Warren CourtBatavia, OH 45103", "93 West Elm Street Port Charlotte, FL 33952", "63 Windfall Drive Shelbyville, TN 37160", "930 Hillcrest Avenue Kansas City, MO 64151", "8 Canal St. Little Rock, AR 72209", "72 Old York Lane Ocoee, FL 34761", "8375 Elizabeth St. Yuba City, CA 95993", "8177 Buckingham St. Atwater, CA 95301", "153 SW. Birch Hill Dr. Coachella, CA 92236", "936 South Mayflower Street Snohomish, WA 98290", "32 Cedar Dr. Des Plaines, IL 60016", "900 W. Mechanic St. Rolla, MO 65401" };
        
        // Professor data: names, addresses, and departments
        string[] namesProfessor = { "Bernardo Lind", "Rocco Stephens", "Thaddeus Solorion", "Zaire Martell", "Rico Kaplan", "Freddie Driver", "Zain Knox", "Francesco Osullivan", "Pranav Poole", "Mikel Street", "Wyatt Lugo", "Curtis Malley" };
        string[] addressProfessor = { "816 Warren Court Batavia, OH 45103", "93 West Elm Street Port Charlotte, FL 33952", "63 Windfall Drive Shelbyville, TN 37160", "930 Hillcrest Avenue Kansas City, MO 64151", "8 Canal St. Little Rock, AR 72209", "72 Old York Lane Ocoee, FL 34761", "8375 Elizabeth St. Yuba City, CA 95993", "8177 Buckingham St. Atwater, CA 95301", "153 SW. Birch Hill Dr. Coachella, CA 92236", "936 South Mayflower Street Snohomish, WA 98290", "32 Cedar Dr. Des Plaines, IL 60016", "900 W. Mechanic St. Rolla, MO 65401" };
        string[] departments = { "Lecturer", "Senior Lecturer", "Associate Professor", "Professor" };

        // Create professor objects and add them to the personList
        for (int i = 0; i < namesProfessor.Length; i++)
        {
            Random random = new Random();
            Person p = new Professor(namesProfessor[i], random.Next(50, 71), departments[random.Next(departments.Length)], addressProfessor[i]);
            personList.Add(p);
        }

        // Create student objects and add them to the personList
        for (int i = 0; i < namesStudent.Length; i++)
        {
            Person s = new Student(idsStudents[i], namesStudent[i], agesStudent[i], addressStudent[i]);
            personList.Add(s);
        }

        // Define the list of courses (Graduate and Undergraduate)
        List<Course> courseList = new List<Course>();
        GraduateCourse graduateCourse1 = new GraduateCourse("Artificial Intelligence", "224", "Development of algorithms to improve accuracy in disease prediction based on patient data");
        GraduateCourse graduateCourse2 = new GraduateCourse("Data Science", "145", "Big data analysis for the impact of labor market trends");
        GraduateCourse graduateCourse3 = new GraduateCourse("Psychology", "168", "The effect of cognitive-behavioral therapy on depressive disorders");
        UndergraduateCourse undergraduateCourse1 = new UndergraduateCourse("Data Structures and Algorithms", "214");
        UndergraduateCourse undergraduateCourse2 = new UndergraduateCourse("Cognitive Psychology", "114");
        UndergraduateCourse undergraduateCourse3 = new UndergraduateCourse("Human Physiology", "314");

        // Add courses to the courseList
        courseList.Add(graduateCourse1);
        courseList.Add(graduateCourse2);
        courseList.Add(graduateCourse3);
        courseList.Add(undergraduateCourse1);
        courseList.Add(undergraduateCourse2);
        courseList.Add(undergraduateCourse3);

        // Add participants (students and professors) to courses
        List<Person> tempersonList = new List<Person>(personList);
        while (tempersonList.Count > 0)
        {
            foreach (var c in courseList)
            {
                c.addParticipant(tempersonList.First());
                tempersonList.RemoveAt(0);

            }
        }

        // Display the courses and participants
        foreach (var c in courseList)
        {
            Console.WriteLine("The course:");
            c.print();
            Console.WriteLine("The participants:");

            foreach (var p in c.getParticipants())
            {
                p.print();
                
            }
            Console.WriteLine(" ");
        }


    }


}


