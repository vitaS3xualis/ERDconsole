// See https://aka.ms/new-console-template for more information

using ERDconsole;

List <Course>StudentCourses = new List<Course> ();
var Course1 = new Course(1, "Bachelor of Science in Hotel and Restaurant Management (BSHRM)");
Course1.ClassSchedules = new List<ClassSchedule>()
{
    new ClassSchedule() { id=1, ClassSlot = "D0", IsTaken = false},
    new ClassSchedule() { id=2, ClassSlot = "D1", IsTaken = false},
    new ClassSchedule() { id=3, ClassSlot = "D2", IsTaken = false},
    new ClassSchedule() { id=4, ClassSlot = "D3", IsTaken = false},
    new ClassSchedule() { id=5, ClassSlot = "D4", IsTaken = false},
    new ClassSchedule() { id=6, ClassSlot = "D5", IsTaken = false},
    new ClassSchedule() { id=7, ClassSlot = "D6", IsTaken = false},
    new ClassSchedule() { id=8, ClassSlot = "D7", IsTaken = false},
    new ClassSchedule() { id=9, ClassSlot = "D8", IsTaken = false},
    new ClassSchedule() { id=10,ClassSlot = "D9", IsTaken = false},
    new ClassSchedule() { id=11,ClassSlot = "N0", IsTaken = false},
    new ClassSchedule() { id=12,ClassSlot = "N1", IsTaken = false},
    new ClassSchedule() { id=13,ClassSlot = "N2", IsTaken = false},
    new ClassSchedule() { id=14,ClassSlot = "N3", IsTaken = false},
    new ClassSchedule() { id=15,ClassSlot = "N4", IsTaken = false},
    new ClassSchedule() { id=16,ClassSlot = "N5", IsTaken = false},
    new ClassSchedule() { id=17,ClassSlot = "N6", IsTaken = false},
    new ClassSchedule() { id=18,ClassSlot = "N7", IsTaken = false},
    new ClassSchedule() { id=19,ClassSlot = "N8", IsTaken = false},
    new ClassSchedule() { id=20,ClassSlot = "N9", IsTaken = false},
};

var Course2 = new Course(2, "Bachelor of Science in Infromation Technology (BSIT)");
Course2.ClassSchedules = new List<ClassSchedule>()
{
    new ClassSchedule() { id=1, ClassSlot = "D0", IsTaken = false},
    new ClassSchedule() { id=2, ClassSlot = "D1", IsTaken = false},
    new ClassSchedule() { id=3, ClassSlot = "D2", IsTaken = false},
    new ClassSchedule() { id=4, ClassSlot = "D3", IsTaken = false},
    new ClassSchedule() { id=5, ClassSlot = "D4", IsTaken = false},
    new ClassSchedule() { id=6, ClassSlot = "D5", IsTaken = false},
    new ClassSchedule() { id=7, ClassSlot = "D6", IsTaken = false},
    new ClassSchedule() { id=8, ClassSlot = "D7", IsTaken = false},
    new ClassSchedule() { id=9, ClassSlot = "D8", IsTaken = false},
    new ClassSchedule() { id=10,ClassSlot = "D9", IsTaken = false},
    new ClassSchedule() { id=11,ClassSlot = "N0", IsTaken = false},
    new ClassSchedule() { id=12,ClassSlot = "N1", IsTaken = false},
    new ClassSchedule() { id=13,ClassSlot = "N2", IsTaken = false},
    new ClassSchedule() { id=14,ClassSlot = "N3", IsTaken = false},
    new ClassSchedule() { id=15,ClassSlot = "N4", IsTaken = false},
    new ClassSchedule() { id=16,ClassSlot = "N5", IsTaken = false},
    new ClassSchedule() { id=17,ClassSlot = "N6", IsTaken = false},
    new ClassSchedule() { id=18,ClassSlot = "N7", IsTaken = false},
    new ClassSchedule() { id=19,ClassSlot = "N8", IsTaken = false},
    new ClassSchedule() { id=20,ClassSlot = "N9", IsTaken = false},
};

