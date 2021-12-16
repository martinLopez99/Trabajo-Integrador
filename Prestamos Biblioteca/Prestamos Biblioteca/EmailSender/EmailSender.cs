using FluentEmail.Smtp;
using System;
using System.Threading.Tasks;
using System.Net.Mail;
using FluentEmail.Core;
using System.Text;
using FluentEmail.Razor;
using Prestamos_Biblioteca.Dominio;

namespace Prestamos_Biblioteca.EmailSender
{
    class EmailSender
    {
        /// <summary>
        /// Envia una notificacion al Cliente del <see cref="Prestamo"/> por mail
        /// </summary>
        /// <param name="pPrestamo"></param>
        /// <returns></returns>
        static async Task SendExpiringNotification(Prestamo pPrestamo)
        {
            var sender = new SmtpSender(new SmtpClient("smtp.gmail.com")
            {
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Port = 25,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("tallerdeprogramacion2021@gmail.com", "tinchosantifederena")

            });

            StringBuilder template = new();
            template.AppendLine("Querido @Model.FirstName,");
            template.AppendLine("<p> El prestamo de su libro @Model.ProductName esta proximo a vencer (Fecha de Vencimiento: @Model.ExpiringDate)," +
                " por favor devuelva su ejemplar pronto para no sufrir consecuencias en su puntaje. </p>");
            template.AppendLine("Sinceramente,");
            template.AppendLine("<p>- El equipo de Taller de Programacion </p>");

            Email.DefaultSender = sender;
            Email.DefaultRenderer = new RazorRenderer();

            var email = await Email
                .From("tallerdeprogramacion2021@gmail.com")
                .To(pPrestamo.Usuario.Email, pPrestamo.Usuario.Nombre + pPrestamo.Usuario.Apellido)
                .Subject("Vencimiento de Prestamo")
                .UsingTemplate(template.ToString(), new
                {
                    FirstName = pPrestamo.Usuario.Nombre + pPrestamo.Usuario.Apellido,
                    ProductName = pPrestamo.Ejemplar.Libro.title,
                    ExpiringDate = pPrestamo.FechaDevolucionEstimada
                })
                //.Body("Esto es un mail de prueba")
                .SendAsync();
        }
    }
}
