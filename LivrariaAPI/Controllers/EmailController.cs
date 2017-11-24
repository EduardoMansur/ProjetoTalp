using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;
using System.Web.Http.Description;

namespace LivrariaAPI.Controllers
{
    public class EmailController : ApiController
    {

        private void sendEmail(string email)
        {

            SmtpClient cliente = new SmtpClient();
            cliente.Host = "smtp.gmail.com";
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;

            cliente.EnableSsl = true;
            cliente.Port = 587;
            System.Net.NetworkCredential credenciais = new NetworkCredential("emailprovatalp@gmail.com", "Aluno123");
            cliente.Credentials = credenciais;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("emailprovatalp@gmail.com");
            mail.To.Add(new MailAddress(email));
            mail.Body = "Corpo do e-mail. Email enviado pela prova  15200402";
            cliente.Send(mail);

        }
        // [Route("api/Email/send")]
        /// <summary>
        /// Send email to destiny
        /// </summary>
        /// <param name="email">destiny</param>
        /// <returns></returns>
        [ResponseType(typeof(string))]
        public IHttpActionResult PostEmail(string email)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            sendEmail(email);
            return CreatedAtRoute("DefaultApi", 200, email);
        }
    }
}
