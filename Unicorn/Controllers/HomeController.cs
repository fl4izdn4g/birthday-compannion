using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unicorn.Models;

namespace Unicorn.Controllers
{
    public class HomeController : Controller
    {
        Dictionary<string, ScreenViewModel> models = new Dictionary<string, ScreenViewModel>()
        {
            { "YRKqQ", new ScreenViewModel() //inteligentna
                {
                    ImageName = "YRKqQ",
                    PasswordPartialName = "YRKqQ",
                    Mode = ScreenViewModel.CIPHER_MODE,
                    PasswordSolution = ".. -. - . .-.. .. --. . -. - -. .-",
                    Next = "FRzgc"
                }
            },
            { "FRzgc", new ScreenViewModel() //ambitna
                {
                    ImageName = "FRzgc",
                    PasswordPartialName = "FRzgc",
                    Mode = ScreenViewModel.DECIPHER_MODE,
                    PasswordSolution = "ambitna",
                    Next = "jorJG"
                }
            },
            { "jorJG", new ScreenViewModel() //madra
                {
                    ImageName = "jorJG",
                    PasswordPartialName = "jorJG",
                    Mode = ScreenViewModel.DECIPHER_MODE,
                    PasswordSolution = "madra",
                    Next = "mJwXx"
                }
            },
            { "mJwXx", new ScreenViewModel() //pracowita
                {
                    ImageName = "mJwXx",
                    PasswordPartialName = "mJwXx",
                    Mode = ScreenViewModel.DECIPHER_MODE,
                    PasswordSolution = "pracowita",
                    Next = "AnrOY"
                }
            },
            { "AnrOY", new ScreenViewModel() //towarzyska
                {
                    ImageName = "AnrOY",
                    PasswordPartialName = "AnrOY",
                    Mode = ScreenViewModel.DECIPHER_MODE,
                    PasswordSolution = "towarzyska",
                    Next = "oyZiX"
                }
            },
            { "oyZiX", new ScreenViewModel() //wrazliwa
                {
                    ImageName = "oyZiX",
                    PasswordPartialName = "oyZiX",
                    Mode = ScreenViewModel.CIPHER_MODE,
                    PasswordSolution = "fpppffmmmffppmfmfffppmmm",
                    Next = "YtYXK"
                }
            },
            { "YtYXK", new ScreenViewModel() //pomocna
                {
                    ImageName = "YtYXK",
                    PasswordPartialName = "YtYXK",
                    Mode = ScreenViewModel.CIPHER_MODE,
                    PasswordSolution = ">+++++++++++[<+++++++++++>-]<---------.-.--.++.>+++[<--->-]<---.>+++[<+++>-]<++.>++++[<---->-]<+++.",
                    Next = "GwvOf"
                }
            },
            { "GwvOf", new ScreenViewModel() //goscinna
                {
                    ImageName = "GwvOf",
                    PasswordPartialName = "GwvOf",
                    Mode = ScreenViewModel.CIPHER_MODE,
                    PasswordSolution = ".. ..  ... ....  .... ...  . ...  .. ....  ... ...  ... ...  . .",
                    Next = "lAtha"
                }
            },
            { "lAtha", new ScreenViewModel()
                {
                    ImageName = "lAtha",
                    PasswordPartialName = "lAtha",
                    Mode = ScreenViewModel.DECIPHER_MODE,
                    PasswordSolution = "piękna",
                    Next = "Wow"
                }
            }
        };

        public ActionResult Index()
        {
            var result = InitCookie();
            if(result != null)
            {
                return result;
            }

            return View();
        }

        private ActionResult InitCookie()
        {
            if (Request.Cookies["jednorozec"] == null)
            {
                HttpCookie cookie = new HttpCookie("jednorozec");
                cookie.Value = "Index";
                Response.Cookies.Add(cookie);
            }
            else
            {
                HttpCookie cookie = Request.Cookies["jednorozec"];
                if (cookie.Value != "Index")
                {
                   return RedirectToAction(cookie.Value);
                }
            }

            return null;
        }

        private ActionResult SetCookie(string value)
        {
            if (Request.Cookies["jednorozec"] == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                HttpCookie cookie = Request.Cookies["jednorozec"];
                cookie.Value = value;
                Response.SetCookie(cookie);
            }

            return null;
        }

        //inteligentna
        public ActionResult YRKqQ()
        {
            var result = SetCookie("YRKqQ");
            if (result != null)
            {
                return result;
            }

            return View("Screen", models["YRKqQ"]);
        }

        [HttpPost]
        public ActionResult YRKqQ(ScreenViewModel model)
        {
            if (model.GivenPassword == models["YRKqQ"].PasswordSolution)
            {
                models["YRKqQ"].IsSuccess = true;
                //return RedirectToAction(models["YRKqQ"].Next);
            }
            else
            {
                models["YRKqQ"].IsError = true;
            }

            return View("Screen", models["YRKqQ"]);
        }

        //ambitna
        public ActionResult FRzgc()
        {
            var result = SetCookie("FRzgc");
            if (result != null)
            {
                return result;
            }

            return View("Screen", models["FRzgc"]);
        }

