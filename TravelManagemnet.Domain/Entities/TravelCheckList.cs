using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Entities
{
    public class TravelCheckList
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
        
            
        
    }
}
