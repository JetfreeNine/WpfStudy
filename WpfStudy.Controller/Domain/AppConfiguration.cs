using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy.Controller.Domain;
public class AppConfiguration
{
    public string ServerName { get; set; } = string.Empty;
    public string IP { get; set; } = string.Empty;
    public string ServerPort { get; set; } = string.Empty;
    public string ID { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}