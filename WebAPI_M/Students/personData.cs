using WebAPI_M.Models.NewFolder;

namespace WebAPI_M.Students
{
    public static class personData
    {
        public static List<PersonM> PersonList = new List<PersonM>
            {
            new PersonM {personId = 1,personName="Praveen",age=21},
            new PersonM {personId = 2,personName="Sandy",age=23},
            new PersonM {personId = 3,personName="Thiru",age=19},
            };
    }
}
