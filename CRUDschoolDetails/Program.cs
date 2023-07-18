using System;
using CRUDschoolDetails.Model;
using CRUDschoolDetails.Business;
using CRUDschoolDetails.Repository;

namespace CRUDschoolDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MenuForCRUD ObjSchoolDetailsMenu = new MenuForCRUD();
                ObjSchoolDetailsMenu.Menu();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
