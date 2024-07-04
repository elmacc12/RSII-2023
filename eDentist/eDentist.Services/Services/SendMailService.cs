using eDentist.Services.Interfaces;
using eDentist.Services.RabbitMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.Services
{
    public class SendMailService: ISendMail
    {
        private readonly IRabbitMQProducer _rabbitMQProducer;
        public SendMailService(IRabbitMQProducer rabbitMQProducer)
        {
            _rabbitMQProducer = rabbitMQProducer;
        }

        public async Task SendMailAsync(string email)
        {
            var oMail = new EmailModel();
            oMail.Recipient = email??"elma.comor@edu.fit.ba";
            oMail.Subject = "eDentist - Info";
            oMail.Content = $"Poštovani,\n\n U toku je velika akcija u našoj ordniaciji. Posjetite nas i provjerite šta samo spremili za vas\n\nSrdačan pozdrav,\nVaša eDentist ordinacija";

            try
            {
                _rabbitMQProducer.SendMessage(oMail);
                Thread.Sleep(TimeSpan.FromSeconds(15));

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error RabbitMQ -> {ex.Message}");
            }
        }
    }
}


public class EmailModel
{


    public string Sender { get; set; }
    public string Recipient { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
}
