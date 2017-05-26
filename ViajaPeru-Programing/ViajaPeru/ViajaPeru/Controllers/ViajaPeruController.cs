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
                    Session["LogedUserID"] = v.usuario_cliente.ToString();
                    return RedirectToAction("Index_Login");
                }
                //else if (t != null)
                //{
                //    Session["LogedUserID"] = v.usuario_cliente.ToString();
                //    return RedirectToAction("Index_Login");
                //}
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
    }
}