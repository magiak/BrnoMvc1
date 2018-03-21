using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrnoMvc1.Business.Services
{
    public class EmailService : IEmailService
    {
        public void Send(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
