using System.IO;
using System;
using System.Xml;
using System.Xml.Serialization;
using WpfStudy.Controller.Domain;
using WpfStudy.Controller.Initializer;
using System.Text;

namespace WpfStudy;

// 서버 환경 설정 체크
internal class Config
{
    AppConfiguration appConfiguration = new AppConfiguration
    {
        ServerName = "localhost",
        IP = "127.0.0.1",
        ServerPort = "3433",
        ID = "test",
        Password = "password",
    };

    internal string GetConnectionString()
    {
        var connectionstring = new AppCheck().ConnectDbServer(appConfiguration);

        return connectionstring;
    }

    internal string GetXmlConnectionString()
    {
        string? connectionstring = null;
        using (MemoryStream memoryStream = new MemoryStream())
        {
            using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream))
            {
                var xmlSerializer = new XmlSerializer(typeof(AppConfiguration));
                xmlSerializer.Serialize(xmlWriter, appConfiguration);
            }
            connectionstring = Encoding.UTF8.GetString(memoryStream.GetBuffer());
        }

        //파일에 출력하는 예
        //using (StreamWriter wr = new StreamWriter(@"C:\Temp\Emp.xml"))
        //{
        //    XmlSerializer xs = new XmlSerializer(typeof(Employee));
        //    xs.Serialize(wr, emp);
        //}
        return connectionstring;
    }
}