        [HttpPost]
        public ActionResult FRzgc(ScreenViewModel model)
        {
            if (model.GivenPassword == models["FRzgc"].PasswordSolution)
            {
                models["FRzgc"].IsSuccess = true;
                //return RedirectToAction(models["FRzgc"].Next);
            }
            else
            {
                models["FRzgc"].IsError = true;
            }

            return View("Screen", models["FRzgc"]);
        }

        //mądra
        public ActionResult jorJG()
        {
            var result = SetCookie("jorJG");
            if (result != null)
            {
                return result;
            }

            return View("Screen", models["jorJG"]);
        }

        [HttpPost]
        public ActionResult jorJG(ScreenViewModel model)
        {
            if (model.GivenPassword == models["jorJG"].PasswordSolution)
            {
                models["jorJG"].IsSuccess = true;
                //return RedirectToAction(models["jorJG"].Next);
            }
            else
            {
                models["jorJG"].IsError = true;
            }

            return View("Screen", models["jorJG"]);
        }

        //pracowita
        public ActionResult mJwXx()
        {
            var result = SetCookie("mJwXx");
            if (result != null)
            {
                return result;
            }

            return View("Screen", models["mJwXx"]);
        }

        [HttpPost]
        public ActionResult mJwXx(ScreenViewModel model)
        {
            if (model.GivenPassword == models["mJwXx"].PasswordSolution)
            {
                models["mJwXx"].IsSuccess = true;
                //return RedirectToAction(models["mJwXx"].Next);
            }
            else
            {
                models["mJwXx"].IsError = true;
            }

            return View("Screen", models["mJwXx"]);
        }

        //towarzyska
        public ActionResult AnrOY()
        {
            var result = SetCookie("AnrOY");
            if (result != null)
            {
                return result;
            }

            return View("Screen", models["AnrOY"]);
        }

        [HttpPost]
        public ActionResult AnrOY(ScreenViewModel model)
        {
            if (model.GivenPassword == models["AnrOY"].PasswordSolution)
            {
                models["AnrOY"].IsSuccess = true;
                //return RedirectToAction(models["AnrOY"].Next);
            }
            else
            {
                models["AnrOY"].IsError = true;
            }

            return View("Screen", models["AnrOY"]);
        }


        //wrazliwa
        public ActionResult oyZiX()
        {
            var result = SetCookie("oyZiX");
            if (result != null)
            {
                return result;
            }

            return View("Screen", models["oyZiX"]);
        }

        [HttpPost]
        public ActionResult oyZiX(ScreenViewModel model)
        {
            if (model.GivenPassword == models["oyZiX"].PasswordSolution)
            {
                models["oyZiX"].IsSuccess = true;
                //return RedirectToAction(models["oyZiX"].Next);
            }
            else
            {
                models["oyZiX"].IsError = true;
            }

            return View("Screen", models["oyZiX"]);
        }

        //pomocna
        public ActionResult YtYXK()
        {
            var result = SetCookie("YtYXK");
            if (result != null)
            {
                return result;
            }

            return View("Screen", models["YtYXK"]);
        }

        [HttpPost]
        public ActionResult YtYXK(ScreenViewModel model)
        {
            if (model.GivenPassword == models["YtYXK"].PasswordSolution 
                || model.GivenPassword == "++++++++++[>+>+++>+++++++>++++++++++<<<<-]>>>>++++++++++++. -. --. ++. ------------. +++++++++++. -------------."
                || model.GivenPassword == "++++++++++ [->++++++++++<] > ++++++++++++.- .--.+ +.< +++[->---<] >---.< +++[- > +++< ] > ++. < +++[ ->--- <] > ----.< +++++++++[- > ---------<] > ---.-- - .<")
            {
                models["YtYXK"].IsSuccess = true;
                //return RedirectToAction(models["YtYXK"].Next);
            }
            else
            {
                models["YtYXK"].IsError = true;
            }

            return View("Screen", models["YtYXK"]);
        }

        //goscinna
        public ActionResult GwvOf()
        {
            var result = SetCookie("GwvOf");
            if (result != null)
            {
                return result;
            }

            return View("Screen", models["GwvOf"]);
        }

        [HttpPost]
        public ActionResult GwvOf(ScreenViewModel model)
        {
            if (model.GivenPassword == models["GwvOf"].PasswordSolution)
            {
                models["GwvOf"].IsSuccess = true;
                //return RedirectToAction(models["GwvOf"].Next);
            }
            else
            {
                models["GwvOf"].IsError = true;
            }
            return View("Screen", models["GwvOf"]);
        }

        //romantyczna
        public ActionResult lAtha()
        {
            var result = SetCookie("lAtha");
            if (result != null)
            {
                return result;
            }

            return View("Screen", models["lAtha"]);
        }

        [HttpPost]
        public ActionResult lAtha(ScreenViewModel model)
        {
            if (model.GivenPassword == models["lAtha"].PasswordSolution)
            {
                models["lAtha"].IsSuccess = true;
                models["lAtha"].IsLast = true;
                //return RedirectToAction(models["lAtha"].Next);
            }
            else
            {
                models["lAtha"].IsError = true;
            }

            return View("Screen", models["lAtha"]);
        }

        public ActionResult Wow()
        {
            var result = SetCookie("Wow");
            if (result != null)
            {
                return result;
            }

            return View();
        }

    }
}