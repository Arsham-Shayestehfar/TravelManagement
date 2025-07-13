using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Domain;
using TravelManagemnet.Domain.Exceptios;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Entities
{
    public class TravelCheckList:AggregateRoot<TravelerCheckListId>
    {
       public TravelerCheckListId Id { get; private set; }
        public TravelerCheckListName _name;
        public Destination _destination;
        private readonly LinkedList<TravelerItem> _items = new();
        public TravelCheckList()
        {
            
        }

        internal TravelCheckList (TravelerCheckListId id,TravelerCheckListName name
            , Destination destination)
        {
            Id = id;
            _name = name;
            _destination = destination;

        }

        private TravelCheckList(TravelerCheckListId id, TravelerCheckListName name
            , Destination destination, LinkedList<TravelerItem> items) :this(id,name,destination)
        {
            _items = items;
        }
        

        public void AddItem(TravelerItem item)
        {
            var exist = _items.Any(c=>c.Name == item.Name);
            if ( exist)
            {
                throw new TravelerItemAlreadyExistsException(_name,item.Name);
            }
           _items.AddLast(item);
        }

        public void AddItems(IEnumerable<TravelerItem> items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }

        public void TakeItem(string ItemName)
        {
            var item = GetItem(ItemName);
            var TravelerItem = item with { IsTaken = true };
            _items.Find(item).Value = TravelerItem;
        }

        public TravelerItem GetItem(string ItemName)
        {
            var item = _items.SingleOrDefault(c=>c.Name == ItemName);
            if ( item == null )
            {
                throw new TravelerItemNotFoundException(ItemName);
            }
            return item;
        }

        public void RemoveItem(string ItemName)
        {
            var item = GetItem(ItemName);
            _items.Remove(item);
        }
            
        
    }
}
