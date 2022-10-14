using HomeWork_LogBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_LogBook.Repository;

public class FakeDepo
{
    public static List<Student> GetStudents()
    {
        return new()
    {
        new(1, null, "Ekremi", "Nihat", "Celal", new DateTime(2022, 10, 3), ParticipationStatus.Unknown, null, null, null, null),
        new(2, null, "Nebili", "Tural", "Mahir", new DateTime(2022, 10, 4), ParticipationStatus.Absent, null, null, null, null),
        new(3, null, "Hesenov", "Elshad", "Salman", new DateTime(2022, 10, 6), ParticipationStatus.Late, null, null, null, null),
        new(4, null, "Ibrahimov", "Huseyn", "Allahverdi", new DateTime(2022, 10, 5), ParticipationStatus.Absent, null, null, null, null),
        new(5, null, "Kerimzada", "Kamran", "Natiq", new DateTime(2022, 10, 15), ParticipationStatus.Absent, null, null, null, null),
        new(6, null, "Meherremli", "Murad", "Yusif", new DateTime(2022, 10, 6), ParticipationStatus.Present, null, null, null, null),
        new(7, null, "Muradov", "Kenan", "Xalid", new DateTime(2022, 10, 7), ParticipationStatus.Present, null, null, null, null),
        new(8, null, "Shamilzade", "Ali", "Azer", new DateTime(2022, 10, 8), ParticipationStatus.Late, null, null, null, null),
        new(9, null, "Shefiyeva", "Leyla", "Dursunn", new DateTime(2022, 10, 8), ParticipationStatus.Late, null, null, null, null),
        };
    }
}