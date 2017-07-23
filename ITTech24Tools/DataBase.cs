using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITTech24Tools.Database
{
    public enum RecordStatus
    {
        Browse = -1,
        Ready = 0,
        ToInsert = 1,
        Inserting = 2,
        Inserted = 3,
        ToEdit = 4,
        Editing = 5,
        Edited = 6,
        ToLoad = 7,
        Loading = 8,
        Loaded = 9,
        ToSave = 10,
        Saving = 11,
        Saved = 12,
        ToDelete = 13,
        Deleting = 14,
        Deleted = 15,
        ToUpdate = 16,
        Updating = 17,
        Updated = 18
    }

    public class Database
    {
        public static bool CompareRecord(RecordStatus status, object value1, object value2)
        {
            bool result = false;
            if (status == RecordStatus.Ready || status == RecordStatus.Loaded || 
                status == RecordStatus.Saved || status == RecordStatus.Edited ||
                status == RecordStatus.Browse || status == RecordStatus.Updated)
            {
                if (value1.GetType() == value2.GetType())
                {
                    if (!value1.Equals(value2))
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
