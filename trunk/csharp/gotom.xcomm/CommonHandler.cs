using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace gotom.xcomm
{

    public delegate void CommonHandler<T>(object sender, CommonEventArgs<T> e);

    public class CommonEventArgs<T> : EventArgs
    {
        public CommonEventArgs(T result)
        {
            Result = result;
        }
        public T Result { get; set; }
    }
}
