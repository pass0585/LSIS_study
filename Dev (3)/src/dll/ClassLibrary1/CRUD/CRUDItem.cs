using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.CRUD
{
    public class CRUDItem
    {
        private ItemType myItemType;
        private string myName;
        private string myDescription;

        //getter, 

        //public string getName()
        //{
        //    return this.myName;
        //}
        //
        ////setter
        //public void setName(string name)
        //{
        //    this.myName = name;
        //}

        public CRUDItem()
        {
        
        }

        public CRUDItem(ItemType itemType, string name, string description = null)
        {
            this.ItemType = itemType;
            this.Name = name;
            this.Description = description;
        }

        public CRUDItem(ItemType itemType, string name)
        {
            this.ItemType = itemType;
            this.Name = name;
        }

        public ItemType ItemType
        {
            get { return this.myItemType; }
            set { this.myItemType = value; }
        }

        public string Name
        {
            get { return this.myName; }
            set { this.myName = value; }
        }
        
        public string Description
        {
            get { return this.myDescription; }
            set { this.myDescription = value; }
        }
    }

    public enum ItemType
    {
        AType,
        BType,
        CType,
    }
}
