
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using GameFrameX.Config;
using SimpleJSON;

namespace Hotfix.Config.test
{
    public abstract partial class DemoDynamic : LuBan.Runtime.BeanBase
    {
        public DemoDynamic(JSONNode _buf)
        {
            { if(!_buf["x1"].IsNumber) { throw new SerializationException(); }  X1 = _buf["x1"]; }
            PostInit();
        }

        public static DemoDynamic DeserializeDemoDynamic(JSONNode _buf)
        {
            switch ((string)_buf["$type"])
            {
                case "DemoD2": return new test.DemoD2(_buf);
                case "DemoE1": return new test.DemoE1(_buf);
                case "test.login.RoleInfo": return new test.login.RoleInfo(_buf);
                case "DemoD5": return new test.DemoD5(_buf);
                default: throw new SerializationException();
            }
        }

        public readonly int X1;

        public virtual void ResolveRef(TablesComponent tables)
        {
            
        }

        public override string ToString()
        {
            return "{ "
            + "x1:" + X1 + ","
            + "}";
        }

        partial void PostInit();
    }
}