var Course3 = new Course(3, "Bachelor of Science in Business Administration (BSBA)");
Course3.ClassSchedules = new List<ClassSchedule>()
{
    new ClassSchedule() { id=1, ClassSlot = "D0", IsTaken = false},
    new ClassSchedule() { id=2, ClassSlot = "D1", IsTaken = false},
    new ClassSchedule() { id=3, ClassSlot = "D2", IsTaken = false},
    new ClassSchedule() { id=4, ClassSlot = "D3", IsTaken = false},
    new ClassSchedule() { id=5, ClassSlot = "D4", IsTaken = false},
    new ClassSchedule() { id=6, ClassSlot = "D5", IsTaken = false},
    new ClassSchedule() { id=7, ClassSlot = "D6", IsTaken = false},
    new ClassSchedule() { id=8, ClassSlot = "D7", IsTaken = false},
    new ClassSchedule() { id=9, ClassSlot = "D8", IsTaken = false},
    new ClassSchedule() { id=10,ClassSlot = "D9", IsTaken = false},
    new ClassSchedule() { id=11,ClassSlot = "N0", IsTaken = false},
    new ClassSchedule() { id=12,ClassSlot = "N1", IsTaken = false},
    new ClassSchedule() { id=13,ClassSlot = "N2", IsTaken = false},
    new ClassSchedule() { id=14,ClassSlot = "N3", IsTaken = false},
    new ClassSchedule() { id=15,ClassSlot = "N4", IsTaken = false},
    new ClassSchedule() { id=16,ClassSlot = "N5", IsTaken = false},
    new ClassSchedule() { id=17,ClassSlot = "N6", IsTaken = false},
    new ClassSchedule() { id=18,ClassSlot = "N7", IsTaken = false},
    new ClassSchedule() { id=19,ClassSlot = "N8", IsTaken = false},
    new ClassSchedule() { id=20,ClassSlot = "N9", IsTaken = false},
};


StudentCourses = new List<Course>();
StudentCourses.Add(Course1);
StudentCourses.Add(Course2);
StudentCourses.Add(Course3);

Console.WriteLine("Enrollment System");
Console.WriteLine("\n\nPress Y if you want to ENROLL\n\n");

var inputbegin = Console.ReadLine();


if (inputbegin.ToLower() == "y")

    
{
    Console.WriteLine("\n\nWhich Course would you like to take?\n\n");


    /*  for (int i = 0; i < StudentCourses.Count ; i++)
      {
          Console.WriteLine(StudentCourses[i].name);
      }
    */
    
    foreach (var course in StudentCourses)
    {
        Console.WriteLine($"{course.id}. {course.name}");
    }
    var inputCourse = Console.ReadLine();
    

    var selectedCourse = StudentCourses.FirstOrDefault(Course => Course.id.ToString() == inputCourse);
    
    if (selectedCourse == null)
    {
        Console.WriteLine("\nINVALID INPUT\n");
    }
    else
    {
        selectedClassSchedule(selectedCourse);
        
    }
    


    /*if (inputCourse == "1")
    {
        Console.WriteLine("\n\nBachelor of Science in Hotel and Restaurant Management (BSHRM) Class schedules:\n\n");
        Console.WriteLine("\n\nDay Class from 9am - 3pm");
        Console.WriteLine("Night Class from 4pm - 10pm\n\n");
    }

    else if (inputCourse == "2")
    {
        Console.WriteLine("\n\nBachelor of Science in Infromation Technology (BSIT) Class schedules:\n\n");
        Console.WriteLine("\n\nDay Class from 9am - 3pm");
        Console.WriteLine("Night Class from 4pm - 10pm\n\n");
    }
    else if (inputCourse == "3")
    {
        Console.WriteLine("\n\nBachelor of Science in Business Administration (BSBA) Class schedules:\n\n");
        Console.WriteLine("\n\nDay Class from 9am - 3pm");
        Console.WriteLine("Night Class from 4pm - 10pm\n\n");
    }

    else
    {

    }*/
}
void selectedClassSchedule(Course selectedCourse)

{
    Console.WriteLine($"n/n/{selectedCourse.name} Class Schedule\n\n\nDay Class from 9am - 3pm\nNight Class from 4pm - 10pm\n\n");
    Console.WriteLine("\n\n Here are the lists of slots than and their availability\n\n");

    foreach (var slot in selectedCourse.ClassSchedules)
    {
        Console.WriteLine($" {slot.ClassSlot} - {(slot.IsTaken ? "Unavailable" : "Available")}");
    }
    Console.Write("\n\nPlease select your Slot.\n\n");
    var inputClassSchedules = Console.ReadLine();

    var selectedSlot = selectedCourse.ClassSchedules.FirstOrDefault(slot => slot.ClassSlot == inputClassSchedules);

    if (selectedSlot == null)
    {
        Console.WriteLine("\n INVALID INPUT! Please press any key to return in slot selection menu or pres N to exit.\n");
        var inputInvalidSlot = Console.ReadLine();
        if (inputInvalidSlot.ToLower() == "n")

        {
            return;
        }
        selectedClassSchedule(selectedCourse);
    }
    else
    {
        if (selectedSlot.IsTaken)
        {
            Console.WriteLine("\nSorry, this slot is already taken.Please press any key to return in slot selection menu or pres N to exit.\n");
            var inputInvalidSlot = Console.ReadLine();

            if (inputInvalidSlot.ToLower() == "n")
            {
                return;
            }
            selectedClassSchedule(selectedCourse);
        }
        else
        {

        
            Console.WriteLine($"\nCongratsulations! You've acquired slot {selectedSlot.ClassSlot} on {selectedCourse.name} for this semester.\n");
            
        
        }
    }
}

 

return;









    


