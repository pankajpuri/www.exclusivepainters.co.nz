using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using www.exclusivepainters.co.nz.Models;
using www.exclusivepainters.co.nz.ViewModels;

namespace www.exclusivepainters.co.nz.Controllers
{
    public class EmployeeFormsController : Controller
    {
        ExPaintersDbEntities db = new ExPaintersDbEntities();
        // GET: EmployeeForms
        public ActionResult Index()
        {
         return View(db.Employees.ToList());
            
        }
        public ActionResult Register()
        {
            return View();      
        }
        // ActivationCode,ResetPasswordCode,IsEmailVerified
        //Include = "Id,FirstName,LastName,Email,Mobile,Password"

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Exclude = "ActivationCode,ResetPasswordCode,IsEmailVerified")] RegistrationForm employee)
        {
            bool Status = false;
            string message = "";
          
         
              // Model Validation 
              if (ModelState.IsValid)
              {
                
                  var isExist = IsEmailExist(employee.Email);
                if (isExist)
                {
                    ModelState.AddModelError("EmailExist", "Email already exist.");
                    return View(employee);
                }
                else
                {


                    employee.ActivationCode = Guid.NewGuid();
                    employee.Password = EncrypPassword.Hash(employee.Password);
                    employee.ConfirmPassword = EncrypPassword.Hash(employee.ConfirmPassword); 

                    employee.IsEmailVerified = false;

                    #region Save to Database

                    Employee emp = new Employee
                    {
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        DateOfBirth = employee.DateOfBirth,
                        Mobile = employee.Mobile,
                        Email = employee.Email,
                        Password = employee.Password,
                        IsEmailVerified = employee.IsEmailVerified,
                        ActivationCode = employee.ActivationCode
                    };

                   ExPaintersDbEntities db = new ExPaintersDbEntities();
                    
                        db.Employees.Add(emp);
                      


                        

                        db.SaveChanges();

                    //Send Email to User
                    /* SendVerificationLinkEmail(employee.Email, employee.ActivationCode.ToString());
                     message = "Registration successfully done. Account activation link " +
                         " has been sent to your email id:" + employee.Email;
                    */
                    Status = true;
                   
                    #endregion
                }
              }
              else
              {
                  message = "Invalid Request";
              }

              ViewBag.Message = message;
              ViewBag.Status = Status;
              return View(employee);
        }

            
        [NonAction]
        public bool IsEmailExist(string email)
        {
            using (ExPaintersDbEntities db = new ExPaintersDbEntities())
            {
                var v = db.Employees.Where(a => a.Email == email).FirstOrDefault();
                return v != null;
            }
        }



        [NonAction]
        public void SendVerificationLinkEmail(string emailID, string activationCode, string emailFor = "VerifyAccount")
        {
            var verifyUrl = "/User/" + emailFor + "/" + activationCode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

            var fromEmail = new MailAddress("pankajpuri016@gmail.com", "Exclusive Painters");
            var toEmail = new MailAddress(emailID);
            var fromEmailPassword = "babybird";// Replace with actual password

            string subject = "";
            string body = "";
            if (emailFor == "VerifyAccount")
            {
                subject = "Your account is successfully created!";
                body = "<br/><br/>We are excited to tell you that your Dotnet Awesome account is" +
                    " successfully created. Please click on the below link to verify your account" +
                    " <br/><br/><a href='" + link + "'>" + link + "</a> ";

            }
            else if (emailFor == "ResetPassword")
            {
                subject = "Reset Password";
                body = "Hi,<br/>br/>We got request for reset your account password. Please click on the below link to reset your password" +
                    "<br/><br/><a href=" + link + ">Reset Password link</a>";
            }


            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
            };

            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(message);
        }
        

        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(string EmailID)
        {
            //Verify Email ID
            //Generate Reset password link 
            //Send Email 
            string message = "";
            bool status = false;

            using (ExPaintersDbEntities dc = new ExPaintersDbEntities())
            {
                var account = dc.Employees.Where(a => a.Email == EmailID).FirstOrDefault();
                if (account != null)
                {
                    //Send email for reset password
                    string resetCode = Guid.NewGuid().ToString();
                    SendVerificationLinkEmail(account.Email, resetCode, "ResetPassword");
                    account.ResetPasswordCode = resetCode;
                    //This line I have added here to avoid confirm password not match issue , as we had added a confirm password property 
                    //in our model class in part 1
                    dc.Configuration.ValidateOnSaveEnabled = false;
                    dc.SaveChanges();
                    message = "Reset password link has been sent to your email id.";
                }
                else
                {
                    message = "Account not found";
                }
            }
            ViewBag.Message = message;
            return View();
        }

        public ActionResult ResetPassword(string id)
        {
            //Verify the reset password link
            //Find account associated with this link
            //redirect to reset password page
            if (string.IsNullOrWhiteSpace(id))
            {
                return HttpNotFound();
            }

            using (ExPaintersDbEntities db = new ExPaintersDbEntities())
            {
                var user = db.Employees.Where(a => a.ResetPasswordCode == id).FirstOrDefault();
                if (user != null)
                {
                    ResetPassword model = new ResetPassword
                    {
                        ResetCode = id
                    };
                    return View(model);
                }
                else
                {
                    return HttpNotFound();
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ResetPassword(ResetPassword model)
        {
            var message = "";
            if (ModelState.IsValid)
            {
                using (ExPaintersDbEntities db = new ExPaintersDbEntities())
                {
                    var user = db.Employees.Where(a => a.ResetPasswordCode == model.ResetCode).FirstOrDefault();
                    if (user != null)
                    {
                        user.Password = EncrypPassword.Hash(model.NewPassword);
                        user.ResetPasswordCode = "";
                        db.Configuration.ValidateOnSaveEnabled = false;
                        db.SaveChanges();
                        message = "New password updated successfully";
                    }
                }
            }
            else
            {
                message = "Something invalid";
            }
            ViewBag.Message = message;
            return View(model);
        }
        //Login
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(RegistrationForm user)
        {
            if (ModelState.IsValid)
            {
                var check = db.Employees.Where(u => u.Email == user.Email).SingleOrDefault();
                if (check != null)
                {
                    if (!check.IsEmailVerified)
                    {
                        ViewBag.Message = "Please verify your email firs";
                    }
                    if (string.Compare(EncrypPassword.Hash(user.Password), check.Password) == 0)
                    {
                        /* int timeout = user.RememberMe ? 525600 : 20; // 525600 min = 1 year
                        var ticket = new FormsAuthenticationTicket(login.EmailID, login.RememberMe, timeout);
                        string encrypted = FormsAuthentication.Encrypt(ticket);
                        var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                        cookie.Expires = DateTime.Now.AddMinutes(timeout);
                        cookie.HttpOnly = true;
                        Response.Cookies.Add(cookie);*/
                    }
                    Session["Id"] = check.Id.ToString();
                    Session["UserName"] = check.FirstName.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect  Username or Password!");
                }
            }
            else
            {
                
            }
            
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["Id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}