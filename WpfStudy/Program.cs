using System;
using System.Threading;
using WpfStudy;

// 프로그램 시작

// 현재 쓰레드 상태를 MTA에서 STA로 변경할 것!
// 쓰레드 상태를 Unknown 상태로 변경한 후, STA로 설정
Action<ApartmentState> ThreadState = Thread.CurrentThread.SetApartmentState;
ThreadState(ApartmentState.Unknown);
ThreadState(ApartmentState.STA);

// 메인프로세스 실행
new MainProcess().AppRun();

// 프로그램 종료