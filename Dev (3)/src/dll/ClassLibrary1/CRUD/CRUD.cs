using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.CRUD
{
    public class CRUD
    {
        private List<CRUDItem> myList = new List<CRUDItem>();

        public List<CRUDItem> List
        {
            get { return this.myList; }
        }

        public void Add(CRUDItem item)
        {
            if (!this.Contains(item.Name)) 
            { 
                this.List.Add(item);
            }            
        }

        public bool Contains(string name)
        {
            var item = this.List.FirstOrDefault(x => x.Name == name);

            return item == null ? false : true;
        }

        public bool Contains(CRUDItem item)
        {
            return this.List.Contains(item);
        }

        public void Remove(string name)
        {
            CRUDItem item = this.List.FirstOrDefault(i => i.Name == name);

            if (this.List.Contains(item))
            {
                this.List.Remove(item);
            }
        }

        public void Remove(int index)
        {
            if (this.List.Count > index || this.List.Count > 0)
            {
                this.List.Remove(this.List[index]);
            }
        }

        public void Remove(CRUDItem item)
        {
            if (this.Contains(item))
            {
                this.List.Remove(item);
            }
        }

        public void Insert(int index, CRUDItem item)
        {
            if (!this.Contains(item.Name))
            {
                this.List.Insert(index, item);
            }
        }

        public void AddRange(List<CRUDItem> list)
        {
            this.List.AddRange(list);
        }

        public int Count()
        {
            return this.List.Count();
        }

        public void Clear()
        {
            this.List.Clear();
        }

        public List<CRUDItem> GetItems(ItemType type)
        {
            List<CRUDItem> items = new List<CRUDItem>();
            
            foreach(CRUDItem item in this.List)
            {
                if (item.ItemType == type)
                {
                    items.Add(item);
                }
            }

            return items;
        }

        public List<CRUDItem> ATypeItems
        {
            get
            {
                return this.GetItems(ItemType.AType);
            }
        }

        public List<CRUDItem> BTypeItems
        {
            get
            {
                return this.GetItems(ItemType.BType);
            }
        }

        public List<CRUDItem> CTypeItems
        {
            get
            {
                return this.GetItems(ItemType.CType);
            }
        }


    }
}
