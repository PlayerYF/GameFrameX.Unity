
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
    public sealed partial class TestRef : LuBan.Runtime.BeanBase
    {
        public TestRef(JSONNode _buf)
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["x1"].IsNumber) { throw new SerializationException(); }  X1 = _buf["x1"]; }
            X1_Ref = null;
            { if(!_buf["x1_2"].IsNumber) { throw new SerializationException(); }  X12 = _buf["x1_2"]; }
            X12_Ref = null;
            { if(!_buf["x2"].IsNumber) { throw new SerializationException(); }  X2 = _buf["x2"]; }
            { if(!_buf["x3"].IsNumber) { throw new SerializationException(); }  X3 = _buf["x3"]; }
            { if(!_buf["x4"].IsNumber) { throw new SerializationException(); }  X4 = _buf["x4"]; }
            X4_Ref = null;
            { var __json0 = _buf["a1"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; A1 = new int[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  A1[__index0++] = __v0; }   }
            { var __json0 = _buf["a2"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; A2 = new int[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  A2[__index0++] = __v0; }   }
            { var __json0 = _buf["b1"]; if(!__json0.IsArray) { throw new SerializationException(); } B1 = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  B1.Add(__v0); }   }
            { var __json0 = _buf["b2"]; if(!__json0.IsArray) { throw new SerializationException(); } B2 = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  B2.Add(__v0); }   }
            { var __json0 = _buf["c1"]; if(!__json0.IsArray) { throw new SerializationException(); } C1 = new System.Collections.Generic.HashSet<int>(/*__json0.Count*/); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  C1.Add(__v0); }   }
            { var __json0 = _buf["c2"]; if(!__json0.IsArray) { throw new SerializationException(); } C2 = new System.Collections.Generic.HashSet<int>(/*__json0.Count*/); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  C2.Add(__v0); }   }
            { var __json0 = _buf["d1"]; if(!__json0.IsArray) { throw new SerializationException(); } D1 = new System.Collections.Generic.Dictionary<int, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  D1.Add(_k0, _v0); }   }
            { var __json0 = _buf["d2"]; if(!__json0.IsArray) { throw new SerializationException(); } D2 = new System.Collections.Generic.Dictionary<int, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  D2.Add(_k0, _v0); }   }
            { if(!_buf["e1"].IsNumber) { throw new SerializationException(); }  E1 = _buf["e1"]; }
            { if(!_buf["e2"].IsNumber) { throw new SerializationException(); }  E2 = _buf["e2"]; }
            { if(!_buf["e3"].IsString) { throw new SerializationException(); }  E3 = _buf["e3"]; }
            { if(!_buf["f1"].IsNumber) { throw new SerializationException(); }  F1 = _buf["f1"]; }
            { if(!_buf["f2"].IsNumber) { throw new SerializationException(); }  F2 = _buf["f2"]; }
            { if(!_buf["f3"].IsString) { throw new SerializationException(); }  F3 = _buf["f3"]; }
            { if(!_buf["s1"].IsObject) { throw new SerializationException(); }  S1 = test.RefDynamicBase.DeserializeRefDynamicBase(_buf["s1"]);  }
            PostInit();
        }

        public static TestRef DeserializeTestRef(JSONNode _buf)
        {
            return new test.TestRef(_buf);
        }

        public readonly int Id;
        public readonly int X1;
        public test.TestBeRef X1_Ref { private set; get; }
        public readonly int X12;
        public test.TestBeRef X12_Ref { private set; get; }
        public readonly int X2;
        public readonly int X3;
        public readonly int X4;
        public tag.TestTag X4_Ref { private set; get; }
        public readonly int[] A1;
        public test.TestBeRef[] A1_Ref { private set; get; }
        public readonly int[] A2;
        public test.TestBeRef[] A2_Ref { private set; get; }
        public readonly System.Collections.Generic.List<int> B1;
        public System.Collections.Generic.List<test.TestBeRef> B1_Ref { private set; get; }
        public readonly System.Collections.Generic.List<int> B2;
        public System.Collections.Generic.List<test.TestBeRef> B2_Ref { private set; get; }
        public readonly System.Collections.Generic.HashSet<int> C1;
        public System.Collections.Generic.HashSet<test.TestBeRef> C1_Ref { private set; get; }
        public readonly System.Collections.Generic.HashSet<int> C2;
        public System.Collections.Generic.HashSet<test.TestBeRef> C2_Ref { private set; get; }
        public readonly System.Collections.Generic.Dictionary<int, int> D1;
        public System.Collections.Generic.Dictionary<int, test.TestBeRef> D1_Ref { private set; get; }
        public readonly System.Collections.Generic.Dictionary<int, int> D2;
        public System.Collections.Generic.Dictionary<int, test.TestBeRef> D2_Ref { private set; get; }
        public readonly int E1;
        public readonly long E2;
        public readonly string E3;
        public readonly int F1;
        public readonly long F2;
        public readonly string F3;
        public readonly test.RefDynamicBase S1;
        public const int __ID__ = -543222491;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            X1_Ref = tables.TbTestBeRef.Get(X1);
            X12_Ref = tables.TbTestBeRef.Get(X12);
            
            
            X4_Ref = tables.TbTestTag.Get(X4);
            A1_Ref = new test.TestBeRef[A1.Length];
            for (int _i = 0; _i < A1.Length; _i++) { A1_Ref[_i] = tables.TbTestBeRef.Get(A1[_i]); }

            A2_Ref = new test.TestBeRef[A2.Length];
            for (int _i = 0; _i < A2.Length; _i++) { A2_Ref[_i] = tables.TbTestBeRef.Get(A2[_i]); }

            B1_Ref = new System.Collections.Generic.List<test.TestBeRef>();
            foreach (var _v in B1) { 
            B1_Ref.Add(tables.TbTestBeRef.Get(_v)); }

            B2_Ref = new System.Collections.Generic.List<test.TestBeRef>();
            foreach (var _v in B2) { 
            B2_Ref.Add(tables.TbTestBeRef.Get(_v)); }

            C1_Ref = new System.Collections.Generic.HashSet<test.TestBeRef>();
            foreach (var _v in C1) { 
            C1_Ref.Add(tables.TbTestBeRef.Get(_v)); }

            C2_Ref = new System.Collections.Generic.HashSet<test.TestBeRef>();
            foreach (var _v in C2) { 
            C2_Ref.Add(tables.TbTestBeRef.Get(_v)); }

            D1_Ref = new System.Collections.Generic.Dictionary<int, test.TestBeRef>();
            foreach (var _kv in D1) { 
                D1_Ref.Add(_kv.Key, tables.TbTestBeRef.Get(_kv.Value));
            }

            D2_Ref = new System.Collections.Generic.Dictionary<int, test.TestBeRef>();
            foreach (var _kv in D2) { 
                D2_Ref.Add(_kv.Key, tables.TbTestBeRef.Get(_kv.Value));
            }

            
            
            
            
            
            
            S1?.ResolveRef(tables);
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "x1:" + X1 + ","
            + "x12:" + X12 + ","
            + "x2:" + X2 + ","
            + "x3:" + X3 + ","
            + "x4:" + X4 + ","
            + "a1:" + StringUtil.CollectionToString(A1) + ","
            + "a2:" + StringUtil.CollectionToString(A2) + ","
            + "b1:" + StringUtil.CollectionToString(B1) + ","
            + "b2:" + StringUtil.CollectionToString(B2) + ","
            + "c1:" + StringUtil.CollectionToString(C1) + ","
            + "c2:" + StringUtil.CollectionToString(C2) + ","
            + "d1:" + StringUtil.CollectionToString(D1) + ","
            + "d2:" + StringUtil.CollectionToString(D2) + ","
            + "e1:" + E1 + ","
            + "e2:" + E2 + ","
            + "e3:" + E3 + ","
            + "f1:" + F1 + ","
            + "f2:" + F2 + ","
            + "f3:" + F3 + ","
            + "s1:" + S1 + ","
            + "}";
        }

        partial void PostInit();
    }
}
