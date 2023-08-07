using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDschoolDetails.Business;
using CRUDschoolDetails.Model;

 namespace CRUDschoolDetailsMVC.Controllers
{
    public class SchoolDetailsController : Controller
    {
        // GET: SchoolDetailsController


        CRUDmethods ObjRepository;

        public SchoolDetailsController()
        {
            ObjRepository = new CRUDmethods();
        }


        public ActionResult List()
        {
            return View("Select", ObjRepository.SelectSchoolDetailsCRUD());
        }

        // GET: SchoolDetailsController/Details/5
        public ActionResult Details(int id)
        {
            var res = ObjRepository.SelectMethodMVC(id);
            return View("Details", res);
        }

        // GET: SchoolDetailsController/Create
        public ActionResult InsertRecord()
        {
            return View("Insert", new SchoolDetailsModel());
        }

        // POST: SchoolDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SchoolDetailsModel data)
        {
            try
            {
                ObjRepository.InsertSchoolDetailsCRUD(data);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            var res = ObjRepository.SelectMethodMVC(id);
            return View("Update", res);
        }

        // POST: SchoolDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int Id, SchoolDetailsModel Reg)
        {
            try
            {
                Reg.Id = Id;
                ObjRepository.UbdateSchoolDetailsCRUD(Reg);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolDetailsController/Delete/5
        public ActionResult Delete(int Id)
        {
            var res = ObjRepository.SelectMethodMVC(Id);
            return View("Delete", res);
        }

        // POST: SchoolDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int Id)
        {
            try
            {
                ObjRepository.DeleteSchoolDetailsCRUD(Id);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
