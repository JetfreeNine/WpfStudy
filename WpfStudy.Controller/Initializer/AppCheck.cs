using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStudy.Controller.Domain;

namespace WpfStudy.Controller.Initializer;

/// <summary>
/// 앱의 초기화를 담당
/// 해야할 일
/// public : 초기화가 정상적인지 체크값 프로퍼티
/// 1. 환경 설정 불러온다.
/// 1.1. xml 환경 설정 파일을 읽어온다.
/// 1-2. 파일을 AppConfiguration 형태로 캐스팅한다.
/// 2. 환경 설정을 이용하여 데이터베이스에 로그인
/// 3. 
/// </summary>

public class AppCheck : IAppCheck
{
    private bool _isAppCheck = false;
    private AppConfiguration _appConfiguration = new AppConfiguration();

    public bool IsAppReady => _isAppCheck;

    public AppCheck()
    {
        Initializer();
    }

    private void Initializer()
    {
        AppConfiguration appConfiguration = GetConfiguration();
    }

    // 환경 설정을 불러온다.
    private AppConfiguration GetConfiguration()
    {
        var appConfiguration = new AppConfiguration();
        return appConfiguration;
    }

    // 환경설정 정보를 통해 DB 연결자를 불러온다.
    // 추후 이부분을 EF 7로 업그레이드 할 것!!!!
    public string ConnectDbServer(AppConfiguration appConfiguration)
    {
        var stringBuilder = new StringBuilder()
            .Append(appConfiguration.IP)
            .Append(',')
            .Append(appConfiguration.ServerPort);

        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder
        {
            DataSource = stringBuilder.ToString(),
            InitialCatalog = appConfiguration.ServerName,
            UserID = appConfiguration.ID,
            Password = appConfiguration.Password
        };

        var sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
        
        return sqlConnectionStringBuilder.ConnectionString;
    }
}
