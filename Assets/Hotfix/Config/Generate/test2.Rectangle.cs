
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

namespace Hotfix.Config.test2
{
    /// <summary>
    /// 矩形
    /// </summary>
    public sealed partial class Rectangle : test.Shape
    {
        public Rectangle(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["width"].IsNumber) { throw new SerializationException(); }  Width = _buf["width"]; }
            { if(!_buf["height"].IsNumber) { throw new SerializationException(); }  Height = _buf["height"]; }
            PostInit();
        }

        public static Rectangle DeserializeRectangle(JSONNode _buf)
        {
            return new test2.Rectangle(_buf);
        }

        /// <summary>
        /// 宽度
        /// </summary>
        public readonly float Width;
        /// <summary>
        /// 高度
        /// </summary>
        public readonly float Height;
        public const int __ID__ = 694982337;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "width:" + Width + ","
            + "height:" + Height + ","
            + "}";
        }

        partial void PostInit();
    }
}
