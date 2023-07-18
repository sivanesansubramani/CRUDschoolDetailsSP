using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using CRUDschoolDetails.Model;


namespace CRUDschoolDetails.Business
{
    class CRUDmethods
    {

        public readonly string connectionString;

        public CRUDmethods()
        {


            connectionString = @"Data source=DESKTOP-8VD1A1F\SQLEXPRESS;Initial catalog=StudentMark;User Id=sa;Password=Anaiyaan@123";
        }
        // Crud operation with Store procedure

        //Insert method

        public void InsertSchoolDetails(SchoolDetailsModel de)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"exec insertschooldetails  '{de.SchoolName}','{de.OwnerName}','{de.address}','{de.location}','{de.NoofStudents}'");

                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Select methods
        public List<SchoolDetailsModel> SelectSchoolDetails()

        {
            try
            {
                List<SchoolDetailsModel> SchoolDataSelect = new List<SchoolDetailsModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                SchoolDataSelect = connection.Query<SchoolDetailsModel>("exec selectschooldetails; ").ToList();
                connection.Close();

                

                foreach (var loopData in SchoolDataSelect)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"SchoolID --{loopData.Id}   SchoolName --{loopData.SchoolName}    Owner --{ loopData.OwnerName}   Address --{ loopData.address}   Location --{ loopData.location}   Number of students --{ loopData.NoofStudents} ");
                    Console.WriteLine("");
                }

                /*Console.WriteLine(constrain);
                Console.ReadLine();*/

                return SchoolDataSelect;

            }
            catch (Exception ex)
            {
                throw ex;
            }



        }


    }
}
