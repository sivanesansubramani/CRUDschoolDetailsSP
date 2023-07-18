using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDschoolDetails.Model;
using CRUDschoolDetails.Business;

namespace  
{
    class MenuForCRUD
    {

      
        public SchoolDetailsModel GetSchoolDetails()
        {
            SchoolDetailsModel school = new SchoolDetailsModel();

            Console.WriteLine("enter school name");
            school.SchoolName = Console.ReadLine();

            Console.WriteLine("enter owner name");
            school.OwnerName = Console.ReadLine();

            Console.WriteLine("enter  address of school");
            school.address = Console.ReadLine();

            Console.WriteLine("enter  location of school");
            school.location = Console.ReadLine();

            Console.WriteLine("enter  how many students in school");
            school.NoofStudents = Console.ReadLine();

            return school;
        }

        public void Menu()
        {

            int b;
            do
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Select");

                CRUDmethods crudSchoolDetails = new CRUDmethods();
                MenuForCRUD MenuObj = new MenuForCRUD();

                b = Convert.ToInt32(Console.ReadLine());

                switch (b)
                {
                    case 1:

                        var PassDet = MenuObj.GetSchoolDetails();
                        crudSchoolDetails.InsertSchoolDetails(PassDet);

                        break;
                    case 2:

                        crudSchoolDetails.SelectSchoolDetails();

                        break;

                    default:
                        Console.WriteLine("your option is not valid");
                        break;

                }

            } while (b != 0);



        }


    }
}
