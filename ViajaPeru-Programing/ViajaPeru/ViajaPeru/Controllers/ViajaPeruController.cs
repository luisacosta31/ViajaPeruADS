using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViajaPeru.Models;

namespace ViajaPeru.Controllers
{
    public class ViajaPeruController : Controller
    {

        BD_VIAJAPERUEntities modelo = new BD_VIAJAPERUEntities();

        // GET: ViajaPeru
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(tb_usuario usuario)
        {
            if (ModelState.IsValid)
            {
                
                //var t = modelo.tb_trabajador.Where(a => a.usuario_trabajador.Equals(trabajador.usuario_trabajador) && a.contra_trabajador.Equals(trabajador.contra_trabajador)).FirstOrDefault();
                var v = modelo.tb_usuario.Where(a => a.usuario_cliente.Equals(usuario.usuario_cliente) && a.contra_cliente.Equals(usuario.contra_cliente)).FirstOrDefault();
                if (v != null)
                {
                    if (v.id_tipo == 1)
                    {
                        Session["LogedUserID"] = v.nom_cliente + " " + v.apepat_cliente.ToString();
                        return RedirectToAction("Index_Login");
                    }
                    else
                    {
                        Session["LogedUserID"] = v.nom_cliente + " " + v.apepat_cliente.ToString();
                        return View("Index_Login_Administrador");
                    }

                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
            return View(usuario);
        }

        public ActionResult Index_Login()
        {

            return View();
        }



        public ActionResult Create_User()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create_User(tb_usuario usuario)
        {
            using (modelo)
            {
                usuario.estado_cliente = 0;
                usuario.id_tipo = 2;
                modelo.tb_usuario.Add(usuario);
                modelo.SaveChanges();
            }
            return View("Login");
        }


        //solo vistas
        public ActionResult About()
        {
            return View();
        }

        public ActionResult About2()
        {
            return View();
        }
    }
}