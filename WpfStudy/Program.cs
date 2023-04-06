using System;
using System.Threading;
using System.Windows;
using System.Xml;

// 프로그램 시작
MessageBox.Show("시작함");

// 쓰레드 상태 MTA에서 STA로 변경할 것, MTA에서 STA로 곧바로 변경 안됨
// Unknown 상태로 일단 변경 했다가 STA로 설정할 것
MessageBox.Show("현재 쓰레드 STA로 변경함");
Action<ApartmentState> ThreadState = Thread.CurrentThread.SetApartmentState;
ThreadState(ApartmentState.Unknown);
ThreadState(ApartmentState.STA);

// 프로그램 실행 전 클라이언트 프로그램 검증 및 파일시스템 처리할 것
// XML 파일이 없다면 서버 정보 입력 화면 실행
MessageBox.Show("1단계: 서버 설정 XML 파일 불러오기");
XmlDocument xmlDoc = new XmlDocument();

xmlDoc.Load(xmlDoc.OuterXml);

// WPF 실행
WpfStudy.WPF.App.Main();

// 프로그램이 정상적으로 종료 시, 처리할 부분
// 여기에 로그를 기록하고 실행시에 로그를 불러서 정상종료 여부를 체크할 것
// 전원이 꺼지는 등, 강제 종료 시, 이부분을 건너뛰기에 로그로 활용 가능함
MessageBox.Show("종료함");