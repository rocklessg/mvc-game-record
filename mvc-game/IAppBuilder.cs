#region Assembly Owin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f0ebd12fd5e55cc5
// Decompiled with ICSharpCode.Decompiler 6.1.0.5902
#endregion

using System;
using System.Collections.Generic;

namespace Owin
{
    public interface IAppBuilder
    {
        IDictionary<string, object> Properties
        {
            get;
        }

        IAppBuilder Use(object middleware, params object[] args);

        object Build(Type returnType);

        IAppBuilder New();
    }
}
#if false // Decompilation log
'118' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5.2\mscorlib.dll'
#endif
