
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

namespace Hotfix.Config.ai
{
    public sealed partial class FloatKeyData : ai.KeyData
    {
        public FloatKeyData(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["value"].IsNumber) { throw new SerializationException(); }  Value = _buf["value"]; }
            PostInit();
        }

        public static FloatKeyData DeserializeFloatKeyData(JSONNode _buf)
        {
            return new ai.FloatKeyData(_buf);
        }

        public readonly float Value;
        public const int __ID__ = -719747885;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
        }

        public override string ToString()
        {
            return "{ "
            + "value:" + Value + ","
            + "}";
        }

        partial void PostInit();
    }
}
