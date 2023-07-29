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
    public class CRUDmethods
    {

        public readonly string connectionString;

        public CRUDmethods()
        {


            connectionString = @"Data source=DESKTOP-8VD1A1F\SQLEXPRESS;Initial catalog=SchoolDetails;User Id=sa;Password=Anaiyaan@123";
        }
        // Crud operation with Store procedure

        //Insert method

        public void InsertSchoolDetailsCRUD(SchoolDetailsModel de)
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
        public List<SchoolDetailsModel> SelectSchoolDetailsCRUD()

        {
            try
            {
                List<SchoolDetailsModel> SchoolDataSelect = new List<SchoolDetailsModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                SchoolDataSelect = connection.Query<SchoolDetailsModel>("exec selectschooldetails; ").ToList();
                connection.Close();

                return SchoolDataSelect;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //Select with id
        public List<SchoolDetailsModel> SelectSchoolDetailsCRUD(int id)

        {
            try
            {
                List<SchoolDetailsModel> schoolDataSelect = new List<SchoolDetailsModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                schoolDataSelect = connection.Query<SchoolDetailsModel>($" exec selectschooldetailsWithId {id}; ").ToList();
                connection.Close();

                return schoolDataSelect;

            }
            catch (Exception ex)
            {
                throw ex;
            }



        }





        //ubdate sp
        public void UbdateSchoolDetailsCRUD(SchoolDetailsModel de)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"exec ubdateschooldetails {de.Id},'{de.SchoolName}','{de.OwnerName}','{de.address}','{de.location}','{de.NoofStudents}'");

                con.Close();
            }
            catch (SqlException ee)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteSchoolDetailsCRUD(int del)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

               
                con.Open();
                con.Execute($"exec deleteschooldetails '{del}'");


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

    }
}
