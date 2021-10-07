using System.Collections.Generic;

namespace Scania.Objects
{
    public static class GridToolbars
    {
        public static List<string> AdminToolbar { get; } = new List<string> { "Add", "Edit", "Delete", "Cancel", "Update" };

        public static List<string> BasicToolbar { get; } = null;
    }
}