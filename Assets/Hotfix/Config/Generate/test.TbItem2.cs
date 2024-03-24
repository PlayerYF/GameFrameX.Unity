
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using SimpleJSON;


namespace cfg.test
{
    public partial class TbItem2
    {
        private readonly System.Collections.Generic.Dictionary<int, test.ItemBase> _dataMap;
        private readonly System.Collections.Generic.List<test.ItemBase> _dataList;
        
        public TbItem2(JSONNode jsonNode)
        {
            _dataMap = new System.Collections.Generic.Dictionary<int, test.ItemBase>();
            _dataList = new System.Collections.Generic.List<test.ItemBase>();
            
            foreach(JSONNode vNode in jsonNode.Children)
            {
                test.ItemBase deserializeItem;
                { if(!vNode.IsObject) { throw new SerializationException(); }  deserializeItem = test.ItemBase.DeserializeItemBase(vNode);  }
                _dataList.Add(deserializeItem);
                _dataMap.Add(deserializeItem.Id, deserializeItem);
            }
        }
    
        public System.Collections.Generic.Dictionary<int, test.ItemBase> DataMap 
        {
            get { return _dataMap; }
        }

        public System.Collections.Generic.List<test.ItemBase> DataList 
        {
            get { return _dataList; }
        }
    
        public T GetOrDefaultAs<T>(int key) where T : test.ItemBase => _dataMap.TryGetValue(key, out var v) ? (T)v : null;
        public T GetAs<T>(int key) where T : test.ItemBase => (T)_dataMap[key];
        public test.ItemBase GetOrDefault(int key) 
        {  
            return _dataMap.TryGetValue(key, out var v) ? v : null;
        }
        
        public test.ItemBase Get(int key) 
        { 
            return _dataMap[key];
        }
        
        public test.ItemBase this[int key] 
        {
            get
            {
                return _dataMap[key];
            }
        }
    
        public void ResolveRef(Tables tables)
        {
            foreach(var value in _dataList)
            {
                value.ResolveRef(tables);
            }
        }
        
    }

}