﻿using SDON.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SDON.Model
{
    /// <summary>
    /// Object that represents a row of column values in a DataTable.
    /// </summary>
    [Serializable]
    public sealed class DataTableRow : SDONSerializeable
    {
        [IgnoreIfDefaultValue(Default = -1)]
        [DataMember(Name = "RowID")]
        private int _rowID = -1;

        [IgnoreIfDefaultValue(Default = null)]
        [DataMember(Name = "Fields")]
        private List<DataTableField> _fields = null;

        /// <summary>
        /// The ID of the row.
        /// </summary>
        public int RowID
        {
            get { return _rowID; }
            set { _rowID = value; }
        }

        /// <summary>
        /// A list of fields that are used to populate a row in a DataTable schema defined in the Diagram object.
        /// </summary>
        public List<DataTableField> Fields
        {
            get { return _fields; }
            set { _fields = value; }
        }
    }
}
