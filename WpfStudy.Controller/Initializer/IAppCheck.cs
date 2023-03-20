using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudy.Controller.Initializer;
public interface IAppCheck
{
    // 준비 완료 여부 프로퍼티
    bool IsAppReady { get; }
}
