
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
    public partial class TbMultiUnionIndexList : BaseDataTable<test.MultiUnionIndexList>
    {
        private System.Collections.Generic.Dictionary<(int, long, string), test.MultiUnionIndexList> _dataMapUnion;
        private readonly System.Func<System.Threading.Tasks.Task<JSONNode>> _loadFunc;
    
        public TbMultiUnionIndexList(System.Func<System.Threading.Tasks.Task<JSONNode>> loadFunc)
        {
            _loadFunc = loadFunc;
            _dataMapUnion = new System.Collections.Generic.Dictionary<(int, long, string), test.MultiUnionIndexList>();
        }
    
        public override async System.Threading.Tasks.Task LoadAsync()
        {
            JSONNode _json = await _loadFunc();
            DataList.Clear();
            foreach(JSONNode _ele in _json.Children)
            {
                test.MultiUnionIndexList _v;
                { if(!_ele.IsObject) { throw new SerializationException(); }  _v = test.MultiUnionIndexList.DeserializeMultiUnionIndexList(_ele);  }
                DataList.Add(_v);
            }
            _dataMapUnion.Clear();
            foreach(var _v in DataList)
            {
                _dataMapUnion.Add((_v.Id1, _v.Id2, _v.Id3), _v);
            }
            PostInit();
        }
    
        //public System.Collections.Generic.List<test.MultiUnionIndexList> DataList => DataList;
        public test.MultiUnionIndexList Get(int id1, long id2, string id3) => _dataMapUnion.TryGetValue((id1, id2, id3), out test.MultiUnionIndexList __v) ? __v : null;
    
        public void ResolveRef(TablesComponent tables)
        {
            foreach(var _v in DataList)
            {
                _v.ResolveRef(tables);
            }
        }
    
        partial void PostInit();
    }
}

