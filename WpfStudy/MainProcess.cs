using System.Windows;

namespace WpfStudy;

// 주 프로세스 관리자
internal class MainProcess
{
    public void AppRun()
    {
        // 1. 서버 환경 설정 체크
        var config = new Config();
        MessageBox.Show(config.GetConnectionString());
        MessageBox.Show(config.GetXmlConnectionString());
        // 1.1 지정된 위치의 XML파일 불러오기
        // 1.1.1 XML 파일 있음 => 1.2
        // 1.1.2 XML 파일 없음 => 1.1.3
        // 1.1.3 XML 파일 생성 프로세스 진행(구현 전에는 강제 종료)
        // 1.2 XML 파일의 정보를 근거로 DB 연결
        // 1.2.1 DB 연결 성공 => 1.3
        // 1.2.2 DB 연결 실패 => throw Exception 후 강제 종료
        // 1.3 기본 뷰 로드
        // 1.3.1 기본 뷰의 뷰모델 생성

        // 기본 뷰 로드
        WPF.App.Main();
    }
}