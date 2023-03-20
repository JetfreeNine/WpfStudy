using System.Threading;
using System.Windows;

// 프로그램 실행 전 클라이언트 프로그램 검증 및 파일시스템 처리할 것

MessageBox.Show("시작함");


// 쓰레드 상태 MTA에서 STA로 변경할 것, MTA에서 STA로 곧바로 변경 안됨
// Unknown 상태로 일단 변경 했다가 STA로 설정할 것

Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
WpfStudy.WPF.App.Main();


// 프로그램 종료 시, 처리할 부분
// 전원이 꺼지는 등, 강제 종료 시, 이부분을 건너뛰기에 로그로 활용 가능함

MessageBox.Show("종료함");