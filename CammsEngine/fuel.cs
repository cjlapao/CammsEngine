using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITTech24Tools.Database;

namespace CammsEngine
{
    public class Fuel
    {
#region Properties
        private tblFuel record;

        public RecordStatus Status { get; set; }

        public int ID
        {
            get { return record.ID; }
            set
            {
                if(record == null || record.ID != value)
                {
                    //TODO: create the loading method for loading a record
                }
            }
        }

        public int SupplierID
        {
            get { return record.SuplierID; }
            set
            {
                if (Database.CompareRecord(Status, record.SuplierID, value))
                {
                    Status = RecordStatus.ToUpdate;
                }
                record.SuplierID = value;
            }
        }
#endregion

        public Fuel()
        {
            record = new tblFuel();
            Status = RecordStatus.ToInsert;
        }
    }
}
