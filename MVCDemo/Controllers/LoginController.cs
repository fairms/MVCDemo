using MVCDemo.DAL;
using System.Linq;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class LoginController : Controller
    {
        private readonly AccountContext db = new AccountContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.LoginState = "登陆前...";
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string email = form["email"];
            string password = form["password"];
            var user = db.SysUsers.Where(b=>b.Email==email&b.Password==password );
            if (user.Count() > 0)
            {
                ViewBag.LoginState = "登录成功";
            }
            else
            {
            ViewBag.LoginState = email + " 登陆后...";
            }
            return View();
        }

    }
}