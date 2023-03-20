using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy.Controller.Domain;
internal class AppConfiguration
{
    internal string ServerName { get; set; } = string.Empty;
    internal string IP { get; set; } = string.Empty;
    internal string ServerPort { get; set; } = string.Empty;
    internal string ID { get; set; } = string.Empty;
    internal string Password { get; set; } = string.Empty;
}