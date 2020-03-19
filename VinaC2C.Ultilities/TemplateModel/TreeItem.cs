using System;
using System.Collections.Generic;
using System.Text;

namespace VinaC2C.Ultilities.TemplateModel
{
    public class TreeItem<T>
    {
        public T Item { get; set; }

        public IEnumerable<TreeItem<T>> Childrens { get; set; }
    }
}
