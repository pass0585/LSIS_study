using ClassLibrary1.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDConsoleApp
{
    class Program
    {
        static CRUD crud = new CRUD();

        static void Main(string[] args)
        {
            //item 추가1
            CRUDItem item = new CRUDItem();
            item.ItemType = ItemType.AType;
            item.Name = "crudItem1";
            item.Description = "crudItem1입니다.";

            crud.Add(item);

            //item 추가2
            CRUDItem item2 = new CRUDItem(ItemType.BType, "crudItem2", "crudItem2입니다.");
            crud.Add(item2);

            //item 추가3
            crud.Add(new CRUDItem(ItemType.CType, "crudItem3", "crudItem3입니다."));

            //item 추가4~6
            crud.Add(new CRUDItem(ItemType.AType, "crudItem4"));
            crud.Add(new CRUDItem(ItemType.BType, "crudItem5"));
            crud.Add(new CRUDItem(ItemType.CType, "crudItem6"));
                        

            // item remvoe
            //crud.Remove("crudItem6");
            //crud.Remove(item2);
            //crud.Remove(0);

            // item insert
            crud.Insert(1, new CRUDItem(ItemType.BType, "crudItem7", "insert입니다."));

            // clear
            //crud.Clear();

            Print();
            Console.ReadKey();
        }

        static void Print()
        {
            foreach(CRUDItem item in crud.List)
            //foreach (CRUDItem item in crud.GetItems(ItemType.AType))
            //foreach (CRUDItem item in crud.ATypeItems)
            {
                Console.Write($"Type : {item.ItemType} | Name : {item.Name}");

                if (item.Description != null)
                {
                    Console.WriteLine($" | Description : {item.Description}");
                }
                else
                {
                    Console.WriteLine(" | ");
                }
            }

            Console.WriteLine($"Total Item Count : {crud.Count()}");

        }
    }
}
